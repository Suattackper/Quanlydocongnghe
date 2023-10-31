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
        public DataTable ThongKe()
        {
            string sql = "select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien from donmua d inner join khachhang k on d.makhachhang=k.makhachhang inner join chitietdonmua c on c.madonmua=d.madonmua";
            return KetNoiSql.Instance.execSql(sql);
        }
        public DataTable Tim(string name)
        {
            string sql = "select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien from donmua d inner join khachhang k on d.makhachhang=k.makhachhang inner join chitietdonmua c on c.madonmua=d.madonmua WHERE k.hoten LIKE @keyword ";
            Object[] prms = new object[] { "%" + name + "%" };
            return KetNoiSql.Instance.execSql(sql, prms);
        }
    }
}
