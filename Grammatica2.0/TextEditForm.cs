using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraRichEdit.API.Native;
using System.Text.RegularExpressions;

namespace Grammatica2._0 {
    public partial class TextEditForm : DevExpress.XtraEditors.XtraForm {
        UnitOfWork uow;
        GramText gramText;
        GramTest currentTest;
        List<TextPiece> currentPieces;
        TextEditMode currentMode = TextEditMode.Main;
        public TextEditForm(Guid oid) {
            InitializeComponent();
            uow = new UnitOfWork();
            if (oid == Guid.Empty) {
                gramText = new GramText(uow);
            } else {
                gramText = uow.GetObjectByKey<GramText>(oid);
            }
            LoadGramText();
        }

        void LoadGramText() {
            teTitle.Text = gramText.Title;
            richEdit.RtfText = gramText.Text;
            lbTests.DisplayMember = "DisplayName";
            lbTests.ValueMember = "Pieces";
            lbTests.DataSource = gramText.Tests;
        }

        void UpdateTestPieces() {
            CharacterProperties allProp = richEdit.Document.BeginUpdateCharacters(richEdit.Document.Range);
            try {
                allProp.BackColor = richEdit.Document.DefaultCharacterProperties.BackColor;
            } finally {
                richEdit.Document.EndUpdateCharacters(allProp);
            }
            if (currentTest == null || currentPieces == null) return;
            foreach (var piece in currentPieces) {
               DocumentRange range = richEdit.Document.CreateRange(piece.Start, piece.Length);
               CharacterProperties properties = richEdit.Document.BeginUpdateCharacters(range);
               try {
                   properties.BackColor = Color.LightBlue;
               } finally {
                   richEdit.Document.EndUpdateCharacters(properties);
               }
            }
        }
        void SetState(TextEditMode mode) {
            if (currentMode == mode) return;
            switch (mode) {
                case TextEditMode.EditText:
                    pnTitle.Visible = true;
                    richEdit.ReadOnly = false;
                    paragraphBar.Visible = true;
                    fontBar.Visible = true;
                    pnSaveChanges.Visible = true;
                    pnQuestion.Visible = false;
                    break;
                case TextEditMode.EditTest:
                    UpdateTestPieces();
                    pnTitle.Visible = false;
                    richEdit.ReadOnly = true;
                    paragraphBar.Visible = false;
                    fontBar.Visible = false;
                    pnSaveChanges.Visible = true;
                    pnQuestion.Visible = true;
                    break;
                default:
                    currentTest = null;
                    currentPieces = null;
                    UpdateTestPieces();
                    pnTitle.Visible = false;
                    richEdit.ReadOnly = true;
                    paragraphBar.Visible = false;
                    fontBar.Visible = false;
                    pnSaveChanges.Visible = false;
                    pnQuestion.Visible = false;
                    break;
            }
            currentMode = mode;
        }

        private void sbEditText_Click(object sender, EventArgs e) {
            if (currentMode == TextEditMode.Main) {
                SetState(TextEditMode.EditText);
            }
        }

        private void sbCancel_Click(object sender, EventArgs e) {
            switch (currentMode) {
                case TextEditMode.EditText:
                    teTitle.Text = gramText.Title;
                    richEdit.RtfText = gramText.Text;
                    break;
            }
            SetState(TextEditMode.Main);
        }

        private void btSaveChanges_Click(object sender, EventArgs e) {
            switch (currentMode) {
                case TextEditMode.EditText:
                    gramText.Title = teTitle.Text;
                    gramText.Text = richEdit.RtfText;
                    break;
                case TextEditMode.EditTest:
                    currentTest.Pieces = currentPieces.Count == 0 ? null : currentPieces.AsReadOnly();
                    currentTest.Title = teTestTitle.Text;
                    currentTest.Question = edQuestion.Text;
                    break;
            }
            SetState(TextEditMode.Main);
        }

        private void TextEditForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (uow.InTransaction) {
                DialogResult result = XtraMessageBox.Show(this, "Сохранить все изменения?", Grammatica2._0.Properties.Resources.Grammarica20,
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result) {
                    case DialogResult.Yes:
                        uow.CommitChanges();
                        uow.Dispose();
                        break;
                    case DialogResult.No:
                        uow.Dispose();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void sbNewTest_Click(object sender, EventArgs e) {
            GramTest newTest = new GramTest(uow);
            object maxNum = gramText.Evaluate(CriteriaOperator.Parse("[Tests].Max(Num)"));
            newTest.Num = maxNum == null ? 1 : ((int)maxNum) + 1;
            gramText.Tests.Add(newTest);
        }

        private void sbDeleteTest_Click(object sender, EventArgs e) {
            if (lbTests.SelectedItem == null) return;
            GramTest selectedTest = (GramTest)lbTests.SelectedItem;
            if (XtraMessageBox.Show(this, string.Format("Вы действительно хотите удалить задание №{0}", selectedTest.Num),
                Grammatica2._0.Properties.Resources.Grammarica20, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                if (currentTest == selectedTest) {
                    if (currentMode == TextEditMode.EditTest) {
                        SetState(TextEditMode.Main);
                    }
                }
                uow.Delete(selectedTest);
            }
        }

        private void sbEditTest_Click(object sender, EventArgs e) {
            if (lbTests.SelectedItem == null) return;
            GramTest selectedTest = (GramTest)lbTests.SelectedItem;
            if (currentTest == selectedTest) {
                return;
            }
            if (currentMode == TextEditMode.EditTest) {
                SetState(TextEditMode.Main);
            }
            currentTest = selectedTest;
            currentPieces = selectedTest.Pieces == null ? new List<TextPiece>() : new List<TextPiece>(selectedTest.Pieces);
            teTestTitle.Text = selectedTest.Title;
            edQuestion.Text = selectedTest.Question;
            SetState(TextEditMode.EditTest);
        }

        private void richEdit_MouseUp(object sender, MouseEventArgs e) {
            //if (currentMode != TextEditMode.EditTest || (e.Button | MouseButtons.Left) != MouseButtons.Left) return;
            //DocumentPosition position = richEdit.Document.Selection.Start;
            //richEdit.Document.Selection = richEdit.Document.CreateRange(position, 0);
            //ISearchResult sr = richEdit.Document.StartSearch(" ", SearchOptions.None, SearchDirection.Backward);
            //while (sr.FindNext() && sr.CurrentResult.End > position) ;
            //if (sr.CurrentResult.End <= position) {
            //    ISearchResult sr2 = richEdit.Document.StartSearch(" ", SearchOptions.None, SearchDirection.Forward);
            //    while (sr2.FindNext() && sr2.CurrentResult.Start <= sr.CurrentResult.End) ;
            //    if (sr2.CurrentResult.Start > sr.CurrentResult.End) {
            //        int foundIndex = -1;
            //        int start = sr.CurrentResult.End.ToInt();
            //        int length = sr2.CurrentResult.Start.ToInt() - start;
            //        for(int i = 0; i < currentPieces.Count; i++) {
            //            TextPiece currentP = currentPieces[i];
            //            if (currentP.Start == start && currentP.Length == length) {
            //                foundIndex = i;
            //                break;
            //            }
            //        }
            //        if (foundIndex < 0) {
            //            currentPieces.Add(new TextPiece(start, length));
            //        } else {
            //            currentPieces.RemoveAt(foundIndex);
            //        }
            //        UpdateTestPieces();
            //    }
            //}
        }

        private void sbAddSelection_Click(object sender, EventArgs e) {
            if (currentMode != TextEditMode.EditTest) return;
            int start = richEdit.Document.Selection.Start.ToInt();
            int length = richEdit.Document.Selection.Length;
            if (length == 0) return;
            for (int i = 0; i < currentPieces.Count; i++) {
                TextPiece currentP = currentPieces[i];
                if (currentP.Start == start && currentP.Length == length) {
                    return;
                }
                if ((currentP.Start >= start && currentP.Start <= start + length) || ((currentP.Start + currentP.Length) >= start && (currentP.Start + currentP.Length) <= start + length) 
                    || (start >= currentP.Start && start <= currentP.Start + currentP.Length) || ((start + length) >= currentP.Start && (start + length) <= currentP.Start + currentP.Length)) {
                    return;
                }
            }
            currentPieces.Add(new TextPiece(start, length));
            UpdateTestPieces();
        }

        private void sbRemoveSelection_Click(object sender, EventArgs e) {
            if (currentMode != TextEditMode.EditTest) return;
            int start = richEdit.Document.Selection.Start.ToInt();
            int length = richEdit.Document.Selection.Length;
            int foundIndex = -1;
            for (int i = 0; i < currentPieces.Count; i++) {
                TextPiece currentP = currentPieces[i];
                if ((currentP.Start >= start && currentP.Start <= start + length) || ((currentP.Start + currentP.Length) >= start && (currentP.Start + currentP.Length) <= start + length) 
                    || (start >= currentP.Start && start <= currentP.Start + currentP.Length) || ((start + length) >= currentP.Start && (start + length) <= currentP.Start + currentP.Length)) {
                    foundIndex = i;
                    break;
                }
            }
            if (foundIndex >= 0) {
                currentPieces.RemoveAt(foundIndex);   
            }
            UpdateTestPieces();
        }

        private void teTestTitle_EditValueChanged(object sender, EventArgs e) {

        }

        private void teTitle_EditValueChanged(object sender, EventArgs e) {
            Text = teTitle.Text;
        }
    }
    public enum TextEditMode {
        Main,
        EditText,
        EditTest
    }
}