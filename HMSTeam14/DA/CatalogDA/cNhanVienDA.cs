using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class cNhanVienDA
    {
        public static List<cNhanVienDO> GetStaffList()
        {
            List<cNhanVienDO> StaffList = new List<cNhanVienDO>();
            using(DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbNHANVIENs select u;
                foreach (var row in query)
                {
                    cNhanVienDO ds = new cNhanVienDO();
                    ds.MANHANVIEN = row.MANHANVIEN;
                    ds.MAPHONGKHAM = cPhongKhamDA.GetNameByClinicID(row.MAPHONGKHAM);
                    ds.MANHOMNHANVIEN = cNhomNhanVienDA.GetNameByGroupID(row.MANHOMND);
                    ds.TENNHANVIEN = row.HOTEN;
                    ds.GIOITINH = row.GIOITINH;
                    ds.TENTAIKHOAN = row.IDDANGNHAP;
                    ds.CHUCDANH = row.CHUCDANH;
                    ds.TINHTRANG = row.TRANGTHAI.Value;
                    ds.NGAYTAO = (DateTime)row.NGAYTAO;
                    StaffList.Add(ds);
                }
                return StaffList;
            }
        }

        public static void InsertNewStaff(string Manhanvien, string Maphongkham, string Manhomnhanvien, string Hoten, string Gioitinh, string Tendangnhap, string Matkhau, string Chucdanh, bool Tinhtrang, DateTime Ngaytao)
        {
            using (DB_HMS_Entities staff = new DB_HMS_Entities())
            {
                tbNHANVIEN infor = new tbNHANVIEN();
                infor.MANHANVIEN = Manhanvien;
                infor.MAPHONGKHAM = Maphongkham;
                infor.MANHOMND = Manhomnhanvien;
                infor.HOTEN = Hoten;
                infor.GIOITINH = Gioitinh;
                infor.CHUCDANH = Chucdanh;
                infor.IDDANGNHAP = Tendangnhap;
                infor.MATKHAU = Matkhau;
                infor.TRANGTHAI = Tinhtrang;
                infor.NGAYTAO = Ngaytao;
                staff.AddTotbNHANVIENs(infor);
                staff.SaveChanges();
            }
        }

        public static void UpdateStaffInfor(string Manhanvien, string Maphongkham, string Manhomnhanvien, string Hoten, string Gioitinh, string Chucdanh, bool Tinhtrang)
        {
            using (DB_HMS_Entities Grp = new DB_HMS_Entities())
            {
                var query = (from u in Grp.tbNHANVIENs
                             where u.MANHANVIEN == Manhanvien
                             select u).First();
                query.MAPHONGKHAM = Maphongkham;
                query.MANHOMND = Manhomnhanvien;
                query.HOTEN = Hoten;
                query.GIOITINH = Gioitinh;
                query.CHUCDANH = Chucdanh;
                query.TRANGTHAI = Tinhtrang;
                Grp.SaveChanges();
            }
        }

        public static string GetStaffID()
        {
            using (DB_HMS_Entities Staff = new DB_HMS_Entities())
            {
                string StaffID = null;
                var query = (from u in Staff.tbNHANVIENs
                             orderby u.MANHANVIEN descending
                             select u).Skip(0).Take(1);
                foreach (var row in query)
                {
                    StaffID = row.MANHANVIEN;
                }
                return StaffID;
            }
        }
        public static bool CheckUser(string username, string password)
        {
            Boolean test = false;
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = from c in dk.tbNHANVIENs
                            where c.IDDANGNHAP == username && c.MATKHAU == password
                            select c;
                foreach (var row in query)
                {
                    if (row.IDDANGNHAP == username || row.MATKHAU == password)
                    {
                        test = true;
                    }
                }
            }
            return test;
        }
        public static void UpdatePassword(string Manhanvien, string Password)
        {
            using (DB_HMS_Entities Grp = new DB_HMS_Entities())
            {
                var query = (from u in Grp.tbNHANVIENs
                             where u.MANHANVIEN == Manhanvien
                             select u).First();
                query.MATKHAU = Password;
                Grp.SaveChanges();
            }
        }
    }
}
