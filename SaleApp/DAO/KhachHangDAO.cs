using SaleApp.Business;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (Instance == null) Instance = new KhachHangDAO(); return KhachHangDAO.Instance; }
            private set { KhachHangDAO.Instance = value; }
        }


    }
}
