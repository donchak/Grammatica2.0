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
        }

        private void iOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using (UnitOfWork uow = new UnitOfWork()) {
                GramText gramText = uow.FindObject<GramText>(null);
                using (TextEditForm form = new TextEditForm(gramText.Oid)) {
                    form.ShowDialog(this);
                }
            }
        }

    }
}