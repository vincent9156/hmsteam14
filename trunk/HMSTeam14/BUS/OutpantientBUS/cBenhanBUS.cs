using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;
namespace BUS
{
    public class cBenhanBUS
    {
        public static List<cBenhanDO> Getdsbenhan(string TRANGTHAIBENHAN, bool TRANGTHAI)
        {
            return DA.cBenhanDA.Getdsbenhan(TRANGTHAIBENHAN, TRANGTHAI);
        }
        public static List<cBenhanDO> Getdsbenhan1(string MABACSI, string TRANGTHAIBENHAN, bool TRANGTHAI)
        {
            return DA.cBenhanDA.Getdsbenhan1(MABACSI, TRANGTHAIBENHAN, TRANGTHAI);
        }
        public static List<cBenhanDO> Getdsbenhan2(string MABACSI,string MABENHNHAN ,string TRANGTHAIBENHAN)
        {
            return DA.cBenhanDA.Getdsbenhan2(MABACSI, MABENHNHAN, TRANGTHAIBENHAN);
        }

        public static void InsertBenhan(string MABENHAN, string STT, string MABENHNHAN, string MABACSI, string TRANGTHAIBENHAN, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cBenhanDA.InsertBenhan(MABENHAN, STT, MABENHNHAN, MABACSI, TRANGTHAIBENHAN, NGAYTAO, TRANGTHAI);
        }
        public static void UpdateTrangthaibenhnhan(string MABENHAN, string TRANGTHAIBENHAN, DateTime NGAYTAO)
        {
            DA.cBenhanDA.UpdateTrangthaibenhnhan(MABENHAN, TRANGTHAIBENHAN, NGAYTAO);
        }
        public static void UpdateTrangthaibenhan(string MABENHAN, DateTime NGAYTAO, bool TRANGTHAI)
        {
            DA.cBenhanDA.UpdateTrangthaibenhan(MABENHAN, NGAYTAO, TRANGTHAI);
        }
        public static void UpdateBacsivaobenhan(string MABENHAN, string MABACSY, DateTime NGAYTAO)
        {
            DA.cBenhanDA.UpdateBacsivaobenhan(MABENHAN, MABACSY, NGAYTAO);
        }
    }
}
