using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using System.Runtime.InteropServices;
namespace DA
{
    public class cTinhNangNhomNhanVienDA
    {
        public static List<cTinhNangNhomNhanVienDO> GetFunctionofGroupList()
        {
            List<cTinhNangNhomNhanVienDO> GroupList = new List<cTinhNangNhomNhanVienDO>();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbTINHNANGNHOMNDs select u;
                foreach (var row in query)
                {
                    cTinhNangNhomNhanVienDO ds = new cTinhNangNhomNhanVienDO();
                    ds.MATINHNANG = row.MATINHNANG;
                    ds.MANHOMNHANVIEN = row.MANHOMND;
                    ds.NGAYTAO = (DateTime) row.NGAYTAO;
                    GroupList.Add(ds);
                }
                return GroupList;
            }
        }

        public static void InsertFunctionofGroup(string MaNhomNhanVien, string MaTinhNang)
        {
            using (DB_HMS_Entities Group = new DB_HMS_Entities())
            {
                tbTINHNANGNHOMND lst = new tbTINHNANGNHOMND();
                lst.MATINHNANG = MaTinhNang;
                lst.MANHOMND = MaNhomNhanVien;
                lst.NGAYTAO = DateTime.Today;
                Group.AddTotbTINHNANGNHOMNDs(lst);
                Group.SaveChanges();
            }
        }

        public static void DeleteFunctionofGroup(string MaNhomNhanVien)
        {
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbTINHNANGNHOMNDs where u.MANHOMND == MaNhomNhanVien select u;
                foreach (var row in query)
                {
                    lst.DeleteObject(row);
                    
                }
                lst.SaveChanges();
            }
        }
        public static List<cTinhNangNhomNhanVienDO> GetListOfFunctionByGroupID(string GroupID)
        {
            GroupID = GroupID.ToLower();
            List<cTinhNangNhomNhanVienDO> lstFunction = new List<cTinhNangNhomNhanVienDO>();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbTINHNANGNHOMNDs where u.MANHOMND == GroupID select u;
                foreach (var row in query)
                {
                    cTinhNangNhomNhanVienDO ds = new cTinhNangNhomNhanVienDO();
                    ds.MATINHNANG = row.MATINHNANG;
                    ds.MANHOMNHANVIEN = row.MANHOMND;
                    ds.NGAYTAO = (DateTime)row.NGAYTAO;
                    lstFunction.Add(ds);
                }
                return lstFunction;
            }
        }
    }
}
