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
        public static List<cBenhanDO> Getdsbenhan(string MAPHONGKHAM ,int TRANGTHAI, int MAXACNHAN, DateTime NGAYHIENTAI)
        {
            return DA.cBenhanDA.Getdsbenhan(MAPHONGKHAM,TRANGTHAI, MAXACNHAN, NGAYHIENTAI);
        }
        public static List<cBenhanDO> Getdsbenhan1(string MAPHONGKHAM,string MABACSI, int TRANGTHAI, int MAXACNHAN,DateTime NGAYHIENTAI)
        {
            return DA.cBenhanDA.Getdsbenhan1(MAPHONGKHAM,MABACSI, TRANGTHAI, MAXACNHAN,NGAYHIENTAI);
        }
        public static List<cBenhanDO> Getdsbenhan2(string MABACSI, string MABENHNHAN, int MAXACNHAN)
        {
            return DA.cBenhanDA.Getdsbenhan2(MABACSI, MABENHNHAN, MAXACNHAN);
        }

        public static void UpdateTrangthai(string MABENHAN, int TRANGTHAI)
        {
            DA.cBenhanDA.UpdateTrangthai(MABENHAN, TRANGTHAI);
        }
        public static void UpdateMaxacnhan(string MABENHAN, int MAXACNHAN)
        {
            DA.cBenhanDA.UpdateMaxacnhan(MABENHAN, MAXACNHAN);
        }
        public static void UpdateBacsivaobenhan(string MABENHAN, string MABACSY)
        {
            DA.cBenhanDA.UpdateBacsivaobenhan(MABENHAN, MABACSY);
        }
        public static cBenhNhanDO GetThongtinbenhan(string MABENHNHAN)
        {
            return DA.cBenhanDA.GetThongtinbenhan(MABENHNHAN);
        }
    }
}
