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
        private string MABACSY = "" ,MAPHONGKHAM ="";
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

            DO.cNhanVienDO user = BUS.cNhanVienBUS.GetStaffInforByID(DO.cCommonDO.CurrentUser.MANHANVIEN);
            MAPHONGKHAM = DO.cCommonDO.CurrentUser.MAPHONGKHAM;
            List<cBenhanDO> dsbenhan = BUS.cBenhanBUS.Getdsbenhan(MAPHONGKHAM,2, 0, DateTime.Today);
            grdDSBNCK.DataSource = dsbenhan;
            MABACSY = DO.cCommonDO.CurrentUser.MANHANVIEN;

            List<cBenhanDO> dsbenhan1 = BUS.cBenhanBUS.Getdsbenhan1(MAPHONGKHAM,MABACSY, 3, 0, DateTime.Today);
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
                lblSTT.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "MABENHAN").ToString();
                lblMabenhnhan.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "MABENHNHAN").ToString();
                lblHoTen.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "HOTEN").ToString();
                lblTuoi.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "TUOI").ToString();
                lblGioitinh.Text = gridDSBNCK.GetRowCellValue(e.RowHandle, "GIOITINH").ToString();
                string MABENHNHAN = gridDSBNCK.GetRowCellValue(e.RowHandle, "MABENHNHAN").ToString();
                cBenhNhanDO infor = BUS.cBenhanBUS.GetThongtinbenhan(MABENHNHAN);
                lblDiachi.Text = infor.DIACHI;
                List<cBenhanDO> hosobenhan = BUS.cBenhanBUS.Getdsbenhan2(MABACSY, lblMabenhan.Text, 4);
                grdHSNLTK.DataSource = hosobenhan;
                BUS.cBenhanBUS.UpdateBacsivaobenhan(lblMabenhan.Text, MABACSY);
                BUS.cBenhanBUS.UpdateTrangthai(lblMabenhan.Text, 2);
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

                lblSTT.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "MABENHAN").ToString();
                lblMabenhnhan.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "MABENHNHAN").ToString();
                lblHoTen.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "HOTEN").ToString();
                lblTuoi.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "TUOI").ToString();
                lblGioitinh.Text = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "GIOITINH").ToString();
                string MABENHNHAN = gridDSBNDKCTBS.GetRowCellValue(e.RowHandle, "MABENHNHAN").ToString();
                cBenhNhanDO infor = BUS.cBenhanBUS.GetThongtinbenhan(MABENHNHAN);
                lblDiachi.Text = infor.DIACHI;
                List<cBenhanDO> hosobenhan = BUS.cBenhanBUS.Getdsbenhan2(MABACSY, lblMabenhan.Text, 4);
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
