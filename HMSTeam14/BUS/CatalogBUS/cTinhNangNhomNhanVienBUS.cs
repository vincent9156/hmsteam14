using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;

namespace BUS
{
    public class cTinhNangNhomNhanVienBUS
    {
        public static List<cTinhNangNhomNhanVienDO> GetFunctionList()
        {
            return DA.cTinhNangNhomNhanVienDA.GetFunctionofGroupList();
        }

        public static void InsertFunctionofGroup(string MaNhomNhanVien, string MaTinhNang)
        {
            DA.cTinhNangNhomNhanVienDA.InsertFunctionofGroup(MaNhomNhanVien, MaTinhNang);
        }

        public static void DeleteFunctionofGroup(string MaNhomNhanVien)
        {
            DA.cTinhNangNhomNhanVienDA.DeleteFunctionofGroup(MaNhomNhanVien);
        }
        public static List<cTinhNangNhomNhanVienDO> GetListOfFunctionByGroupID(string GroupID)
        {
            return DA.cTinhNangNhomNhanVienDA.GetListOfFunctionByGroupID(GroupID);
        }
    }
}
