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
    public partial class ucBenh : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBenh()
        {
            InitializeComponent();
        }
        #region Hàm hỗ trợ các thao tác nghiệp vụ
      
        /// <summary>
        /// Hàm khai báo biến 
        /// </summary>
        private bool Add = false, Update = false;
        /// <summary>
        /// Hàm lấy thông tin bệnh
        /// </summary>
        /// <returns></returns>
        public cBenhPKDO Getthongtinbenh()
        {
            cBenhPKDO ds = new cBenhPKDO();
            //String[] n = txtTenbenhTV.Text.Split(' ');
            //string sTenTV= "";
            //for (int i = 0; i < n.Length; i++)
            //{
            //    n[i] = n[i].Trim();
            //    if (n[i] != "")
            //    {
            //        sTenTV = sTenTV + " " + n[i];
            //    }
            //}
            ds.TENBENHTV =txtTenbenhTV.Text;
            //String[] n1 = txtTenbenhTA.Text.Split(' ');
            //string sTenTA = "";
            //for (int i = 0; i < n.Length; i++)
            //{
            //    n1[i] = n1[i].Trim();
            //    if (n1[i] != "")
            //    {
            //        sTenTA = sTenTA + " " + n[i];
            //    }
            //}
            ds.TENBENHTA = txtTenbenhTA.Text;
            ds.MABENH = txtMabenh.Text;
            ds.MANHOMBENH1 = cmbNhombenh.EditValue.ToString();
            ds.MOTA1 = txtMota.Text;
            ds.NGAYTAO1 = DateTime.Today;
            if (chkTrangThai.Checked==true)
            {
                ds.TRANGTHAI1 = true;
            }
            else
            {
                ds.TRANGTHAI1 = false;
            }
            return ds;
        }
        private void ucBenh_Load(object sender, EventArgs e)
        {
            LoadDsbenh();
        }
        /// <summary>
        /// Hàm load dữ liệu form
        /// </summary>
        private void LoadDsbenh()
        {
            List<cBenhPKDO> dsbenh = BUS.cBenhBUS.Getdsbenh();
            grdBenh.DataSource = dsbenh;
            Enablediting(false);
            List<cNhomBenhDO> dsnhombenh = BUS.cBenhBUS.GetdsNhombenh();
            cmbNhombenh.Properties.DataSource = dsnhombenh;
            cmbNhombenh.Properties.DisplayMember = "MANHOMBENH";
            cmbNhombenh.Properties.ValueMember = "MANHOMBENH";
            LookUpEdit.DataSource = dsnhombenh;
            LookUpEdit.DisplayMember = "TENNHOMBENH";
            LookUpEdit.ValueMember = "MANHOMBENH";
        }
        /// <summary>
        /// reset hết text
        /// </summary>
        private void Resettextvalue()
        {
            txtMabenh.Text = "";
            txtTenbenhTA.Text = "";
            txtTenbenhTV.Text = "";
            txtMota.Text = "";
            cmbNhombenh.EditValue = "";
            chkTrangThai.Checked = false;
        }
        /// <summary>
        /// hàm ẩn và mở các button và textbox....
        /// </summary>
        /// <param name="editing"></param>
        private void Enablediting(bool editing)
        {
            btnTaomoi.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnNhombenh.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnKhongLuu.Enabled = editing;
            cmbNhombenh.Enabled = editing;
            txtMota.Enabled = editing;
            txtTenbenhTA.Enabled = editing;
            txtTenbenhTV.Enabled = editing;
            chkTrangThai.Enabled = editing;
        }
        /// <summary>
        /// Kiểm tra đầu vào
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private static bool Checkdauvao(cBenhPKDO ds)
        {
            if (ds.MANHOMBENH1.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn nhóm bệnh!");
                return false;
            }
            if (ds.TENBENHTV.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập lại tên bệnh tiếng việt!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// lấy mã bệnh vị trí cuối cùng
        /// </summary>
        /// <returns></returns>
        public string XuLyMaBenh()
        {
            string maNhombenh = cmbNhombenh.EditValue.ToString();
            string maNhombenh1 = "";
            string maBenh = BUS.cBenhBUS.GetMabenh(maNhombenh);
            if (maBenh == null)
            {
                maNhombenh1 = maNhombenh + ".00";
            }
            else
            {

                string kyTuDau = maBenh.Substring(0, 4);
                int soCanTang = Convert.ToInt32(maBenh.Substring(4)) + 1;

                if (soCanTang >= 0 && soCanTang < 10)
                    maNhombenh1 = kyTuDau + "0" + soCanTang;
                if (soCanTang >= 10 && soCanTang < 100)
                    maNhombenh1 = kyTuDau + "." + soCanTang;
                if (soCanTang >= 100)
                    maNhombenh1 = "Không thể tăng hơn nữa!";
            }
            return maNhombenh1;
        }
        #endregion
        #region Xử lý các thao tác nghiệp vụ

        /// <summary>
        /// thực hiện thao tác thêm mới nhóm bệnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNhombenh_Click(object sender, EventArgs e)
        {
            frmNhombenh nhombenh = new frmNhombenh();
            if (nhombenh.ShowDialog() == DialogResult.Cancel)
            {
                ucBenh_Load(sender, e);
            }
        }
        /// <summary>
        /// thực hiện thao tác thêm mới dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            Add = true;
            Update = false;
            Resettextvalue();
            Enablediting(true);
        }
        /// <summary>
        /// Thực hiện thao tác lưu dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuu_Click(object sender, EventArgs e)
        {

            cBenhPKDO ds = Getthongtinbenh();
            string mabenh = XuLyMaBenh();
            if (Checkdauvao(ds) == true)
            {
                if (Add && BUS.cBenhBUS.CheckBenh(ds.MABENH) == true && Update == false)
                {
                    XtraMessageBox.Show("Mã bệnh đã tồn tại: " + txtMabenh.Text + "!!",
                        "Hỏi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Enablediting(true);
                }
                else
                {
                    if (Add && BUS.cBenhBUS.CheckBenh(ds.MABENH) == false && Update == false)
                    {
                        BUS.cBenhBUS.InsertBenh(mabenh, ds.MANHOMBENH1, ds.TENBENHTA, ds.TENBENHTV, ds.MOTA1, ds.NGAYTAO1, ds.TRANGTHAI1);
                        ucBenh_Load(sender, e);
                        XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (Update)
                {
                    BUS.cBenhBUS.UpdateBenh(ds.MABENH, ds.TENBENHTA, ds.TENBENHTV, ds.MOTA1, ds.NGAYTAO1, ds.TRANGTHAI1);
                    ucBenh_Load(sender, e);
                    XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// thực hiện thao táo không lưu dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            Enablediting(false);
        }
        /// <summary>
        /// Thực hiện binding dữ liệu theo phương thức row changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridBenh_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtMabenh.Text = gridBenh.GetRowCellValue(e.FocusedRowHandle, "MABENH").ToString();
                txtTenbenhTA.Text = gridBenh.GetRowCellValue(e.FocusedRowHandle, "TENBENHTA").ToString();
                txtTenbenhTV.Text = gridBenh.GetRowCellValue(e.FocusedRowHandle, "TENBENHTV").ToString();
                cmbNhombenh.EditValue = gridBenh.GetRowCellValue(e.FocusedRowHandle, "MANHOMBENH1").ToString();
                txtMota.Text = gridBenh.GetRowCellValue(e.FocusedRowHandle, "MOTA1").ToString();
                bool TRANGTHAI = bool.Parse(gridBenh.GetRowCellValue(e.FocusedRowHandle, "TRANGTHAI1").ToString());
                if (TRANGTHAI == true)
                {
                    chkTrangThai.Checked = true;
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
            }
            catch (System.Exception ex)
            {

            }
        }
        /// <summary>
        /// Thực hiện chức năng binding dữ liệu theo phương thức rowclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridBenh_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMabenh.Text = gridBenh.GetRowCellValue(e.RowHandle, "MABENH").ToString();
                txtTenbenhTA.Text = gridBenh.GetRowCellValue(e.RowHandle, "TENBENHTA").ToString();
                txtTenbenhTV.Text = gridBenh.GetRowCellValue(e.RowHandle, "TENBENHTV").ToString();
                cmbNhombenh.EditValue = gridBenh.GetRowCellValue(e.RowHandle, "MANHOMBENH1").ToString();
                txtMota.Text = gridBenh.GetRowCellValue(e.RowHandle, "MOTA").ToString();
                bool TRANGTHAI = bool.Parse(gridBenh.GetRowCellValue(e.RowHandle, "TRANGTHAI1").ToString());
                if (TRANGTHAI == true)
                {
                    chkTrangThai.Checked = true;
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
            }
            catch (System.Exception ex)
            {

            }
        }
        /// <summary>
        /// Thực hiện chức năng cập nhật dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            Add = false;
            Update = true;
            Enablediting(true);
        }
#endregion
    }
}
