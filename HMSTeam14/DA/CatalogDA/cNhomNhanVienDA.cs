using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class cNhomNhanVienDA
    {
        public static List<cNhomNhanVienDO> GetStaffGroupList()
        {
            List<cNhomNhanVienDO> GroupList = new List<cNhomNhanVienDO>();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbNHOMNGUOIDUNGs select u;
                foreach (var row in query)
                {
                    cNhomNhanVienDO ds = new cNhomNhanVienDO();
                    ds.MANHOMNHANVIEN = row.MANHOMNDN;
                    ds.TENNHOMNHANVIEN = row.TENNHOMND;
                    ds.MOTA = row.MOTA;
                    ds.TRANGTHAI = row.TRANGTHAI.Value;
                    GroupList.Add(ds);
                }
                return GroupList;
            }
        }

        public static void InsertStaffGroup(string MaNhomNhanVien, string TenNhomNhanVien, string MoTa, bool TrangThai)
        {
            using (DB_HMS_Entities Group = new DB_HMS_Entities())
            {
                tbNHOMNGUOIDUNG lst = new tbNHOMNGUOIDUNG();
                lst.MANHOMNDN = MaNhomNhanVien;
                lst.TENNHOMND = TenNhomNhanVien;
                lst.MOTA = MoTa;
                lst.TRANGTHAI = TrangThai;
                Group.AddTotbNHOMNGUOIDUNGs(lst);
                Group.SaveChanges();
            }
        }

        public static void UpdateStaffGroup(string MaNhomNhanVien, string TenNhomNhanVien, string MoTa, bool TrangThai)
        {
            using (DB_HMS_Entities Group = new DB_HMS_Entities())
            {
                var query = (from u in Group.tbNHOMNGUOIDUNGs where u.MANHOMNDN == MaNhomNhanVien select u).First();
                query.TENNHOMND = TenNhomNhanVien;
                query.MOTA = MoTa;
                query.TRANGTHAI = TrangThai;
                Group.SaveChanges();
            }
        }

        public static bool CheckExist(string TENNHOM)
        {
            bool exist = false;
            using (DB_HMS_Entities Group = new DB_HMS_Entities())
            {
                var query = (from u in Group.tbNHOMNGUOIDUNGs where u.TENNHOMND == TENNHOM select u);
                foreach (var row in query)
                {
                    if (row.TENNHOMND == TENNHOM)
                    {
                        exist = true;
                    }
                }
            }
            return exist;
        }
 
        public static string GetStaffGroupID()
        {
            using (DB_HMS_Entities Group = new DB_HMS_Entities())
            {
                string GroupID = null;
                var query = (from u in Group.tbNHOMNGUOIDUNGs
                             orderby u.MANHOMNDN descending
                             select u).Skip(0).Take(1);
                foreach (var row in query)
                {
                    GroupID = row.MANHOMNDN;
                }
                return GroupID;
            }
        }

        public static string GetIDByGroupName(string Name)
        {
            Name = Name.ToLower();
            cNhomNhanVienDO group = new cNhomNhanVienDO();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbNHOMNGUOIDUNGs where u.TENNHOMND == Name select u;
                foreach (var row in query)
                {
                    group.MANHOMNHANVIEN = row.MANHOMNDN;
                }
            }
            return group.MANHOMNHANVIEN;
        }

        public static string GetNameByGroupID(string ID)
        {
            ID = ID.ToLower();
            cNhomNhanVienDO group = new cNhomNhanVienDO();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbNHOMNGUOIDUNGs where u.MANHOMNDN == ID select u;
                foreach (var row in query)
                {
                    group.TENNHOMNHANVIEN = row.TENNHOMND;
                }
            }
            return group.TENNHOMNHANVIEN;
        }
    }
}
