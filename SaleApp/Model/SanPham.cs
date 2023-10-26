using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Model
{
    internal class SanPham
    {
        private int maSanPham;
        private string tenSanPham;
        private int maLoaiHang;
        private int giaBan;
        private byte[] anh;

        public SanPham()
        {
        }

        public SanPham(int maSanPham, string tenSanPham, int maLoaiHang, int giaBan, byte[] anh)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.MaLoaiHang = maLoaiHang;
            this.GiaBan = giaBan;
            this.Anh = anh;
        }

        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int MaLoaiHang { get => maLoaiHang; set => maLoaiHang = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public byte[] Anh { get => anh; set => anh = value; }
    }
}
