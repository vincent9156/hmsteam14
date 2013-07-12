using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace BUS
{
    public class cSinhLieuBUS
    {
        /// <summary>
        /// gửi yêu cầu nhập thông tin sinh liệu và lưu xuống database
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
        public static void InsertInfomation(string MASINHLIEU, string MABENHAN, string MAYTA, string MACH, string NHIPTHO, string NHIETDO, string HUYETAP, string CHIEUCAO, string CANNANG, string VONGBUNG, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cSinhLieuDA.InsertInformation(MASINHLIEU, MABENHAN, MAYTA, MACH, NHIPTHO, NHIETDO, HUYETAP, CHIEUCAO, CANNANG, VONGBUNG, NGAYTAO, TRANGTHAI);
        }
        /// <summary>
        /// Hàm gửi yêu cầu lấy mã sinh liệu
        /// </summary>
        /// <returns></returns>
        public static string Getmasl()
        {
            return DA.cSinhLieuDA.Getmasl();
        }
        /// <summary>
        /// Hàm gửi yêu cầu lấy mã bệnh án
        /// </summary>
        /// <returns></returns>
        public static string Getmabenhan()
        {
            return DA.cSinhLieuDA.Getmabenhan();
        }
        /// <summary>
        /// Hàm gửi yêu cầu lấy mã y tá
        /// </summary>
        /// <returns></returns>
        public static string Getmayta()
        {
            return DA.cSinhLieuDA.Getmayta();
        }
    }
}
