using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;
namespace DA
{
    public class cKeToaDO
    {
        public static void InsertToathuoc( string MABENHAN, string MATHUOC, string SOLUONG, string SOLANDUNG, string SOLUONGDUNG,DateTime NGAYTAO)
        {
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                tbKETOATHUOC sl = new tbKETOATHUOC();
                sl.MABENHAN = MABENHAN;
                sl.SOLUONG = Int32.Parse(SOLUONG);
                sl.SOLANDUNG = Int32.Parse(SOLANDUNG);
                sl.SOLUONGDUNG = Int32.Parse(SOLUONGDUNG);
                sl.NGAYTAO = NGAYTAO;
                dk.SaveChanges();
            }
        }
        public static void UpdateToathuoc(string MABENHAN, string MATHUOC, string SOLUONG, string SOLANDUNG, string SOLUONGDUNG,DateTime NGAYTAO)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbKETOATHUOC pk = new tbKETOATHUOC();
                var query = (from dss in ds.tbKETOATHUOCs
                             where dss.MABENHAN == MABENHAN
                             select dss).First();
                //query.MABENH = MABENH;
                query.MATHUOC = MATHUOC;
                query.SOLUONG = int.Parse(SOLUONG);
                query.SOLANDUNG = int.Parse(SOLANDUNG);
                query.SOLUONGDUNG = int.Parse(SOLUONGDUNG);
                query.NGAYTAO = NGAYTAO;
                ds.SaveChanges();
            }
        }

    }
}
