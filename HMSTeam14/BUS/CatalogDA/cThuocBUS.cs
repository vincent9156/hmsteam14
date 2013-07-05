using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;

namespace BUS
{
    public class cThuocBUS
    {
        /// <summary>
        /// gửi yêu cầu lấy danh sách thuốc từ GUI
        /// /// </summary>
        /// <returns></returns>
        public static List<cThuocDO> GetMedicine()
        {
            return DA.cThuocDA.GetListMedicine();
        }
        /// <summary>
        /// Gửi yêu cầu thêm thuốc xuống database
        /// </summary>
        /// <param name="MATHUOC"></param>
        /// <param name="TENTHUONGMAI"></param>
        /// <param name="TENBIETDUOC"></param>
        /// <param name="CACHDUNG"></param>
        /// <param name="DONVI"></param>
        /// <param name="DONVIDUNG"></param>
        /// <param name="GHICHU"></param>
        /// <param name="TRANGTHAI"></param>
        public static void InsertMedicine(string MATHUOC, string TENTHUONGMAI, string TENBIETDUOC, string CACHDUNG, string DONVI, string DONVIDUNG, string GHICHU, Boolean TRANGTHAI)
        {
            DA.cThuocDA.InsertMedicine(MATHUOC, TENTHUONGMAI, TENBIETDUOC, CACHDUNG, DONVI, DONVIDUNG, GHICHU, TRANGTHAI);
        }
        /// <summary>
        /// Gửi yêu cầu cập nhật thông tin thuốc
        /// </summary>
        /// <param name="MATHUOC"></param>
        /// <param name="TENTHUONGMAI"></param>
        /// <param name="TENBIETDUOC"></param>
        /// <param name="CACHDUNG"></param>
        /// <param name="DONVI"></param>
        /// <param name="DONVIDUNG"></param>
        /// <param name="GHICHU"></param>
        /// <param name="TRANGTHAI"></param>
        public static void UpdateMedicine(string MATHUOC, string TENTHUONGMAI, string TENBIETDUOC, string CACHDUNG, string DONVI, string DONVIDUNG, string GHICHU, Boolean TRANGTHAI)
        {
            DA.cThuocDA.UpdateMedicine(MATHUOC, TENTHUONGMAI, TENBIETDUOC, CACHDUNG, DONVI, DONVIDUNG, GHICHU, TRANGTHAI);
        }
        /// <summary>
        /// Gửi yêu cầu kiểm tra người dùng tồn tại dưới cơ sở dữ liệu
        /// </summary>
        /// <param name="MATHUOC"></param>
        /// <returns></returns>
        public static bool CheckMedicine(string MATHUOC)
        {
            return DA.cThuocDA.CheckMedicine(MATHUOC);
        }

        public static string Getmathuoc()
        {
            return DA.cThuocDA.Getmathuoc();
        }
    }
}
