using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp
{
    internal class HinhAnh
    {
        private string tenhinhanh;
        private byte[] anh;

        public HinhAnh()
        {
        }

        public HinhAnh(string tenhinhanh, byte[] anh)
        {
            this.tenhinhanh = tenhinhanh;
            this.Anh = anh;
        }

      
        public string Tenhinhanh { get => this.tenhinhanh; set => this.tenhinhanh = value; }
        public byte[] Anh { get => anh; set => anh = value; }
    }
}
