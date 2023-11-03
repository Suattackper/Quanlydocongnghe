using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        { 
            get { if (instance == null) instance = new SanPhamDAO(); return SanPhamDAO.instance; } 
            private set { SanPhamDAO.instance = value; }
        }

        private SanPhamDAO() { }

        public List<ModelSanPham> loadDanhSachSP()
        {
            List<ModelSanPham> listModel = new List<ModelSanPham>();

            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC USP_GetSanPhamList");

            foreach (DataRow  item in data.Rows)
            {
                ModelSanPham model = new ModelSanPham(item);
                listModel.Add(model);
            }

            return listModel;
        }
        public void SetCbx(ComboBox b,string table,  string mb)
        {
            
            string sql = "select * from " + table;
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            b.DataSource = data;
            b.DisplayMember = mb;

        }
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

        private string getMaSP(string ten)
        {
            string sql = $"select MaSanPham,TenSanPham from SANPHAM where TenSanPham = '{ten}'";

            string ma = null;
            DataTable check = DataProvider.Instance.execSql(sql);
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["TenSanPham"].ToString() == ten)
                {
                    return existingRow["MaSanPham"].ToString();
                }
            }
            return ma;
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
    }


}
