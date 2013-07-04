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
    public partial class ucKhambenhngoaitru : DevExpress.XtraEditors.XtraUserControl
    {
        public ucKhambenhngoaitru()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmHosobenhan hosobenhan = new frmHosobenhan();
            if (hosobenhan.ShowDialog() == DialogResult.Cancel)
            {
                ucKhambenhngoaitru_Load(sender, e);
            }
        }

        private void ucKhambenhngoaitru_Load(object sender, EventArgs e)
        {

        }

        private void grdHSNLTK_Click(object sender, EventArgs e)
        {
            frmHosobenhan hosobenhan = new frmHosobenhan();
            if (hosobenhan.ShowDialog() == DialogResult.Cancel)
            {
                ucKhambenhngoaitru_Load(sender, e);
            }
        }
    }
}
