namespace SaleApp.View
{
    partial class XuatKho
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
            gbTTNhapHang = new GroupBox();
            dtpNgayXuat = new DateTimePicker();
            gbTTSP = new GroupBox();
            cbLoaiHang = new ComboBox();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtSoLuong = new TextBox();
            txtGiaTien = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtLiDo = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            btnThem = new Button();
            txtMaNV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            gbDSSPNhap = new GroupBox();
            dtgvDSSPNhap = new DataGridView();
            clSTT = new DataGridViewTextBoxColumn();
            clMaSP = new DataGridViewTextBoxColumn();
            clTenSP = new DataGridViewTextBoxColumn();
            clLoaiSP = new DataGridViewTextBoxColumn();
            clMaNV = new DataGridViewTextBoxColumn();
            clLiDo = new DataGridViewTextBoxColumn();
            clSoLuong = new DataGridViewTextBoxColumn();
            clDonGia = new DataGridViewTextBoxColumn();
            txtSoPhieuXuat = new TextBox();
            gbTTNhapHang.SuspendLayout();
            gbTTSP.SuspendLayout();
            gbDSSPNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDSSPNhap).BeginInit();
            SuspendLayout();
            // 
            // gbTTNhapHang
            // 
            gbTTNhapHang.Controls.Add(txtSoPhieuXuat);
            gbTTNhapHang.Controls.Add(dtpNgayXuat);
            gbTTNhapHang.Controls.Add(gbTTSP);
            gbTTNhapHang.Controls.Add(txtLiDo);
            gbTTNhapHang.Controls.Add(btnSua);
            gbTTNhapHang.Controls.Add(btnXoa);
            gbTTNhapHang.Controls.Add(btnReset);
            gbTTNhapHang.Controls.Add(btnThem);
            gbTTNhapHang.Controls.Add(txtMaNV);
            gbTTNhapHang.Controls.Add(label6);
            gbTTNhapHang.Controls.Add(label5);
            gbTTNhapHang.Controls.Add(label4);
            gbTTNhapHang.Controls.Add(label2);
            gbTTNhapHang.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbTTNhapHang.Location = new Point(30, 45);
            gbTTNhapHang.Name = "gbTTNhapHang";
            gbTTNhapHang.Size = new Size(1302, 477);
            gbTTNhapHang.TabIndex = 2;
            gbTTNhapHang.TabStop = false;
            gbTTNhapHang.Text = "Thông tin Xuất kho ";
            // 
            // dtpNgayXuat
            // 
            dtpNgayXuat.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayXuat.Format = DateTimePickerFormat.Short;
            dtpNgayXuat.Location = new Point(157, 119);
            dtpNgayXuat.Name = "dtpNgayXuat";
            dtpNgayXuat.Size = new Size(225, 28);
            dtpNgayXuat.TabIndex = 18;
            // 
            // gbTTSP
            // 
            gbTTSP.Controls.Add(cbLoaiHang);
            gbTTSP.Controls.Add(txtMaSP);
            gbTTSP.Controls.Add(txtTenSP);
            gbTTSP.Controls.Add(txtSoLuong);
            gbTTSP.Controls.Add(txtGiaTien);
            gbTTSP.Controls.Add(label12);
            gbTTSP.Controls.Add(label10);
            gbTTSP.Controls.Add(label9);
            gbTTSP.Controls.Add(label8);
            gbTTSP.Controls.Add(label7);
            gbTTSP.Location = new Point(401, 30);
            gbTTSP.Name = "gbTTSP";
            gbTTSP.Size = new Size(584, 370);
            gbTTSP.TabIndex = 17;
            gbTTSP.TabStop = false;
            gbTTSP.Text = "Thông tin Sản phẩm";
            // 
            // cbLoaiHang
            // 
            cbLoaiHang.FormattingEnabled = true;
            cbLoaiHang.Location = new Point(176, 286);
            cbLoaiHang.Name = "cbLoaiHang";
            cbLoaiHang.Size = new Size(182, 35);
            cbLoaiHang.TabIndex = 11;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(131, 59);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(191, 31);
            txtMaSP.TabIndex = 10;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(131, 106);
            txtTenSP.Multiline = true;
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(275, 44);
            txtTenSP.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(179, 170);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(191, 31);
            txtSoLuong.TabIndex = 8;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(167, 231);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(191, 31);
            txtGiaTien.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 286);
            label12.Name = "label12";
            label12.Size = new Size(132, 27);
            label12.TabIndex = 6;
            label12.Text = "Loại hàng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 168);
            label10.Name = "label10";
            label10.Size = new Size(132, 27);
            label10.TabIndex = 4;
            label10.Text = "Số lượng :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 109);
            label9.Name = "label9";
            label9.Size = new Size(96, 27);
            label9.TabIndex = 3;
            label9.Text = "Tên SP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 231);
            label8.Name = "label8";
            label8.Size = new Size(108, 27);
            label8.TabIndex = 2;
            label8.Text = "Đơn giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 59);
            label7.Name = "label7";
            label7.Size = new Size(84, 27);
            label7.TabIndex = 1;
            label7.Text = "Mã SP:";
            // 
            // txtLiDo
            // 
            txtLiDo.Location = new Point(109, 245);
            txtLiDo.Multiline = true;
            txtLiDo.Name = "txtLiDo";
            txtLiDo.Size = new Size(273, 181);
            txtLiDo.TabIndex = 16;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 122, 204);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(611, 410);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 46);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 122, 204);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(738, 410);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 46);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 122, 204);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(866, 410);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(119, 46);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 122, 204);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(482, 410);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 46);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(191, 184);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(191, 31);
            txtMaNV.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 299);
            label6.Name = "label6";
            label6.Size = new Size(84, 27);
            label6.TabIndex = 4;
            label6.Text = "Lí Do:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 116);
            label5.Name = "label5";
            label5.Size = new Size(132, 27);
            label5.TabIndex = 3;
            label5.Text = "Ngày xuất:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 182);
            label4.Name = "label4";
            label4.Size = new Size(168, 27);
            label4.TabIndex = 2;
            label4.Text = "Mã Nhân Viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 57);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 0;
            label2.Text = "Số Phiếu Xuất:";
            // 
            // gbDSSPNhap
            // 
            gbDSSPNhap.Controls.Add(dtgvDSSPNhap);
            gbDSSPNhap.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbDSSPNhap.Location = new Point(30, 539);
            gbDSSPNhap.Name = "gbDSSPNhap";
            gbDSSPNhap.Size = new Size(1337, 251);
            gbDSSPNhap.TabIndex = 3;
            gbDSSPNhap.TabStop = false;
            gbDSSPNhap.Text = "Danh sách Sản phẩm xuất ";
            // 
            // dtgvDSSPNhap
            // 
            dtgvDSSPNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDSSPNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDSSPNhap.Columns.AddRange(new DataGridViewColumn[] { clSTT, clMaSP, clTenSP, clLoaiSP, clMaNV, clLiDo, clSoLuong, clDonGia });
            dtgvDSSPNhap.Location = new Point(6, 36);
            dtgvDSSPNhap.Name = "dtgvDSSPNhap";
            dtgvDSSPNhap.RowHeadersWidth = 62;
            dtgvDSSPNhap.RowTemplate.Height = 33;
            dtgvDSSPNhap.Size = new Size(1310, 209);
            dtgvDSSPNhap.TabIndex = 0;
            // 
            // clSTT
            // 
            clSTT.HeaderText = "STT";
            clSTT.MinimumWidth = 8;
            clSTT.Name = "clSTT";
            // 
            // clMaSP
            // 
            clMaSP.HeaderText = "Mã SP";
            clMaSP.MinimumWidth = 8;
            clMaSP.Name = "clMaSP";
            // 
            // clTenSP
            // 
            clTenSP.HeaderText = "Tên SP";
            clTenSP.MinimumWidth = 8;
            clTenSP.Name = "clTenSP";
            // 
            // clLoaiSP
            // 
            clLoaiSP.HeaderText = "Loại SP";
            clLoaiSP.MinimumWidth = 8;
            clLoaiSP.Name = "clLoaiSP";
            // 
            // clMaNV
            // 
            clMaNV.HeaderText = "Mã NV";
            clMaNV.MinimumWidth = 8;
            clMaNV.Name = "clMaNV";
            // 
            // clLiDo
            // 
            clLiDo.HeaderText = "Lí Do";
            clLiDo.MinimumWidth = 8;
            clLiDo.Name = "clLiDo";
            // 
            // clSoLuong
            // 
            clSoLuong.HeaderText = "Số Lượng";
            clSoLuong.MinimumWidth = 8;
            clSoLuong.Name = "clSoLuong";
            // 
            // clDonGia
            // 
            clDonGia.HeaderText = "Đơn Giá";
            clDonGia.MinimumWidth = 8;
            clDonGia.Name = "clDonGia";
            // 
            // txtSoPhieuXuat
            // 
            txtSoPhieuXuat.Location = new Point(205, 57);
            txtSoPhieuXuat.Name = "txtSoPhieuXuat";
            txtSoPhieuXuat.Size = new Size(177, 31);
            txtSoPhieuXuat.TabIndex = 19;
            // 
            // XuatKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 802);
            Controls.Add(gbDSSPNhap);
            Controls.Add(gbTTNhapHang);
            Name = "XuatKho";
            Text = "XuatKho";
            gbTTNhapHang.ResumeLayout(false);
            gbTTNhapHang.PerformLayout();
            gbTTSP.ResumeLayout(false);
            gbTTSP.PerformLayout();
            gbDSSPNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDSSPNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTTNhapHang;
        private Button btnSua;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private TextBox txtMaNV;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox gbDSSPNhap;
        private DataGridView dtgvDSSPNhap;
        private TextBox txtLiDo;
        private Label label2;
        private GroupBox gbTTSP;
        private ComboBox cbLoaiHang;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtSoLuong;
        private TextBox txtGiaTien;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridViewTextBoxColumn clSTT;
        private DataGridViewTextBoxColumn clMaSP;
        private DataGridViewTextBoxColumn clTenSP;
        private DataGridViewTextBoxColumn clLoaiSP;
        private DataGridViewTextBoxColumn clMaNV;
        private DataGridViewTextBoxColumn clLiDo;
        private DataGridViewTextBoxColumn clSoLuong;
        private DataGridViewTextBoxColumn clDonGia;
        private DateTimePicker dtpNgayXuat;
        private TextBox txtSoPhieuXuat;
    }
}