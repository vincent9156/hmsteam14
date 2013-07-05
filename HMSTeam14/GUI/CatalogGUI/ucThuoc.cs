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
using System.Linq;


namespace GUI
{
    public partial class ucThuoc : DevExpress.XtraEditors.XtraUserControl
    {
        public ucThuoc()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Khai báo biến sử dụng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool add = false, update = false;
        private string MATHUOC;
        /// <summary>
        /// Thực hiện chức năng load danh sách thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucThuoc_Load(object sender, EventArgs e)
        {
            LoadListMedicine();
            EnableEditing(false);
            lookupEditCachDung_Load();
            lookupEditDonVi_Load();
            lookupEditDonvidung_Load();
        }
        private void LoadListMedicine()
        {
            List<cThuocDO> ListMedicine = BUS.cThuocBUS.GetMedicine();
            grdThuoc.DataSource = ListMedicine;
            EnableEditing(false);
        }
        /// <summary>
        /// Hàm lấy thông tin thuốc từ data object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public cThuocDO GetInformationMedicine()
        {
            cThuocDO me = new cThuocDO();
            me.MATHUOC = txtMathuoc.Text;
            me.TENBIETDUOC = txtTenthuoctv.Text;
            me.TENTHUONGMAI = txtTenthuocta.Text;
            me.CACHDUNG = lookUpEditCachDung.EditValue.ToString();
            me.DONVI = lookUpEditDonVi.EditValue.ToString();
            me.DONVIDUNG = lookUpEditDonViDung.EditValue.ToString();
            me.GHICHU = txtGhichu.Text;
            if (chkTrangThai.Checked == true)
            {
                me.TRANGTHAI = true;
            }
            else
            {
                me.TRANGTHAI = false;
            }
            return me;
        }
              

        /// <summary>
        /// Hàm reset text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetTextValue()
        {
            txtGhichu.Text = "";
            txtMathuoc.Text = "";
            txtTenthuocta.Text = "";
            txtTenthuoctv.Text = "";
            chkTrangThai.Checked = false;
            lookUpEditCachDung.EditValue = "";
            lookUpEditDonVi.EditValue = "";
            lookUpEditDonViDung.EditValue = "";
        }
        /// <summary>
        /// Hàm ẩn và mở các button và text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnableEditing(bool editing)
        {
            btnTaomoi.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnKhongLuu.Enabled = editing;
            lookUpEditCachDung.Enabled = editing;
            lookUpEditDonVi.Enabled = editing;
            lookUpEditDonViDung.Enabled = editing;
            chkTrangThai.Enabled = editing;
            txtGhichu.Enabled = editing;
            txtTenthuocta.Enabled = editing;
            txtTenthuoctv.Enabled = editing;
        }
        /// <summary>
        /// Kiểm tra đầu vào
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private static bool Checkdauvao(cThuocDO ds)
        {
            if (ds.TENBIETDUOC.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập tên Biệt Dược!");
                return false;
            }
            if (ds.TENTHUONGMAI.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập tên Thương Mại");
                return false;
            }
            if (ds.DONVI.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập Đơn Vị");
                return false;
            }
            return true;
        }
        /// <summary>
        /// xử lý mã thuốc
        /// </summary>
        /// <returns></returns>
        public string Xulymathuoc()
        {
            string mathuoc = BUS.cThuocBUS.Getmathuoc();
            int socantang = Convert.ToInt32(mathuoc) + 1;
            string mathuoc2 = null;
            if (socantang >= 0 && socantang < 10)
            {
                mathuoc2 = "0" + socantang;
            }
            if (socantang >= 10)
            {
                mathuoc2 = socantang.ToString();
            }
            return mathuoc2;
        }

        private void btnNhomthuoc_Click(object sender, EventArgs e)
        {
            frmNhomthuoc nhomthuoc = new frmNhomthuoc();
            if (nhomthuoc.ShowDialog() == DialogResult.Cancel)
            {
                ucThuoc_Load(sender, e);
            }
        }



        private void lookUpEditCachDung_EditValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Thực hiện thêm mới dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            add = true;
            update = false;
            ResetTextValue();
            EnableEditing(true);
            txtMathuoc.Text = Xulymathuoc();
        }
        /// <summary>
        /// Thực hiện lưu dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            cThuocDO ds = GetInformationMedicine();
            string mathuoc = Xulymathuoc();
            if (Checkdauvao(ds) == true)
            {
                if (add && BUS.cThuocBUS.CheckMedicine(ds.MATHUOC) == true && update == false)
                {
                    XtraMessageBox.Show("Mã thuốc đã tồn tại: " + txtMathuoc.Text + "!!",
                        "Hỏi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EnableEditing(true);
                }
                else
                {
                    if (add && BUS.cThuocBUS.CheckMedicine(ds.MATHUOC) == false && update == false)
                    {
                        BUS.cThuocBUS.InsertMedicine(mathuoc, ds.TENTHUONGMAI, ds.TENBIETDUOC, ds.CACHDUNG, ds.DONVI, ds.DONVIDUNG, ds.GHICHU, ds.TRANGTHAI);
                        ucThuoc_Load(sender, e);
                        XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (update)
                {
                    BUS.cThuocBUS.UpdateMedicine(ds.MATHUOC, ds.TENTHUONGMAI, ds.TENBIETDUOC, ds.CACHDUNG, ds.DONVI, ds.DONVIDUNG, ds.GHICHU, ds.TRANGTHAI);
                    ucThuoc_Load(sender, e);
                    XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// thao tác khi bấm nút hủy bỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            EnableEditing(false);
        }
        /// <summary>
        /// thực hiện binding dữ liệu theo phương thức row changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridThuoc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtMathuoc.Text = gridThuoc.GetRowCellValue(e.FocusedRowHandle, "MATHUOC").ToString();
                txtTenthuocta.Text = gridThuoc.GetRowCellValue(e.FocusedRowHandle, "TENTHUONGMAI").ToString();
                txtTenthuoctv.Text = gridThuoc.GetRowCellValue(e.FocusedRowHandle, "TENBIETDUOC").ToString();
                txtGhichu.Text = gridThuoc.GetRowCellValue(e.FocusedRowHandle, "GHICHU").ToString();
                lookUpEditCachDung.EditValue = gridThuoc.GetRowCellValue(e.FocusedRowHandle, "CACHDUNG").ToString();
                lookUpEditDonVi.EditValue = gridThuoc.GetRowCellValue(e.FocusedRowHandle, "DONVI").ToString();
                lookUpEditDonViDung.EditValue = gridThuoc.GetRowCellValue(e.FocusedRowHandle, "DONVIDUNG").ToString();
                bool TRANGTHAI = bool.Parse(gridThuoc.GetRowCellValue(e.FocusedRowHandle, "TRANGTHAI").ToString());
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
        /// Thực hiện binding dữ liệu bằng phương pháp row click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridThuoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMathuoc.Text = gridThuoc.GetRowCellValue(e.RowHandle, "MATHUOC").ToString();
                txtTenthuocta.Text = gridThuoc.GetRowCellValue(e.RowHandle, "TENTHUONGMAI").ToString();
                txtTenthuoctv.Text = gridThuoc.GetRowCellValue(e.RowHandle, "TENBIETDUOC").ToString();
                txtGhichu.Text = gridThuoc.GetRowCellValue(e.RowHandle, "GHICHU").ToString();
                lookUpEditCachDung.EditValue = gridThuoc.GetRowCellValue(e.RowHandle, "CACHDUNG").ToString();
                lookUpEditDonVi.EditValue = gridThuoc.GetRowCellValue(e.RowHandle, "DONVI").ToString();
                lookUpEditDonViDung.EditValue = gridThuoc.GetRowCellValue(e.RowHandle, "DONVIDUNG").ToString();
                bool TRANGTHAI = bool.Parse(gridThuoc.GetRowCellValue(e.RowHandle, "TRANGTHAI").ToString());
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
        /// Thao tác khi bấm sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            add = false;
            update = true;
            EnableEditing(true);
        }
        /// <summary>
        /// thêm value vào lookupEditCachdung
        /// </summary>
        private void lookupEditCachDung_Load()
        {
            //string[] Cachdung;
            List<Cachdung> cd = new List<Cachdung>();
            cd.Add(new Cachdung("Uống"));
            cd.Add(new Cachdung("Nhỏ"));
            cd.Add(new Cachdung("Nhai"));
            cd.Add(new Cachdung("Nhét hậu môn"));
            cd.Add(new Cachdung("Tiêm"));
            cd.Add(new Cachdung("Hít"));
            lookUpEditCachDung.Properties.DataSource = cd;
            lookUpEditCachDung.Properties.DisplayMember = "cachdung";
            lookUpEditCachDung.Properties.ValueMember = "cachdung";
        }

        private void lookUpEditCachdung_EditValueChanged(object sender, EventArgs e)
        {

            string mystring = lookUpEditCachDung.EditValue.ToString();

            lookUpEditCachDung.EditValue = mystring;
        }
        
        public class Cachdung
        {
            public string cachdung { set; get; }
            public Cachdung(string cd)
            {
                this.cachdung = cd;
            }
        }
        /// <summary>
        /// Thao tác lookUPEditDonVi
        /// </summary>
        private void lookupEditDonVi_Load()
        {
            List<Donvi> dv = new List<Donvi>();
            dv.Add(new Donvi("Vĩ"));
            dv.Add(new Donvi("Hộp"));
            dv.Add(new Donvi("Ống"));
            dv.Add(new Donvi("ml"));
            dv.Add(new Donvi("Gói"));
            dv.Add(new Donvi("lọ"));
            lookUpEditDonVi.Properties.DataSource = dv;
            lookUpEditDonVi.Properties.DisplayMember = "donvi";
            lookUpEditDonVi.Properties.ValueMember = "donvi";
        }

        private void lookupEditDonVi_EditValueChanged(object sender, EventArgs e)
        {

            string mystring = lookUpEditDonVi.EditValue.ToString();

            lookUpEditDonVi.EditValue = mystring;
        }

           public class Donvi
        {
            public string donvi { set; get; }
            public Donvi(string dv)
            {
                this.donvi = dv;
            }
        }
        /// <summary>
        /// thêm value vào lookupEditDonviDung
        /// </summary>
        private void lookupEditDonvidung_Load()
        {
            List<Donvidung> dvd = new List<Donvidung>();
            dvd.Add(new Donvidung("Viên"));
            dvd.Add(new Donvidung("Bột"));
            dvd.Add(new Donvidung("Ống"));
            dvd.Add(new Donvidung("Gói"));
            lookUpEditDonViDung.Properties.DataSource = dvd;
            lookUpEditDonViDung.Properties.DisplayMember = "donvidung";
            lookUpEditDonViDung.Properties.ValueMember = "donvidung";
        }

        private void lookUpEditDonvidung_EditValueChanged(object sender, EventArgs e)
        {

            string mystring = lookUpEditDonViDung.EditValue.ToString();

            lookUpEditDonViDung.EditValue = mystring;
        }
        
        public class Donvidung
        {
            public string donvidung { set; get; }
            public Donvidung(string dvd)
            {
                this.donvidung = dvd;
            }
        }
    }
}
