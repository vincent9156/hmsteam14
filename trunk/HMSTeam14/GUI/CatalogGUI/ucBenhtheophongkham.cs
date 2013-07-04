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
    public partial class ucBenhtheophongkham : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBenhtheophongkham()
        {
            InitializeComponent();
        }
        #region Hàm hỗ trợ xử lý các sự kiện 
        private void ucBenhtheophongkham_Load(object sender, EventArgs e)
        {
            LoadDsbenh();
        }
        /// <summary>
        /// Hàm khai báo biến 
        /// </summary>
        private bool Add = false, Update = false;
        /// <summary>
        /// Hàm lấy thông tin bệnh
        /// </summary>
        /// <returns></returns>
        public cBenhTheoPKDO Getthongtinbenh()
        {
            cBenhTheoPKDO ds = new cBenhTheoPKDO();
            ds.MABENH = cmbMabenh.EditValue.ToString();
            ds.MAPHONGKHAM = cmbPhongKham.EditValue.ToString();
            ds.NGAYTAO = DateTime.Today;
            return ds;
        }  
        /// <summary>
        /// Hàm load dữ liệu form
        /// </summary>
        private void LoadDsbenh()
        {
            List<cBenhTheoPKDO> dsbenhtheoPK = BUS.cBenhTheoPKBUS.Getdsbenhtheopk();
            grdLoaibenhtheopk.DataSource = dsbenhtheoPK;
            List<cBenhPKDO> dsbenh = BUS.cBenhBUS.Getdsbenh();
            cmbMabenh.Properties.DataSource = dsbenh;
            cmbMabenh.Properties.DisplayMember = "MABENH";
            cmbMabenh.Properties.ValueMember = "MABENH";
            cmbTenbenh.Properties.DataSource = dsbenh;
            cmbTenbenh.Properties.DisplayMember = "TENBENHTV";
            cmbTenbenh.Properties.ValueMember = "MABENH";
            List<cPhongKhamDO> dsphongkham = BUS.cPhongKhamBUS.Getdsphongkham();
            cmbPhongKham.Properties.DataSource = dsphongkham;
            cmbPhongKham.Properties.DisplayMember = "MAPHONGKHAM";
            cmbPhongKham.Properties.ValueMember = "MAPHONGKHAM";
            LookUpTenbenh.DataSource = dsbenh;
            LookUpTenbenh.DisplayMember="TENBENHTV";
            LookUpTenbenh.ValueMember="MABENH";
            LookUpTenPhong.DataSource = dsphongkham;
            LookUpTenPhong.DisplayMember="TENPHONG";
            LookUpTenPhong.ValueMember="MAPHONGKHAM";
            Resettextvalue();
        }
        private void cmbMabenh_EditValueChanged(object sender, EventArgs e)
        {          
           string mabenh =cmbMabenh.EditValue.ToString();
            cmbTenbenh.EditValue= mabenh;
        }
        private void cmbTenbenh_EditValueChanged(object sender, EventArgs e)
        {
            string mabenh = cmbTenbenh.EditValue.ToString();
            cmbMabenh.EditValue = mabenh;
        }
        /// <summary>
        /// reset hết text
        /// </summary>
        private void Resettextvalue()
        {
            cmbMabenh.EditValue = "";
            cmbPhongKham.EditValue = "";
            cmbTenbenh.EditValue = "";
        }
        /// <summary>
        /// Kiểm tra đầu vào
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private static bool Checkdauvao(cBenhTheoPKDO ds)
        {
            if (ds.MABENH.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn bệnh!");
                return false;
            }
            if (ds.MAPHONGKHAM.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn phòng khám!");
                return false;
            }

            return true;
        }
        private void DeleteBenhtheopk()
        {

            string MABENH = gridLoaibenhtheopk.GetRowCellValue(gridLoaibenhtheopk.FocusedRowHandle, "MABENH").ToString();
            string MAPHONG = gridLoaibenhtheopk.GetRowCellValue(gridLoaibenhtheopk.FocusedRowHandle, "MAPHONGKHAM").ToString();
            BUS.cBenhTheoPKBUS.DeleteBenhtheopk(MABENH,MAPHONG);
        }
#endregion
        #region Hàm thực hiện xử lý các sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            Add = true;
            cBenhTheoPKDO ds = Getthongtinbenh();
             if (Checkdauvao(ds) == true)
            {
                if (Add && BUS.cBenhTheoPKBUS.CheckBenhtheopk(ds.MABENH ,ds.MAPHONGKHAM) == true && Update == false)
                {
                    XtraMessageBox.Show(" Bệnh đã tồn tại trong phòng khám đó ",
                        "Hỏi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Add && BUS.cBenhTheoPKBUS.CheckBenhtheopk(ds.MABENH ,ds.MAPHONGKHAM )== false && Update == false)
                    {
                        BUS.cBenhTheoPKBUS.InsertBentheopk(ds.MABENH,ds.MAPHONGKHAM,ds.NGAYTAO);
                        ucBenhtheophongkham_Load(sender, e);
                        //Enablediting(false);
                        XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
             }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa Bệnh : " + cmbTenbenh.EditValue + " ra khỏi Phòng khám : "+cmbPhongKham.EditValue + " hay không?" , "Hỏi",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteBenhtheopk();
                // load lại form
                ucBenhtheophongkham_Load(sender, e);

            }

        }
        private void gridLoaibenhtheopk_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cmbPhongKham.EditValue = gridLoaibenhtheopk.GetRowCellValue(e.RowHandle, "MAPHONGKHAM").ToString();
            cmbMabenh.EditValue = gridLoaibenhtheopk.GetRowCellValue(e.RowHandle, "MABENH").ToString();
            cmbTenbenh.EditValue = gridLoaibenhtheopk.GetRowCellValue(e.RowHandle, "MABENH").ToString();
        }
        #endregion

    }
}
