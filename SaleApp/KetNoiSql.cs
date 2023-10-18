using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp
{
    internal class KetNoiSql
    {
        //Cú pháp sử dụng hàm, nhớ open() và close() khi sử dụng
        //KetNoiSql kn = new KetNoiSql();
        //SqlConnection conn = kn.KetNoi();

        public SqlConnection KetNoi()
        {
            SqlConnection conn = null;
            String sql = @"Data Source=VvV\ANHTAN;Initial Catalog=QUAN_LY_BAN_HANG;Integrated Security=True";
            using (conn = new SqlConnection(sql))
            {
                try
                {
                    MessageBox.Show("Kết nối thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
            return conn;
        }
    }
}
