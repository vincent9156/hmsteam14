using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class cTinhNangDA
    {
        public static List<cTinhNangDO> GetFunctionList()
        {
            List<cTinhNangDO> list = new List<cTinhNangDO>();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = (from u in lst.tbTINHNANGs select u);
                foreach (var row in query)
                {
                    cTinhNangDO ds = new cTinhNangDO();
                    ds.MATINHNANG = row.MATINHNANG;
                    ds.TENTINHNANG = row.TENTINHNANG;
                    list.Add(ds);
                }
            }
            return list;
        }
    }
}
