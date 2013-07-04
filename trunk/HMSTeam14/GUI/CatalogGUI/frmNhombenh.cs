using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DO;
using BUS;
namespace GUI
{
    public partial class frmNhombenh : DevExpress.XtraEditors.XtraForm
    {
        public frmNhombenh()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhombenh_Load(object sender, EventArgs e)
        {
            Loaddsnhombenh();

        }
        /// <summary>
        /// tải thông tin bệnh
        /// </summary>
        private void Loaddsnhombenh()
        {
            Resettextvalue();
            
        }
        public cNhomBenhDO Getthongtinnhombenh()
        {
            cNhomBenhDO ds = new cNhomBenhDO();
            ds.MANHOMBENH = txtMaNhom.Text;
            ds.TENNHOMBENH = txtTenNhom.Text;
            ds.NGAYTAO = DateTime.Today;
            ds.MOTA = txtMota.Text;
            ds.TRANGTHAI=true;
            return ds;
        }
        /// <summary>
        /// kiểm tra thông tin nhập vào
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private static bool Checkdauvao(cNhomBenhDO ds)
        {
            if (ds.MANHOMBENH.Length<=2|| ds.MANHOMBENH.Length>3)
            {
                XtraMessageBox.Show("Mã nhóm bệnh chỉ có 3 ký tự ");
                return false;
            }
            if (ds.MANHOMBENH.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập mã nhóm bênh!");
                return false;
            }
            if (ds.TENNHOMBENH.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập tên nhóm bệnh!");
                return false;
            }

            return true;
        }
        /// <summary>
        /// reset hết text
        /// </summary>
        private void Resettextvalue()
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            txtMota.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            cNhomBenhDO ds = Getthongtinnhombenh();
            if (Checkdauvao(ds) == true)
            {
                if ( BUS.cBenhBUS.CheckNhombenh(ds.MANHOMBENH) == true)
                {
                    XtraMessageBox.Show("Nhóm bệnh đã tồn tại: " + txtMaNhom.Text + "!!",
                        "Hỏi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (BUS.cBenhBUS.CheckNhombenh(ds.MANHOMBENH) == false)
                    {
                        BUS.cBenhBUS.InsertNhombenh(ds.MANHOMBENH, ds.TENNHOMBENH, ds.MOTA,ds.NGAYTAO, ds.TRANGTHAI);
                        frmNhombenh_Load(sender, e);
                        XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Resettextvalue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}