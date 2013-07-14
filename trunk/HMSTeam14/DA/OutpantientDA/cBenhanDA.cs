using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;
namespace DA
{
    public class cBenhanDA
    {
        public static List<cBenhanDO> Getdsbenhan(string MAPHONGKHAM ,int TRANGTHAI, int MAXACNHAN,DateTime NGAYHIENTAI)
        {
            List<cBenhanDO> dsbenhan = new List<cBenhanDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbHOSOKHAMBENHs
                            join ads1 in ds.tbBENHNHANs on ads.MABENHNHAN equals ads1.MABENHNHAN
                            where ads.MAPHONGKHAM==MAPHONGKHAM && ads.TRANGTHAI == TRANGTHAI && ads.MAXACNHAN == MAXACNHAN && ads.NGAYDK== NGAYHIENTAI
                            select new { ads, ads1};
                foreach (var row in query)
                {
                    cBenhanDO dss = new cBenhanDO();
                    dss.MABENHAN = row.ads.MAKHAMBENH;
                    dss.MABENHNHAN = row.ads.MABENHNHAN;
                    dss.MABACSY = row.ads.MABACSY;
                    dss.HOTEN = row.ads1.HO + " " + row.ads1.TEN;
                    dss.TUOI = row.ads.TUOI.ToString();
                    dss.GIOITINH = row.ads.GIOITINH;
                    dss.NGAYDK = row.ads.NGAYDK.Value;
                    dss.GIODK = row.ads.GIODK.Value.ToString().Substring(9);
                    dsbenhan.Add(dss);
                }
                return dsbenhan;
            }
        }
        public static List<cBenhanDO> Getdsbenhan1(string MAPHONGKHAM ,string MABACSI, int TRANGTHAI, int MAXACNHAN , DateTime NGAYHIENTAI)
        {
            List<cBenhanDO> dsbenhan = new List<cBenhanDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbHOSOKHAMBENHs
                            join ads1 in ds.tbBENHNHANs on ads.MABENHNHAN equals ads1.MABENHNHAN
                            where  ads.TRANGTHAI == TRANGTHAI && ads.MAXACNHAN == MAXACNHAN && ads.MABACSY==MABACSI && ads.NGAYDK== NGAYHIENTAI && ads.MAPHONGKHAM ==MAPHONGKHAM
                            select new { ads, ads1 };
                foreach (var row in query)
                {
                    cBenhanDO dss = new cBenhanDO();
                    dss.MABENHAN = row.ads.MAKHAMBENH;
                    dss.MABENHNHAN = row.ads.MABENHNHAN;
                    dss.MABACSY = row.ads.MABACSY;
                    dss.HOTEN = row.ads1.HO + " " + row.ads1.TEN;
                    dss.TUOI = row.ads.TUOI.ToString();
                    dss.GIOITINH = row.ads.GIOITINH;
                    dss.NGAYDK = row.ads.NGAYDK.Value;
                    dss.GIODK = row.ads.GIODK.Value.ToString().Substring(9);
                    dsbenhan.Add(dss);
                }
                return dsbenhan;
            }
        }
        public static List<cBenhanDO> Getdsbenhan2(string MABACSI, string MABENHNHAN, int MAXACNHAN)
        {
            List<cBenhanDO> dsbenhan = new List<cBenhanDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbHOSOKHAMBENHs
                            join ads1 in ds.tbBENHNHANs on ads.MABENHNHAN equals ads1.MABENHNHAN
                            where ads.MAKHAMBENH == MABENHNHAN && ads.MAXACNHAN == MAXACNHAN && ads.MABACSY == MABACSI
                            select new { ads, ads1 };
                foreach (var row in query)
                {
                    cBenhanDO dss = new cBenhanDO();
                    dss.MABENHAN = row.ads.MAKHAMBENH;
                    dss.MABENHNHAN = row.ads.MABENHNHAN;
                    dss.MABACSY = row.ads.MABACSY;
                    dss.HOTEN = row.ads1.HO + " " + row.ads1.TEN;
                    dss.TUOI = row.ads.TUOI.ToString();
                    dss.GIOITINH = row.ads.GIOITINH;
                    dss.NGAYDK = row.ads.NGAYDK.Value;
                    dss.GIODK = row.ads.GIODK.Value.ToString().Substring(9);
                    dsbenhan.Add(dss);
                }
                return dsbenhan;
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
        public static void UpdateTrangthai(string MABENHAN, int TRANGTHAI )
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbHOSOKHAMBENH pk = new tbHOSOKHAMBENH();
                var query = (from dss in ds.tbHOSOKHAMBENHs
                             where dss.MAKHAMBENH ==MABENHAN
                             select dss).First();
                query.TRANGTHAI = TRANGTHAI;
                ds.SaveChanges();
            }
        }
        public static void UpdateMaxacnhan(string MABENHAN, int MAXACNHAN)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbHOSOKHAMBENH pk = new tbHOSOKHAMBENH();
                var query = (from dss in ds.tbHOSOKHAMBENHs
                             where dss.MAKHAMBENH == MABENHAN
                             select dss).First();
                query.MAXACNHAN = MAXACNHAN;
                ds.SaveChanges();
            }
        }
        public static void UpdateBacsivaobenhan(string MABENHAN, string MABACSY)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbHOSOKHAMBENH pk = new tbHOSOKHAMBENH();
                var query = (from dss in ds.tbHOSOKHAMBENHs
                             where dss.MAKHAMBENH == MABENHAN
                             select dss).First();
                query.MABACSY = MABACSY;
                ds.SaveChanges();
            }
        }
        public static cBenhNhanDO GetThongtinbenhan(string MABENHNHAN)
        {
            cBenhNhanDO ma = new cBenhNhanDO();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = (from u in lst.tbBENHNHANs
                             join u2 in lst.tbQUANHUYENs on u.IDQH equals u2.IDQH
                             join u3 in lst.tbTINHTPs on u2.IDTP equals u3.IDTP
                             where u.MABENHNHAN == MABENHNHAN
                             select new { u,u2,u3}).First();
                ma.MABENHNHAN = query.u.MABENHNHAN;
                ma.HOTEN = query.u.HO+" "+query.u.TEN;
                ma.DIACHI = query.u.DIACHI + " , " + query.u2.TENQH + " , " + query.u3.TENTP;
                ma.GIOITINH = query.u.GIOITINH;
                ma.NTNSBN = query.u.NTNSBN;
                return ma;
            }

        }
    }
}
