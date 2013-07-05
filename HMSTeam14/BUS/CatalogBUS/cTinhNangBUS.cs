using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;

namespace BUS
{
    public class cTinhNangBUS
    {
        public static List<cTinhNangDO> GetFunctionList()
        {
            return DA.cTinhNangDA.GetFunctionList();
        }
    }
}
