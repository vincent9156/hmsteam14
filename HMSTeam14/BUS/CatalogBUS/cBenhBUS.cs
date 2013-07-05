using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BUS
{
    public class cBenhBUS
    {
        #region Xử lý nghiệp vụ bệnh trong bệnh viện

        public static List<cBenhPKDO> Getdsbenh()
        {
            return DA.cBenhDA.Getdsbenh();
        }

        public static void InsertBenh(string MABENH, string MANHOMBENH, string TENBENHTA, string TENBENHTV, string MOTA, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cBenhDA.InsertBenh(MABENH, MANHOMBENH, TENBENHTA, TENBENHTV, MOTA, NGAYTAO, TRANGTHAI);
        }

        public static void UpdateBenh(string MABENH, string TENBENHTA, string TENBENHTV, string MOTA, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cBenhDA.UpdateBenh( MABENH, TENBENHTA, TENBENHTV, MOTA,  NGAYTAO,  TRANGTHAI);
        }

        public static bool CheckBenh(string MABENH)
        {
            return DA.cBenhDA.CheckBenh(MABENH);
        }

        public static string GetMabenh(string MANHOMBENH)
        {
            return DA.cBenhDA.GetMabenh(MANHOMBENH);
        }
        #endregion
        #region Xử lý nghiệp vụ nhóm bệnh trong bệnh viện
        public static List<cNhomBenhDO> GetdsNhombenh()
        {
            return DA.cBenhDA.GetdsNhombenh();
        }

        public static void InsertNhombenh(string MANHOMBENH, string TENNHOMBENH, string MOTA, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cBenhDA.InsertNhombenh(MANHOMBENH, TENNHOMBENH, MOTA, NGAYTAO, TRANGTHAI);
        }

        public static void Updatephongkham(string MANHOMBENH, string TENNHOMBENHH, string MOTA, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cBenhDA.UpdateNhombenh(MANHOMBENH, TENNHOMBENHH, MOTA, NGAYTAO, TRANGTHAI);
        }

        public static bool CheckNhombenh(string MANHOMBENH)
        {
            return DA.cBenhDA.CheckNhombenh(MANHOMBENH);
        }
        #endregion
    }
}
