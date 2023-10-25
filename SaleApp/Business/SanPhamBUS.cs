using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SaleApp.Business
{
    internal class SanPhamBUS
    {
        private static SanPhamBUS instance;

        internal static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamBUS();
                return instance;
            }
        }
        private SanPhamBUS() { }

        public void Xem(DataGridView dgv)
        {
            dgv.DataSource = SanPhamDAO.Instance.Xem();
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã sản phẩm";
            dgv.Columns[1].HeaderText = "Tên sản phẩm";
            dgv.Columns[2].HeaderText = "Loại hàng";
            dgv.Columns[3].HeaderText = "Giá bán";
        }
        public byte[] getAnh(string masp)
        {
            byte[] image = null;
            DataTable check = SanPhamDAO.Instance.getAnh(masp);
            if (check.Rows.Count > 0)
            {
                // Kiểm tra xem có dữ liệu hình ảnh trong bảng
                DataRow row = check.Rows[0];
                if (row["Anh"] != DBNull.Value)
                {
                    // Lấy dữ liệu hình ảnh từ cơ sở dữ liệu
                    image = (byte[])row["Anh"];
                }
            }
            return image;
        }
        public string Them(SANPHAM p)
        {
            if (p.TenSanPham == "")
            {
                return "errorTen";
            }
            if (p.MaSanPham == "")
            {
                return "errorMa";
            }
            if (p.MaLoaiHang == null)
            {
                return "errorMal";
            }
            if (p.Anh == null)
            {
                return "errorAnh";
            }
            if (p.GiaBan == null)
            {
                return "errorGia";
            }
            //kiểm tra mã sp đã tồn tại chưa
            DataTable check = SanPhamDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaSanPham"].ToString() == p.MaSanPham)
                {
                    return "error1";
                }
            }
            SanPhamDAO.Instance.Them(p);
            return "";
        }
        public bool Xoa(DataGridView dgv)
        {
            //lấy dữ liệu cột đầu đang được chọn
            string code = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value + "";
            //kiem tra xem masp có tồn tại trong chi tiet phieu nhap không
            DataTable check = ChiTietPhieuNhapDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaSanPham"].ToString() == code)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này này!", "Thông báo!");
                    return false;
                    break;
                }
            }
            return SanPhamDAO.Instance.Xoa(code);
        }
        public string Sua(SANPHAM p)
        {
            SanPhamDAO.Instance.Sua(p);
            return "";
        }
        public void Tim(DataGridView dgv, string tenncc)
        {
            dgv.DataSource = SanPhamDAO.Instance.Tim(tenncc);
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã sản phẩm";
            dgv.Columns[1].HeaderText = "Tên sản phẩm";
            dgv.Columns[2].HeaderText = "Loại hàng";
            dgv.Columns[3].HeaderText = "Giá bán";
        }
    }
}
