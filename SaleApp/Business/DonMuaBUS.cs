using SaleApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Business
{
    internal class DonMuaBUS
    {
        private static DonMuaBUS instance;

        internal static DonMuaBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonMuaBUS();
                return instance;
            }
        }
        private DonMuaBUS() { }
        public void ThongKe(DataGridView dgv)
        {
            dgv.DataSource = DonMuaDAO.Instance.ThongKe();
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã đơn mua";
            dgv.Columns[1].HeaderText = "Tên khách hàng";
            dgv.Columns[2].HeaderText = "Ngày mua";
            dgv.Columns[3].HeaderText = "Mã nhân viên";
            dgv.Columns[4].HeaderText = "Tổng tiền";
        }
        public void Tim(DataGridView dgv, string tenkh)
        {
            dgv.DataSource = DonMuaDAO.Instance.Tim(tenkh);
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã đơn mua";
            dgv.Columns[1].HeaderText = "Tên khách hàng";
            dgv.Columns[2].HeaderText = "Ngày mua";
            dgv.Columns[3].HeaderText = "Mã nhân viên";
            dgv.Columns[4].HeaderText = "Tổng tiền";
        }
    }
}
