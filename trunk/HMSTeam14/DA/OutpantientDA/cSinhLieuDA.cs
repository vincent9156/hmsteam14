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
        /// lấy thông tin bệnh nhân
        /// </summary>
        /// <returns></returns>
        public static List<cBenhnhanDO> GetBenhNhan()
        {
            List<cBenhnhanDO> dsbenhnhan = new List<cBenhnhanDO>();
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = from ds in dk.tbBENHNHANs
                            select ds;
                foreach (var row in query)
                {
                    cBenhnhanDO ds = new cBenhnhanDO();
                    ds.STT = row.STT;
                    ds.MABENHNHAN = row.MABENHNHAN;
                    ds.HOTEN = row.HO + " " + row.TEN;
                    ds.DIACHI = row.DUONG + " " + row.QUAN + " " + row.TINH;
                    ds.GIOITINH = row.GIOITINH;
                    ds.NGAYSINH = row.NGAYSINH.Value;
                    ds.TUOI = row.TUOI;
                    dsbenhnhan.Add(ds);
                }
                return dsbenhnhan;                             
            }
        }

        public static cBenhnhanDO GetBenhNhan1(string PatientID)
        {
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = (from d in dk.tbBENHNHANs
                            where d.MABENHNHAN == PatientID
                            select d).First();
                    cBenhnhanDO ds = new cBenhnhanDO();
                    ds.MABENHNHAN = query.MABENHNHAN;
                    ds.DIACHI = query.DUONG + ", " + query.QUAN + ", " + query.TINH;
                    ds.HOTEN = query.HO + " " + query.TEN;
                    ds.GIOITINH = query.GIOITINH;
                    ds.NGAYSINH = query.NGAYSINH.Value;
                    ds.TUOI = query.TUOI;
                return ds;
            }
        }
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
                sl.CANBANG = CANNANG;
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
