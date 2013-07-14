using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO
{
    public class cThuocDO
    {
        // khai bao bien su dung
        public string MATHUOC { get; set; }
        public string TENTHUONGMAI { get; set; }
        public string TENBIETDUOC { get; set; }
        public string CACHDUNG { set; get; }
        public string DONVIDUNG { set; get; }
        public string DONVI { set; get; }
        public string GHICHU { set; get; }
        public Boolean TRANGTHAI { set; get; }
        public DateTime NGAYTAO { set; get; }
    }
    public class cThuoc1DO
    {
        // khai bao bien su dung
        public string MATHUOC { get; set; }
        public string TENTHUONGMAI { get; set; }
    }
}
