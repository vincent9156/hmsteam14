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
        public static List<cBenhanDO> Getdsbenhan(string TRANGTHAIBENHAN,bool TRANGTHAI)
        {
            List<cBenhanDO> dsbenhan = new List<cBenhanDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbBENHANs
                            join ads1 in ds.tbBENHNHANs on ads.MABENHNHAN equals ads1.MABENHNHAN
                            where ads.TRANGTHAIBENHNHAN == TRANGTHAIBENHAN && ads.TRANGTHAI ==TRANGTHAI
                            select new { ads, ads1};
                foreach (var row in query)
                {
                    cBenhanDO dss = new cBenhanDO();
                    dss.MABENHAN = row.ads.MABENHAN;
                    dss.MABENHNHAN = row.ads.MABENHNHAN;
                    dss.MABACSY = row.ads.MABACSY;
                    dss.STT = row.ads1.STT;
                    dss.HOTEN = row.ads1.HO + "" + row.ads1.TEN;
                    dss.DIACHI = row.ads1.DUONG + " " + row.ads1.QUAN + " " + row.ads1.TINH;
                    dss.TUOI = row.ads1.TUOI;
                    dss.GIOITINH = row.ads1.GIOITINH;
                    dss.TRANGTHAI = row.ads.TRANGTHAI.Value;
                    dss.TRANGTHAIBENHNHAN = row.ads.TRANGTHAIBENHNHAN;
                    dss.NGAYTAO = row.ads.NGAYTAO.Value;
                    dsbenhan.Add(dss);
                }
                return dsbenhan;
            }
        }
        public static List<cBenhanDO> Getdsbenhan1(string MABACSI, string TRANGTHAIBENHAN, bool TRANGTHAI)
        {
            List<cBenhanDO> dsbenhan1 = new List<cBenhanDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbBENHANs
                            join ads1 in ds.tbBENHNHANs on ads.MABENHNHAN equals ads1.MABENHNHAN
                            where ads.TRANGTHAIBENHNHAN == TRANGTHAIBENHAN && ads.TRANGTHAI == TRANGTHAI && ads.MABACSY == MABACSI
                            select new { ads, ads1 };
                foreach (var row in query)
                {
                    cBenhanDO dss = new cBenhanDO();
                    dss.MABENHAN = row.ads.MABENHAN;
                    dss.MABENHNHAN = row.ads.MABENHNHAN;
                    dss.MABACSY = row.ads.MABACSY;
                    dss.STT = row.ads1.STT;
                    dss.HOTEN = row.ads1.HO + "  " + row.ads1.TEN;
                    dss.DIACHI = row.ads1.DUONG + "/" + row.ads1.QUAN + "/" + row.ads1.TINH;
                    dss.TUOI = row.ads1.TUOI;
                    dss.GIOITINH = row.ads1.GIOITINH;
                    dss.TRANGTHAI = row.ads.TRANGTHAI.Value;
                    dss.TRANGTHAIBENHNHAN = row.ads.TRANGTHAIBENHNHAN;
                    dss.NGAYTAO = row.ads.NGAYTAO.Value;
                    dsbenhan1.Add(dss);
                }
                return dsbenhan1;
            }
        }
        public static List<cBenhanDO> Getdsbenhan2(string MABACSI, string MABENHNHAN, string TRANGTHAIBENHAN)
        {
            List<cBenhanDO> dsbenhan1 = new List<cBenhanDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbBENHANs
                            join ads1 in ds.tbBENHNHANs on ads.MABENHNHAN equals ads1.MABENHNHAN
                            where ads.MABACSY==MABACSI && ads.MABENHNHAN ==MABENHNHAN && ads.TRANGTHAIBENHNHAN == TRANGTHAIBENHAN
                            select new { ads, ads1 };
                foreach (var row in query)
                {
                    cBenhanDO dss = new cBenhanDO();
                    dss.MABENHAN = row.ads.MABENHAN;
                    dss.MABENHNHAN = row.ads.MABENHNHAN;
                    dss.MABACSY = row.ads.MABACSY;
                    dss.STT = row.ads1.STT;
                    dss.HOTEN = row.ads1.HO + "  " + row.ads1.TEN;
                    dss.DIACHI = row.ads1.DUONG + "/" + row.ads1.QUAN + "/" + row.ads1.TINH;
                    dss.TUOI = row.ads1.TUOI;
                    dss.GIOITINH = row.ads1.GIOITINH;
                    dss.TRANGTHAI = row.ads.TRANGTHAI.Value;
                    dss.TRANGTHAIBENHNHAN = row.ads.TRANGTHAIBENHNHAN;
                    dss.NGAYTAO = row.ads.NGAYTAO.Value;
                    dsbenhan1.Add(dss);
                }
                return dsbenhan1;
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
        public static void InsertBenhan(string MABENHAN, string STT,string MABENHNHAN, string MABACSI, string TRANGTHAIBENHAN,  DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbBENHAN pk = new tbBENHAN();
                pk.MABENHAN = MABENHAN;
                pk.MABACSY = MABACSI;
                pk.MABENHNHAN = MABENHNHAN;
                pk.STT = STT;
                pk.NGAYTAO = NGAYTAO;
                pk.TRANGTHAI = TRANGTHAI;
                ds.AddTotbBENHANs(pk);
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
        public static void UpdateTrangthaibenhnhan(string MABENHAN, string TRANGTHAIBENHAN, DateTime NGAYTAO)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbBENHAN pk = new tbBENHAN();
                var query = (from dss in ds.tbBENHANs
                             where dss.MABENHAN ==MABENHAN
                             select dss).First();
                //query.MABENH = MABENH;
                query.MABENHAN = MABENHAN;
                query.TRANGTHAIBENHNHAN = TRANGTHAIBENHAN;
                query.NGAYTAO = NGAYTAO;
                ds.SaveChanges();
            }
        }
        public static void UpdateTrangthaibenhan(string MABENHAN,  DateTime NGAYTAO,bool TRANGTHAI)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbBENHAN pk = new tbBENHAN();
                var query = (from dss in ds.tbBENHANs
                             where dss.MABENHAN == MABENHAN
                             select dss).First();
                //query.MABENH = MABENH;
                query.MABENHAN = MABENHAN;
                query.TRANGTHAI = TRANGTHAI;
                query.NGAYTAO = NGAYTAO;
                ds.SaveChanges();
            }
        }
        public static void UpdateBacsivaobenhan(string MABENHAN, string MABACSY,DateTime NGAYTAO)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbBENHAN pk = new tbBENHAN();
                var query = (from dss in ds.tbBENHANs
                             where dss.MABENHAN == MABENHAN
                             select dss).First();
                //query.MABENH = MABENH;
                query.MABENHAN = MABENHAN;
                query.MABACSY = MABACSY;
                query.NGAYTAO = NGAYTAO;
                ds.SaveChanges();
            }
        }
    }
}
