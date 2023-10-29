using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleApp.Model;

namespace SaleApp.DAO
{
    internal class KetNoiSql
    {
        private static KetNoiSql instance;
        string connsql = @"Data Source=VvV\ANHTAN;Initial Catalog=QUAN_LY_BAN_HANG;Integrated Security=True";
        public KetNoiSql()
        {
        }

        public static KetNoiSql Instance
        {
            get
            {
                if (instance == null)
                    instance = new KetNoiSql();
                return instance;
            }
        }

        public List<QUYEN> getDataQuyen()
        {
            List<QUYEN> quyens = new List<QUYEN>();
            DataTable dataTable = new DataTable();
            String sql = "Select * from QUYEN";
            //Kết nối sql
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Truy vấn sql
            SqlCommand command = new SqlCommand(sql, conn);
            //Lưu dữ liệu vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Lấy dữ liệu vào datatable
            adapter.Fill(dataTable);
            conn.Close();
            //Sao chép dữ liệu từ datatable vào list QUYEN
            foreach (DataRow row in dataTable.Rows)
            {
                QUYEN quyen = new QUYEN();
                // Sao chép giá trị từ các cột tương ứng trong bảng QUYEN
                quyen.TenQuyen = row["TenQuyen"].ToString();
                quyen.MaQuyen = Convert.ToInt32(row["MaQuyen"]);
                quyens.Add(quyen);
            }

            return quyens;
        }
        public List<LOAIHANG> getDataLoaiHang()
        {
            List<LOAIHANG> quyens = new List<LOAIHANG>();
            DataTable dataTable = new DataTable();
            String sql = "Select * from LOAIHANG";
            //Kết nối sql
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Truy vấn sql
            SqlCommand command = new SqlCommand(sql, conn);
            //Lưu dữ liệu vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Lấy dữ liệu vào datatable
            adapter.Fill(dataTable);
            conn.Close();
            //Sao chép dữ liệu từ datatable vào list QUYEN
            foreach (DataRow row in dataTable.Rows)
            {
                LOAIHANG quyen = new LOAIHANG();
                // Sao chép giá trị từ các cột tương ứng trong bảng QUYEN
                quyen.TenLoaiHang = row["TenLoaiHang"].ToString();
                quyen.MaLoaiHang = Convert.ToInt32(row["MaLoaiHang"]);
                quyens.Add(quyen);
            }

            return quyens;
        }
        public List<SANPHAM> getDataSanPham()
        {
            List<SANPHAM> quyens = new List<SANPHAM>();
            DataTable dataTable = new DataTable();
            String sql = "Select * from SANPHAM";
            //Kết nối sql
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Truy vấn sql
            SqlCommand command = new SqlCommand(sql, conn);
            //Lưu dữ liệu vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Lấy dữ liệu vào datatable
            adapter.Fill(dataTable);
            conn.Close();
            //Sao chép dữ liệu từ datatable vào list QUYEN
            foreach (DataRow row in dataTable.Rows)
            {
                SANPHAM quyen = new SANPHAM();
                // Sao chép giá trị từ các cột tương ứng trong bảng QUYEN
                quyen.TenSanPham = row["TenSanPham"].ToString();
                quyen.MaSanPham = row["MaLoaiHang"].ToString();
                quyens.Add(quyen);
            }

            return quyens;
        }
        public List<NHACUNGCAP> getDataNhaCungCap()
        {
            List<NHACUNGCAP> quyens = new List<NHACUNGCAP>();
            DataTable dataTable = new DataTable();
            String sql = "Select * from NHACUNGCAP";
            //Kết nối sql
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Truy vấn sql
            SqlCommand command = new SqlCommand(sql, conn);
            //Lưu dữ liệu vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Lấy dữ liệu vào datatable
            adapter.Fill(dataTable);
            conn.Close();
            //Sao chép dữ liệu từ datatable vào list QUYEN
            foreach (DataRow row in dataTable.Rows)
            {
                NHACUNGCAP quyen = new NHACUNGCAP();
                // Sao chép giá trị từ các cột tương ứng trong bảng QUYEN
                quyen.TenNhaCungCap = row["TenNhaCungCap"].ToString();
                quyen.MaNhaCungCap = row["MaNhaCungCap"].ToString();
                quyens.Add(quyen);
            }

            return quyens;
        }
        public string checkLogin(TAIKHOAN taikhoan)
        {
            string user = null;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_checkLogin", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@sodienthoai", taikhoan.SoDienThoai);
            command.Parameters.AddWithValue("@matkhau", taikhoan.MatKhau);
            command.Parameters.AddWithValue("@maquyen", taikhoan.MaQuyen);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    user = reader.GetString(0); //lấy dữ liệu cột đầu tiên
                }
            }
            else return "error";
            reader.Close();
            conn.Close();
            return user;
        }
        // SELECT ....
        public DataTable execSql(string sql, params Object[] args)
        {
            DataTable dat = new DataTable();
            using (SqlConnection connection = new SqlConnection(connsql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(' ');
                    List<string> paramList = new List<string>();
                    foreach (string s in processSql)
                        if (s.StartsWith("@"))
                        {
                            if (s.EndsWith(","))
                                paramList.Add(s.Remove(s.Length - 1));
                            else paramList.Add(s);
                        }
                    for (int i = 0; i < args.Length; i++)
                        command.Parameters.AddWithValue(paramList[i], args[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dat);
                connection.Close();
            }
            return dat;
        }

        // INSERT, UPDATE, DELETE ....
        public int execNonSql(string sql, params Object[] args)
        {
            int effectedRows;
            using (SqlConnection connection = new SqlConnection(connsql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(' ');
                    List<string> paramList = new List<string>();
                    foreach (string s in processSql)
                        if (s.StartsWith("@"))
                        {
                            if (s.EndsWith(","))
                                paramList.Add(s.Remove(s.Length - 1));
                            else paramList.Add(s);
                        }
                    for (int i = 0; i < args.Length; i++)
                        command.Parameters.AddWithValue(paramList[i], args[i]);
                }
                effectedRows = command.ExecuteNonQuery();
                connection.Close();
            }
            return effectedRows;
        }
    }
}
