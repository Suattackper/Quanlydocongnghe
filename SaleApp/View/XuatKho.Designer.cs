namespace SaleApp.View
{
    partial class frmXuatKho
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
            this.gbTTNhapHang = new System.Windows.Forms.GroupBox();
            this.gbTTSP = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLiDo = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbDSSPNhap = new System.Windows.Forms.GroupBox();
            this.dtgvDSSPXuat = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTTNhapHang.SuspendLayout();
            this.gbTTSP.SuspendLayout();
            this.gbDSSPNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSPXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTTNhapHang
            // 
            this.gbTTNhapHang.Controls.Add(this.gbTTSP);
            this.gbTTNhapHang.Controls.Add(this.txtLiDo);
            this.gbTTNhapHang.Controls.Add(this.btnXuat);
            this.gbTTNhapHang.Controls.Add(this.label6);
            this.gbTTNhapHang.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTTNhapHang.Location = new System.Drawing.Point(11, 11);
            this.gbTTNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.gbTTNhapHang.Name = "gbTTNhapHang";
            this.gbTTNhapHang.Padding = new System.Windows.Forms.Padding(2);
            this.gbTTNhapHang.Size = new System.Drawing.Size(979, 315);
            this.gbTTNhapHang.TabIndex = 2;
            this.gbTTNhapHang.TabStop = false;
            this.gbTTNhapHang.Text = "Thông tin Xuất kho ";
            // 
            // gbTTSP
            // 
            this.gbTTSP.Controls.Add(this.label7);
            this.gbTTSP.Controls.Add(this.cbSanPham);
            this.gbTTSP.Controls.Add(this.cbLoaiHang);
            this.gbTTSP.Controls.Add(this.btnReset);
            this.gbTTSP.Controls.Add(this.btnXoa);
            this.gbTTSP.Controls.Add(this.txtSoLuong);
            this.gbTTSP.Controls.Add(this.txtDonGia);
            this.gbTTSP.Controls.Add(this.btnThem);
            this.gbTTSP.Controls.Add(this.label12);
            this.gbTTSP.Controls.Add(this.label10);
            this.gbTTSP.Controls.Add(this.label8);
            this.gbTTSP.Location = new System.Drawing.Point(416, 24);
            this.gbTTSP.Margin = new System.Windows.Forms.Padding(2);
            this.gbTTSP.Name = "gbTTSP";
            this.gbTTSP.Padding = new System.Windows.Forms.Padding(2);
            this.gbTTSP.Size = new System.Drawing.Size(546, 284);
            this.gbTTSP.TabIndex = 17;
            this.gbTTSP.TabStop = false;
            this.gbTTSP.Text = "Thông tin Sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sản phẩm:";
            // 
            // cbSanPham
            // 
            this.cbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(146, 36);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(199, 30);
            this.cbSanPham.TabIndex = 0;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(146, 234);
            this.cbLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(199, 30);
            this.cbLoaiHang.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(396, 207);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 37);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(396, 140);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 37);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(146, 104);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(199, 27);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(146, 169);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(199, 27);
            this.txtDonGia.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(396, 78);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 242);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "Loại hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số lượng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Đơn giá:";
            // 
            // txtLiDo
            // 
            this.txtLiDo.Location = new System.Drawing.Point(44, 81);
            this.txtLiDo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLiDo.Multiline = true;
            this.txtLiDo.Name = "txtLiDo";
            this.txtLiDo.Size = new System.Drawing.Size(323, 162);
            this.txtLiDo.TabIndex = 0;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(92, 258);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(90, 37);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lí Do:";
            // 
            // gbDSSPNhap
            // 
            this.gbDSSPNhap.Controls.Add(this.dtgvDSSPXuat);
            this.gbDSSPNhap.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDSSPNhap.Location = new System.Drawing.Point(11, 330);
            this.gbDSSPNhap.Margin = new System.Windows.Forms.Padding(2);
            this.gbDSSPNhap.Name = "gbDSSPNhap";
            this.gbDSSPNhap.Padding = new System.Windows.Forms.Padding(2);
            this.gbDSSPNhap.Size = new System.Drawing.Size(979, 285);
            this.gbDSSPNhap.TabIndex = 3;
            this.gbDSSPNhap.TabStop = false;
            this.gbDSSPNhap.Text = "Danh sách Sản phẩm xuất ";
            // 
            // dtgvDSSPXuat
            // 
            this.dtgvDSSPXuat.AllowUserToAddRows = false;
            this.dtgvDSSPXuat.AllowUserToDeleteRows = false;
            this.dtgvDSSPXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSSPXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSPXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.clTenSP,
            this.clLoaiSP,
            this.clSoLuong,
            this.clDonGia});
            this.dtgvDSSPXuat.Location = new System.Drawing.Point(5, 29);
            this.dtgvDSSPXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDSSPXuat.Name = "dtgvDSSPXuat";
            this.dtgvDSSPXuat.ReadOnly = true;
            this.dtgvDSSPXuat.RowHeadersWidth = 62;
            this.dtgvDSSPXuat.RowTemplate.Height = 33;
            this.dtgvDSSPXuat.Size = new System.Drawing.Size(970, 252);
            this.dtgvDSSPXuat.TabIndex = 0;
            this.dtgvDSSPXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSSPXuat_CellClick);
            this.dtgvDSSPXuat.SelectionChanged += new System.EventHandler(this.dtgvDSSPXuat_SelectionChanged);
            // 
            // clMaSP
            // 
            this.clMaSP.HeaderText = "Mã SP";
            this.clMaSP.MinimumWidth = 8;
            this.clMaSP.Name = "clMaSP";
            this.clMaSP.ReadOnly = true;
            // 
            // clTenSP
            // 
            this.clTenSP.HeaderText = "Tên SP";
            this.clTenSP.MinimumWidth = 8;
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.ReadOnly = true;
            // 
            // clLoaiSP
            // 
            this.clLoaiSP.HeaderText = "Loại SP";
            this.clLoaiSP.MinimumWidth = 8;
            this.clLoaiSP.Name = "clLoaiSP";
            this.clLoaiSP.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.MinimumWidth = 8;
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Đơn Giá";
            this.clDonGia.MinimumWidth = 8;
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            // 
            // frmXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 618);
            this.Controls.Add(this.gbDSSPNhap);
            this.Controls.Add(this.gbTTNhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmXuatKho";
            this.Text = "XuatKho";
            this.Load += new System.EventHandler(this.frmXuatKho_Load);
            this.gbTTNhapHang.ResumeLayout(false);
            this.gbTTNhapHang.PerformLayout();
            this.gbTTSP.ResumeLayout(false);
            this.gbTTSP.PerformLayout();
            this.gbDSSPNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSPXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbTTNhapHang;
        private Button btnXuat;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private Label label6;
        private GroupBox gbDSSPNhap;
        private DataGridView dtgvDSSPXuat;
        private TextBox txtLiDo;
        private GroupBox gbTTSP;
        private ComboBox cbLoaiHang;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Label label12;
        private Label label10;
        private Label label8;
        private ComboBox cbSanPham;
        private Label label7;
        private DataGridViewTextBoxColumn clMaSP;
        private DataGridViewTextBoxColumn clTenSP;
        private DataGridViewTextBoxColumn clLoaiSP;
        private DataGridViewTextBoxColumn clSoLuong;
        private DataGridViewTextBoxColumn clDonGia;
    }
}