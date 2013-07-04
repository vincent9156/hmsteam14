using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class ucBenh : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBenh()
        {
            InitializeComponent();
        }

        private void ucBenh_Load(object sender, EventArgs e)
        {

        }

        private void btnNhombenh_Click(object sender, EventArgs e)
        {
            frmNhombenh nhombenh = new frmNhombenh();
            if (nhombenh.ShowDialog() == DialogResult.Cancel)
            {
                ucBenh_Load(sender, e);
            }
        }
    }
}
