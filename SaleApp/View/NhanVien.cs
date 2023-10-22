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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }



        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
