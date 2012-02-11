namespace Grammatica2._0 {
    partial class Form1 {
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
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mTests = new DevExpress.XtraBars.BarSubItem();
            this.iNew = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iDelete = new DevExpress.XtraBars.BarButtonItem();
            this.iExecute = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.iResults = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.mHelp = new DevExpress.XtraBars.BarSubItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpView1 = new DevExpress.Xpo.XPView(this.components);
            this.mainUOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTestsCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainUOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mTests,
            this.barButtonItem2,
            this.iOpen,
            this.iDelete,
            this.iNew,
            this.iSave,
            this.iSaveAs,
            this.iExit,
            this.mHelp,
            this.iAbout,
            this.iExecute,
            this.barSubItem1,
            this.iResults});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 15;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mTests),
            new DevExpress.XtraBars.LinkPersistInfo(this.iResults)});
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // mTests
            // 
            this.mTests.Caption = "&Тексты";
            this.mTests.Id = 0;
            this.mTests.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.iDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.iExecute, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit, true)});
            this.mTests.Name = "mTests";
            // 
            // iNew
            // 
            this.iNew.Caption = "&Создать";
            this.iNew.Id = 6;
            this.iNew.Name = "iNew";
            this.iNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNew_ItemClick);
            // 
            // iOpen
            // 
            this.iOpen.Caption = "&Изменить";
            this.iOpen.Id = 4;
            this.iOpen.Name = "iOpen";
            this.iOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOpen_ItemClick);
            // 
            // iDelete
            // 
            this.iDelete.Caption = "&Удалить";
            this.iDelete.Id = 5;
            this.iDelete.Name = "iDelete";
            this.iDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDelete_ItemClick);
            // 
            // iExecute
            // 
            this.iExecute.Caption = "Выполнить";
            this.iExecute.Id = 12;
            this.iExecute.Name = "iExecute";
            this.iExecute.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExecute_ItemClick);
            // 
            // iExit
            // 
            this.iExit.Caption = "В&ыход";
            this.iExit.Id = 9;
            this.iExit.Name = "iExit";
            // 
            // iResults
            // 
            this.iResults.Caption = "Результаты";
            this.iResults.Id = 14;
            this.iResults.Name = "iResults";
            this.iResults.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iResults_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(797, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 431);
            this.barDockControlBottom.Size = new System.Drawing.Size(797, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 409);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(797, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 409);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Open";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // iSave
            // 
            this.iSave.Caption = "&Save";
            this.iSave.Id = 7;
            this.iSave.Name = "iSave";
            // 
            // iSaveAs
            // 
            this.iSaveAs.Caption = "Save &As";
            this.iSaveAs.Id = 8;
            this.iSaveAs.Name = "iSaveAs";
            // 
            // mHelp
            // 
            this.mHelp.Caption = "&Help";
            this.mHelp.Id = 10;
            this.mHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout)});
            this.mHelp.Name = "mHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.Id = 11;
            this.iAbout.Name = "iAbout";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 13;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpView1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(797, 409);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // xpView1
            // 
            this.xpView1.ObjectType = typeof(Grammatica2._0.GramText);
            this.xpView1.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Oid", DevExpress.Xpo.SortDirection.Ascending, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("Title", DevExpress.Xpo.SortDirection.None, "[Title]", false, true),
            new DevExpress.Xpo.ViewProperty("TestsCount", DevExpress.Xpo.SortDirection.None, "[Tests][].Count()", false, true)});
            this.xpView1.Session = this.mainUOW;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colTestsCount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Название";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            // 
            // colTestsCount
            // 
            this.colTestsCount.Caption = "Количество заданий";
            this.colTestsCount.FieldName = "TestsCount";
            this.colTestsCount.Name = "colTestsCount";
            this.colTestsCount.OptionsColumn.ReadOnly = true;
            this.colTestsCount.Visible = true;
            this.colTestsCount.VisibleIndex = 1;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 431);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Грамматика 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainUOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mTests;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iDelete;
        private DevExpress.XtraBars.BarButtonItem iNew;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iSaveAs;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarSubItem mHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.Xpo.UnitOfWork mainUOW;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colTestsCount;
        private DevExpress.Xpo.XPView xpView1;
        private DevExpress.XtraBars.BarButtonItem iExecute;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem iResults;
        private DevExpress.XtraBars.BarSubItem barSubItem1;

    }
}
