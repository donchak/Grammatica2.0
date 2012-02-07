namespace Grammatica2._0 {
    partial class ResultsForm {
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
            this.components = new System.ComponentModel.Container();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.sbExit = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExecutionTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTestCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTestSkippedCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMistakeCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResultingScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.sbExit);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 358);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(888, 46);
            this.pnControl.TabIndex = 5;
            // 
            // sbExit
            // 
            this.sbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbExit.Location = new System.Drawing.Point(776, 11);
            this.sbExit.Name = "sbExit";
            this.sbExit.Size = new System.Drawing.Size(100, 23);
            this.sbExit.TabIndex = 0;
            this.sbExit.Text = "Выйти";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(888, 358);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(Grammatica2._0.GramTestResult);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colExecutionTime,
            this.colTestCount,
            this.colTestSkippedCount,
            this.colMistakeCount,
            this.colResultingScore});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colExecutionTime
            // 
            this.colExecutionTime.FieldName = "ExecutionTime";
            this.colExecutionTime.Name = "colExecutionTime";
            this.colExecutionTime.Visible = true;
            this.colExecutionTime.VisibleIndex = 2;
            // 
            // colTestCount
            // 
            this.colTestCount.FieldName = "TestCount";
            this.colTestCount.Name = "colTestCount";
            this.colTestCount.Visible = true;
            this.colTestCount.VisibleIndex = 3;
            // 
            // colTestSkippedCount
            // 
            this.colTestSkippedCount.FieldName = "TestSkippedCount";
            this.colTestSkippedCount.Name = "colTestSkippedCount";
            this.colTestSkippedCount.Visible = true;
            this.colTestSkippedCount.VisibleIndex = 4;
            // 
            // colMistakeCount
            // 
            this.colMistakeCount.FieldName = "MistakeCount";
            this.colMistakeCount.Name = "colMistakeCount";
            this.colMistakeCount.Visible = true;
            this.colMistakeCount.VisibleIndex = 5;
            // 
            // colResultingScore
            // 
            this.colResultingScore.FieldName = "ResultingScore";
            this.colResultingScore.Name = "colResultingScore";
            this.colResultingScore.Visible = true;
            this.colResultingScore.VisibleIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 404);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pnControl);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private DevExpress.XtraEditors.SimpleButton sbExit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colExecutionTime;
        private DevExpress.XtraGrid.Columns.GridColumn colTestCount;
        private DevExpress.XtraGrid.Columns.GridColumn colTestSkippedCount;
        private DevExpress.XtraGrid.Columns.GridColumn colMistakeCount;
        private DevExpress.XtraGrid.Columns.GridColumn colResultingScore;
    }
}