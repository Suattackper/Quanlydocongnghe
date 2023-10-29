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
    public partial class frmXuatKho : Form
    {
        private string sdt;
        public frmXuatKho()
        {
            InitializeComponent();
        }
        public frmXuatKho(string sdt)
        {
            this.sdt = sdt;
            InitializeComponent();
        }
    }
}
