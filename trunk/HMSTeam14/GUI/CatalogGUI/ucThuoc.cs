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
    public partial class ucThuoc : DevExpress.XtraEditors.XtraUserControl
    {
        public ucThuoc()
        {
            InitializeComponent();
        }

        private void ucThuoc_Load(object sender, EventArgs e)
        {

        }

        private void btnNhomthuoc_Click(object sender, EventArgs e)
        {
            frmNhomthuoc nhomthuoc = new frmNhomthuoc();
            if (nhomthuoc.ShowDialog() == DialogResult.Cancel)
            {
                ucThuoc_Load(sender, e);
            }
        }
    }
}
