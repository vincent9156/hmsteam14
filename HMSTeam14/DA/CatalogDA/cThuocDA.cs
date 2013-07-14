using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class cThuocDA
    {
        /// <summary>
        /// Lấy danh sách người dùng từ database
        /// </summary>
        /// <returns></returns>
        public static List<cThuocDO> GetListMedicine()
        {
            List<cThuocDO> dsMedicine = new List<cThuocDO>();
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = from ds in dk.tbTHUOCs
                            select ds;
                foreach (var row in query)
                {
                    cThuocDO ds = new cThuocDO();
                    ds.MATHUOC = row.MATHUOC;
                    ds.TENTHUONGMAI = row.TENTHUONGMAI;
                    ds.TENBIETDUOC = row.TENBIETDUOC;
                    ds.CACHDUNG = row.CACHDUNG;
                    ds.DONVI = row.DONVI;
                    ds.DONVIDUNG = row.DONVIDUNG;
                    ds.GHICHU = row.GHICHU;
                    ds.TRANGTHAI = row.TRANGTHAI.Value;
                    dsMedicine.Add(ds);
                }
                return dsMedicine;
            }
        }

        public static List<cThuocDO> GetListMedicine1(Boolean Trangthai)
        {
            List<cThuocDO> dsMedicine = new List<cThuocDO>();
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = from ds in dk.tbTHUOCs
                            where ds.TRANGTHAI== Trangthai
                            select ds;
                foreach (var row in query)
                {
                    cThuocDO ds = new cThuocDO();
                    ds.MATHUOC = row.MATHUOC;
                    ds.TENTHUONGMAI = row.TENTHUONGMAI;
                    ds.TENBIETDUOC = row.TENBIETDUOC;
                    ds.CACHDUNG = row.CACHDUNG;
                    ds.DONVI = row.DONVI;
                    ds.DONVIDUNG = row.DONVIDUNG;
                    ds.GHICHU = row.GHICHU;
                    ds.TRANGTHAI = row.TRANGTHAI.Value;
                    dsMedicine.Add(ds);
                }
                return dsMedicine;
            }
        }
        public static List<cThuoc1DO> GetListMedicine2(Boolean Trangthai)
        {
            List<cThuoc1DO> dsMedicine = new List<cThuoc1DO>();
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = from ds in dk.tbTHUOCs
                            where ds.TRANGTHAI == Trangthai
                            select ds;
                foreach (var row in query)
                {
                    cThuoc1DO ds = new cThuoc1DO();
                    ds.MATHUOC = row.MATHUOC;
                    ds.TENTHUONGMAI = row.TENTHUONGMAI;
                    dsMedicine.Add(ds);
                }
                return dsMedicine;
            }
        }
        /// <summary>
        /// Thêm thuốc xuống database
        /// </summary>
        /// <param name="MATHUOC"></param>
        /// <param name="TENTHUONGMAI"></param>
        /// <param name="TENBIETDUOC"></param>
        /// <param name="CACHDUNG"></param>
        /// <param name="DONVI"></param>
        /// <param name="DONVIDUNG"></param>
        /// <param name="GHICHU"></param>
        /// <param name="TRANGTHAI"></param>

        public static void InsertMedicine(string MATHUOC, string TENTHUONGMAI, string TENBIETDUOC, string CACHDUNG, string DONVI, string DONVIDUNG, string GHICHU, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                tbTHUOC med = new tbTHUOC();
                med.MATHUOC = MATHUOC;
                med.TENTHUONGMAI = TENTHUONGMAI;
                med.TENBIETDUOC = TENBIETDUOC;
                med.CACHDUNG = CACHDUNG;
                med.DONVI = DONVI;
                med.DONVIDUNG = DONVIDUNG;
                med.GHICHU = GHICHU;
                med.TRANGTHAI = TRANGTHAI;
                dk.AddTotbTHUOCs(med);
                dk.SaveChanges();
            }
        }
        /// <summary>
        /// Cập nhật thông tin thuốc
        /// </summary>
        /// <param name="MATHUOC"></param>
        /// <param name="TENTHUONGMAI"></param>
        /// <param name="TENBIETDUOC"></param>
        /// <param name="CACHDUNG"></param>
        /// <param name="DONVI"></param>
        /// <param name="DONVIDUNG"></param>
        /// <param name="GHICHU"></param>
        /// <param name="TRANGTHAI"></param>
        public static void UpdateMedicine(string MATHUOC, string TENTHUONGMAI, string TENBIETDUOC, string CACHDUNG, string DONVI, string DONVIDUNG, string GHICHU, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = (from up in dk.tbTHUOCs
                             where up.MATHUOC == MATHUOC
                             select up).First();
                query.MATHUOC = MATHUOC;
                query.TENBIETDUOC = TENBIETDUOC;
                query.TENTHUONGMAI = TENTHUONGMAI;
                query.CACHDUNG = CACHDUNG;
                query.DONVIDUNG = DONVIDUNG;
                query.DONVI = DONVI;
                query.GHICHU = GHICHU;
                query.TRANGTHAI = TRANGTHAI;
                dk.SaveChanges();
            }
        }
        /// <summary>
        /// Kiểm tra người dùng tồn tại dưới cơ sở dữ liệu
        /// </summary>
        /// <param name="MATHUOC"></param>
        /// <returns></returns>
        public static bool CheckMedicine(string MATHUOC)
        {
            Boolean test = false;
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = from ck in dk.tbTHUOCs
                            where ck.MATHUOC == MATHUOC
                            select ck;
                foreach (var row in query)
                {
                    if (row.MATHUOC == MATHUOC)
                    {
                        test = true;
                    }
                }
            }
            return test;
        }
        public static string Getmathuoc()
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                string mathuoc = null;
                var query = (from dss in ds.tbTHUOCs
                             orderby dss.MATHUOC descending
                             select dss).Skip(0).Take(1);
                foreach (var row in query)
                {
                    mathuoc = row.MATHUOC;
                }
                return mathuoc;
            }
        }

        public static string GetIDByClinicName(string Name)
        {
            Name = Name.ToLower();
            cPhongKhamDO group = new cPhongKhamDO();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbPHONGKHAMs where u.TENPHONG == Name select u;
                foreach (var row in query)
                {
                    group.MAPHONGKHAM = row.MAPHONGKHAM;
                }
            }
            return group.MAPHONGKHAM;
        }

        public static string GetNameByClinicID(string ID)
        {
            ID = ID.ToLower();
            cPhongKhamDO group = new cPhongKhamDO();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbPHONGKHAMs where u.MAPHONGKHAM == ID select u;
                foreach (var row in query)
                {
                    group.TENPHONG = row.TENPHONG;
                }
            }
            return group.TENPHONG;
        }
        public static cThuocDO Getthongtinthuoc(string MATHUOC)
        {

            cThuocDO st = new cThuocDO();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = (from u in lst.tbTHUOCs where u.MATHUOC == MATHUOC select u).First();
                st.CACHDUNG = query.CACHDUNG;
                st.DONVI = query.DONVI;
                st.DONVIDUNG = query.DONVIDUNG;
                st.GHICHU = query.GHICHU;
                return st;
            }

        }
    }
}
