using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;

namespace Grammatica2._0 {
    public partial class TextEditForm : DevExpress.XtraEditors.XtraForm {
        UnitOfWork uow;
        GramText gramText;
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
            richEdit.RtfText = gramText.Text;
            lbTests.DisplayMember = "Num";
            lbTests.ValueMember = "Pieces";
            lbTests.DataSource = gramText.Tests;
        }

        void SetState(TextEditMode mode) {
            if (currentMode == mode) return;
            switch (mode) {
                case TextEditMode.EditText:
                    richEdit.ReadOnly = false;
                    paragraphBar.Visible = true;
                    fontBar.Visible = true;
                    pnSaveChanges.Visible = true;
                    break;
                case TextEditMode.EditTest:
                    richEdit.ReadOnly = true;
                    paragraphBar.Visible = false;
                    fontBar.Visible = false;
                    pnSaveChanges.Visible = true;
                    break;
                default:
                    richEdit.ReadOnly = true;
                    paragraphBar.Visible = false;
                    fontBar.Visible = false;
                    pnSaveChanges.Visible = false;
                    break;
            }
            currentMode = mode;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            if (currentMode == TextEditMode.Main) {
                SetState(TextEditMode.EditText);
            }
        }

        private void sbCancel_Click(object sender, EventArgs e) {
            switch (currentMode) {
                case TextEditMode.EditText:
                    richEdit.RtfText = gramText.Text;
                    break;
            }
            SetState(TextEditMode.Main);
        }

        private void btSaveChanges_Click(object sender, EventArgs e) {
            switch (currentMode) {
                case TextEditMode.EditText:
                    gramText.Text = richEdit.RtfText;
                    break;
            }
            SetState(TextEditMode.Main);
        }

        private void TextEditForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (uow.InTransaction) {
                DialogResult result = XtraMessageBox.Show(this, "Сохранить все изменения?", "Грамматика 2.0", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
    }
    public enum TextEditMode {
        Main,
        EditText,
        EditTest
    }
}