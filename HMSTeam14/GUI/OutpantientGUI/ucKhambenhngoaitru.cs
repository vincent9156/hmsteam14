using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DO;
using BUS;
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
            LoadDsbenhan();
            Timer tmr = new Timer();
            tmr.Interval = 5000;
            tmr.Enabled = true;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        private void LoadDsbenhan()
        {
            List<cBenhanDO> dsbenhan = BUS.cBenhanBUS.Getdsbenhan("Chờ Khám",true);
            grdDSBNCK.DataSource = dsbenhan;
            string MABACSY ="ABC002";
            List<cBenhanDO> dsbenhan1 = BUS.cBenhanBUS.Getdsbenhan1( MABACSY,"Đang Khám",true);
            grdDSBNDKCTBS.DataSource = dsbenhan1;
        }
        public cBenhanDO Getthongtinbenh()
        {
            cBenhanDO ds = new cBenhanDO();
            return ds;
        }
        private void grdHSNLTK_Click(object sender, EventArgs e)
        {
            frmHosobenhan hosobenhan = new frmHosobenhan();
            if (hosobenhan.ShowDialog() == DialogResult.Cancel)
            {
                ucKhambenhngoaitru_Load(sender, e);
            }
        }

        private void gridDSBNCK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                lblSTT.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "STT").ToString();
                lblMabenhan.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "MABENHAN").ToString();
                lblMabenhnhan.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "MABENHNHAN").ToString();
                lblHoTen.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "HOTEN").ToString();
                lblDiachi.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "DIACHI").ToString();
                lblTuoi.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "TUOI").ToString();
                lblGioitinh.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "GIOITINH").ToString();
                List<cBenhanDO> hosobenhan = BUS.cBenhanBUS.Getdsbenhan2("ABC002", lblMabenhan.Text, "Kết Thúc");
                grdHSNLTK.DataSource = hosobenhan;
                BUS.cBenhanBUS.UpdateBacsivaobenhan(lblMabenhan.Text, "ABC002", DateTime.Today);
                BUS.cBenhanBUS.UpdateTrangthaibenhnhan(lblMabenhan.Text, "Đang Khám", DateTime.Today);
                ucKhambenhngoaitru_Load(sender, e);
            }
            catch (System.Exception ex)
            {
            	
            }
        }

        private void gridDSBNDKCTBS_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                lblSTT.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "STT").ToString();
                lblMabenhan.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "MABENHAN").ToString();
                lblMabenhnhan.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "MABENHNHAN").ToString();
                lblHoTen.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "HOTEN").ToString();
                lblDiachi.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "DIACHI").ToString();
                lblTuoi.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "TUOI").ToString();
                lblGioitinh.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "GIOITINH").ToString();
                List<cBenhanDO> hosobenhan = BUS.cBenhanBUS.Getdsbenhan2("ABC002", lblMabenhan.Text, "Kết Thúc");
                grdHSNLTK.DataSource = hosobenhan;
            }
            catch (System.Exception ex)
            {

            }
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                ucKhambenhngoaitru_Load(sender, e);
            }
            catch (System.Exception ex)
            {
            	
            }
 
        }
    }
}
