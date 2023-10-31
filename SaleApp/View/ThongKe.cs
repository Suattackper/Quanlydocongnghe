using OfficeOpenXml;
using SaleApp.Business;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp.View
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                //tạo một workbook Excel mới
                using (var package = new ExcelPackage())
                {
                    //tạo trang tinh sheet1 và gán chp workbook
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                    // Ghi dữ liệu từ DataGridView vào Excel worksheet
                    for (int i = 1; i <= dataGridView.Columns.Count; i++)
                    {
                        // Ghi tiêu đề cột
                        worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                        worksheet.Cells[1, i].Style.Font.Bold = true;
                        // Đặt độ rộng cột bằng chiều dài của tiêu đề cột
                        worksheet.Column(i).AutoFit();
                    }
                    //Ghi dữ liệu vào woekbook từ datagridview
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            if (dataGridView[j, i].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridView[j, i].Value.ToString();
                            }
                        }
                    }

                    // Lưu workbook ra tệp Excel
                    package.SaveAs(new FileInfo(filePath));

                    MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DonMuaBUS.Instance.ThongKe(dtgvDSDonHang);
            float tong = 0;
            foreach (DataGridViewRow row in dtgvDSDonHang.Rows)
            {
                tong = tong + float.Parse(row.Cells[4].Value.ToString());
            }
            laTong.Text = tong.ToString() + " VND";
        }
        
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            DonMuaBUS.Instance.ThongKe(dtgvDSDonHang);
            float tong = 0;
            foreach (DataGridViewRow row in dtgvDSDonHang.Rows)
            {
                tong = tong + float.Parse(row.Cells[4].Value.ToString());
            }
            laTong.Text = tong.ToString() + " VND";
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                //hiển thị hộp thoại lưu cho người dùng
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Chọn vị trí lưu tệp Excel
                    string filePath = saveFileDialog.FileName;

                    // Viết dữ liệu vào tệp Excel
                    ExportToExcel(dtgvDSDonHang, filePath);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DonMuaBUS.Instance.Tim(dtgvDSDonHang, txtTimKiem.Text);
        }
    }
}
