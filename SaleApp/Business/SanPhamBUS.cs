using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp.Business
{
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;

        public static SanPhamBUS Instance {
            get{  if (instance == null) instance = new SanPhamBUS(); return SanPhamBUS.instance; }
            private set { SanPhamBUS.instance = value; }
        }
        public void GetTongBill(TextBox txbTongBill , DataGridView dataGridView1)
        {
            double tong = 0;
            txbTongBill.Text = "";

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["dvgTong"].Value != null)
                {
                    double giaTriTong;
                    if (double.TryParse(item.Cells["dvgTong"].Value.ToString(), out giaTriTong))
                    {
                        tong += giaTriTong;
                    }
                }
            }

            txbTongBill.Text = tong.ToString("N0");
        }

        public void CalcTongTien(DataGridView dataGridView1,DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "dvgSoLuong")
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int soLuongHienTai = int.Parse(selectedRow.Cells["dvgSoLuong"].Value.ToString());
                DataGridViewCell cellGiaBan = dataGridView1.Rows[e.RowIndex].Cells["dvgGiaBan"];
                float giaBan = float.Parse(selectedRow.Cells["dvgGiaBan"].Value.ToString());
                selectedRow.Cells["dvgTong"].Value = (soLuongHienTai * giaBan).ToString("N0");
            }
        }

        public void ActionWithDVG(DataGridView dataGridView1, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex >= 0) // người dùng đã chọn 
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Bạn thực sự muốn xóa sản phẩm này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == System.Windows.Forms.DialogResult.OK)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "des")
                {
                    int soLuongHienTai = int.Parse(selectedRow.Cells["dvgSoLuong"].Value.ToString());
                    selectedRow.Cells["dvgSoLuong"].Value = soLuongHienTai - 1;
                    if (int.Parse(selectedRow.Cells["dvgSoLuong"].Value.ToString()) <= 0)
                    {
                        if (MessageBox.Show("Bạn thực sự muốn xóa sản phẩm này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == System.Windows.Forms.DialogResult.OK)
                        {
                            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                        }
                        else
                        {
                            selectedRow.Cells["dvgSoLuong"].Value = 1;
                        }
                    }
                }
            }
        }

        public void ActionModelSanPham(ModelSanPham S, DataGridView dataGridView1 , TextBox txbTongBill,DataTable dt)
        {
            S.onSelect += (ss, ee) =>
            {

                var wdg = (ModelSanPham)ss;

                bool SanPhamDaTonTai = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["dvgMaSP"].Value != null && item.Cells["dvgMaSP"].Value.ToString() == wdg.MaSanPham.ToString())
                    {
                     
                        // Sản phẩm đã tồn tại trong DataGridView, tăng số lượng và cập nhật tổng tiền
                        int soLuongHienTai = int.Parse(item.Cells["dvgSoLuong"].Value.ToString());
                        item.Cells["dvgSoLuong"].Value = soLuongHienTai + 1;

                        float giaBan = float.Parse(item.Cells["dvgGiaBan"].Value.ToString());
                        item.Cells["dvgTong"].Value = (giaBan * (soLuongHienTai + 1)).ToString("N0");
                        SanPhamBUS.Instance.GetTongBill(txbTongBill, dataGridView1);
                        SanPhamDaTonTai = true;
                        break; // thoát khỏi vòng lặp vì sản phẩm đã tồn tại
                    }
                }
   
                if (SanPhamDaTonTai == false)
                {
                    // thêm sản phầm nếu nó chưa tồn tại
                    dataGridView1.Rows.Add(new object[] { wdg.MaSanPham, wdg.TenSanPham, 1, wdg.GiaBan.ToString("N0"), wdg.GiaBan.ToString("N0")});
                   
                    SanPhamBUS.Instance.GetTongBill(txbTongBill, dataGridView1);
                }
      
            };
      
        }
        public void checkSame()
        {

        }
        public void LoadData(DataTable dt , DataGridView dataGridView1)
        {
            dt.Clear();
            // Kiểm tra xem cột có tồn tại trong DataTable chưa trước khi thêm
            if (!dt.Columns.Contains("Mã SP"))
            {
                // Nếu chưa tồn tại, thì thêm cột mới
                dt.Columns.Add("Mã SP");
            }

            // Tiếp tục kiểm tra và thêm các cột khác
            if (!dt.Columns.Contains("Tên SP"))
            {
                dt.Columns.Add("Tên SP");

            }
            if (!dt.Columns.Contains("Số Lượng"))
            {
                dt.Columns.Add("Số Lượng");
            }
            if (!dt.Columns.Contains("Giá Bán"))
            {
                dt.Columns.Add("Giá Bán");
            }
            if (!dt.Columns.Contains("Tổng"))
            {
                dt.Columns.Add("Tổng");
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow newRow = dt.NewRow();
                newRow["Mã SP"] = row.Cells["dvgMaSP"].Value;
                //if (row.Cells["dvgMaSP"].Value == r)
                newRow["Tên SP"] = row.Cells["dvgTenSP"].Value;
                newRow["Số Lượng"] = Convert.ToInt32(row.Cells["dvgSoLuong"].Value); // Ép kiểu về int
                newRow["Giá Bán"] = Convert.ToSingle(row.Cells["dvgGiaBan"].Value).ToString("N0"); // Ép kiểu về float
                newRow["Tổng"] = Convert.ToSingle(row.Cells["dvgTong"].Value).ToString("N0");
                dt.Rows.Add(newRow);
            }
        }
        public string CalcTienThua(object sender,TextBox txbKhachDua , TextBox txbTongBill)
        {
            TextBox txb = (TextBox)sender;
            string inputText = txb.Text;
            string kq= " ";

            while (!double.TryParse(inputText, out double numericValue))
            {
                MessageBox.Show("Hãy nhập vào 1 số");
                break;

            }
            if (double.TryParse(inputText, out double numericValue1))
            {
                string formattedText = numericValue1.ToString("N0"); // Format as numeric with thousands separators
                txb.Text = formattedText;


                double khachdua = double.Parse(txbKhachDua.Text);
                double tong = double.Parse(txbTongBill.Text);
                double calc;
                if (khachdua < tong)
                {
                   kq = "Không đủ";
                }
                else if (khachdua > tong)
                {
                    calc = khachdua - tong;
                    kq = calc.ToString("N0");
                }
                else
                {
                    kq =  "";
                }
            }
            return kq;
        }


    }
}
