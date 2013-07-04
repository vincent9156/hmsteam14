using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BUS
{
    public class cBenhTheoPKBUS
    {
        /// <summary>
        /// Lay danh sach benh theo phong kham tu entities
        /// </summary>
        /// <returns></returns>
        public static List<cBenhTheoPKDO> Getdsbenhtheopk()
        {
           return DA.cBenhTheoPKDA.Getdsbenhtheopk();
        }
        /// <summary>
        /// Thêm bệnh theo phòng khám vào database
        /// </summary>
        /// <param name="MABENH"></param>
        /// <param name="MANHOMBENH"></param>
        /// <param name="TENBENHTA"></param>
        /// <param name="TENBENHTV"></param>
        /// <param name="MOTA"></param>
        /// <param name="NGAYTAO"></param>
        /// <param name="TRANGTHAI"></param>
        public static void InsertBentheopk(string MABENH, string MAPHONGKHAM, DateTime NGAYTAO)
        {
            DA.cBenhTheoPKDA.InsertBentheopk(MABENH, MAPHONGKHAM, NGAYTAO);
        }
        /// <summary>
        /// kiểm tra mã bệnh đó đã tồn tại hay chưa
        /// </summary>
        /// <param name="MABENH"></param>
        /// <returns></returns>
        public static bool CheckBenhtheopk(string MABENH, string MAPHONGKHAM)
        {
            return DA.cBenhTheoPKDA.CheckBenhtheopk(MABENH, MAPHONGKHAM);
        }
        /// <summary>
        /// Hàm delete 1 bệnh theo phòng khám
        /// </summary>
        /// <param name="maquocgia"></param>
        public static void DeleteBenhtheopk(string MABENH, string MAPHONGKHAM)
        {
            DA.cBenhTheoPKDA.DeleteBenhtheopk(MABENH, MAPHONGKHAM);
        }
    }
}
