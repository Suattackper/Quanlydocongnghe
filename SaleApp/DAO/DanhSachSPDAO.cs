using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    public class DanhSachSPDAO
    {
        private static DanhSachSPDAO instance;

        public static DanhSachSPDAO Instance
        { 
            get { if (instance == null) instance = new DanhSachSPDAO(); return DanhSachSPDAO.instance; } 
            private set { DanhSachSPDAO.instance = value; }
        }

        private DanhSachSPDAO() { }

        public List<ModelSanPham> loadDanhSachSP()
        {
            List<ModelSanPham> listModel = new List<ModelSanPham>();

            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC USP_GetSanPhamList");

            foreach (DataRow  item in data.Rows)
            {
                ModelSanPham model = new ModelSanPham(item);
                listModel.Add(model);
            }

            return listModel;
        }
    }


}
