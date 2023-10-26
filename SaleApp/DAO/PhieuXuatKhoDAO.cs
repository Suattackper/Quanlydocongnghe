using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class PhieuXuatKhoDAO
    {
        private static PhieuXuatKhoDAO instance;

        internal static PhieuXuatKhoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuXuatKhoDAO();
                return instance;
            }
        }
        private PhieuXuatKhoDAO() { }
        public DataTable Xem()
        {
            string sql = "select * from PHIEUXUATKHO";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
