using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Grammatica2._0 {
    public partial class PromtForm : DevExpress.XtraEditors.XtraForm {
        public PromtForm(string promtText) {
            InitializeComponent();
            memoEdit1.Text = promtText;
        }
    }
}