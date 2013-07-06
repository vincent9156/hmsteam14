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
    public partial class ucNhanvien : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNhanvien()
        {
            InitializeComponent();
        }

        private bool Add = false, Update = false;
        //private List<cTinhNangDO> listFunc = BUS.cTinhNangBUS.GetFunctionList();
        //private List<cTinhNangNhomNhanVienDO> lstFunction = new List<cTinhNangNhomNhanVienDO>();
        public cNhanVienDO GetStaffInfor()
        {
            cNhanVienDO Gr = new cNhanVienDO();
            Gr.TENNHANVIEN = txtHovatenlot.Text.Trim();
            Gr.MANHANVIEN = txtManguoidung.Text;
            Gr.MANHOMNHANVIEN = BUS.cNhanVienBUS.GetIDByGroupName(lookUpNhom.EditValue.ToString());
            Gr.MAPHONGKHAM = BUS.cNhanVienBUS.GetIDByClinicName(lookUpPhongBan.EditValue.ToString());
            if (radNam.Checked == true)
            {
                Gr.GIOITINH = "Nam";
            }
            else
            {
                Gr.GIOITINH = "Nữ";
            }
            Gr.TENTAIKHOAN = txtTendangnhap.Text;
            Gr.MATKHAU = "123456";
            Gr.CHUCDANH = lookUpChuvu.EditValue.ToString();
            Gr.NGAYTAO = DateTime.Now;
            if (chkTrangthai.Checked == true)
            {
                Gr.TINHTRANG = true;
            }
            else
            {
                Gr.TINHTRANG = false;
            }
            return Gr;
        }

        private void LoadStaffList()
        {
            List<cNhanVienDO> GroupList = BUS.cNhanVienBUS.GetStaffList();
            grdNhanvien.DataSource = GroupList;
            Enablediting(false);

        }

        private void Enablediting(bool editing)
        {
            btnTaomoi.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnKhongLuu.Enabled = editing;
            txtHovatenlot.Enabled = editing;
            chkTrangthai.Enabled = editing;
            lookUpChuvu.Enabled = editing;
            lookUpNhom.Enabled = editing;
            lookUpPhongBan.Enabled = editing;
            radNam.Enabled = editing;
            radNu.Enabled = editing;
        }

        private static bool CheckInput(cNhanVienDO staff)
        {
            if (staff.TENNHANVIEN == "")
            {
                XtraMessageBox.Show("Vui lòng nhập tên nhân viên!");
                return false;
            }
            return true;
        }

        private void Resettextvalue()
        {
            txtTendangnhap.Text = null;
            chkTrangthai.Checked = false;
            txtHovatenlot.Text = null;
            lookUpChuvu.EditValue = "";
            lookUpNhom.EditValue = "";
            lookUpPhongBan.EditValue = "";
            radNam.Checked = false;
            radNu.Checked = false;
            txtManguoidung.Text = null;
        }

        private string StaffID()
        {
            string ID = BUS.cNhanVienBUS.GetStaffID();
            string NewID = "ABC";
            if (ID != null)
            {
                string matudong = ID.Substring(3);
                int stt = int.Parse(matudong);
                stt += 1;
                string tam = stt.ToString();
                for (int i = 0; i < (3 - tam.Length); i++)
                {
                    NewID += "0";
                }
                NewID += stt.ToString();
            }
            else
            {
                NewID = "ABC001";
            }
            return NewID;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Add = false;
            Update = true;
            Enablediting(true);
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            Add = true;
            Update = false;
            Resettextvalue();
            Enablediting(true);
            txtManguoidung.Text = StaffID();
            txtTendangnhap.Text = txtManguoidung.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cNhanVienDO ds = GetStaffInfor();
            string Staff = StaffID();

            if (CheckInput(ds) == true)
            {
                if (Add && Update == false)
                {
                    BUS.cNhanVienBUS.InsertNewStaff(Staff, ds.MAPHONGKHAM, ds.MANHOMNHANVIEN, ds.TENNHANVIEN, ds.GIOITINH, ds.TENTAIKHOAN, ds.MATKHAU, ds.CHUCDANH, ds.TINHTRANG, ds.NGAYTAO);
                    ucNhanVien_Load(sender, e);
                    XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (Update)
            {
                BUS.cNhanVienBUS.UpdateStaffInfor(ds.MANHANVIEN, ds.MAPHONGKHAM, ds.MANHOMNHANVIEN, ds.TENNHANVIEN, ds.GIOITINH, ds.CHUCDANH, ds.TINHTRANG);
                ucNhanVien_Load(sender, e);
                XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void gridNhomNguoiDung_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtManguoidung.Text = gridNhanvien.GetRowCellValue(e.RowHandle, "MANHANVIEN").ToString();
                txtHovatenlot.Text = gridNhanvien.GetRowCellValue(e.RowHandle, "TENNHANVIEN").ToString();
                txtTendangnhap.Text = gridNhanvien.GetRowCellValue(e.RowHandle, "TENTAIKHOAN").ToString();
                lookUpChuvu.EditValue = gridNhanvien.GetRowCellValue(e.RowHandle, "CHUCDANH").ToString();
                lookUpNhom.EditValue = gridNhanvien.GetRowCellValue(e.RowHandle, "MANHOMNHANVIEN").ToString();
                lookUpPhongBan.EditValue = gridNhanvien.GetRowCellValue(e.RowHandle, "MAPHONGKHAM").ToString();
                if (gridNhanvien.GetRowCellValue(e.RowHandle, "GIOITINH").ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                if (gridNhanvien.GetRowCellValue(e.RowHandle, "GIOITINH").ToString() == "Nữ")
                {
                    radNu.Checked = true;
                }
                bool TRANGTHAI = bool.Parse(gridNhanvien.GetRowCellValue(e.RowHandle, "TINHTRANG").ToString());
                if (TRANGTHAI == true)
                {
                    chkTrangthai.Checked = true;
                }
                else
                {
                    chkTrangthai.Checked = false;
                }
            }
            catch (System.Exception ex)
            {

            }
        }

        private void gridNhomNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtManguoidung.Text = gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "MANHANVIEN").ToString();
                txtHovatenlot.Text = gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "TENNHANVIEN").ToString();
                txtTendangnhap.Text = gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "TENTAIKHOAN").ToString();
                lookUpChuvu.EditValue = gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "CHUCDANH").ToString();
                lookUpNhom.EditValue = gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "MANHOMNHANVIEN").ToString();
                lookUpPhongBan.EditValue = gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "MAPHONGKHAM").ToString();
                if (gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "GIOITINH").ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                if (gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "GIOITINH").ToString() == "Nữ")
                {
                    radNu.Checked = true;
                }
                bool TRANGTHAI = bool.Parse(gridNhanvien.GetRowCellValue(e.FocusedRowHandle, "TINHTRANG").ToString());
                if (TRANGTHAI == true)
                {
                    chkTrangthai.Checked = true;
                }
                else
                {
                    chkTrangthai.Checked = false;
                }
            }
            catch (System.Exception ex)
            {
            }
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            LoadStaffList();
            Enablediting(false);
            LoadTitleLOOKUP();
            LoadClinicLOOKUP();
            LoadStaffGroupLOOKUP();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            Enablediting(false);
        }


        /// <summary>
        /// Thực hiện sự kiện cho nút enter
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys data)
        {
            if (data == Keys.Enter)
            {
                btnLuu.PerformClick();
                return true;
            }
            return false;
        }

        private void LoadTitleLOOKUP()
        {
            List<Title> tit = new List<Title>();
            tit.Add(new Title("Y Tá", "Y Tá"));
            tit.Add(new Title("Bác Sĩ", "BS"));
            tit.Add(new Title("Thạc sĩ", "Th.S"));
            tit.Add(new Title("Tiến Sĩ", "TS"));
            tit.Add(new Title("Phó Giáo Sư", "PGS TS"));
            tit.Add(new Title("Giáo Sư", "GS TS"));
            lookUpChuvu.Properties.DataSource = tit;
            lookUpChuvu.Properties.DisplayMember = "title";
            lookUpChuvu.Properties.ValueMember = "vtitle";
        }

        private void LoadStaffGroupLOOKUP()
        {
            List<GroupLookup> grouplist = new List<GroupLookup>();
            List<cNhomNhanVienDO> grp = BUS.cNhomNhanVienBUS.GetStaffGroupList();
            foreach (var row in grp)
            {
                if (row.TRANGTHAI == true)
                {
                    grouplist.Add(new GroupLookup(row.TENNHOMNHANVIEN));
                }
            }

            lookUpNhom.Properties.DataSource = grouplist;
            lookUpNhom.Properties.DisplayMember = "group";
            lookUpNhom.Properties.ValueMember = "group";
        }

        private void LoadClinicLOOKUP()
        {
            List<ClinicLookup> cliniclist = new List<ClinicLookup>();
            List<cPhongKhamDO> clc = cPhongKhamBUS.Getdsphongkham();
            foreach (var row in clc)
            {
                if (row.TRANGTHAI == true)
                {
                    cliniclist.Add(new ClinicLookup(row.TENPHONG));
                }
            }

            lookUpPhongBan.Properties.DataSource = cliniclist;
            lookUpPhongBan.Properties.DisplayMember = "clinic";
            lookUpPhongBan.Properties.ValueMember = "clinic";
        }
        private class Title
        {
            public string title { set; get; }
            public string vtitle { set; get; }
            public Title(string t, string vt)
            {
                this.title = t;
                this.vtitle = vt;
            }
        }

        private class GroupLookup
        {
            public string group { set; get; }
            public GroupLookup(string g)
            {
                this.group = g;
            }
        }

        private class ClinicLookup
        {
            public string clinic { set; get; }
            public ClinicLookup(string c)
            {
                this.clinic = c;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cNhanVienDO ds = GetStaffInfor();
            BUS.cNhanVienBUS.UpdatePassword(ds.MANHANVIEN, ds.MATKHAU);
            ucNhanVien_Load(sender, e);
            XtraMessageBox.Show("Mật khẩu đã được thiết lập lại!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
