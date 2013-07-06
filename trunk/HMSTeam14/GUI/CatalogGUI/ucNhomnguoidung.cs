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
    public partial class ucNhomnguoidung : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNhomnguoidung()
        {
            InitializeComponent();
        }
        private bool Add = false, Update = false;
        private List<cTinhNangDO> listFunc = BUS.cTinhNangBUS.GetFunctionList();
        private List<cTinhNangNhomNhanVienDO> lstFunction = new List<cTinhNangNhomNhanVienDO>();
        public cNhomNhanVienDO GetStaffGroupInfor()
        {
            cNhomNhanVienDO Gr = new cNhomNhanVienDO();
           
           
            Gr.TENNHOMNHANVIEN = CheckName(txtTenNhom.Text).Trim();
            Gr.MANHOMNHANVIEN = txtMaNhom.Text;
            Gr.MOTA = txtMota.Text;
            if (chkTrangthai.Checked == true)
            {
                Gr.TRANGTHAI = true;
            }
            else
            {
                Gr.TRANGTHAI = false;
            }
            return Gr;
        }
        private string CheckName(string name)
        {
            String[] n = name.Split(' ');
            string sTenNhom = "";
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = n[i].Trim();
                if (n[i] != "")
                {
                    sTenNhom = sTenNhom + " " + n[i];
                }
            }
            return sTenNhom;
        }
        private void LoadStaffGroupList()
        {
            List<cNhomNhanVienDO> GroupList = BUS.cNhomNhanVienBUS.GetStaffGroupList();
            grdNhomNhanVien.DataSource = GroupList;
            Enablediting(false);

        }

        private void Enablediting(bool editing)
        {
            btnTaomoi.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnKhongLuu.Enabled = editing;
            //txtMaphongkham.Enabled = editing;
            txtTenNhom.Enabled = editing;
            txtMota.Enabled = editing;
            chkTrangthai.Enabled = editing;
            chklstTinhnang.Enabled = editing;
        }

        private static bool CheckInput(cNhomNhanVienDO Group)
        {
            if (Group.TENNHOMNHANVIEN == "")
            {
                XtraMessageBox.Show("Vui lòng nhập tên nhóm nhân viên!");
                return false;
            }
            return true;
        }

        private void Resettextvalue()
        {
            txtTenNhom.Text = null;
            chkTrangthai.Checked = false;
            txtMota.Text = null;
        }

        private string StaffGroupID()
        {
            string ID = BUS.cNhomNhanVienBUS.GetStaffGroupID();
            string NewID = "G";
            if (ID != null)
            {
                string matudong = ID.Substring(1);
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
                NewID = "G001";
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
            txtMaNhom.Text = StaffGroupID();
            chklstTinhnang.UnCheckAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cNhomNhanVienDO ds = GetStaffGroupInfor();
            string GroupID = StaffGroupID();

            if(CheckInput(ds) == true)
            {
                if (Add && BUS.cNhomNhanVienBUS.CheckExist(ds.TENNHOMNHANVIEN) == true && Update == false)
                {
                    XtraMessageBox.Show("Tên phòng khám đã tồn tại: " + CheckName(txtTenNhom.Text) + "!",
                        "Hỏi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Enablediting(true);
                }else
                {
                    if(Add && BUS.cNhomNhanVienBUS.CheckExist(ds.TENNHOMNHANVIEN) == false && Update == false)
                    {
                        BUS.cNhomNhanVienBUS.InsertStaffGroup(GroupID, ds.TENNHOMNHANVIEN, ds.MOTA, ds.TRANGTHAI);
                        SaveFunction();
                        ucNhomNhanVien_Load(sender, e);
                        XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if(Update)
                {
                    BUS.cNhomNhanVienBUS.UpdateStaffGroup(ds.MANHOMNHANVIEN, ds.TENNHOMNHANVIEN, ds.MOTA, ds.TRANGTHAI);
                    BUS.cTinhNangNhomNhanVienBUS.DeleteFunctionofGroup(txtMaNhom.Text);
                    SaveFunction();
                    ucNhomNhanVien_Load(sender, e);
                    XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void gridNhomNguoiDung_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaNhom.Text = gridNhomNhanVien.GetRowCellValue(e.RowHandle, "MANHOMNHANVIEN").ToString();
                txtTenNhom.Text = gridNhomNhanVien.GetRowCellValue(e.RowHandle, "TENNHOMNHANVIEN").ToString();
                txtMota.Text = gridNhomNhanVien.GetRowCellValue(e.RowHandle, "MOTA").ToString();
                lstFunction = BUS.cTinhNangNhomNhanVienBUS.GetListOfFunctionByGroupID(txtMaNhom.Text);
                SetCheckedGroupsForSelectedUser();
                bool TRANGTHAI = bool.Parse(gridNhomNhanVien.GetRowCellValue(e.RowHandle, "TRANGTHAI").ToString());
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
                txtMaNhom.Text = gridNhomNhanVien.GetRowCellValue(e.FocusedRowHandle, "MANHOMNHANVIEN").ToString();
                txtTenNhom.Text = gridNhomNhanVien.GetRowCellValue(e.FocusedRowHandle, "TENNHOMNHANVIEN").ToString();
                txtMota.Text = gridNhomNhanVien.GetRowCellValue(e.FocusedRowHandle, "MOTA").ToString();
                bool TRANGTHAI = bool.Parse(gridNhomNhanVien.GetRowCellValue(e.FocusedRowHandle, "TRANGTHAI").ToString());
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
        private int loadno = 0;
        private void ucNhomNhanVien_Load(object sender, EventArgs e)
        {
            LoadStaffGroupList();
            Enablediting(false);
            if (loadno == 0)
            {
                chklstTinhnang_Load();
                loadno++;
            }
            lstFunction = BUS.cTinhNangNhomNhanVienBUS.GetListOfFunctionByGroupID(txtMaNhom.Text);
            SetCheckedGroupsForSelectedUser();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            Enablediting(false);
        }

        private void chklstTinhnang_Load()
        {
            string sText = string.Empty;
            foreach (var row in listFunc)
            {
                cCheckedListBoxItem item = new cCheckedListBoxItem();
                item.Text = row.TENTINHNANG;
                item.Tag = row;
                chklstTinhnang.Items.Add(item);

                if (sText.Length < item.Text.Length)
                    sText = item.Text;
            }
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

        ///<sumary>
        /// Them chuc nang vao nhom nhan vien
        ///<sumary>
        cTinhNangDO objTinhnang;
        cTinhNangNhomNhanVienDO objTinhnangNhomnhanvien;
        private void SaveFunction()
        {
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                for (int i = 0; i < chklstTinhnang.CheckedItems.Count; i++)
                {
                    cCheckedListBoxItem item = (cCheckedListBoxItem) chklstTinhnang.CheckedItems[i];
                    if (item != null)
                    {
                        objTinhnang = (cTinhNangDO)item.Tag;
                        objTinhnangNhomnhanvien = new cTinhNangNhomNhanVienDO();
                        objTinhnangNhomnhanvien.MANHOMNHANVIEN = txtMaNhom.Text.Trim();
                        objTinhnangNhomnhanvien.MATINHNANG = objTinhnang.MATINHNANG;
                        BUS.cTinhNangNhomNhanVienBUS.InsertFunctionofGroup(objTinhnangNhomnhanvien.MANHOMNHANVIEN, objTinhnangNhomnhanvien.MATINHNANG);
                    }
                }
            }
        }

        private void SetCheckedGroupsForSelectedUser()
        {
            chklstTinhnang.UnCheckAll();
            for (int i = 0; i < lstFunction.Count; i++)
            {
                int j = 0;
                foreach (var row in listFunc)
                {
                    if (row.MATINHNANG == lstFunction[i].MATINHNANG)
                    {
                        chklstTinhnang.SetItemChecked(j, true);
                    }
                    j++;
                }
            }
        }
    }
}
