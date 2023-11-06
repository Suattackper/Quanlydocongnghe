using SaleApp.Business;
using SaleApp.DAO;
using SaleApp.Model;
using SaleApp.View;
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

        DataTable dt = new DataTable();
        public frmDonHang()
        {
            InitializeComponent();
            LoadSanPham();
            //LoadData();
        }

        #region Events

       

        //void loadNhanVien()
        //{
        //    List<ModelSanPham> listmodel = DanhSachSPDAO.Instance.loadDanhSachSP();
        //    foreach (ModelSanPham item in listmodel)
        //    {
        //        ModelSanPham model = new ModelSanPham();
        //        flpDanhSachSanPham.Controls.Add(model);
        //    }
        //}

        void InsertInforKhachHang()
        {
            string sql = "insert into KHACHHANG (makhachhang,hoten,sodienthoai) values ( @makh, @hoten, @sodienthoai ) ";

            KHACHHANG kh = new KHACHHANG();
            kh.MaKhachHang = txbMaKH.Text.Trim();
            kh.HoTen = txtHoTen.Text.Trim();
            kh.SoDienThoai = txtSDT.Text.Trim();
            Object[] p = new object[] { kh.MaKhachHang, kh.HoTen, kh.SoDienThoai };
            DataProvider.Instance.execNonSql(sql, p);
        }
        void LoadSanPham()
        {

            SanPhamDAO.Instance.SetCbx(cbxLoaiSp, "LOAIHANG", "tenloaihang");
            SanPhamDAO.Instance.SetCbx(cbxNCC, "NHACUNGCAP" ,"tennhacungcap");
            string query = "select s.masanpham,s.tensanpham,l.tenloaihang,s.giaban, s.anh from sanpham s inner join loaihang l on l.maloaihang=s.maloaihang";
           
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                byte[] imagearray = SanPhamBUS.Instance.getAnh(item["MaSanPham"].ToString());
           
                AddSanPham(item["MaSanPham"].ToString(), item["TenLoaiHang"].ToString(), item["TenSanPham"].ToString(), float.Parse(item["GiaBan"].ToString()), imagearray);
                
            }
            
        }

        void AddSanPham(string MaSP, string tenloai, string TenSP, float GiaSP, byte[] AnhSP)
        {
            bool productExists = false;
            var S = new ModelSanPham()
            { 

                TenSanPham = TenSP,
                MaLoaiHang = int.Parse(LoaiHangBUS.Instance.getMaLoaiHang(tenloai)),
                GiaBan = GiaSP,
                Anh = AnhSP,
                MaSanPham = MaSP

            };
            flpDanhSachSanPham.Controls.Add(S);


            SanPhamBUS.Instance.ActionModelSanPham(S,dataGridView1,txbTongBill,dt);
         
        }
        #endregion


        
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            flpDanhSachSanPham.Controls.Clear();
            LoadSanPham();
        }
        private void txbKhachDua_TextChanged(object sender, EventArgs e)
        {
            // tính tiền thừa
            txbTienThua.Text = SanPhamBUS.Instance.CalcTienThua(sender, txbKhachDua, txbTongBill);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // tim kiem
            int flag = 0;
            foreach (var item in flpDanhSachSanPham.Controls)
            {                var pro = (ModelSanPham)item;
                pro.Visible = pro.TenSanPham.ToLower().Contains(txtTimKiem.Text.Trim().ToLower());
                flag++;
                if (flag == 0)
                {
                    Label lb = new Label();
                    lb.Text = "Sản phầm không tồn tại";
                    flpDanhSachSanPham.Controls.Add(lb);
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các sản phẩm hiện tại
            flpDanhSachSanPham.Controls.Clear();
            LoadSanPham();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SanPhamBUS.Instance.ActionWithDVG(dataGridView1, e);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //txbKhachDua.Enabled = true;
            SanPhamBUS.Instance.CalcTongTien(dataGridView1,e);
            SanPhamBUS.Instance.GetTongBill(txbTongBill, dataGridView1);
               
        }

       
        private void btnInDon_Click(object sender, EventArgs e)
        {
           
            XuatHoaDon a = new(txbTongBill.Text, txbKhachDua.Text, txbTienThua.Text, txbMaKH.Text, txtHoTen.Text, txtSDT.Text ,dt);
            if (txtHoTen.Text == "" || txtSDT.Text == "" || txbMaKH.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                SanPhamBUS.Instance.LoadData(dt,dataGridView1);
                a.ShowDialog();

            }
            InsertInforKhachHang();
            string sql = "insert into DONMUA (makhachhang,manhanvien,tongtien) values ( @makh, @manv, @tong ) ";

            Object[] p = new object[] { txbMaKH.Text, "11", decimal.Parse(txbTongBill.Text) };
            DataProvider.Instance.execNonSql(sql, p);


        }

            private void txbTongBill_TextChanged(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if(txb.Text != "0")
            {
                txbKhachDua.Enabled = true;
            }
            else
            {
                txbKhachDua.Enabled = false;
            }
           
        }
    }
}
