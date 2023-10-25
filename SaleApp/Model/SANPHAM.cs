using System;
using System.Collections.Generic;

namespace SaleApp.Model
{

    internal class SANPHAM
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int MaLoaiHang { get; set; }
        public float GiaBan { get; set; }
        public byte[] Anh { get; set; }
    }
}
