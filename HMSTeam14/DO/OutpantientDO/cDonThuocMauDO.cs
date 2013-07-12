using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO
{
    /// <summary>
    /// khai báo biến sử dụng cho đơn thuốc mẫu
    /// </summary>
    public class cDonThuocMauDO
    {
        public string MADONTHUOCMAU{get;set;}
        public string MABACSY{get;set;}
        public DateTime NGAYTAO{get; set;}
        public Boolean TRANGTHAI{get;set;}
    }

    /// <summary>
    /// khai báo biến sử dụng cho bảng đơn thuốc mẫu chi tiết
    /// </summary>
    public class cDonThuocMauChiTietDO
    {
        public int STT{get;set;}
        public string MATHUOC{get;set;}
        public string MADONTHUOCMAU1{get;set;}
        public string MABACSI{get;set;}
        public string SOLUONG{get;set;}
        public string SOLUONGDUNG {get;set;}
        public string SOLANDUNG {get;set;}
        public string TENTHUONGMAI { get; set; }
        public string CACHDUNG { set; get; }
        public string DONVIDUNG { set; get; }
        public string DONVI { set; get; }
        public string GHICHU { set; get; }
        public Boolean TRANGTHAI1 { set; get; }
        public DateTime NGAYTAO1 { set; get; }
    }
}
