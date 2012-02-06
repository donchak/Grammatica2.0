using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.Xpo;


namespace Grammatica2._0 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void iNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using (TextEditForm form = new TextEditForm(Guid.Empty)) {
                form.ShowDialog(this);
            }
            xpView1.Reload();
        }

        private void iOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ViewRecord record = gridView1.GetFocusedRow() as ViewRecord;
            if (record == null) return;
            using (TextEditForm form = new TextEditForm((Guid)record["Oid"])) {
                form.ShowDialog(this);
            }
            xpView1.Reload();
        }

        private void iDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ViewRecord record = gridView1.GetFocusedRow() as ViewRecord;
            if (record == null) return;
            using (UnitOfWork uow = new UnitOfWork()) {
                GramText text = uow.GetObjectByKey<GramText>(record["Oid"]);
                if (text == null) return;
                if (XtraMessageBox.Show(this, string.Format("Вы действительно хотите удалить текст \"{0}\"", text.Title),
                Grammatica2._0.Properties.Resources.Grammarica20, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    text.Delete();
                    uow.CommitChanges();
                    xpView1.Reload();
                }
            }
        }

    }
}