
namespace SaleApp
{
    partial class DonHang
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
            gbTTSP = new GroupBox();
            panel1 = new Panel();
            btnSua = new Button();
            btnReset = new Button();
            btnXoa = new Button();
            btnThemDS = new Button();
            label12 = new Label();
            txtDonGia = new TextBox();
            txtTenSP = new TextBox();
            txtSoLuong = new TextBox();
            txtMaSP = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtTTKhachHang = new GroupBox();
            btnThem = new Button();
            label9 = new Label();
            txtTongTien = new TextBox();
            txtMaNV = new TextBox();
            label8 = new Label();
            dtpNgayTao = new DateTimePicker();
            label7 = new Label();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            txtMaKH = new TextBox();
            txtMaDH = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnInDon = new Button();
            btnHuyDon = new Button();
            gbTTSP.SuspendLayout();
            panel1.SuspendLayout();
            txtTTKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // gbTTSP
            // 
            gbTTSP.Controls.Add(panel1);
            gbTTSP.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbTTSP.Location = new Point(30, 298);
            gbTTSP.Name = "gbTTSP";
            gbTTSP.Size = new Size(1059, 334);
            gbTTSP.TabIndex = 1;
            gbTTSP.TabStop = false;
            gbTTSP.Text = "Thông tin Sản phẩm";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThemDS);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(txtMaSP);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(27, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 261);
            panel1.TabIndex = 1;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 122, 204);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(525, 83);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(181, 53);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 122, 204);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(525, 202);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(181, 53);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 122, 204);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(525, 142);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(181, 54);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThemDS
            // 
            btnThemDS.BackColor = Color.FromArgb(0, 122, 204);
            btnThemDS.FlatStyle = FlatStyle.Flat;
            btnThemDS.ForeColor = Color.White;
            btnThemDS.Location = new Point(525, 23);
            btnThemDS.Name = "btnThemDS";
            btnThemDS.Size = new Size(181, 54);
            btnThemDS.TabIndex = 9;
            btnThemDS.Text = "Thêm vào DS";
            btnThemDS.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(75, 151);
            label12.Name = "label12";
            label12.Size = new Size(92, 23);
            label12.TabIndex = 8;
            label12.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(173, 205);
            txtDonGia.Multiline = true;
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(182, 38);
            txtDonGia.TabIndex = 7;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(175, 83);
            txtTenSP.Multiline = true;
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(230, 43);
            txtTenSP.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(175, 148);
            txtSoLuong.Multiline = true;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(147, 35);
            txtSoLuong.TabIndex = 5;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(173, 13);
            txtMaSP.Multiline = true;
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(182, 46);
            txtMaSP.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 92);
            label13.Name = "label13";
            label13.Size = new Size(145, 23);
            label13.TabIndex = 3;
            label13.Text = "Tên Sản Phẩm:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 208);
            label11.Name = "label11";
            label11.Size = new Size(90, 23);
            label11.TabIndex = 1;
            label11.Text = "Đơn giá:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 23);
            label10.Name = "label10";
            label10.Size = new Size(143, 23);
            label10.TabIndex = 0;
            label10.Text = "Mã Sản Phẩm:";
            // 
            // txtTTKhachHang
            // 
            txtTTKhachHang.Controls.Add(btnThem);
            txtTTKhachHang.Controls.Add(label9);
            txtTTKhachHang.Controls.Add(txtTongTien);
            txtTTKhachHang.Controls.Add(txtMaNV);
            txtTTKhachHang.Controls.Add(label8);
            txtTTKhachHang.Controls.Add(dtpNgayTao);
            txtTTKhachHang.Controls.Add(label7);
            txtTTKhachHang.Controls.Add(txtEmail);
            txtTTKhachHang.Controls.Add(txtSDT);
            txtTTKhachHang.Controls.Add(txtDiaChi);
            txtTTKhachHang.Controls.Add(label6);
            txtTTKhachHang.Controls.Add(label5);
            txtTTKhachHang.Controls.Add(label3);
            txtTTKhachHang.Controls.Add(txtHoTen);
            txtTTKhachHang.Controls.Add(txtMaKH);
            txtTTKhachHang.Controls.Add(txtMaDH);
            txtTTKhachHang.Controls.Add(label4);
            txtTTKhachHang.Controls.Add(label2);
            txtTTKhachHang.Controls.Add(label1);
            txtTTKhachHang.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTTKhachHang.Location = new Point(12, 12);
            txtTTKhachHang.Name = "txtTTKhachHang";
            txtTTKhachHang.Size = new Size(1364, 255);
            txtTTKhachHang.TabIndex = 0;
            txtTTKhachHang.TabStop = false;
            txtTTKhachHang.Text = "Thông tin Khách hàng ";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 122, 204);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(1021, 166);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(145, 44);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(785, 110);
            label9.Name = "label9";
            label9.Size = new Size(93, 22);
            label9.TabIndex = 20;
            label9.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(984, 94);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(247, 38);
            txtTongTien.TabIndex = 19;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(984, 36);
            txtMaNV.Multiline = true;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(247, 38);
            txtMaNV.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(785, 41);
            label8.Name = "label8";
            label8.Size = new Size(184, 22);
            label8.TabIndex = 16;
            label8.Text = "Mã Nhân Viên Xử Lí:";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Format = DateTimePickerFormat.Short;
            dtpNgayTao.Location = new Point(477, 194);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(243, 32);
            dtpNgayTao.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(375, 200);
            label7.Name = "label7";
            label7.Size = new Size(96, 22);
            label7.TabIndex = 14;
            label7.Text = "Thời Gian:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(477, 139);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 35);
            txtEmail.TabIndex = 12;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(477, 92);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(193, 35);
            txtSDT.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(477, 36);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(282, 38);
            txtDiaChi.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(410, 150);
            label6.Name = "label6";
            label6.Size = new Size(61, 22);
            label6.TabIndex = 9;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(426, 94);
            label5.Name = "label5";
            label5.Size = new Size(45, 22);
            label5.TabIndex = 8;
            label5.Text = "SDT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(391, 41);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 7;
            label3.Text = "Địa Chỉ:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(98, 184);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(265, 42);
            txtHoTen.TabIndex = 6;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(169, 135);
            txtMaKH.Multiline = true;
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(193, 35);
            txtMaKH.TabIndex = 5;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(169, 79);
            txtMaDH.Multiline = true;
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(193, 35);
            txtMaDH.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 194);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 3;
            label4.Text = "Họ Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 139);
            label2.Name = "label2";
            label2.Size = new Size(157, 22);
            label2.TabIndex = 1;
            label2.Text = "Mã Khách Hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 92);
            label1.Name = "label1";
            label1.Size = new Size(135, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã Đơn Hàng:";
            // 
            // btnInDon
            // 
            btnInDon.BackColor = Color.FromArgb(0, 122, 204);
            btnInDon.FlatStyle = FlatStyle.Flat;
            btnInDon.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnInDon.ForeColor = Color.White;
            btnInDon.Location = new Point(272, 645);
            btnInDon.Name = "btnInDon";
            btnInDon.Size = new Size(244, 63);
            btnInDon.TabIndex = 11;
            btnInDon.Text = "In Đơn Hàng";
            btnInDon.UseVisualStyleBackColor = false;
            // 
            // btnHuyDon
            // 
            btnHuyDon.BackColor = Color.FromArgb(0, 122, 204);
            btnHuyDon.FlatStyle = FlatStyle.Flat;
            btnHuyDon.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyDon.ForeColor = Color.White;
            btnHuyDon.Location = new Point(549, 645);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.Size = new Size(160, 63);
            btnHuyDon.TabIndex = 14;
            btnHuyDon.Text = "Hủy Đơn";
            btnHuyDon.UseVisualStyleBackColor = false;
            // 
            // DonHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 720);
            Controls.Add(btnHuyDon);
            Controls.Add(btnInDon);
            Controls.Add(txtTTKhachHang);
            Controls.Add(gbTTSP);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DonHang";
            gbTTSP.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            txtTTKhachHang.ResumeLayout(false);
            txtTTKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbTTSP;
        private GroupBox txtTTKhachHang;
        private Label label9;
        private TextBox txtTongTien;
        private TextBox txtMaNV;
        private Label label8;
        private DateTimePicker dtpNgayTao;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtHoTen;
        private TextBox txtMaKH;
        private TextBox txtMaDH;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnThem;
        private Panel panel1;
        private TextBox txtDonGia;
        private TextBox txtTenSP;
        private TextBox txtSoLuong;
        private TextBox txtMaSP;
        private Label label13;
        private Label label11;
        private Label label10;
        private Button btnReset;
        private Button btnXoa;
        private Button btnThemDS;
        private Label label12;
        private Button btnSua;
        private Button btnInDon;
        private Button btnHuyDon;
    }
}