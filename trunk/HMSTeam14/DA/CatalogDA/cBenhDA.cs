using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class cBenhDA
    {
        #region Xử lý nghiệp vụ bệnh
        /// <summary>
        /// Lay danh sach benh tu entities
        /// </summary>
        /// <returns></returns>
        public static List<cBenhPKDO> Getdsbenh()
        {
            List<cBenhPKDO> dsbenh = new List<cBenhPKDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbBENHs
                            select ads;
                foreach (var row in query)
                {
                    cBenhPKDO dss = new cBenhPKDO();
                    dss.MABENH = row.MABENH;
                    dss.MANHOMBENH1 = row.MANHOMBENH;
                    dss.MOTA1 = row.MOTA;
                    dss.TENBENHTA = row.TENBENHTA;
                    dss.TENBENHTV = row.TENBENHTV;
                    dss.NGAYTAO1 = row.NGAYTAO.Value;
                    dss.TRANGTHAI1 = row.TRANGTHAI;
                    dsbenh.Add(dss);
                }
                return dsbenh;
            }
        }
        public static List<cBenhPKDO> Getdsbenh1(bool test)
        {
            List<cBenhPKDO> dsbenh = new List<cBenhPKDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbBENHs
                            where ads.TRANGTHAI == test
                            select ads;
                foreach (var row in query)
                {
                    cBenhPKDO dss = new cBenhPKDO();
                    dss.MABENH = row.MABENH;
                    dss.MANHOMBENH1 = row.MANHOMBENH;
                    dss.MOTA1 = row.MOTA;
                    dss.TENBENHTA = row.TENBENHTA;
                    dss.TENBENHTV = row.TENBENHTV;
                    dss.NGAYTAO1 = row.NGAYTAO.Value;
                    dss.TRANGTHAI1 = row.TRANGTHAI;
                    dsbenh.Add(dss);
                }
                return dsbenh;
            }
        }
        /// <summary>
        /// Thêm bệnh vào database
        /// </summary>
        /// <param name="MABENH"></param>
        /// <param name="MANHOMBENH"></param>
        /// <param name="TENBENHTA"></param>
        /// <param name="TENBENHTV"></param>
        /// <param name="MOTA"></param>
        /// <param name="NGAYTAO"></param>
        /// <param name="TRANGTHAI"></param>
        public static void InsertBenh(string MABENH, string MANHOMBENH1, string TENBENHTA, string TENBENHTV, string MOTA1, DateTime NGAYTAO1, Boolean TRANGTHAI1)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbBENH pk = new tbBENH();
                pk.MABENH = MABENH;
                pk.MANHOMBENH = MANHOMBENH1;
                pk.TENBENHTA = TENBENHTA;
                pk.TENBENHTV = TENBENHTV;
                pk.MOTA = MOTA1;
                pk.NGAYTAO = NGAYTAO1;
                pk.TRANGTHAI = TRANGTHAI1;
                ds.AddTotbBENHs(pk);
                ds.SaveChanges();
            }
        }
        /// <summary>
        /// Cập nhật bệnh vào database
        /// </summary>
        /// <param name="MABENH"></param>
        /// <param name="MANHOMBENH"></param>
        /// <param name="TENBENHTA"></param>
        /// <param name="TENBENHTV"></param>
        /// <param name="MOTA"></param>
        /// <param name="NGAYTAO"></param>
        /// <param name="TRANGTHAI"></param>
        public static void UpdateBenh(string MABENH, string TENBENHTA, string TENBENHTV, string MOTA, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbBENH pk = new tbBENH();
                var query = (from dss in ds.tbBENHs
                             where dss.MABENH == MABENH
                             select dss).First();
                //query.MABENH = MABENH;
                query.TENBENHTA = TENBENHTA;
                query.TENBENHTV = TENBENHTV;
                query.MOTA = MOTA;
                query.NGAYTAO = NGAYTAO;
                query.TRANGTHAI = TRANGTHAI;
                ds.SaveChanges();
            }
        }
        /// <summary>
        /// kiểm tra mã bệnh đó đã tồn tại hay chưa
        /// </summary>
        /// <param name="MABENH"></param>
        /// <returns></returns>
        public static bool CheckBenh(string MABENH)
        {
            Boolean ktbenh = false;
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = (from dss in ds.tbBENHs
                             where dss.MABENH == MABENH.Trim()
                             select dss);
                foreach (var row in query)
                {
                    if (row.MABENH == MABENH)
                    {
                        ktbenh = true;
                    }
                }
            }
            return ktbenh;
        }

        /// <summary>
        /// Lay mã bệnh ở vị trí cuối cùng từ database
        /// </summary>
        /// <returns></returns>
        public static string GetMabenh(string MANHOMBENH)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                string mabenh= null;
                var query = (from dss in ds.tbBENHs
                             where dss.MANHOMBENH ==MANHOMBENH
                             orderby dss.MABENH descending
                             select dss).Skip(0).Take(1);
                foreach (var row in query)
                {
                    mabenh = row.MABENH;
                }
                return mabenh;
            }
        }
        #endregion
        #region Xử lý nghiệp vụ nhóm bệnh
        /// <summary>
        /// Lay danh sach nhom benh tu entities
        /// </summary>
        /// <returns></returns>
        public static List<cNhomBenhDO> GetdsNhombenh()
        {
            List<cNhomBenhDO> dsNhombenh = new List<cNhomBenhDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbNHOMBENHs
                            select ads;
                foreach (var row in query)
                {
                    cNhomBenhDO dss = new cNhomBenhDO();
                    dss.MANHOMBENH = row.MANHOMBENH;
                    dss.TENNHOMBENH = row.TENNHOMBENH;
                    dss.MOTA = row.MOTA;
                    dss.NGAYTAO = row.NGAYTAO.Value;
                    dss.TRANGTHAI = row.TRANGTHAI.Value;
                    dsNhombenh.Add(dss);
                }
                return dsNhombenh;
            }
        }
        /// <summary>
        /// Thêm nhóm bệnh vào database
        /// </summary>
        /// <param name="MABENH"></param>
        /// <param name="MANHOMBENH"></param>
        /// <param name="TENBENHTA"></param>
        /// <param name="TENBENHTV"></param>
        /// <param name="MOTA"></param>
        /// <param name="NGAYTAO"></param>
        /// <param name="TRANGTHAI"></param>
        public static void InsertNhombenh( string MANHOMBENH, string TENNHOMBENH, string MOTA, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbNHOMBENH pk = new tbNHOMBENH();
                pk.MANHOMBENH = MANHOMBENH;
                pk.TENNHOMBENH = TENNHOMBENH;
                pk.MOTA = MOTA;
                pk.NGAYTAO = NGAYTAO;
                pk.TRANGTHAI = TRANGTHAI;
                ds.AddTotbNHOMBENHs(pk);
                ds.SaveChanges();
            }
        }
        /// <summary>
        /// Cập nhật nhóm bệnh xuống database
        /// </summary>
        /// <param name="MANHOMBENH"></param>
        /// <param name="TENNHOMBENH"></param>
        /// <param name="MOTA"></param>
        /// <param name="NGAYTAO"></param>
        /// <param name="TRANGTHAI"></param>
        public static void UpdateNhombenh(string MANHOMBENH, string TENNHOMBENH, string MOTA, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbNHOMBENH pk = new tbNHOMBENH();
                var query = (from dss in ds.tbNHOMBENHs
                             where dss.MANHOMBENH == MANHOMBENH
                             select dss).First();
                query.TENNHOMBENH = TENNHOMBENH;
                query.MOTA = MOTA;
                query.NGAYTAO = NGAYTAO;
                query.TRANGTHAI = TRANGTHAI;
                ds.SaveChanges();
            }
        }

        /// <summary>
        /// kiểm tra mã nhóm bệnh đó đã tồn tại hay chưa
        /// </summary>
        /// <param name="MABENH"></param>
        /// <returns></returns>
        public static bool CheckNhombenh(string MANHOMBENH)
        {
            Boolean ktnhombenh = false;
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = (from dss in ds.tbNHOMBENHs
                             where dss.MANHOMBENH == MANHOMBENH.Trim()
                             select dss);
                foreach (var row in query)
                {
                    if (row.MANHOMBENH == MANHOMBENH)
                    {
                        ktnhombenh= true;
                    }
                }
            }
            return ktnhombenh;
        }
        #endregion
    }
}
