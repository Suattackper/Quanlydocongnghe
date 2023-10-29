using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Business
{
    internal class ChiTietPhieuNhapBUS
    {
        private static ChiTietPhieuNhapBUS instance;

        internal static ChiTietPhieuNhapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuNhapBUS();
                return instance;
            }
        }
        private ChiTietPhieuNhapBUS() { }
        public void XemHangTon(DataGridView dgv)
        {
            dgv.DataSource = ChiTietPhieuNhapDAO.Instance.XemHangTon();
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã sản phẩm";
            dgv.Columns[1].HeaderText = "Tên sản phẩm";
            dgv.Columns[2].HeaderText = "Loại";
            dgv.Columns[3].HeaderText = "Số lượng tồn";
        }
        public string Them(CHITIETPHIEUNHAP p)
        {
            if (p.SoLuongNhap == null)
            {
                return "errorSo";
            }
            if (p.GiaNhap == null)
            {
                return "errorGia";
            }
            if (p.MaSanPham == null)
            {
                return "errorMa";
            }
            if (p.SoPhieuNhapKho == null)
            {
                return "errorSop";
            }
            ChiTietPhieuNhapDAO.Instance.Them(p);
            return "";
        }
    }
}
