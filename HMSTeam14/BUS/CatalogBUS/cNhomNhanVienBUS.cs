using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;

namespace BUS
{
    public class cNhomNhanVienBUS
    {
        public static List<cNhomNhanVienDO> GetStaffGroupList()
        {
            return DA.cNhomNhanVienDA.GetStaffGroupList();
        }

        public static void InsertStaffGroup(string MaNhomNhanVien, string TenNhomNhanVien, string MoTa, bool TrangThai)
        {
            DA.cNhomNhanVienDA.InsertStaffGroup(MaNhomNhanVien, TenNhomNhanVien, MoTa, TrangThai);
        }

        public static void UpdateStaffGroup(string MaNhomNhanVien, string TenNhomNhanVien, string MoTa, bool TrangThai)
        {
            DA.cNhomNhanVienDA.UpdateStaffGroup(MaNhomNhanVien, TenNhomNhanVien, MoTa, TrangThai);
        }

        public static bool CheckExist(string TENNHOM)
        {
            return DA.cNhomNhanVienDA.CheckExist(TENNHOM);
        }

        public static string GetStaffGroupID()
        {
            return DA.cNhomNhanVienDA.GetStaffGroupID();
        }
    }
}
