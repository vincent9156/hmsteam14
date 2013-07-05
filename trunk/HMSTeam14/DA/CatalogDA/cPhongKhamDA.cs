using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class cPhongKhamDA
    {
        /// <summary>
        /// Lay danh sach phong kham tu entities
        /// </summary>
        /// <returns></returns>
        public static List<cPhongKhamDO> Getdsphongkham()
        {
            List<cPhongKhamDO> dsphongkham = new List<cPhongKhamDO>();
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
            	var query = from ads in ds.tbPHONGKHAMs
                            select ads;
                foreach(var row in query)
                {
                    cPhongKhamDO dss = new cPhongKhamDO();
                    dss.MAPHONGKHAM = row.MAPHONGKHAM;
                    dss.TENPHONG = row.TENPHONG;
                    dss.NGAYTAO = row.NGAYTAO.Value;
                    dss.TRANGTHAI = row.TRANGTHAI.Value;
                    dsphongkham.Add(dss);
                }
                return dsphongkham;
            }
        }

        /// <summary>
        /// Them moi phong kham vao entities
        /// </summary>
        /// <param name="MAPHONGKHAM"></param>
        /// <param name="TENPHONG"></param>
        /// <param name="NGAYTAO"></param>
        /// <param name="TRANGTHAI"></param>
        public static void Insertphongkham(string MAPHONGKHAM, string TENPHONG, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbPHONGKHAM pk = new tbPHONGKHAM();
                pk.MAPHONGKHAM = MAPHONGKHAM;
                pk.TENPHONG = TENPHONG;
                pk.NGAYTAO = NGAYTAO;
                pk.TRANGTHAI = TRANGTHAI;
                ds.AddTotbPHONGKHAMs(pk);
                ds.SaveChanges();
            }
        }

        /// <summary>
        /// cap nhat phong kham vao entities
        /// </summary>
        /// <param name="MAPHONGKHAM"></param>
        /// <param name="TENPHONG"></param>
        /// <param name="NGAYTAO"></param>
        /// <param name="TRANGTHAI"></param>
        public static void Updatephongkham(string MAPHONGKHAM, string TENPHONG, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                tbPHONGKHAM pk = new tbPHONGKHAM();
                var query = (from dss in ds.tbPHONGKHAMs
                             where dss.MAPHONGKHAM == MAPHONGKHAM
                             select dss).First();
                query.TENPHONG = TENPHONG;
                query.NGAYTAO = NGAYTAO;
                query.TRANGTHAI = TRANGTHAI;
                ds.SaveChanges();
            }
        }

        /// <summary>
        /// Kiem tra phong kham co trung hay khong
        /// </summary>
        /// <param name="TENPHONG"></param>
        /// <returns></returns>
        public static bool Checkphongkham(string TENPHONG)
        {
            Boolean ktphongkham = false;
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                var query = (from dss in ds.tbPHONGKHAMs
                             where dss.TENPHONG == TENPHONG.Trim()
                             select dss);
                foreach (var row in query)
                {
                    if (row.TENPHONG == TENPHONG)
                    {
                        ktphongkham = true;
                    }
                }
            }
            return ktphongkham;
        }

        /// <summary>
        /// Lay ma phong kham tu entities
        /// </summary>
        /// <returns></returns>
        public static string Getmaphongkham()
        {
            using (DB_HMS_Entities ds = new DB_HMS_Entities())
            {
                string maphongkham = null;
                var query = (from dss in ds.tbPHONGKHAMs
                             orderby dss.MAPHONGKHAM descending
                             select dss).Skip(0).Take(1);
                foreach (var row in query)
                {
                    maphongkham = row.MAPHONGKHAM;
                }
                return maphongkham;
            }
        }

        public static string GetIDByClinicName(string Name)
        {
            Name = Name.ToLower();
            cPhongKhamDO group = new cPhongKhamDO();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbPHONGKHAMs where u.TENPHONG == Name select u;
                foreach (var row in query)
                {
                    group.MAPHONGKHAM = row.MAPHONGKHAM;
                }
            }
            return group.MAPHONGKHAM;
        }

        public static string GetNameByClinicID(string ID)
        {
            ID = ID.ToLower();
            cPhongKhamDO group = new cPhongKhamDO();
            using (DB_HMS_Entities lst = new DB_HMS_Entities())
            {
                var query = from u in lst.tbPHONGKHAMs where u.MAPHONGKHAM == ID select u;
                foreach (var row in query)
                {
                    group.TENPHONG = row.TENPHONG;
                }
            }
            return group.TENPHONG;
        }
    }
}
