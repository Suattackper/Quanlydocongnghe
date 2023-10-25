using DocumentFormat.OpenXml.Vml;
using SaleApp.Business;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace SaleApp.View
{
    public partial class frmNhapSP : Form
    {
        public frmNhapSP()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txtMaSP.Text = "";
            txtGiaBan.Text = "";
            txtTenSP.Text = "";
            pbHinhAnh.Image = null;
            cbLoaiSP.SelectedIndex = 0;
            SanPhamBUS.Instance.Xem(dtgvDSSP);
        }

        private void frmNhapSP_Load(object sender, EventArgs e)
        {
            LoaiHangBUS.Instance.getDataLoaiHang(cbLoaiSP);
            SanPhamBUS.Instance.Xem(dtgvDSSP);
        }

        private void dtgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã bấm vào một ô hợp lệ hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSSP.Rows[e.RowIndex];
                // Lấy giá trị từ cột của hàng được chọn và hiển thị nó trong các TextBox
                txtMaSP.Text = selectedRow.Cells[0].Value.ToString();
                txtTenSP.Text = selectedRow.Cells[1].Value.ToString();
                cbLoaiSP.Text = selectedRow.Cells[2].Value.ToString();
                txtGiaBan.Text = selectedRow.Cells[3].Value.ToString();
                byte[] imageData = SanPhamBUS.Instance.getAnh(selectedRow.Cells[0].Value.ToString());
                if (imageData != null)
                {
                    //Chỉnh ảnh phù hợp với pbHinhAnh
                    pbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    // Đặt hình ảnh cho PictureBox
                    pbHinhAnh.Image = Image.FromStream(new MemoryStream(imageData));

                }
                else pbHinhAnh.Image = null;
            }
        }

        private void dtgvDSSP_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dtgvDSSP.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSSP.SelectedRows[0];
                // Lấy giá trị từ cột của hàng được chọn và hiển thị nó trong các TextBox
                txtMaSP.Text = selectedRow.Cells[0].Value.ToString();

                txtTenSP.Text = selectedRow.Cells[1].Value.ToString();
                cbLoaiSP.Text = selectedRow.Cells[2].Value.ToString();
                txtGiaBan.Text = selectedRow.Cells[3].Value.ToString();
                byte[] imageData = SanPhamBUS.Instance.getAnh(selectedRow.Cells[0].Value.ToString());
                if (imageData != null)
                {
                    //Chỉnh ảnh phù hợp với pbHinhAnh
                    pbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    // Đặt hình ảnh cho PictureBox
                    pbHinhAnh.Image = Image.FromStream(new MemoryStream(imageData));
                }
                else pbHinhAnh.Image = null;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SANPHAM sp = new SANPHAM();
            sp.MaSanPham = txtMaSP.Text;
            sp.TenSanPham = txtTenSP.Text;
            sp.MaLoaiHang = int.Parse(LoaiHangBUS.Instance.getMaLoaiHang(cbLoaiSP.Text));
            sp.GiaBan = float.Parse(txtGiaBan.Text);
            byte[] anh = null;
            //Chuyển ảnh thành mảng byte
            using (MemoryStream memoryStream = new MemoryStream())
            {
                if (pbHinhAnh.Image == null)
                {
                    MessageBox.Show("Ảnh không được để trống!", "Error");
                    return;
                }
                else
                {
                    pbHinhAnh.Image.Save(memoryStream, pbHinhAnh.Image.RawFormat);
                    anh = memoryStream.ToArray();
                }
            }
            sp.Anh = anh;
            string check = SanPhamBUS.Instance.Them(sp);
            switch (check)
            {
                case "errorTen":
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Error");
                    return;
                case "errorMa":
                    MessageBox.Show("Mã sản phẩm không được để trống!", "Error");
                    return;
                case "errorMal":
                    MessageBox.Show("Loại hàng không được để trống!", "Error");
                    return;
                case "errorAnh":
                    MessageBox.Show("Ảnh không được để trống!", "Error");
                    return;
                case "errorGia":
                    MessageBox.Show("Giá bán không được để trống!", "Error");
                    return;
                case "error1":
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Error");
                    return;
            }

            //if (nccht != cbNhaCungCap.Text)
            //{
            //    PHIEUNHAPKHO p = new PHIEUNHAPKHO();
            //    p.MaNhaCungCap = NhaCungCapBUS.Instance.getMaNhaCungCap(cbNhaCungCap.Text);
            //    p.MaNhanVien = NhanVienBUS.Instance.getMaNhanVien(sdt);
            //    PhieuNhapKhoBUS.Instance.Them(p);
            //}

            //CHITIETPHIEUNHAP c = new CHITIETPHIEUNHAP();
            //c.MaSanPham = txtMaSP.Text;
            //c.SoLuongNhap = int.Parse(txtSoLuong.Text);
            //c.GiaNhap = float.Parse(txtGiaMua.Text);
            //string checkp = ChiTietPhieuNhapBUS.Instance.Them(c);

            //switch (checkp)
            //{
            //    case "errorSop":
            //        MessageBox.Show("Chưa có số phiếu!", "Error");
            //        return;
            //    case "errorSo":
            //        MessageBox.Show("Số lượng không được để trống!", "Error");
            //        return;
            //    case "errorGia":
            //        MessageBox.Show("Giá mua không được để trống!", "Error");
            //        return;
            //    case "errorMa":
            //        MessageBox.Show("Mã sản phẩm không được để trống!", "Error");
            //        return;
            //}

            MessageBox.Show("Thêm thành công!", "Thông báo");
            SanPhamBUS.Instance.Xem(dtgvDSSP);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Đặt tiêu đề cho hộp thoại openFileDialog
                openFileDialog.Title = "Chọn ảnh";
                //Đặt bộ lọc cho các tệp ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn đến tệp đã chọn
                    string selectedImagePath = openFileDialog.FileName;
                    //Chỉnh ảnh phù hợp với pbHinhAnh
                    pbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    //Hiển thị ảnh
                    pbHinhAnh.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (SanPhamBUS.Instance.Xoa(dtgvDSSP))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                SanPhamBUS.Instance.Xem(dtgvDSSP);
            }
            else MessageBox.Show("Xóa không thành công", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SANPHAM sp = new SANPHAM();
            sp.MaSanPham = txtMaSP.Text;
            sp.TenSanPham = txtTenSP.Text;
            sp.MaLoaiHang = int.Parse(LoaiHangBUS.Instance.getMaLoaiHang(cbLoaiSP.Text));
            sp.GiaBan = float.Parse(txtGiaBan.Text);
            byte[] anh = null;
            //Chuyển ảnh thành mảng byte
            using (MemoryStream memoryStream = new MemoryStream())
            {
                if (pbHinhAnh.Image == null)
                {
                    MessageBox.Show("Ảnh không được để trống!", "Error");
                    return;
                }
                else
                {
                    pbHinhAnh.Image.Save(memoryStream, pbHinhAnh.Image.RawFormat);
                    anh = memoryStream.ToArray();
                }
            }
            sp.Anh = anh;


            // Lấy hàng hiện tại (current row)
            int rowIndex = dtgvDSSP.CurrentCell.RowIndex;
            // Lấy giá trị từ ô hiện tại
            string macuahang = dtgvDSSP.Rows[rowIndex].Cells[0].Value.ToString();

            if (macuahang != txtMaSP.Text)
            {
                MessageBox.Show("Mã sản phẩm không được thay đổi!", "Error");
                return;
            }
            SanPhamBUS.Instance.Sua(sp);
            MessageBox.Show("Sửa thành công!", "Thông báo");
            SanPhamBUS.Instance.Xem(dtgvDSSP);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SanPhamBUS.Instance.Tim(dtgvDSSP, txtTimKiem.Text);
        }
    }
}
