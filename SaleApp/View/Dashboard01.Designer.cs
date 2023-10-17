namespace SaleApp.View
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            panel1 = new Panel();
            pbNhanVien = new PictureBox();
            lblChucVu = new Label();
            label6 = new Label();
            btnClose = new Button();
            panel5 = new Panel();
            lblTongDoanhThu = new Label();
            label4 = new Label();
            pictureBox11 = new PictureBox();
            panel2 = new Panel();
            btnThoat = new Button();
            btnThongKe = new Button();
            btnNhanVien = new Button();
            btnKhoHang = new Button();
            btnSP = new Button();
            btnNhaCC = new Button();
            btnTaoDon = new Button();
            btnTrangChu = new Button();
            panel3 = new Panel();
            lblTongSPDaBan = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            lblTongKH = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNhanVien).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pbNhanVien);
            panel1.Controls.Add(lblChucVu);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Cascadia Code", 8F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1666, 80);
            panel1.TabIndex = 0;
            // 
            // pbNhanVien
            // 
            pbNhanVien.BackgroundImageLayout = ImageLayout.Stretch;
            pbNhanVien.Image = (Image)resources.GetObject("pbNhanVien.Image");
            pbNhanVien.Location = new Point(537, 0);
            pbNhanVien.Margin = new Padding(3, 4, 3, 4);
            pbNhanVien.Name = "pbNhanVien";
            pbNhanVien.Size = new Size(80, 80);
            pbNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNhanVien.TabIndex = 7;
            pbNhanVien.TabStop = false;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Cascadia Code", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblChucVu.ForeColor = Color.White;
            lblChucVu.Location = new Point(766, 27);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(65, 29);
            lblChucVu.TabIndex = 6;
            lblChucVu.Text = "NULL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(623, 27);
            label6.Name = "label6";
            label6.Size = new Size(117, 29);
            label6.TabIndex = 5;
            label6.Text = "Chức vụ:";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1616, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 55);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(230, 126, 34);
            panel5.Controls.Add(lblTongDoanhThu);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox11);
            panel5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(429, 300);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 203);
            panel5.TabIndex = 4;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Cascadia Code", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongDoanhThu.ForeColor = Color.White;
            lblTongDoanhThu.Location = new Point(60, 122);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(95, 43);
            lblTongDoanhThu.TabIndex = 3;
            lblTongDoanhThu.Text = "NULL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 28);
            label4.Name = "label4";
            label4.Size = new Size(140, 32);
            label4.TabIndex = 1;
            label4.Text = "Doanh thu";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(241, 56);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(91, 89);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 0;
            pictureBox11.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 73, 94);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnThongKe);
            panel2.Controls.Add(btnNhanVien);
            panel2.Controls.Add(btnKhoHang);
            panel2.Controls.Add(btnSP);
            panel2.Controls.Add(btnNhaCC);
            panel2.Controls.Add(btnTaoDon);
            panel2.Controls.Add(btnTrangChu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 810);
            panel2.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(336, 739);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(65, 71);
            btnThoat.TabIndex = 8;
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Image = (Image)resources.GetObject("btnThongKe.Image");
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(12, 648);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(374, 68);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống kê ";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Image = (Image)resources.GetObject("btnNhanVien.Image");
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(12, 541);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(374, 68);
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnKhoHang
            // 
            btnKhoHang.FlatAppearance.BorderSize = 0;
            btnKhoHang.FlatStyle = FlatStyle.Flat;
            btnKhoHang.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoHang.ForeColor = Color.White;
            btnKhoHang.Image = (Image)resources.GetObject("btnKhoHang.Image");
            btnKhoHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoHang.Location = new Point(12, 434);
            btnKhoHang.Name = "btnKhoHang";
            btnKhoHang.Size = new Size(374, 68);
            btnKhoHang.TabIndex = 5;
            btnKhoHang.Text = "Kho Hàng ";
            btnKhoHang.UseVisualStyleBackColor = true;
            // 
            // btnSP
            // 
            btnSP.FlatAppearance.BorderSize = 0;
            btnSP.FlatStyle = FlatStyle.Flat;
            btnSP.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSP.ForeColor = Color.White;
            btnSP.Image = (Image)resources.GetObject("btnSP.Image");
            btnSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnSP.Location = new Point(12, 113);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(374, 68);
            btnSP.TabIndex = 4;
            btnSP.Text = "Sản Phẩm";
            btnSP.UseVisualStyleBackColor = true;
            // 
            // btnNhaCC
            // 
            btnNhaCC.FlatAppearance.BorderSize = 0;
            btnNhaCC.FlatStyle = FlatStyle.Flat;
            btnNhaCC.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhaCC.ForeColor = Color.White;
            btnNhaCC.Image = (Image)resources.GetObject("btnNhaCC.Image");
            btnNhaCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCC.Location = new Point(12, 220);
            btnNhaCC.Name = "btnNhaCC";
            btnNhaCC.Size = new Size(374, 68);
            btnNhaCC.TabIndex = 3;
            btnNhaCC.Text = "Nhà Cung Cấp";
            btnNhaCC.UseVisualStyleBackColor = true;
            // 
            // btnTaoDon
            // 
            btnTaoDon.FlatAppearance.BorderSize = 0;
            btnTaoDon.FlatStyle = FlatStyle.Flat;
            btnTaoDon.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoDon.ForeColor = Color.White;
            btnTaoDon.Image = (Image)resources.GetObject("btnTaoDon.Image");
            btnTaoDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoDon.Location = new Point(12, 327);
            btnTaoDon.Name = "btnTaoDon";
            btnTaoDon.Size = new Size(374, 68);
            btnTaoDon.TabIndex = 1;
            btnTaoDon.Text = "Tạo đơn";
            btnTaoDon.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.Image = (Image)resources.GetObject("btnTrangChu.Image");
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(12, 6);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(374, 68);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 204, 113);
            panel3.Controls.Add(lblTongSPDaBan);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(844, 300);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 203);
            panel3.TabIndex = 6;
            // 
            // lblTongSPDaBan
            // 
            lblTongSPDaBan.AutoSize = true;
            lblTongSPDaBan.Font = new Font("Cascadia Code", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongSPDaBan.ForeColor = Color.White;
            lblTongSPDaBan.Location = new Point(60, 122);
            lblTongSPDaBan.Name = "lblTongSPDaBan";
            lblTongSPDaBan.Size = new Size(95, 43);
            lblTongSPDaBan.TabIndex = 3;
            lblTongSPDaBan.Text = "NULL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(294, 32);
            label2.TabIndex = 1;
            label2.Text = "Tổng Sản phẩm đã bán";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(276, 76);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 152, 219);
            panel4.Controls.Add(lblTongKH);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox2);
            panel4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(1253, 300);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 203);
            panel4.TabIndex = 5;
            // 
            // lblTongKH
            // 
            lblTongKH.AutoSize = true;
            lblTongKH.Font = new Font("Cascadia Code", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongKH.ForeColor = Color.White;
            lblTongKH.Location = new Point(60, 122);
            lblTongKH.Name = "lblTongKH";
            lblTongKH.Size = new Size(95, 43);
            lblTongKH.TabIndex = 3;
            lblTongKH.Text = "NULL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(31, 28);
            label5.Name = "label5";
            label5.Size = new Size(224, 32);
            label5.TabIndex = 1;
            label5.Text = "Tổng khách hàng";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 76);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 890);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard01";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNhanVien).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Panel panel5;
        private Label lblTongDoanhThu;
        private Label label4;
        private PictureBox pictureBox11;
        private Panel panel2;
        private Panel panel3;
        private Label lblTongSPDaBan;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label lblTongKH;
        private Label label5;
        private PictureBox pictureBox2;
        private Label lblChucVu;
        private Label label6;
        private PictureBox pbNhanVien;
        private Button btnTrangChu;
        private Button btnNhanVien;
        private Button btnKhoHang;
        private Button btnSP;
        private Button btnNhaCC;
        private Button btnTaoDon;
        private Button btnThongKe;
        private Button btnThoat;
    }
}