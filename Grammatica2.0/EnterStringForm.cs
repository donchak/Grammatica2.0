using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Grammatica2._0 {
    public partial class EnterStringForm : DevExpress.XtraEditors.XtraForm {
        EnterStringForm() {
            InitializeComponent();
        }

        public static string Show(IWin32Window owner, string caption, string windowCaption, string defaultValue) {
            using (EnterStringForm form = new EnterStringForm()) {
                form.Text = windowCaption;
                form.labelControl1.Text = caption;
                form.textEdit1.Text = defaultValue;
                if (form.ShowDialog(owner) == DialogResult.OK) {
                    return form.textEdit1.Text;
                }
            }
            return null;
        }
    }
}