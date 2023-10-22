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

        //Cú pháp sử dụng hàm, nhớ open() và close() khi sử dụng
        //KetNoiSql kn = new KetNoiSql();
        //SqlConnection conn = kn.KetNoi();

        //||SqlConnection conn = KetNoiSql.Instance.ketNoi();

        //public SqlConnection ketNoi()
        //{
        //    SqlConnection conn = null;
        //    using (conn = new SqlConnection(connsql))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            MessageBox.Show("Kết nối thành công");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
        //        }
        //    }
        //    return conn;
        //}

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
