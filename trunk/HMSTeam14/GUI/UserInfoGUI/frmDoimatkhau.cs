using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using DO;
using BUS;

namespace GUI
{
    public partial class frmDoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void btnDongydoimatkhau_Click(object sender, EventArgs e)
        {
            if (txtMatkhauhientai.Text.Trim() == null || txtMatkhaumoi.Text.Trim() == null || txtXacnhanmatkhau.Text.Trim() == null)
            {
                if (txtMatkhauhientai.Text.Trim() == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtMatkhaumoi.Text.Trim() == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập mật khẩu mới!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtXacnhanmatkhau.Text.Trim() == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập xác nhận lại mật khẩu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtMatkhaumoi.Text = "";
                txtMatkhauhientai.Text = "";
                txtXacnhanmatkhau.Text = "";
                //txtMatkhauhientai.Focus();
            }
            else
            {
                if (CheckPassword(txtMatkhaumoi.Text) == true && txtMatkhaumoi.Text.Length >= 6)
                {
                    DO.cNhanVienDO user = BUS.cNhanVienBUS.GetStaffInforByID(DO.cCommonDO.CurrentUser.MANHANVIEN);
                    string inputpassword = BUS.cNhanVienBUS.ToMD5(BUS.cNhanVienBUS.ToMD5(BUS.cNhanVienBUS.ToMD5(txtMatkhauhientai.Text)));
                    if (user.MATKHAU == inputpassword)
                    {
                        if (txtMatkhaumoi.Text.Trim().Equals(txtXacnhanmatkhau.Text.Trim()) == false)
                        {
                            XtraMessageBox.Show("Mật khẩu xác nhận chưa đúng!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMatkhaumoi.Text = "";
                            txtMatkhauhientai.Text = "";
                            txtXacnhanmatkhau.Text = "";
                            //txtMatkhauhientai.Focus();
                        }else
                        {
                            XtraMessageBox.Show("Thay đổi mật khẩu thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BUS.cNhanVienBUS.UpdatePassword(user.MANHANVIEN, txtMatkhaumoi.Text);
                            this.Hide();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Mật khẩu hiện tại không đúng!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMatkhaumoi.Text = "";
                        txtMatkhauhientai.Text = "";
                        txtXacnhanmatkhau.Text = "";
                        //txtMatkhauhientai.Focus();
                    }
                }
                else
                {
                    if (txtMatkhaumoi.Text.Length < 6)
                    {
                        XtraMessageBox.Show("Mật khẩu phải hơn 6 kí tự!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        XtraMessageBox.Show("Mật khẩu chỉ bao gồm kí tự, chữ số và các kí tự đặc biệt \n Không bao gồm khoảng trắng!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtMatkhaumoi.Text = "";
                    txtMatkhauhientai.Text = "";
                    txtXacnhanmatkhau.Text = "";
                    //txtMatkhauhientai.Focus();
                }
            }
        }

        private bool CheckPassword(string password)
        {
            return Regex.IsMatch(password, "(^[A-Za-z0-9_~!@#$%^&*()-=_+:;<>?/`”’\\s]{4,}$)");
        }

        private void btnHuybodoimatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys data)
        {
            if (data == Keys.Enter)
            {
                btnDongydoimatkhau.PerformClick();
                return true;
            }
            return false;
        }
    }
}