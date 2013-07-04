﻿using System;
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
    public partial class ucPhongkham : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPhongkham()
        {
            InitializeComponent();
        }

        /// <summary>
        /// khai báo các biến
        /// </summary>
        private bool Add = false, Update = false;

        /// <summary>
        /// lấy thông tin phòng khám
        /// </summary>
        /// <returns></returns>
        public cPhongKhamDO Getthongtinpk()
        {
            cPhongKhamDO ds = new cPhongKhamDO();
            ds.TENPHONG = txtTenphongkham.Text;
            ds.MAPHONGKHAM = txtMaphongkham.Text;
            ds.NGAYTAO = DateTime.Today;
            if(chkTrangThai.Checked == true)
            {
                ds.TRANGTHAI = true;
            }else
            {
                ds.TRANGTHAI = false;
            }
            return ds;
        }

        /// <summary>
        /// tải thông tin phòng khám
        /// </summary>
        private void Loaddsphongkham()
        {
            List<cPhongKhamDO> dsphongkham = BUS.cPhongKhamBUS.Getdsphongkham();
            grdDanhmucphongkham.DataSource = dsphongkham;
            Enablediting(false);
        }

        /// <summary>
        /// hàm ẩn và mở các button và textbox....
        /// </summary>
        /// <param name="editing"></param>
        private void Enablediting(bool editing)
        {
            btnTaomoi.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnKhongLuu.Enabled = editing;
            //txtMaphongkham.Enabled = editing;
            txtTenphongkham.Enabled = editing;
            chkTrangThai.Enabled = editing;
        }

        /// <summary>
        /// kiểm tra thông tin nhập vào
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private static bool Checkdauvao(cPhongKhamDO ds)
        {
            if (ds.TENPHONG.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập lại tên phòng khám!");
                return false;
            }
            return true;
        }

        /// <summary>
        /// reset hết text
        /// </summary>
        private void Resettextvalue()
        {
            txtTenphongkham.Text = null;
            chkTrangThai.Checked = false;
        }

        /// <summary>
        /// xử lý mã phòng khám
        /// </summary>
        /// <returns></returns>
        public string Xulymaphongkham()
        {
            string maphongkham = BUS.cPhongKhamBUS.Getmaphongkham();
            int socantang = Convert.ToInt32(maphongkham) + 1;
            string maphongkham2 = null;
            if (socantang >= 0 && socantang < 10)
            {
                maphongkham2 = "0000" + socantang;
            }
            if(socantang >=10 && socantang <100)
            {
                maphongkham2 = "000" + socantang;
            }
            if(socantang >=100 && socantang <1000)
            {
                maphongkham2 = "00" + socantang;
            }
            if(socantang >=1000 && socantang <10000)
            {
                maphongkham2 ="0" + socantang;
            }
            if(socantang >=10000 && socantang <100000)
            {
                maphongkham2 = socantang.ToString();
            }
            return maphongkham2;
        }

        /// <summary>
        /// tạo mới phòng khám
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            Add = true;
            Update = false;
            Resettextvalue();
            Enablediting(true);
            txtMaphongkham.Text = Xulymaphongkham();
        }

        /// <summary>
        /// sửa thông tin phòng khám
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            Add = false;
            Update = true;
            Enablediting(true);
        }

        /// <summary>
        /// sử lý lưu thông tin phòng khám
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            cPhongKhamDO ds = Getthongtinpk();
            string maphongkham = Xulymaphongkham();

            if(Checkdauvao(ds) == true)
            {
                if (Add && BUS.cPhongKhamBUS.Checkphongkham(ds.TENPHONG) == true && Update == false)
                {
                    XtraMessageBox.Show("Tên phòng khám đã tồn tại: " + txtTenphongkham.Text + "!!",
                        "Hỏi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Enablediting(true);
                }else
                {
                    if(Add && BUS.cPhongKhamBUS.Checkphongkham(ds.TENPHONG) == false && Update == false)
                    {
                        BUS.cPhongKhamBUS.Insertphongkham(maphongkham, ds.TENPHONG, ds.NGAYTAO, ds.TRANGTHAI);
                        ucPhongkham_Load(sender, e);
                        XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if(Update)
                {
                    BUS.cPhongKhamBUS.Updatephongkham(ds.MAPHONGKHAM, ds.TENPHONG, ds.NGAYTAO, ds.TRANGTHAI);
                    ucPhongkham_Load(sender, e);
                    XtraMessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Load thông tin phòng khám
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucPhongkham_Load(object sender, EventArgs e)
        {
            Loaddsphongkham();
            Enablediting(false);
        }

        /// <summary>
        /// binding phòng khám
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridDanhmucphongkham_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaphongkham.Text = gridDanhmucphongkham.GetRowCellValue(e.RowHandle, "MAPHONGKHAM").ToString();
                txtTenphongkham.Text = gridDanhmucphongkham.GetRowCellValue(e.RowHandle, "TENPHONG").ToString();
                bool TRANGTHAI = bool.Parse(gridDanhmucphongkham.GetRowCellValue(e.RowHandle, "TRANGTHAI").ToString());
                if(TRANGTHAI == true)
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
        /// binding theo sự kiện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridDanhmucphongkham_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtMaphongkham.Text = gridDanhmucphongkham.GetRowCellValue(e.FocusedRowHandle, "MAPHONGKHAM").ToString();
                txtTenphongkham.Text = gridDanhmucphongkham.GetRowCellValue(e.FocusedRowHandle, "TENPHONG").ToString();
                bool TRANGTHAI = bool.Parse(gridDanhmucphongkham.GetRowCellValue(e.FocusedRowHandle, "TRANGTHAI").ToString());
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
        /// Thực hiện sự kiện cho nút không lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if(data == Keys.Enter)
            {
                btnLuu.PerformClick();
                return true;
            }
            return false;
        }
    }
}
