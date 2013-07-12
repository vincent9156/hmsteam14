using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using System.Runtime.InteropServices;

namespace DA
{
    public class cSinhLieuDA
    {
        /// <summary>
        /// Nhập vào thông tin của sinh liệu
        /// </summary>
        /// <param name="MASINHLIEU"></param>
        /// <param name="MABENHNHAN"></param>
        /// <param name="MAYTA"></param>
        /// <param name="MACH"></param>
        /// <param name="NHIPTHO"></param>
        /// <param name="NHIETDO"></param>
        /// <param name="HUYETAP"></param>
        /// <param name="CHIEUCAO"></param>
        /// <param name="CANNANG"></param>
        /// <param name="VONGBUNG"></param>
        /// <param name="NGAYTAO"></param>
        /// <param name="TRANGTHAI"></param>
        public static void InsertInformation(string MASINHLIEU, string MABENHAN, string MAYTA, string MACH, string NHIPTHO, string NHIETDO,string HUYETAP, string CHIEUCAO, string CANNANG, string VONGBUNG, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities dk= new DB_HMS_Entities())
            {
                tbSINHLIEU sl = new tbSINHLIEU();
                sl.MASINHLIEU = MASINHLIEU;
                sl.MABENHAN = MABENHAN;
                sl.MAYTA = MAYTA;
                sl.MACH = MACH;
                sl.NHIPTHO = NHIPTHO;
                sl.NHIETDO = NHIETDO;
                sl.HUYETAP = HUYETAP;
                sl.CHIEUCAO = CHIEUCAO;
                sl.CANNANG = CANNANG;
                sl.VONGBUNG = VONGBUNG;
                sl.NGAYTAO = NGAYTAO;
                sl.TRANGTHAI = TRANGTHAI;
                dk.AddTotbSINHLIEUx(sl);
                dk.SaveChanges();
            }
        }
        /// <summary>
        /// get mã sinh liệu
        /// </summary>
        /// <returns></returns>
        public static string Getmasl()
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                string masl = null;
                var query = (from dss in ds.tbSINHLIEUx
                             orderby dss.MASINHLIEU descending
                             select dss).Skip(0).Take(1);
                foreach (var row in query)
                {
                    masl = row.MASINHLIEU;
                }
                return masl;
            }
        }
        /// <summary>
        /// get mã bệnh án
        /// </summary>
        /// <returns></returns>
        public static string Getmabenhan()
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                string mabenhan = null;
                var query = (from dss in ds.tbSINHLIEUx
                             orderby dss.MABENHAN descending
                             select dss).Skip(0).Take(1);
                foreach (var row in query)
                {
                    mabenhan = row.MABENHAN;
                }
                return mabenhan;
            }
        }
        /// <summary>
        /// hàm xử lý lấy mã y tá
        /// </summary>
        /// <returns></returns>
        public static string Getmayta()
        {
            return cCommon.CurrentUser.ToString();
        }
    }
}
