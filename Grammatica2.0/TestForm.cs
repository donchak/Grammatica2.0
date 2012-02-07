using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using System.Collections.ObjectModel;

namespace Grammatica2._0 {
    public partial class TestForm : DevExpress.XtraEditors.XtraForm {
        readonly UnitOfWork uow;
        readonly GramText gramText;
        readonly GramTestResult gramTestResult;
        readonly List<TextPiece> currentPieces = new List<TextPiece>();
        readonly DateTime startTime;
        ReadOnlyCollection<TextPiece> checkPieces;
        bool textComplete = false;
        int currentTestIndex = -1;
        public TestForm(Guid oid) {
            InitializeComponent();
            uow = new UnitOfWork();
            if (oid == Guid.Empty) {
                gramText = new GramText(uow);
            } else {
                gramText = uow.GetObjectByKey<GramText>(oid);
            }
            gramTestResult = new GramTestResult(uow);
            gramTestResult.Text = gramText;
            gramTestResult.TestCount = gramText.Tests.Count;
            gramTestResult.TestSkippedCount = 0;
            gramTestResult.MistakeCount = 0;
            gramTestResult.ResultingScore = 0;
            gramTestResult.ExecutionTime = 0;
            Text = gramText.Title;
            richEdit.RtfText = gramText.Text;
            richEdit.ReadOnly = true;
            startTime = DateTime.Now;
        }

        private void NextTest(bool skipped) {
            if (!pnTestInfo.Visible) pnTestInfo.Visible = true;
            if (currentTestIndex >= 0) {
                if (skipped) {
                    gramTestResult.TestSkippedCount = gramTestResult.TestSkippedCount + 1;
                } else {
                    if (!DocumentHelpers.AlmostCorrectPieces(currentPieces, checkPieces)) {
                        gramTestResult.MistakeCount = gramTestResult.MistakeCount + 1;
                        XtraMessageBox.Show(this, "Элементы текста выделены неверно. Попробуйте еще раз.", Grammatica2._0.Properties.Resources.Grammarica20, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    } else {
                        XtraMessageBox.Show(this, "Верно.", Grammatica2._0.Properties.Resources.Grammarica20, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            currentPieces.Clear();
            currentTestIndex++;
            if (currentTestIndex >= gramText.Tests.Count) {
                gramTestResult.ExecutionTime = DateTime.Now.Subtract(startTime).Ticks;
                uow.CommitChanges();
                textComplete = true;
                XtraMessageBox.Show(this, "Выполнения заданий завершено.", Grammatica2._0.Properties.Resources.Grammarica20, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            GramTest test = gramText.Tests[currentTestIndex];
            meQuestion.Text = test.Question;
            checkPieces = test.Pieces;
            DocumentHelpers.UpdateDocumentPieces(richEdit, currentPieces);
        }
        private void sbAddSelection_Click(object sender, EventArgs e) {
            DocumentHelpers.AddSelection(richEdit, currentPieces);
            DocumentHelpers.UpdateDocumentPieces(richEdit, currentPieces);
        }

        private void sbRemoveSelection_Click(object sender, EventArgs e) {
            DocumentHelpers.RemoveSelection(richEdit, currentPieces);
            DocumentHelpers.UpdateDocumentPieces(richEdit, currentPieces);
        }

        private void TestForm_Shown(object sender, EventArgs e) {
            string name = EnterStringForm.Show(this, "Введите ваше имя", "Имя обучаемого", GramTestResult.PreviouseName);
            if (name == null) {
                textComplete = true;
                Close();
                return;
            }
            GramTestResult.PreviouseName = name;
            gramTestResult.Name = name;
            NextTest(false);
        }

        private void sbNext_Click(object sender, EventArgs e) {
            NextTest(false);
        }

        private void sbSkip_Click(object sender, EventArgs e) {
            NextTest(true);
        }

        private void sbExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!textComplete && XtraMessageBox.Show(this, "Вы действительно хотите завершить выполнение заданий.",
                 Grammatica2._0.Properties.Resources.Grammarica20, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                e.Cancel = true;
            }
        }
    }
}