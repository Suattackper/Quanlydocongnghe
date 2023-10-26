using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();

            LoadSanPham();
            
        }

        #region Events
        void loadNhanVien()
        {
            List<ModelSanPham> listmodel = DanhSachSPDAO.Instance.loadDanhSachSP();

            foreach (ModelSanPham item in listmodel)
            {
                ModelSanPham model = new ModelSanPham();
                flpDanhSachSanPham.Controls.Add(model);
            }
        }

        void LoadListKhachHang()
        {
            string query = "exec USP_GetSanPhamByMaHang @mahang";


            //dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] { "1" });
        }
        public string getMaLoai(string tenloai)
        {
            string sql = $"select MaLoaiHang,TenLoaiHang from LOAIHANG where TenLoaiHang = '{tenloai}'";
            string ma = null;
            DataTable check = DataProvider.Instance.ExcuteQuery(sql);
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["TenLoaiHang"].ToString() == tenloai)
                {
                    return existingRow["MaLoaiHang"].ToString();
                }
            }
            return ma;
        }
        void LoadSanPham()
        {
            SetCbxLoaiSP();
            SetCbxNCC();
            //SqlConnection conn = new SqlConnection(STRconn);
            string query = "select s.masanpham,s.tensanpham,l.tenloaihang,s.giaban, s.anh from sanpham s inner join loaihang l on l.maloaihang=s.maloaihang";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            //foreach (DataRow item in data.Rows)
            //{
            //    ModelSanPham model = new ModelSanPham(item);
            //    listModel.Add(model);
            //}
            foreach (DataRow item in data.Rows)
            {
                byte[] imagearray = (byte[])getAnh(item["MaSanPham"].ToString());
                //byte[] imagebytearray = imagearray; Image.FromStream(new MemoryStream(getAnh(item["MaSanPham"].ToString())))
                //Image anh = Image.FromStream(new MemoryStrec
                AddSanPham(item["MaSanPham"].ToString(), item["TenLoaiHang"].ToString(), item["TenSanPham"].ToString(), float.Parse(item["GiaBan"].ToString()), imagearray);
                //flpDanhSachSanPham.Controls.Add(AddSanPham(item));
            }
        }

        void AddSanPham(string MaSP, string tenloai, string TenSP, float GiaSP, byte[] AnhSP)
        {
            bool productExists = false;
            var S = new ModelSanPham()
            {

                TenSanPham = TenSP,
                MaLoaiHang = int.Parse(getMaLoai(tenloai)),
                GiaBan = GiaSP,
                Anh = AnhSP,
                MaSanPham = MaSP

            };
            flpDanhSachSanPham.Controls.Add(S);



            S.onSelect += (ss, ee) =>
            {

                var wdg = (ModelSanPham)ss;

                bool SanPhamDaTonTai = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {



                    if (item.Cells["dvgMaSP"].Value != null && item.Cells["dvgMaSP"].Value.ToString() == wdg.MaSanPham.ToString())
                    {
                        // Sản phẩm đã tồn tại trong DataGridView, tăng số lượng và cập nhật tổng tiền
                        int soLuongHienTai = int.Parse(item.Cells["dvgSoLuong"].Value.ToString());
                        item.Cells["dvgSoLuong"].Value = soLuongHienTai + 1;

                        float giaBan = float.Parse(item.Cells["dvgGiaBan"].Value.ToString());
                        item.Cells["dvgTong"].Value = (giaBan * (soLuongHienTai + 1)).ToString("N0");
                        GetTongBill();
                        SanPhamDaTonTai = true;
                        break; // thoát khỏi vòng lặp vì sản phẩm đã tồn tại
                    }
                }

                if (SanPhamDaTonTai == false)
                {
                    // thêm sản phầm nếu nó chưa tồn tại
                    dataGridView1.Rows.Add(new object[] { wdg.MaSanPham, wdg.TenSanPham, 1, wdg.GiaBan.ToString("N0"), wdg.GiaBan.ToString("N0") });
                    GetTongBill();
                }

            };




        }
        #endregion








        public void SetCbxLoaiSP()
        {
            string sql = "select * from dbo.LOAIHANG";
           DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            cbxLoaiSp.DataSource = data;
            cbxLoaiSp.DisplayMember = "tenloaihang";
         
        }
            
        public void SetCbxNCC()
        {
            string sql = "select * from dbo.NHACUNGCAP";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            cbxNCC.DataSource = data;
            cbxNCC.DisplayMember = "TenNhaCungCap";
        }



        //public DataTable getAnh(string masp)
        //{
        //    string sql = $"select MaSanPham,Anh from SANPHAM where MaSanPham = '{masp}'";
        //    return DataProvider.Instance.ExcuteQuery(sql);
        //}
        public byte[] getAnh(string masp)
        {
            string sql = $"select MaSanPham,Anh from SANPHAM where MaSanPham = '{masp}'";
            byte[] image = null;
            DataTable check = DataProvider.Instance.ExcuteQuery(sql);
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
        public void GetTongBill()
        {
            double tong = 0;
            txbTongBill.Text = "";

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["dvgTong"].Value != null)
                {
                    double giaTriTong;
                    if (double.TryParse(item.Cells["dvgTong"].Value.ToString(), out giaTriTong))
                    {
                        tong += giaTriTong;
                    }
                }
            }

            txbTongBill.Text = tong.ToString("N0" ) ;
            txbKhachDua.Enabled = true;
            
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            flpDanhSachSanPham.Controls.Clear();
            LoadSanPham();
        }

 

        private void txbKhachDua_TextChanged(object sender, EventArgs e)
        {
           
            TextBox txb = (TextBox)sender;
            string inputText = txb.Text;
           
           
          
           
            while (!double.TryParse(inputText, out double numericValue))
            {
                MessageBox.Show("Hãy nhập vào 1 số");
                break;

            }
            if (double.TryParse(inputText, out double numericValue1))
            {
                string formattedText = numericValue1.ToString("N0"); // Format as numeric with thousands separators
                txb.Text = formattedText;
            
            
                double khachdua = double.Parse(txbKhachDua.Text);
                double tong = double.Parse(txbTongBill.Text);
                double calc;
                if (khachdua < tong)
                {
                    txbTienThua.Text = "Không đủ";
                }
                else if (khachdua > tong)
                {
                    calc = khachdua - tong;
                    txbTienThua.Text = calc.ToString("N0");
                }
                else
                {
                    txbTienThua.Text = "";
                }
            }
          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from dbo.LOAIHANG";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            string selectedValue = cbxLoaiSp.SelectedValue.ToString();
            var rows = data.AsEnumerable()
    .Where(row => row.Field<string>("tenloaihang") == selectedValue)
    .ToList();
         
                MessageBox.Show(selectedValue.ToString());
            
        }
    }
}
