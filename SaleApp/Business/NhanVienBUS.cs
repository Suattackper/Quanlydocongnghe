using SaleApp.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Business
{
    internal class NhanVienBUS
    {
        private static NhanVienBUS instance;

        internal static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
        }
        private NhanVienBUS() { }
        public string getMaNhanVien(string sdt)
        {
            string ma = null;
            DataTable check = NhanVienDAO.Instance.getMaNhanVien(sdt);
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["SoDienThoai"].ToString() == sdt)
                {
                    return existingRow["MaNhanVien"].ToString();
                }
            }
            return ma;
        }
    }
}
