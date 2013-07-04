using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO
{

    public class cNhomBenhDO
    {
        /// <summary>
        /// Khai bao bien su dung cho bang nhom benh
        /// </summary>
        public string MANHOMBENH { get; set; }
        public string TENNHOMBENH { get; set; }
        public string MOTA { get; set; }
        public DateTime NGAYTAO { get; set; }
        public Boolean TRANGTHAI { get; set; }
    }
    public class cBenhPKDO
    {
        /// <summary>
        /// Khai bao bien su dung cho bang benh
        /// </summary>
        public string MABENH { get; set; }
        public string MANHOMBENH1 { get; set; }
        public string TENBENHTA { get; set; }
        public string TENBENHTV { get; set; }
        public string MOTA1 { get; set; }
        public DateTime NGAYTAO1 { get; set; }
        public bool TRANGTHAI1 { get; set; }
    }
}
