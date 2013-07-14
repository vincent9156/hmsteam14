using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;
namespace BUS
{
    public class cKeToaBUS
    {
        public static void InsertToathuoc(string MABENHAN, string MATHUOC, string SOLUONG, string SOLANDUNG, string SOLUONGDUNG, DateTime NGAYTAO)
        {
            DA.cKeToaDO.InsertToathuoc(MABENHAN, MATHUOC, SOLUONG, SOLANDUNG, SOLUONGDUNG, NGAYTAO);
        }
        public static void UpdateToathuoc(string MABENHAN, string MATHUOC, string SOLUONG, string SOLANDUNG, string SOLUONGDUNG, DateTime NGAYTAO)
        {
            DA.cKeToaDO.UpdateToathuoc(MABENHAN, MATHUOC, SOLUONG, SOLANDUNG, SOLUONGDUNG, NGAYTAO);
        }
    }
}
