using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class DonMuaDAO
    {
        private static DonMuaDAO instance;

        internal static DonMuaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonMuaDAO();
                return instance;
            }
        }
        private DonMuaDAO() { }

        public DataTable Xem()
        {
            string sql = "SELECT * FROM DONMUA";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
