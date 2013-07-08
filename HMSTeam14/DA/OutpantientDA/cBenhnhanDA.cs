using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class cBenhnhanDA
    {
        public static List<cBenhnhanDO> Getdsbenhnhan(string NGAYHIENTAI)
        {
            List<cBenhnhanDO> dsbenhan = new List<cBenhnhanDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbBENHNHANs
                            where ads.STT.Substring(0,5) == NGAYHIENTAI
                            select ads;
                foreach (var row in query)
                {
                    cBenhnhanDO dss = new cBenhnhanDO();
                    dss.MABENHNHAN = row.MABENHNHAN;
                    dss.STT = row.STT;
                    dss.TEN = row.TEN;
                    dss.HO = row.HO;
                    dss.HOTEN = row.HO + "" + row.TEN;
                    dss.NGAYSINH = row.NGAYSINH;
                    dss.TUOI = row.TUOI;
                    dss.TRANGTHAI = row.TRANGTHAI.Value;
                    dss.NGAYTAO = row.NGAYTAO.Value;
                    dsbenhan.Add(dss);
                }
                return dsbenhan;
            }
        }
    }
}
