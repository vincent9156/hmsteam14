using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BUS
{
    public class cBenhnhanBUS
    {

        /// <summary>
        /// Lấy lên ds bệnh nhân khi truyền vào ngày hiện tại 
        /// </summary>
        /// <param name="NGAYHIENTAI"></param>
        /// <returns></returns>
        public static List<cBenhnhanDO> Getdsbenhnhan(string NGAYHIENTAI)
        {
            return DA.cBenhnhanDA.Getdsbenhnhan(NGAYHIENTAI);
        }
    }
}
