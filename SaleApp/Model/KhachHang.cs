using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Model
{
    internal class KhachHang
    {
        private string makh;
        private string hoten;
        private string sdt;


        public KhachHang()
        {
        }

        public KhachHang(string makh ,string hoten, string sdt)
        {
            Makh = makh;
            Hoten = hoten;
            Sdt = sdt;
        }

        
        public string Hoten { get => hoten; set => hoten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Makh { get => makh; set => makh = value; }
    }
}
