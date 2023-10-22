using System;
using System.Collections.Generic;

namespace SaleApp.Model
{

    internal class PHIEUNHAPKHO
    {
        public int SoPhieuNhapKho { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public string MaNhaCungCap { get; set; }
        public decimal TamUng { get; set; }
        public Nullable<System.DateTime> NgayThanhToan { get; set; }
        public string MaNhanVien { get; set; }
    }
}
