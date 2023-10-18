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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            frmTrangChu a = new frmTrangChu();
            LoadForm(a);
        }
        // theo dõi Form hiện tại đang được hiển thị
        private Form formNow;
        private void LoadForm(Form formnew)
        {
            //Nếu có form đang hiển thị, đóng form
            if (formNow != null)
            {
                formNow.Close();
            }
            //đổi form hiển thị
            formNow = formnew;
            //Đặt lại form mới này thành cửa sổ cấp thấp
            formnew.TopLevel = false;
            //Đặt form thành không có viền cửa sổ
            formnew.FormBorderStyle = FormBorderStyle.None;
            //Lấp đầy chỗ trống trong form
            formnew.Dock = DockStyle.Fill;
            //chứa form vào PBody
            PBody.Controls.Add(formnew);
            PBody.Tag = formnew;
            //Nếu có btn txt, ... trong PBody, form sẽ hiển thị lên 
            formnew.BringToFront();
            //Hàm gọi form hiển thị
            formnew.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            frmKhoHang a = new frmKhoHang();
            LoadForm(a);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien a = new frmNhanVien();
            LoadForm(a);
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            frmDonHang a = new frmDonHang();
            LoadForm(a);
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap a = new frmNhaCungCap();
            LoadForm(a);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            frmTrangChu a = new frmTrangChu();
            LoadForm(a);
        }
    }
}
