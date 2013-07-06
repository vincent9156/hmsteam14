using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class frmGiaodienchinh : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaodienchinh()
        {
            InitializeComponent();
        }

        private void btnPhongkham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucPhongkham Phongkham = new ucPhongkham();
            pnHienthi.Controls.Add(Phongkham);
            Phongkham.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucThuoc Thuoc = new ucThuoc();
            pnHienthi.Controls.Add(Thuoc);
            Thuoc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnBenh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucBenh Benh = new ucBenh();
            pnHienthi.Controls.Add(Benh);
            Benh.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void frmGiaodienchinh_Load(object sender, EventArgs e)
        {
            // skins
            DevExpress.UserSkins.BonusSkins.Register();
            //DevExpress.UserSkins.OfficeSkins.Register();
            SkinHelper.InitSkinPopupMenu(btnGiaodien);
        }

        private void btnHosobenhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucKhambenhngoaitru Benhan = new ucKhambenhngoaitru();
            pnHienthi.Controls.Add(Benhan);
            Benhan.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        private void btnToathuocmau_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucDonthuocmau Donthuoc = new ucDonthuocmau();
            pnHienthi.Controls.Add(Donthuoc);
            Donthuoc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnTrangchu_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucTrangchu Trangchu = new ucTrangchu();
            pnHienthi.Controls.Add(Trangchu);
            Trangchu.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnNhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucNhanvien nhanvien = new ucNhanvien();
            pnHienthi.Controls.Add(nhanvien);
            nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnLichlamviec_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucLichlamviec lichlamviec = new ucLichlamviec();
            pnHienthi.Controls.Add(lichlamviec);
            lichlamviec.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnNhomnguoidung_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucNhomnguoidung nhomnguoidung = new ucNhomnguoidung();
            pnHienthi.Controls.Add(nhomnguoidung);
            nhomnguoidung.Dock = System.Windows.Forms.DockStyle.Fill;

        }

        private void btnBenhtheoPK_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucBenhtheophongkham benhtheophongkham = new ucBenhtheophongkham();
            pnHienthi.Controls.Add(benhtheophongkham);
            benhtheophongkham.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnBaocao_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucBaocao baocao = new ucBaocao();
            pnHienthi.Controls.Add(baocao);
            baocao.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnDangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btnThaydoimk_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoimatkhau doimatkhau = new frmDoimatkhau();
            doimatkhau.Show();
        }

        private void btnPhanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucPhanquyen phanquyen = new ucPhanquyen();
            pnHienthi.Controls.Add(phanquyen);
            phanquyen.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnSinhlieuThetrang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnHienthi.Controls.Clear();
            ucSinhlieu sinhlieu = new ucSinhlieu();
            pnHienthi.Controls.Add(sinhlieu);
            sinhlieu.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnGiupdo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHelp giupdo = new frmHelp();
            giupdo.Show();
        }

        private void btnThongtinPM_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongtinphanmem thongtin = new frmThongtinphanmem();
            thongtin.Show();
        }

        private void frmGiaodienchinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.ExitThread();
        }
    }
}