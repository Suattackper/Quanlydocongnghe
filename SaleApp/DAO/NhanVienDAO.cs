using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }
        private NhanVienDAO() { }
        public DataTable getMaNhanVien(string masp)
        {
            string sql = $"select MaNhanVien,SoDienThoai from NHANVIEN where SoDienThoai = '{masp}'";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
