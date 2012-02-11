namespace Grammatica2._0 {
    partial class TestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.richEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.pnTestInfo = new DevExpress.XtraEditors.PanelControl();
            this.sbPromt = new DevExpress.XtraEditors.SimpleButton();
            this.sbRemoveSelection = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddSelection = new DevExpress.XtraEditors.SimpleButton();
            this.meQuestion = new DevExpress.XtraEditors.MemoEdit();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.sbNext = new DevExpress.XtraEditors.SimpleButton();
            this.sbSkip = new DevExpress.XtraEditors.SimpleButton();
            this.sbExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnTestInfo)).BeginInit();
            this.pnTestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEdit
            // 
            this.richEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEdit.Location = new System.Drawing.Point(0, 95);
            this.richEdit.Name = "richEdit";
            this.richEdit.ReadOnly = true;
            this.richEdit.Size = new System.Drawing.Size(829, 337);
            this.richEdit.TabIndex = 2;
            this.richEdit.Text = "richEditControl1";
            this.richEdit.Views.PrintLayoutView.ZoomFactor = 0.8F;
            // 
            // pnTestInfo
            // 
            this.pnTestInfo.Controls.Add(this.sbPromt);
            this.pnTestInfo.Controls.Add(this.sbRemoveSelection);
            this.pnTestInfo.Controls.Add(this.sbAddSelection);
            this.pnTestInfo.Controls.Add(this.meQuestion);
            this.pnTestInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTestInfo.Location = new System.Drawing.Point(0, 0);
            this.pnTestInfo.Name = "pnTestInfo";
            this.pnTestInfo.Size = new System.Drawing.Size(829, 95);
            this.pnTestInfo.TabIndex = 3;
            this.pnTestInfo.Visible = false;
            // 
            // sbPromt
            // 
            this.sbPromt.Location = new System.Drawing.Point(12, 64);
            this.sbPromt.Name = "sbPromt";
            this.sbPromt.Size = new System.Drawing.Size(28, 23);
            this.sbPromt.TabIndex = 9;
            this.sbPromt.Text = "?";
            this.sbPromt.Click += new System.EventHandler(this.sbPromt_Click);
            // 
            // sbRemoveSelection
            // 
            this.sbRemoveSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbRemoveSelection.Location = new System.Drawing.Point(685, 64);
            this.sbRemoveSelection.Name = "sbRemoveSelection";
            this.sbRemoveSelection.Size = new System.Drawing.Size(132, 25);
            this.sbRemoveSelection.TabIndex = 8;
            this.sbRemoveSelection.Text = "Удалить";
            this.sbRemoveSelection.Click += new System.EventHandler(this.sbRemoveSelection_Click);
            // 
            // sbAddSelection
            // 
            this.sbAddSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAddSelection.Location = new System.Drawing.Point(547, 64);
            this.sbAddSelection.Name = "sbAddSelection";
            this.sbAddSelection.Size = new System.Drawing.Size(132, 25);
            this.sbAddSelection.TabIndex = 7;
            this.sbAddSelection.Text = "Добавить выделенное";
            this.sbAddSelection.Click += new System.EventHandler(this.sbAddSelection_Click);
            // 
            // meQuestion
            // 
            this.meQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.meQuestion.Location = new System.Drawing.Point(12, 12);
            this.meQuestion.Name = "meQuestion";
            this.meQuestion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meQuestion.Properties.Appearance.Options.UseFont = true;
            this.meQuestion.Properties.ReadOnly = true;
            this.meQuestion.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meQuestion.Size = new System.Drawing.Size(805, 46);
            this.meQuestion.TabIndex = 0;
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.sbNext);
            this.pnControl.Controls.Add(this.sbSkip);
            this.pnControl.Controls.Add(this.sbExit);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 432);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(829, 46);
            this.pnControl.TabIndex = 4;
            // 
            // sbNext
            // 
            this.sbNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbNext.Location = new System.Drawing.Point(611, 11);
            this.sbNext.Name = "sbNext";
            this.sbNext.Size = new System.Drawing.Size(100, 23);
            this.sbNext.TabIndex = 2;
            this.sbNext.Text = "Ответить";
            this.sbNext.Click += new System.EventHandler(this.sbNext_Click);
            // 
            // sbSkip
            // 
            this.sbSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSkip.Location = new System.Drawing.Point(717, 11);
            this.sbSkip.Name = "sbSkip";
            this.sbSkip.Size = new System.Drawing.Size(100, 23);
            this.sbSkip.TabIndex = 1;
            this.sbSkip.Text = "Пропустить";
            this.sbSkip.Click += new System.EventHandler(this.sbSkip_Click);
            // 
            // sbExit
            // 
            this.sbExit.Location = new System.Drawing.Point(12, 11);
            this.sbExit.Name = "sbExit";
            this.sbExit.Size = new System.Drawing.Size(100, 23);
            this.sbExit.TabIndex = 0;
            this.sbExit.Text = "Выйти";
            this.sbExit.Click += new System.EventHandler(this.sbExit_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 478);
            this.Controls.Add(this.richEdit);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnTestInfo);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.TestForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pnTestInfo)).EndInit();
            this.pnTestInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEdit;
        private DevExpress.XtraEditors.PanelControl pnTestInfo;
        private DevExpress.XtraEditors.PanelControl pnControl;
        private DevExpress.XtraEditors.SimpleButton sbSkip;
        private DevExpress.XtraEditors.SimpleButton sbExit;
        private DevExpress.XtraEditors.SimpleButton sbNext;
        private DevExpress.XtraEditors.MemoEdit meQuestion;
        private DevExpress.XtraEditors.SimpleButton sbRemoveSelection;
        private DevExpress.XtraEditors.SimpleButton sbAddSelection;
        private DevExpress.XtraEditors.SimpleButton sbPromt;
    }
}