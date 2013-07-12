using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BUS
{
    public class cDonthuocmauBUS
    {
        public static List<cDonThuocMauChiTietDO> Getdsdonthuocmau(string MADONTHUOCMAU, string MABACSY)
        {
            return DA.cDonThuocMauDA.Getdsdonthuocmau(MADONTHUOCMAU, MABACSY);
        }
        public static void InsertDonthuocmau(string MADONTHUOCMAU, string MABACSI, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cDonThuocMauDA.InsertDonthuocmau(MADONTHUOCMAU, MABACSI, NGAYTAO, TRANGTHAI);
        }
        public static void InsertDonthuocchitiet(string MADONTHUOCMAU, string MABACSI, string MATHUOC, string SOLUONG, string SOLANDUNG, string SOLUONGDUNG, DateTime NGAYTAO)
        {
            DA.cDonThuocMauDA.InsertDonthuocchitiet(MADONTHUOCMAU, MABACSI, MATHUOC, SOLUONG, SOLANDUNG, SOLUONGDUNG, NGAYTAO);
        }
        public static void UpdateDonthuocchitiet(string MADONTHUOCMAU, string MABACSI, string MATHUOC, string SOLUONG, string SOLANDUNG, string SOLUONGDUNG, DateTime NGAYTAO)
        {
            DA.cDonThuocMauDA.UpdateDonthuocchitiet(MADONTHUOCMAU, MABACSI,MATHUOC, SOLUONG, SOLANDUNG, SOLUONGDUNG, NGAYTAO);
        }
        public static void DeleteDonthuocchitiet(string MADONTHUOCMAU, string MABACSI,string MATHUOC)
        {
            DA.cDonThuocMauDA.DeleteDonthuocchitiet(MADONTHUOCMAU, MABACSI,MATHUOC);
        }
        public static bool CheckDonthuocmau(string MADONTHUOCMAU, string MABACSI)
        {
            return DA.cDonThuocMauDA.CheckDonthuocmau(MADONTHUOCMAU, MABACSI);
        }
        public static bool CheckThuoctrongdonthuoc(string MADONTHUOCMAU, string MABACSI ,string MATHUOC)
        {
            return DA.cDonThuocMauDA.CheckThuoctrongdonthuoc(MADONTHUOCMAU, MABACSI, MATHUOC);
        }
    }
}
