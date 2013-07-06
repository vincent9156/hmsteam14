using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DO;

namespace GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private int CountLogin = 4;
        private void btnOK_Click(object sender, EventArgs e)
        {
          
            if (CountLogin > 0 && Check() == true)
            {

                if (BUS.cNhanVienBUS.CheckUser(txtUsername.Text, txtPassword.Text) == true)
                {
                    frmGiaodienchinh Trangchinh = new frmGiaodienchinh();
                    Trangchinh.Show();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    CountLogin--;
                    XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu! \nVui lòng kiểm tra lại .\nBạn còn " + CountLogin + " lần đăng nhập nữa.", "FGS Logistics - Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
            if (CountLogin == 0)
                Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public bool Check()
        {
            if (txtUsername.Text == "")
            {
                XtraMessageBox.Show(" Chưa nhập tên đăng nhập !!!");
                return false;
            }
            if (txtPassword.Text == "")
            {
                XtraMessageBox.Show(" Chưa nhập mật khẩu !!!");
                return false;
            }
            return true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keydata)
        {
            if (keydata == Keys.Enter)
            {
                btnOK.PerformClick();
                return true;
            }
            return false;
        }
        public static string MD5(string password)
        {
            byte[] textBytes = System.Text.Encoding.Default.GetBytes(password);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }
    }
}