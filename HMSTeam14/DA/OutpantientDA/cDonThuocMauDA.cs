using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class cDonThuocMauDA
    {
        public static List<cDonThuocMauChiTietDO> Getdsdonthuocmau(string MADONTHUOCMAU, string MABACSY)
        {
            List<cDonThuocMauChiTietDO> dsbenhan = new List<cDonThuocMauChiTietDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbDONTHUOCMAUs
                            join ads1 in ds.tbDONTHUOCMAUCHITIETs on ads.MADONTHUOCMAU equals ads1.MADONTHUOCMAU
                            join ads2 in ds.tbTHUOCs on ads1.MATHUOC equals ads2.MATHUOC
                            where ads.MADONTHUOCMAU == MADONTHUOCMAU && ads.MABACSY == MABACSY
                            select new { ads, ads1,ads2 };
                foreach (var row in query)
                {
                    cDonThuocMauChiTietDO dss = new cDonThuocMauChiTietDO();
                    dss.STT = row.ads1.STT;
                    dss.MADONTHUOCMAU1 = row.ads1.MADONTHUOCMAU;
                    dss.MATHUOC = row.ads1.MATHUOC;
                    dss.TENTHUONGMAI = row.ads2.TENTHUONGMAI;
                    dss.SOLUONG = row.ads1.SOLUONG.ToString();
                    dss.SOLANDUNG = row.ads1.SOLANDUNG.ToString();
                    dss.SOLUONGDUNG = row.ads1.SOLUONGDUNG.ToString();
                    dss.DONVI = row.ads2.DONVI;
                    dss.DONVIDUNG = row.ads2.DONVIDUNG;
                    dss.CACHDUNG = row.ads2.CACHDUNG;
                    dss.GHICHU = row.ads2.GHICHU;
                    dsbenhan.Add(dss);
                }
                return dsbenhan;
            }
          
        }

        
        public static void InsertDonthuocmau(string MADONTHUOCMAU, string MABACSI, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbDONTHUOCMAU pk = new tbDONTHUOCMAU();
                pk.MADONTHUOCMAU = MADONTHUOCMAU;
                pk.MABACSY = MABACSI;
                pk.NGAYTAO = NGAYTAO;
                pk.TRANGTHAI = TRANGTHAI;
                ds.AddTotbDONTHUOCMAUs(pk);
                ds.SaveChanges();
            }
        }
        public static void InsertDonthuocchitiet(string MADONTHUOCMAU, string MABACSI, string MATHUOC, string SOLUONG, string SOLANDUNG ,string SOLUONGDUNG, DateTime NGAYTAO)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbDONTHUOCMAUCHITIET pk = new tbDONTHUOCMAUCHITIET();
                pk.MADONTHUOCMAU = MADONTHUOCMAU;
                pk.MABACSI = MABACSI;
                pk.MATHUOC = MATHUOC;
                pk.SOLUONG = Int32.Parse(SOLUONG);
                pk.SOLANDUNG = Int32.Parse(SOLANDUNG);
                pk.SOLUONGDUNG = Int32.Parse(SOLUONGDUNG);
                pk.NGAYTAO = NGAYTAO;
                ds.AddTotbDONTHUOCMAUCHITIETs(pk);
                ds.SaveChanges();
            }
        }
        public static void UpdateDonthuocchitiet(string MADONTHUOCMAU, string MABACSI, string MATHUOC, string SOLUONG, string SOLANDUNG, string SOLUONGDUNG, DateTime NGAYTAO)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbDONTHUOCMAUCHITIET pk = new tbDONTHUOCMAUCHITIET();
                var query = (from dss in ds.tbDONTHUOCMAUCHITIETs
                             where dss.MADONTHUOCMAU ==MADONTHUOCMAU && dss.MABACSI==MABACSI && dss.MATHUOC==MATHUOC
                             select dss).First();
                //query.MABENH = MABENH;
                query.SOLUONG =  Int32.Parse(SOLUONG) ;
                query.SOLANDUNG =  Int32.Parse(SOLANDUNG);
                query.SOLUONGDUNG =  Int32.Parse(SOLUONGDUNG);
                query.NGAYTAO = NGAYTAO;
                ds.SaveChanges();
            }
        }
        public static void DeleteDonthuocchitiet(string MADONTHUOCMAU, string MABACSI,string MATHUOC)
        {
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = (from c in dk.tbDONTHUOCMAUCHITIETs
                             where c.MADONTHUOCMAU == MADONTHUOCMAU && c.MABACSI == MABACSI && c.MATHUOC==MATHUOC
                             select c).First();
                dk.DeleteObject(query);
                dk.SaveChanges();
            }
        }
        public static bool CheckDonthuocmau(string MADONTHUOCMAU, string MABACSI)
        {
            Boolean ktbenhpk = false;
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = (from dss in ds.tbDONTHUOCMAUs
                             where dss.MADONTHUOCMAU == MADONTHUOCMAU && dss.MABACSY == MABACSI
                             select dss);
                foreach (var row in query)
                {
                    if (row.MADONTHUOCMAU == MADONTHUOCMAU || row.MABACSY ==MABACSI)
                    {
                        ktbenhpk = true;
                    }
                }
            }
            return ktbenhpk;
        }
        public static bool CheckThuoctrongdonthuoc(string MADONTHUOCMAU, string MABACSI ,string MATHUOC)
        {
            Boolean ktbenhpk = false;
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = (from dss in ds.tbDONTHUOCMAUCHITIETs
                             where dss.MADONTHUOCMAU == MADONTHUOCMAU && dss.MABACSI == MABACSI && dss.MATHUOC==MATHUOC
                             select dss);
                foreach (var row in query)
                {
                    if (row.MADONTHUOCMAU == MADONTHUOCMAU || row.MABACSI == MABACSI || row.MATHUOC==MATHUOC)
                    {
                        ktbenhpk = true;
                    }
                }
            }
            return ktbenhpk;
        }
    }
}
