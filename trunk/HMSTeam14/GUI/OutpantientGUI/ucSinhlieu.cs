using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using DO;
using BUS;
namespace GUI
{
    public partial class ucSinhlieu : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSinhlieu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm lấy danh sách bệnh nhân
        /// </summary>
        private void LoadDSBN()
        {
            DO.cNhanVienDO user = BUS.cNhanVienBUS.GetStaffInforByID(DO.cCommonDO.CurrentUser.MANHANVIEN);
            string MAPHONGKHAM = DO.cCommonDO.CurrentUser.MAPHONGKHAM;
            List<cBenhanDO> dsbenhnhan = BUS.cBenhanBUS.Getdsbenhan(MAPHONGKHAM,1, 0, DateTime.Today);
            grdDanhsachbenhnhan.DataSource = dsbenhnhan;
        }

        private void ucSinhlieu_Load(object sender, EventArgs e)
        {
            LoadDSBN();
        }
        /// <summary>
        /// Check thông tin nhập vào
        /// </summary>
        /// <param name="sl"></param>
        /// <returns></returns>
        private static bool Check(cSinhLieuDO sl)
        {
            if (sl.MACH.Equals("") || sl.NHIETDO.Equals("") || sl.HUYETAP.Equals("") || sl.NHIPTHO.Equals("") || sl.CHIEUCAO.Equals("") || sl.CANNANG.Equals("") || sl.VONGBUNG.Equals(""))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Hàm kiểm tra chuỗi có phải số hay không
        /// </summary>
        /// <param name="stringToTest"></param>
        /// <returns></returns>
        private static Boolean IsNumeric(string stringToTest)
        {
            int result;
            return int.TryParse(stringToTest, out result);
        }

        /// <summary>
        /// lấy thông tin nhập vào
        /// </summary>
        /// <returns></returns>
        public cSinhLieuDO GetInformation()
        {
            cSinhLieuDO sl = new cSinhLieuDO();
            sl.MACH = txtMach.Text;
            sl.NHIETDO = txtNhietDo.Text;
            sl.HUYETAP = String.Format("{0}/{1}", txtHuyetAp.Text, txtHuyetAp1.Text);
            sl.NHIPTHO = txtNhipTho.Text;
            sl.CHIEUCAO = txtChieuCao.Text;
            sl.CANNANG = txtCanNang.Text;
            sl.VONGBUNG = txtVongBung.Text;
            sl.TRANGTHAI = true;
            sl.NGAYTAO = DateTime.Now;
            return sl;
        }


        /// <summary>
        /// Hàm xử lý lấy mã sinh liệu tự động
        /// </summary>
        /// <returns></returns>
        public string Xulymasinhlieu()
        {
            string masl = BUS.cSinhLieuBUS.Getmasl();
            int socantang = Convert.ToInt32(masl) + 1;
            string masl2 = null;
            if (socantang >= 0 && socantang < 10)
            {
                masl2 = "0" + socantang;
            }
            if (socantang >= 10)
            {
                masl2 = socantang.ToString();
            }
            return masl2;
        }

        /// <summary>
        /// Hàm lấy mã y tá tự động
        /// </summary>
        /// <returns></returns>
        public string Xulymayta()
        {
            return cCommonDO.CurrentUser.MANHANVIEN;
        }
        private void gridDSBN_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                string ID = gridDanhsachbenhnhan.GetRowCellValue(e.RowHandle, "MABENHNHAN").ToString();
                cBenhNhanDO infor = BUS.cBenhanBUS.GetThongtinbenhan(ID);
                lblMaBenhNhan.Text = ID;
                lblHoTen.Text = infor.HOTEN;
                lblGioiTinh.Text = infor.GIOITINH;
                lblDiaChi.Text = infor.DIACHI;
                lblNgaySinh.Text = (String)(infor.NTNSBN).ToString();
                lblTuoi.Text = gridDanhsachbenhnhan.GetRowCellValue(e.RowHandle, "TUOI").ToString();
                EnableEditing(false);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Hàm xử lý sự kiện Hủy bỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtCanNang.Text = "";
            txtChieuCao.Text = "";
            txtHuyetAp.Text = "";
            txtHuyetAp1.Text = "";
            txtMach.Text = "";
            txtNhietDo.Text = "";
            txtNhipTho.Text = "";
            txtVongBung.Text = "";
            lblMaBenhNhan.Text = "";
            lblHoTen.Text = "";
            lblNgaySinh.Text = "";
            lblDiaChi.Text = "";
            lblGioiTinh.Text = "";
            lblTuoi.Text = "";
            EnableEditing(true);
        }

        /// <summary>
        /// Hàm xử lý sự kiện Lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            cSinhLieuDO i = GetInformation();
            string masl = Xulymasinhlieu();
            string mabenhan = lblMaBenhNhan.Text;
            string mayta = Xulymayta();
            if (Check(i) == true)
            {
                if (IsNumeric(txtCanNang.Text) == true && IsNumeric(txtChieuCao.Text) == true && IsNumeric(txtHuyetAp.Text) == true && IsNumeric(txtHuyetAp1.Text) == true && IsNumeric(txtMach.Text) == true && IsNumeric(txtNhietDo.Text) == true && IsNumeric(txtNhipTho.Text) == true && IsNumeric(txtVongBung.Text) == true)
                {
                    BUS.cSinhLieuBUS.InsertInfomation(masl, mabenhan, mayta, i.MACH, i.NHIPTHO, i.NHIETDO, i.HUYETAP, i.CHIEUCAO, i.CANNANG, i.VONGBUNG, i.NGAYTAO, i.TRANGTHAI);
                    BUS.cBenhanBUS.UpdateTrangthai(mabenhan, 2);
                    XtraMessageBox.Show("Lưu thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng điền các mục bằng số!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin sinh liệu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Thiết lập Enable
        /// </summary>
        /// <param name="editing"></param>
        private void EnableEditing(bool editing)
        {
            btnLuu.Enabled = !editing;
            txtCanNang.Enabled = !editing;
            txtChieuCao.Enabled = !editing;
            txtHuyetAp.Enabled = !editing;
            txtHuyetAp1.Enabled = !editing;
            txtMach.Enabled = !editing;
            txtNhietDo.Enabled = !editing;
            txtNhipTho.Enabled = !editing;
            txtVongBung.Enabled = !editing;
        }
    }
}
