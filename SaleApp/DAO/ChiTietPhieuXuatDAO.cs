using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class ChiTietPhieuXuatDAO
    {
        private static ChiTietPhieuXuatDAO instance;

        internal static ChiTietPhieuXuatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuXuatDAO();
                return instance;
            }
        }
        private ChiTietPhieuXuatDAO() { }
        public DataTable Xem()
        {
            string sql = "select * from CHITIETPHIẼUUAT";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
