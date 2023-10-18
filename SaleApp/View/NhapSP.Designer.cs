namespace SaleApp.View
{
    partial class frmNhapSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapSP));
            lblNhapSP = new Label();
            groupBox1 = new GroupBox();
            pbHInhAnh = new PictureBox();
            label2 = new Label();
            cbHienThiHinhAnh = new ComboBox();
            gbThongTin = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMaSP = new TextBox();
            txtMaLoai = new TextBox();
            txtTenSP = new TextBox();
            txtMaNCC = new TextBox();
            txtGia = new TextBox();
            cbLoaiSP = new ComboBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            btnThem = new Button();
            gbDanhSachSP = new GroupBox();
            dtgvDSSP = new DataGridView();
            clMaSP = new DataGridViewTextBoxColumn();
            clMaNCC = new DataGridViewTextBoxColumn();
            clTenSP = new DataGridViewTextBoxColumn();
            clLoaiSP = new DataGridViewTextBoxColumn();
            clGia = new DataGridViewTextBoxColumn();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHInhAnh).BeginInit();
            gbThongTin.SuspendLayout();
            gbDanhSachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDSSP).BeginInit();
            SuspendLayout();
            // 
            // lblNhapSP
            // 
            lblNhapSP.AutoSize = true;
            lblNhapSP.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblNhapSP.Location = new Point(591, 19);
            lblNhapSP.Name = "lblNhapSP";
            lblNhapSP.Size = new Size(241, 37);
            lblNhapSP.TabIndex = 0;
            lblNhapSP.Text = "Nhập Sản Phẩm ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbHienThiHinhAnh);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pbHInhAnh);
            groupBox1.Font = new Font("Cascadia Code SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(145, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 325);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hình ảnh ";
            // 
            // pbHInhAnh
            // 
            pbHInhAnh.Location = new Point(6, 30);
            pbHInhAnh.Name = "pbHInhAnh";
            pbHInhAnh.Size = new Size(376, 227);
            pbHInhAnh.TabIndex = 0;
            pbHInhAnh.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 275);
            label2.Name = "label2";
            label2.Size = new Size(208, 24);
            label2.TabIndex = 1;
            label2.Text = "Hiển thị hình ảnh:";
            // 
            // cbHienThiHinhAnh
            // 
            cbHienThiHinhAnh.FormattingEnabled = true;
            cbHienThiHinhAnh.Location = new Point(206, 271);
            cbHienThiHinhAnh.Name = "cbHienThiHinhAnh";
            cbHienThiHinhAnh.Size = new Size(158, 35);
            cbHienThiHinhAnh.TabIndex = 2;
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(btnSua);
            gbThongTin.Controls.Add(btnXoa);
            gbThongTin.Controls.Add(btnReset);
            gbThongTin.Controls.Add(btnThem);
            gbThongTin.Controls.Add(cbLoaiSP);
            gbThongTin.Controls.Add(txtGia);
            gbThongTin.Controls.Add(txtMaNCC);
            gbThongTin.Controls.Add(txtTenSP);
            gbThongTin.Controls.Add(txtMaLoai);
            gbThongTin.Controls.Add(txtMaSP);
            gbThongTin.Controls.Add(label8);
            gbThongTin.Controls.Add(label7);
            gbThongTin.Controls.Add(label6);
            gbThongTin.Controls.Add(label5);
            gbThongTin.Controls.Add(label4);
            gbThongTin.Controls.Add(label3);
            gbThongTin.Font = new Font("Cascadia Code SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbThongTin.ForeColor = Color.Black;
            gbThongTin.Location = new Point(675, 82);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Size = new Size(571, 471);
            gbThongTin.TabIndex = 2;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 49);
            label3.Name = "label3";
            label3.Size = new Size(156, 27);
            label3.TabIndex = 0;
            label3.Text = "Mã sản phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 279);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 1;
            label4.Text = "Mã NCC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 160);
            label5.Name = "label5";
            label5.Size = new Size(108, 27);
            label5.TabIndex = 2;
            label5.Text = "Mã loại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 215);
            label6.Name = "label6";
            label6.Size = new Size(180, 27);
            label6.TabIndex = 3;
            label6.Text = "Loại sản phẩm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 105);
            label7.Name = "label7";
            label7.Size = new Size(168, 27);
            label7.TabIndex = 4;
            label7.Text = "Tên sản phẩm:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 339);
            label8.Name = "label8";
            label8.Size = new Size(108, 27);
            label8.TabIndex = 5;
            label8.Text = "Giá bán:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(180, 49);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(150, 31);
            txtMaSP.TabIndex = 6;
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(132, 160);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(150, 31);
            txtMaLoai.TabIndex = 7;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(192, 95);
            txtTenSP.Multiline = true;
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(291, 41);
            txtTenSP.TabIndex = 8;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(132, 279);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(150, 31);
            txtMaNCC.TabIndex = 9;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(132, 339);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(150, 31);
            txtGia.TabIndex = 10;
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(192, 212);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(182, 35);
            cbLoaiSP.TabIndex = 11;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 122, 204);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(160, 403);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 46);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 122, 204);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(312, 403);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 46);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 122, 204);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(462, 403);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(103, 46);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 122, 204);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(18, 403);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 46);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // gbDanhSachSP
            // 
            gbDanhSachSP.Controls.Add(dtgvDSSP);
            gbDanhSachSP.Font = new Font("Cascadia Code SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            gbDanhSachSP.Location = new Point(27, 559);
            gbDanhSachSP.Name = "gbDanhSachSP";
            gbDanhSachSP.Size = new Size(1303, 300);
            gbDanhSachSP.TabIndex = 3;
            gbDanhSachSP.TabStop = false;
            gbDanhSachSP.Text = "Danh sách SP";
            gbDanhSachSP.Enter += gbDanhSachSP_Enter;
            // 
            // dtgvDSSP
            // 
            dtgvDSSP.AllowUserToResizeColumns = false;
            dtgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDSSP.BackgroundColor = SystemColors.Control;
            dtgvDSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDSSP.Columns.AddRange(new DataGridViewColumn[] { clMaSP, clMaNCC, clTenSP, clLoaiSP, clGia });
            dtgvDSSP.GridColor = Color.FromArgb(224, 224, 224);
            dtgvDSSP.Location = new Point(11, 32);
            dtgvDSSP.Name = "dtgvDSSP";
            dtgvDSSP.RowHeadersWidth = 62;
            dtgvDSSP.RowTemplate.Height = 33;
            dtgvDSSP.Size = new Size(1277, 262);
            dtgvDSSP.TabIndex = 0;
            // 
            // clMaSP
            // 
            clMaSP.HeaderText = "Mã SP";
            clMaSP.MinimumWidth = 8;
            clMaSP.Name = "clMaSP";
            // 
            // clMaNCC
            // 
            clMaNCC.HeaderText = "Mã NCC";
            clMaNCC.MinimumWidth = 8;
            clMaNCC.Name = "clMaNCC";
            // 
            // clTenSP
            // 
            clTenSP.HeaderText = "Tên SP";
            clTenSP.MinimumWidth = 8;
            clTenSP.Name = "clTenSP";
            // 
            // clLoaiSP
            // 
            clLoaiSP.HeaderText = "Loại SP ";
            clLoaiSP.MinimumWidth = 8;
            clLoaiSP.Name = "clLoaiSP";
            // 
            // clGia
            // 
            clGia.HeaderText = "Giá bán ";
            clGia.MinimumWidth = 8;
            clGia.Name = "clGia";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Cascadia Code Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.ForeColor = SystemColors.WindowFrame;
            txtTimKiem.Location = new Point(143, 442);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(390, 65);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.Text = "Tìm kiếm ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(487, 457);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(40, 40);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.UseCompatibleTextRendering = true;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmNhapSP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 871);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(gbDanhSachSP);
            Controls.Add(gbThongTin);
            Controls.Add(groupBox1);
            Controls.Add(lblNhapSP);
            Name = "frmNhapSP";
            Text = "NhapSP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHInhAnh).EndInit();
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            gbDanhSachSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDSSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapSP;
        private GroupBox groupBox1;
        private ComboBox cbHienThiHinhAnh;
        private Label label2;
        private PictureBox pbHInhAnh;
        private GroupBox gbThongTin;
        private Label label3;
        private ComboBox cbLoaiSP;
        private TextBox txtGia;
        private TextBox txtMaNCC;
        private TextBox txtTenSP;
        private TextBox txtMaLoai;
        private TextBox txtMaSP;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnSua;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private GroupBox gbDanhSachSP;
        private DataGridView dtgvDSSP;
        private DataGridViewTextBoxColumn clMaSP;
        private DataGridViewTextBoxColumn clMaNCC;
        private DataGridViewTextBoxColumn clTenSP;
        private DataGridViewTextBoxColumn clLoaiSP;
        private DataGridViewTextBoxColumn clGia;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}