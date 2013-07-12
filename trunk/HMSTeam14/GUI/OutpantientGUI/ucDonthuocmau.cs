using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DO;
using System.Text.RegularExpressions;
namespace GUI
{
    public partial class ucDonthuocmau : DevExpress.XtraEditors.XtraUserControl
    {
        public ucDonthuocmau()
        {
            InitializeComponent();
        }
        private string MABACSY = "", DTMau = "";
        private bool update = false, Add = false, check2 = false;
        private void ucDonthuocmau_Load(object sender, EventArgs e)
        {
            LoadListMedicine();
        }
        private void LoadListMedicine()
        {
            List<cThuocDO> dsThuoc = BUS.cThuocBUS.GetMedicine1(true);
            cmbTenthuoc.Properties.DataSource = dsThuoc;
            cmbTenthuoc.Properties.DisplayMember = "TENTHUONGMAI";
            cmbTenthuoc.Properties.ValueMember = "MATHUOC";
            MABACSY = DO.cCommonDO.CurrentUser.MANHANVIEN;
            List<cDonThuocMauChiTietDO> dsdonthuoc1 = BUS.cDonthuocmauBUS.Getdsdonthuocmau(DTMau, MABACSY);
            lbldangsudungdon.Text = DTMau;
            grdDonthuocmau.DataSource = dsdonthuoc1;
            EnableEditing(false);
        }
        public cDonThuocMauChiTietDO GetInformationMedicine()
        {
            cDonThuocMauChiTietDO me = new cDonThuocMauChiTietDO();
            me.MATHUOC = cmbTenthuoc.EditValue.ToString();
            me.SOLUONG = txtSoluong.Text;
            me.SOLANDUNG = txtSolandung.Text;
            me.SOLUONGDUNG = txtSoluongdan.Text;
            return me;
        }
        private void lblDT1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check2 = true;
            if (BUS.cDonthuocmauBUS.CheckDonthuocmau("DT1", MABACSY) == false)
            {
                BUS.cDonthuocmauBUS.InsertDonthuocmau("DT1", MABACSY, DateTime.Today, true);
                DTMau = "DT1";
                XtraMessageBox.Show("Đơn thuốc mẫu 1 chưa có và đã được thêm");
                ucDonthuocmau_Load(sender, e);
            }
            else
            {
                DTMau = "DT1";
                ucDonthuocmau_Load(sender, e);
            }
        }

        private void cmbTenthuoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                DO.cThuocDO Thuoc = BUS.cThuocBUS.Getthongtinthuoc(cmbTenthuoc.EditValue.ToString());
                txtCachdung.Text = Thuoc.CACHDUNG;
                txtDonvi.Text = Thuoc.DONVI;
                txtDonvidung.Text = Thuoc.DONVIDUNG;
                txtGhichu.Text = Thuoc.GHICHU;
            }
            catch (System.Exception ex)
            {

            }
        }
        private static Boolean IsNumeric(string stringToTest)
        {
            int result;
            return int.TryParse(stringToTest, out result);
        }

        private static bool Checkdauvao(cDonThuocMauChiTietDO ds)
        {
            if (ds.MATHUOC.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn thuốc!");
                return false;
            }
            if (ds.SOLUONG.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn số lượng!");
                return false;
            }
            if (ds.SOLANDUNG.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn số lần dùng!");
                return false;
            }
            if (ds.SOLUONGDUNG.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn số lượng  dùng!");
                return false;
            }
            if (Int32.Parse(ds.SOLUONG) == 0)
            {
                XtraMessageBox.Show("Số lượng phải khác 0");
                return false;
            }
            if (Int32.Parse(ds.SOLANDUNG) == 0)
            {
                XtraMessageBox.Show("Số lần dùng phải khác 0");
                return false;
            }
            if (Int32.Parse(ds.SOLUONGDUNG) == 0)
            {
                XtraMessageBox.Show("Số lượng dùng phải khác 0");
                return false;
            }
            if (Int32.Parse(ds.SOLUONG) < (Int32.Parse(ds.SOLUONGDUNG)))
            {
                XtraMessageBox.Show("Số lượng dùng lớn hơn Số lượng");
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            cDonThuocMauChiTietDO es = GetInformationMedicine();
            if (Checkdauvao(es) == true)
            {
                if (IsNumeric(txtSoluong.Text) == true && IsNumeric(txtSolandung.Text) == true && IsNumeric(txtSoluongdan.Text) == true)
                {
                    if (Add && BUS.cDonthuocmauBUS.CheckThuoctrongdonthuoc(DTMau, MABACSY, es.MATHUOC) == true && update == false)
                    {
                        XtraMessageBox.Show(" Thuốc đã tồn tại trong đơn thuốc này ",
                        "Hỏi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ucDonthuocmau_Load(sender, e);
                    }
                    else
                    {
                        if (Add == true && BUS.cDonthuocmauBUS.CheckThuoctrongdonthuoc(DTMau, MABACSY, es.MATHUOC) == false && update == false)
                        {
                            DTMau = lbldangsudungdon.Text;
                            BUS.cDonthuocmauBUS.InsertDonthuocchitiet(DTMau, MABACSY, es.MATHUOC, es.SOLUONG, es.SOLANDUNG, es.SOLUONGDUNG, DateTime.Today);
                            XtraMessageBox.Show("Thêm mới thuốc vào đơn thuốc mẫu " + DTMau + " thành công");
                            Add = false;
                            ucDonthuocmau_Load(sender, e);
                        }
                        else
                        {
                            if (Add == false && update == true)
                            {
                                DTMau = lbldangsudungdon.Text;
                                BUS.cDonthuocmauBUS.UpdateDonthuocchitiet(DTMau, MABACSY, es.MATHUOC, es.SOLUONG, es.SOLANDUNG, es.SOLUONGDUNG, DateTime.Today);
                                XtraMessageBox.Show("Cập nhật thuốc vào đơn thuốc mẫu " + DTMau + " thành công");
                                update = false;
                                ucDonthuocmau_Load(sender, e);
                            }
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng điền các mục bằng số!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lblDT2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check2 = true;
            if (BUS.cDonthuocmauBUS.CheckDonthuocmau("DT2", MABACSY) == false)
            {
                BUS.cDonthuocmauBUS.InsertDonthuocmau("DT2", MABACSY, DateTime.Today, true);
                DTMau = "DT2";
                XtraMessageBox.Show("Đơn thuốc mẫu 2 chưa có và đã được thêm");
                ucDonthuocmau_Load(sender, e);
            }
            else
            {
                DTMau = "DT2";
                ucDonthuocmau_Load(sender, e);
            }
        }

        private void lblDT3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check2 = true;
            if (BUS.cDonthuocmauBUS.CheckDonthuocmau("DT3", MABACSY) == false)
            {
                BUS.cDonthuocmauBUS.InsertDonthuocmau("DT3", MABACSY, DateTime.Today, true);
                DTMau = "DT3";
                XtraMessageBox.Show("Đơn thuốc mẫu 3 chưa có và đã được thêm");
                ucDonthuocmau_Load(sender, e);
            }
            else
            {
                DTMau = "DT3";
                ucDonthuocmau_Load(sender, e);
            }
        }

        private void lblDT4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check2 = true;
            if (BUS.cDonthuocmauBUS.CheckDonthuocmau("DT4", MABACSY) == false)
            {
                BUS.cDonthuocmauBUS.InsertDonthuocmau("DT4", MABACSY, DateTime.Today, true);
                DTMau = "DT4";
                XtraMessageBox.Show("Đơn thuốc mẫu 4 chưa có và đã được thêm");
                ucDonthuocmau_Load(sender, e);
            }
            else
            {
                DTMau = "DT4";
                ucDonthuocmau_Load(sender, e);
            }
        }

        private void lblDT5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check2 = true;
            if (BUS.cDonthuocmauBUS.CheckDonthuocmau("DT5", MABACSY) == false)
            {
                BUS.cDonthuocmauBUS.InsertDonthuocmau("DT5", MABACSY, DateTime.Today, true);
                DTMau = "DT5";
                XtraMessageBox.Show("Đơn thuốc mẫu 5 chưa có và đã được thêm");
                ucDonthuocmau_Load(sender, e);
            }
            else
            {
                DTMau = "DT5";
                ucDonthuocmau_Load(sender, e);
            }
        }

        private void lblDT6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check2 = true;
            if (BUS.cDonthuocmauBUS.CheckDonthuocmau("DT6", MABACSY) == false)
            {
                BUS.cDonthuocmauBUS.InsertDonthuocmau("DT6", MABACSY, DateTime.Today, true);
                DTMau= "DT6";
                XtraMessageBox.Show("Đơn thuốc mẫu 6 chưa có và đã được thêm");
                ucDonthuocmau_Load(sender, e);
            }
            else
            {
                DTMau = "DT6";
                ucDonthuocmau_Load(sender, e);
            }
        }

        private void lblDT7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check2 = true;
            if (BUS.cDonthuocmauBUS.CheckDonthuocmau("DT7", MABACSY) == false)
            {
                BUS.cDonthuocmauBUS.InsertDonthuocmau("DT7", MABACSY, DateTime.Today, true);
                DTMau = "DT7";
                XtraMessageBox.Show("Đơn thuốc mẫu 7 chưa có và đã được thêm");
                ucDonthuocmau_Load(sender, e);
            }
            else
            {
                DTMau = "DT7";
                ucDonthuocmau_Load(sender, e);
            }
        }

        private void lblDT8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check2 = true;
            if (BUS.cDonthuocmauBUS.CheckDonthuocmau("DT8", MABACSY) == false)
            {
                BUS.cDonthuocmauBUS.InsertDonthuocmau("DT8", MABACSY, DateTime.Today, true);
                DTMau = "DT8";
                XtraMessageBox.Show("Đơn thuốc mẫu 8 chưa có và đã được thêm");
                ucDonthuocmau_Load(sender, e);
            }
            else
            {
                DTMau = "DT8";
                ucDonthuocmau_Load(sender, e);
            }
        }

        private void gridDonthuocmau_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                cmbTenthuoc.EditValue = gridDonthuocmau.GetRowCellValue(e.RowHandle, "MATHUOC").ToString();
                txtSoluong.Text = gridDonthuocmau.GetRowCellValue(e.RowHandle, "SOLUONG").ToString();
                txtDonvi.Text = gridDonthuocmau.GetRowCellValue(e.RowHandle, "DONVI").ToString();
                txtGhichu.Text = gridDonthuocmau.GetRowCellValue(e.RowHandle, "GHICHU").ToString();
                txtDonvidung.Text = gridDonthuocmau.GetRowCellValue(e.RowHandle, "DONVIDUNG").ToString();
                txtSolandung.Text = gridDonthuocmau.GetRowCellValue(e.RowHandle, "SOLANDUNG").ToString();
                txtSoluongdan.Text = gridDonthuocmau.GetRowCellValue(e.RowHandle, "SOLUONGDUNG").ToString();
                txtCachdung.Text = gridDonthuocmau.GetRowCellValue(e.RowHandle, "CACHDUNG").ToString();
            }
            catch (System.Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (check2 == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa thuốc ra khỏi đơn thuốc này hay không?", "Hỏi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string MADONTHUOCMAU = gridDonthuocmau.GetRowCellValue(gridDonthuocmau.FocusedRowHandle, "MADONTHUOCMAU1").ToString();
                    string MATHUOC = gridDonthuocmau.GetRowCellValue(gridDonthuocmau.FocusedRowHandle, "MATHUOC").ToString();
                    BUS.cDonthuocmauBUS.DeleteDonthuocchitiet(MADONTHUOCMAU, MABACSY,MATHUOC);
                    // load lại form
                    DTMau = MADONTHUOCMAU;
                    ucDonthuocmau_Load(sender, e);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn đơn thuốc mẫu plz!!!");
            }
        }
        private void Resettextvalue()
        {
 
            txtDonvi.Text = "";
            txtDonvidung.Text = "";
            txtGhichu.Text = "";
            txtSolandung.Text = "";
            txtSoluong.Text = "";
            txtSoluongdan.Text = "";
            txtCachdung.Text = "";
            cmbTenthuoc.EditValue = "";
        }
        private void EnableEditing(bool editing)
        {
            //btnThem.Enabled = !editing;
            //btnXoa.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnKhongluu.Enabled = editing;
            cmbTenthuoc.Enabled = editing;
            txtCachdung.Enabled = editing;
            txtDonvi.Enabled = editing;
            txtDonvidung.Enabled = editing;
            txtGhichu.Enabled = editing;
            txtSolandung.Enabled = editing;
            txtSoluong.Enabled = editing;
            txtSoluongdan.Enabled = editing;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check2==true)
            {
                Add = true;
                EnableEditing(true);
                Resettextvalue();
            } 
            else
            {
                XtraMessageBox.Show("Vui lòng chọn đơn thuốc mẫu plz!!!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check2 == true)
            {
                update = true;
                EnableEditing(true);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn đơn thuốc mẫu plz!!!");
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSolandung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoluongdan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            EnableEditing(false);
            Resettextvalue();
        }
    }
}
