using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class cDonThuocMauDA
    {
        public static List<cDonThuocMauChiTietDO> Getdsthuocmau()
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbDONTHUOCMAUs
                            join ads1 in ds.tbDONTHUOCMAUCHITIETs
                            on ads.MABACSY equals ads1.MABACSI
                            join ads2 in ds.tbTHUOCs
                            on ads1.MATHUOC equals ads2.MATHUOC
                            select new { ads, ads1, ads2 };
                foreach (var row in query)
                {
                    cDonThuocMauChiTietDO dss = new cDonThuocMauChiTietDO();
                    dss.MATHUOC = row.ads1.MATHUOC;
                    dss.TENTHUONGMAI = row.ads2.TENTHUONGMAI;
                    dss.SOLUONG = row.ads1.SOLUONG;
                    dss.DONVI = row.ads2.DONVI;
                    dss.CACHDUNG = row.ads2.CACHDUNG;
                    dss.DONVIDUNG = row.ads2.DONVIDUNG;
                    dss.GHICHU = row.ads2.GHICHU;
                }
            }
        }
    }
}
