namespace SaleApp.View
{
    partial class frmNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbTTNhapHang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbTTSP = new System.Windows.Forms.GroupBox();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTamUng = new System.Windows.Forms.TextBox();
            this.txtSoPhieuNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDSSPNhap = new System.Windows.Forms.GroupBox();
            this.dtgvDSSPNhap = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTTNhapHang.SuspendLayout();
            this.gbTTSP.SuspendLayout();
            this.gbDSSPNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSPNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(390, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Hàng ";
            // 
            // gbTTNhapHang
            // 
            this.gbTTNhapHang.Controls.Add(this.gbTTSP);
            this.gbTTNhapHang.Controls.Add(this.dtpNgayNhap);
            this.gbTTNhapHang.Controls.Add(this.txtMaNCC);
            this.gbTTNhapHang.Controls.Add(this.txtMaNV);
            this.gbTTNhapHang.Controls.Add(this.txtTamUng);
            this.gbTTNhapHang.Controls.Add(this.txtSoPhieuNhap);
            this.gbTTNhapHang.Controls.Add(this.label6);
            this.gbTTNhapHang.Controls.Add(this.label5);
            this.gbTTNhapHang.Controls.Add(this.label4);
            this.gbTTNhapHang.Controls.Add(this.label3);
            this.gbTTNhapHang.Controls.Add(this.label2);
            this.gbTTNhapHang.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTTNhapHang.Location = new System.Drawing.Point(22, 44);
            this.gbTTNhapHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTTNhapHang.Name = "gbTTNhapHang";
            this.gbTTNhapHang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTTNhapHang.Size = new System.Drawing.Size(964, 287);
            this.gbTTNhapHang.TabIndex = 1;
            this.gbTTNhapHang.TabStop = false;
            this.gbTTNhapHang.Text = "Thông tin Nhập Hàng ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(435, 84);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 37);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(435, 137);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 37);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(433, 190);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 37);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(435, 31);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 37);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // gbTTSP
            // 
            this.gbTTSP.Controls.Add(this.btnReset);
            this.gbTTSP.Controls.Add(this.btnXoa);
            this.gbTTSP.Controls.Add(this.btnSua);
            this.gbTTSP.Controls.Add(this.cbLoaiHang);
            this.gbTTSP.Controls.Add(this.txtMaSP);
            this.gbTTSP.Controls.Add(this.txtTenSP);
            this.gbTTSP.Controls.Add(this.btnThem);
            this.gbTTSP.Controls.Add(this.txtSoLuong);
            this.gbTTSP.Controls.Add(this.txtGiaNhap);
            this.gbTTSP.Controls.Add(this.label12);
            this.gbTTSP.Controls.Add(this.label10);
            this.gbTTSP.Controls.Add(this.label9);
            this.gbTTSP.Controls.Add(this.label8);
            this.gbTTSP.Controls.Add(this.label7);
            this.gbTTSP.Location = new System.Drawing.Point(368, 11);
            this.gbTTSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTTSP.Name = "gbTTSP";
            this.gbTTSP.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTTSP.Size = new System.Drawing.Size(587, 252);
            this.gbTTSP.TabIndex = 10;
            this.gbTTSP.TabStop = false;
            this.gbTTSP.Text = "Thông tin Sản phẩm";
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(132, 183);
            this.cbLoaiHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(146, 30);
            this.cbLoaiHang.TabIndex = 11;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(132, 30);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(154, 27);
            this.txtMaSP.TabIndex = 10;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(132, 68);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(154, 30);
            this.txtTenSP.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(132, 109);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(154, 27);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(132, 147);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(154, 27);
            this.txtGiaNhap.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "Loại hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số lượng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tên SP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giá nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã SP:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(159, 84);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(161, 25);
            this.dtpNgayNhap.TabIndex = 9;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(159, 120);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(154, 27);
            this.txtMaNCC.TabIndex = 8;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(159, 158);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(154, 27);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtTamUng
            // 
            this.txtTamUng.Location = new System.Drawing.Point(159, 197);
            this.txtTamUng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTamUng.Name = "txtTamUng";
            this.txtTamUng.Size = new System.Drawing.Size(154, 27);
            this.txtTamUng.TabIndex = 6;
            // 
            // txtSoPhieuNhap
            // 
            this.txtSoPhieuNhap.Location = new System.Drawing.Point(159, 41);
            this.txtSoPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoPhieuNhap.Name = "txtSoPhieuNhap";
            this.txtSoPhieuNhap.Size = new System.Drawing.Size(154, 27);
            this.txtSoPhieuNhap.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tạm ứng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NV xử lí: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Phiếu:";
            // 
            // gbDSSPNhap
            // 
            this.gbDSSPNhap.Controls.Add(this.dtgvDSSPNhap);
            this.gbDSSPNhap.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDSSPNhap.Location = new System.Drawing.Point(11, 335);
            this.gbDSSPNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDSSPNhap.Name = "gbDSSPNhap";
            this.gbDSSPNhap.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDSSPNhap.Size = new System.Drawing.Size(970, 255);
            this.gbDSSPNhap.TabIndex = 2;
            this.gbDSSPNhap.TabStop = false;
            this.gbDSSPNhap.Text = "Danh sách Sản phẩm nhập";
            // 
            // dtgvDSSPNhap
            // 
            this.dtgvDSSPNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSSPNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSPNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSP,
            this.clTenSP,
            this.clLoaiSP,
            this.clNhaCC,
            this.clSoLuong,
            this.clDonGia,
            this.clThanhTien});
            this.dtgvDSSPNhap.Location = new System.Drawing.Point(5, 29);
            this.dtgvDSSPNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvDSSPNhap.Name = "dtgvDSSPNhap";
            this.dtgvDSSPNhap.RowHeadersWidth = 62;
            this.dtgvDSSPNhap.RowTemplate.Height = 33;
            this.dtgvDSSPNhap.Size = new System.Drawing.Size(950, 222);
            this.dtgvDSSPNhap.TabIndex = 0;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 8;
            this.clSTT.Name = "clSTT";
            // 
            // clMaSP
            // 
            this.clMaSP.HeaderText = "Mã SP";
            this.clMaSP.MinimumWidth = 8;
            this.clMaSP.Name = "clMaSP";
            // 
            // clTenSP
            // 
            this.clTenSP.HeaderText = "Tên SP";
            this.clTenSP.MinimumWidth = 8;
            this.clTenSP.Name = "clTenSP";
            // 
            // clLoaiSP
            // 
            this.clLoaiSP.HeaderText = "Loại SP";
            this.clLoaiSP.MinimumWidth = 8;
            this.clLoaiSP.Name = "clLoaiSP";
            // 
            // clNhaCC
            // 
            this.clNhaCC.HeaderText = "Nhà CC";
            this.clNhaCC.MinimumWidth = 8;
            this.clNhaCC.Name = "clNhaCC";
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.MinimumWidth = 8;
            this.clSoLuong.Name = "clSoLuong";
            // 
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Đơn Giá";
            this.clDonGia.MinimumWidth = 8;
            this.clDonGia.Name = "clDonGia";
            // 
            // clThanhTien
            // 
            this.clThanhTien.HeaderText = "Thành Tiền ";
            this.clThanhTien.MinimumWidth = 8;
            this.clThanhTien.Name = "clThanhTien";
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 601);
            this.Controls.Add(this.gbDSSPNhap);
            this.Controls.Add(this.gbTTNhapHang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng ";
            this.gbTTNhapHang.ResumeLayout(false);
            this.gbTTNhapHang.PerformLayout();
            this.gbTTSP.ResumeLayout(false);
            this.gbTTSP.PerformLayout();
            this.gbDSSPNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSPNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox gbTTNhapHang;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtMaNCC;
        private TextBox txtMaNV;
        private TextBox txtTamUng;
        private TextBox txtSoPhieuNhap;
        private GroupBox gbTTSP;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnSua;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private ComboBox cbLoaiHang;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtSoLuong;
        private TextBox txtGiaNhap;
        private GroupBox gbDSSPNhap;
        private DataGridView dtgvDSSPNhap;
        private DataGridViewTextBoxColumn clSTT;
        private DataGridViewTextBoxColumn clMaSP;
        private DataGridViewTextBoxColumn clTenSP;
        private DataGridViewTextBoxColumn clLoaiSP;
        private DataGridViewTextBoxColumn clNhaCC;
        private DataGridViewTextBoxColumn clSoLuong;
        private DataGridViewTextBoxColumn clDonGia;
        private DataGridViewTextBoxColumn clThanhTien;
    }
}