using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class cBenhTheoPKDA
    {
        #region Xử lý nghiệp vụ bệnh
        /// <summary>
        /// Lay danh sach benh theo phong kham tu entities
        /// </summary>
        /// <returns></returns>
        public static List<cBenhTheoPKDO> Getdsbenhtheopk()
        {
            List<cBenhTheoPKDO> dsbenhtheopk = new List<cBenhTheoPKDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = from ads in ds.tbBENHPHONGKHAMs
                            select ads;
                foreach (var row in query)
                {
                    cBenhTheoPKDO dss = new cBenhTheoPKDO();
                    dss.MABENH = row.MABENH;
                    dss.MAPHONGKHAM = row.MAPHONGKHAM;
                    dss.NGAYTAO = row.NGAYTAO.Value;
                    dsbenhtheopk.Add(dss);
                }
                return dsbenhtheopk;
            }
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
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbBENHPHONGKHAM pk = new tbBENHPHONGKHAM();
                pk.MABENH = MABENH;
                pk.MAPHONGKHAM = MAPHONGKHAM;
                pk.NGAYTAO = NGAYTAO;
                ds.AddTotbBENHPHONGKHAMs(pk);
                ds.SaveChanges();
            }
        }
        /// <summary>
        /// kiểm tra mã bệnh đó đã tồn tại hay chưa
        /// </summary>
        /// <param name="MABENH"></param>
        /// <returns></returns>
        public static bool CheckBenhtheopk(string MABENH, string MAPHONGKHAM)
        {
            Boolean ktbenhpk = false;
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = (from dss in ds.tbBENHPHONGKHAMs
                             where dss.MABENH == MABENH.Trim()&& dss.MAPHONGKHAM==MAPHONGKHAM.Trim()
                             select dss);
                foreach (var row in query)
                {
                    if (row.MABENH == MABENH || row.MAPHONGKHAM== MAPHONGKHAM)
                    {
                        ktbenhpk = true;
                    }
                }
            }
            return ktbenhpk;
        }
        /// <summary>
        /// Hàm delete 1 quốc gia ở database
        /// </summary>
        /// <param name="maquocgia"></param>
        public static void DeleteBenhtheopk(string MABENH ,string MAPHONGKHAM)
        {
            using (DB_HMS_Entities dk = new DB_HMS_Entities())
            {
                var query = (from c in dk.tbBENHPHONGKHAMs
                             where c.MABENH == MABENH && c.MAPHONGKHAM== MAPHONGKHAM
                             select c).First();

                dk.DeleteObject(query);
                dk.SaveChanges();
            }
        }
        #endregion
    }
}
