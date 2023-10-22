using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp.Business
{
    internal class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;

        internal static NhaCungCapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapBUS();
                return instance;
            }
        }
        private NhaCungCapBUS() { }

        public void Xem(DataGridView dgv)
        {
            dgv.DataSource = NhaCungCapDAO.Instance.Xem();
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgv.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgv.Columns[2].HeaderText = "Số điện thoại";
            dgv.Columns[3].HeaderText = "Địa chỉ";
        }
        public string Them(NHACUNGCAP p)
        {
            if (p.TenNhaCungCap == "")
            {
                return "errorTen";
            }
            if (p.MaNhaCungCap == "")
            {
                return "errorMa";
            }
            if (p.SoDienThoai == "")
            {
                return "errorSdt";
            }
            //Kiểm tra 1 chuỗi có phải là số điện thoại
            if (Regex.IsMatch(p.SoDienThoai, @"^(03|07|08|09|01[2-9])[0-9]{8}$"))
            {
                return "errorSdt2";
            }
            if (p.DiaChi == "")
            {
                return "errorDiachi";
            }
            //kiểm tra mã ncc và sđt đã tồn tại chưa
            DataTable check = NhaCungCapDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaNhaCungCap"].ToString() == p.MaNhaCungCap)
                {
                    return "error1";
                }
                if (existingRow["SoDienThoai"].ToString() == p.SoDienThoai)
                {
                    return "error2";
                }
            }
            NhaCungCapDAO.Instance.Them(p);
            return "";
        }
        public bool Xoa(DataGridView dgv)
        {
            //lấy dữ liệu cộ đầu đang được chọn
            string code = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value + "";
            bool kt = false;
            string codepnk = "";
            //kiem tra xem mancc có tồn tại trong phiếu nhập kho không
            DataTable check = PhieuNhapKhoDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaNhaCungCap"].ToString() == code)
                {
                    //hỏi xác nhận xóa các dữ liệu liên qua đến ncc này
                    DialogResult result = MessageBox.Show("Điều này sẽ xóa các dữ liệu liên quan đến nhà cung cấp này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        //lấy sô phiếu nhập kho
                        codepnk = existingRow["SoPhieuNhapKho"].ToString();
                        //xóa
                        ChiTietPhieuNhapDAO.Instance.Xoa(codepnk);
                        PhieuNhapKhoDAO.Instance.Xoa(code);
                    }
                    else return false;
                    break;
                }
            }
            return NhaCungCapDAO.Instance.Xoa(code);
        }
        public string Sua(NHACUNGCAP p, string sdt)
        {
            // kiểm tra mã ncc và sđt đã tồn tại chưa
            DataTable check = NhaCungCapDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["SoDienThoai"].ToString() == p.SoDienThoai && existingRow["SoDienThoai"].ToString() != sdt)
                {
                    return "error2";
                }
            }
            NhaCungCapDAO.Instance.Sua(p);
            return "";
        }
        public void Tim(DataGridView dgv, string tenncc)
        {
            dgv.DataSource = NhaCungCapDAO.Instance.Tim(tenncc);
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgv.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgv.Columns[2].HeaderText = "Số điện thoại";
            dgv.Columns[3].HeaderText = "Địa chỉ";
        }
    }
}
