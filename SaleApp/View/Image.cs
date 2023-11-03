using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleApp.Model;

namespace SaleApp.View
{
    public partial class frmImage : Form
    {
        
        public frmImage()
        {
            InitializeComponent();
            LoadData();
        }

        //conn.Open();
        //    SqlCommand cmd = new SqlCommand("select * from dbo.HinhAnh ", conn);
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //    dataGridView1.DataSource = dt; ;
        //    conn.Close();

        string STRconn = @"Data Source=DESKTOP-J60VD8G;Initial Catalog=QUAN_LY_BAN_HANG;Integrated Security=True";
        private object sqlDbType;

        public void LoadData()
        {

            SqlConnection conn = new SqlConnection(STRconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dbo.SANPHAM", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
         private HinhAnh GetValues()
        {
            string tenhinhanh = txbTen.Text;
            byte[] anh = ImageToByteArray(pictureBox1);
            return new HinhAnh(tenhinhanh, anh);
        }
        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();


        }
        private void button2_Click(object sender, EventArgs e)
        {

           
            HinhAnh image =  GetValues();
            string query = "UPDATE SANPHAM SET Anh = @Anh WHERE MaSanPham = @MaSanPham";
           
         

            using (SqlConnection conn = new SqlConnection(STRconn))
            {

                conn.Open();
             
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Anh", SqlDbType.VarBinary).Value = image.Anh;
                    cmd.Parameters.Add("@MaSanPham", SqlDbType.NVarChar).Value = image.Tenhinhanh;
                 
                    cmd.ExecuteNonQuery(); // Thực hiện lệnh SQL để thêm dữ liệu hình ảnh
                }
                conn.Close();
              
            }
            frmImage_Load(sender, e);


            MessageBox.Show("Thêm Thành Công");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

            }
        }

        private void frmImage_Load(object sender, EventArgs e)
        {
            LoadData();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dataGridView1.Columns[4];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbTen.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString()!="")
            {
                MemoryStream memoryStream = new MemoryStream((byte[])dataGridView1.SelectedRows[0].Cells[1].Value);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HinhAnh image = GetValues();
            string query = "UPDATE HinhAnh set Anh = @Anh where TenHinhAnh = @TenHinhAnh";



            using (SqlConnection conn = new SqlConnection(STRconn))
            {

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Tenhinhanh", SqlDbType.NVarChar).Value = image.Tenhinhanh;
                    cmd.Parameters.Add("@Anh", SqlDbType.VarBinary).Value = image.Anh;
                    cmd.ExecuteNonQuery(); // Thực hiện lệnh SQL để thêm dữ liệu hình ảnh
                }
                conn.Close();

            }
            frmImage_Load(sender, e);


            MessageBox.Show("Sửa Thành Công");
        }
    }
}
