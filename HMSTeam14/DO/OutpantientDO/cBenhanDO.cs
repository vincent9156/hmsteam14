using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO
{
    public class cBenhanDO
    {
        public string MABENHAN { set; get; }
        public string MABENHNHAN { set; get; }
        public string MABACSY { set; get; }
        public string HOTEN {set;get;}
        public string TUOI { set; get; }
        public string GIOITINH { set; get; }
        public DateTime NGAYDK { set; get; }
        public string GIODK { set; get; }
        public int MAXACNHAN { set; get; }
        public int TRANGTHAI { set; get; }
        public string MAPHONGKHAM {set;get;}
    }
    public class cBenhNhanDO
    {
        public string MABENHNHAN { set; get; }
        public string HOTEN { set; get; }
        public DateTime? NTNSBN { set; get; }
        public int NSBN {get;set;}
        public string GIOITINH { set; get; }
        public string DIACHI { set; get; }
        public string TINH {get;set;}
    }
}
