namespace SaleApp
{
    partial class frmChiTietDon
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
            lblChiTietDon = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            gbThongTinKH = new GroupBox();
            txtDC = new TextBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label2 = new Label();
            txtMaD = new TextBox();
            label8 = new Label();
            txtMaNV = new TextBox();
            gbDSCTHD = new GroupBox();
            dtgrvHienThiListSPChon = new DataGridView();
            clMaSP = new DataGridViewTextBoxColumn();
            clTenSP = new DataGridViewTextBoxColumn();
            clSoLuong = new DataGridViewTextBoxColumn();
            clGiaTien = new DataGridViewTextBoxColumn();
            clThanhTien = new DataGridViewTextBoxColumn();
            gbThongTinKH.SuspendLayout();
            gbDSCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrvHienThiListSPChon).BeginInit();
            SuspendLayout();
            // 
            // lblChiTietDon
            // 
            lblChiTietDon.AutoSize = true;
            lblChiTietDon.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblChiTietDon.Location = new Point(431, 28);
            lblChiTietDon.Name = "lblChiTietDon";
            lblChiTietDon.Size = new Size(289, 37);
            lblChiTietDon.TabIndex = 0;
            lblChiTietDon.Text = "Chi Tiết Đơn Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(216, 126);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 1;
            label1.Text = "Mã Đơn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(361, 58);
            label4.Name = "label4";
            label4.Size = new Size(120, 24);
            label4.TabIndex = 4;
            label4.Text = "Họ và tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(115, 120);
            label5.Name = "label5";
            label5.Size = new Size(54, 24);
            label5.TabIndex = 5;
            label5.Text = "SDT:";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 58);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 6;
            label3.Text = "Mã Khách Hàng:";
            // 
            // gbThongTinKH
            // 
            gbThongTinKH.Controls.Add(txtDC);
            gbThongTinKH.Controls.Add(txtSDT);
            gbThongTinKH.Controls.Add(txtTenKH);
            gbThongTinKH.Controls.Add(txtMaKH);
            gbThongTinKH.Controls.Add(label2);
            gbThongTinKH.Controls.Add(label4);
            gbThongTinKH.Controls.Add(label3);
            gbThongTinKH.Controls.Add(label5);
            gbThongTinKH.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbThongTinKH.Location = new Point(112, 183);
            gbThongTinKH.Name = "gbThongTinKH";
            gbThongTinKH.Size = new Size(706, 202);
            gbThongTinKH.TabIndex = 7;
            gbThongTinKH.TabStop = false;
            gbThongTinKH.Text = "Thông tin khách hàng:";
            // 
            // txtDC
            // 
            txtDC.Location = new Point(465, 113);
            txtDC.Multiline = true;
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(222, 42);
            txtDC.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(185, 123);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(150, 28);
            txtSDT.TabIndex = 10;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(478, 53);
            txtTenKH.Multiline = true;
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(222, 42);
            txtTenKH.TabIndex = 9;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(185, 53);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(150, 28);
            txtMaKH.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(361, 120);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 7;
            label2.Text = "Địa Chỉ:";
            // 
            // txtMaD
            // 
            txtMaD.Location = new Point(312, 122);
            txtMaD.Name = "txtMaD";
            txtMaD.Size = new Size(150, 31);
            txtMaD.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(592, 127);
            label8.Name = "label8";
            label8.Size = new Size(240, 27);
            label8.TabIndex = 17;
            label8.Text = "Mã Nhân Viên Xử Lí:";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(838, 126);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(150, 31);
            txtMaNV.TabIndex = 18;
            // 
            // gbDSCTHD
            // 
            gbDSCTHD.Controls.Add(dtgrvHienThiListSPChon);
            gbDSCTHD.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbDSCTHD.Location = new Point(59, 402);
            gbDSCTHD.Name = "gbDSCTHD";
            gbDSCTHD.Size = new Size(1065, 275);
            gbDSCTHD.TabIndex = 19;
            gbDSCTHD.TabStop = false;
            gbDSCTHD.Text = "Dach Sách Chi tiết Hóa đơn ";
            // 
            // dtgrvHienThiListSPChon
            // 
            dtgrvHienThiListSPChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrvHienThiListSPChon.BackgroundColor = SystemColors.Control;
            dtgrvHienThiListSPChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrvHienThiListSPChon.Columns.AddRange(new DataGridViewColumn[] { clMaSP, clTenSP, clSoLuong, clGiaTien, clThanhTien });
            dtgrvHienThiListSPChon.Location = new Point(6, 30);
            dtgrvHienThiListSPChon.Name = "dtgrvHienThiListSPChon";
            dtgrvHienThiListSPChon.RowHeadersWidth = 62;
            dtgrvHienThiListSPChon.RowTemplate.Height = 33;
            dtgrvHienThiListSPChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrvHienThiListSPChon.Size = new Size(1053, 239);
            dtgrvHienThiListSPChon.TabIndex = 20;
            // 
            // clMaSP
            // 
            clMaSP.HeaderText = "Mã Sản Phẩm";
            clMaSP.MinimumWidth = 8;
            clMaSP.Name = "clMaSP";
            // 
            // clTenSP
            // 
            clTenSP.HeaderText = "Tên Sản Phẩm";
            clTenSP.MinimumWidth = 8;
            clTenSP.Name = "clTenSP";
            // 
            // clSoLuong
            // 
            clSoLuong.HeaderText = "Số Lượng";
            clSoLuong.MinimumWidth = 8;
            clSoLuong.Name = "clSoLuong";
            // 
            // clGiaTien
            // 
            clGiaTien.HeaderText = "Giá Tiền";
            clGiaTien.MinimumWidth = 8;
            clGiaTien.Name = "clGiaTien";
            // 
            // clThanhTien
            // 
            clThanhTien.HeaderText = "Thành Tiền";
            clThanhTien.MinimumWidth = 8;
            clThanhTien.Name = "clThanhTien";
            // 
            // frmChiTietDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 689);
            Controls.Add(gbDSCTHD);
            Controls.Add(txtMaNV);
            Controls.Add(label8);
            Controls.Add(txtMaD);
            Controls.Add(gbThongTinKH);
            Controls.Add(label1);
            Controls.Add(lblChiTietDon);
            Name = "frmChiTietDon";
            Text = "ChiTietDon";
            gbThongTinKH.ResumeLayout(false);
            gbThongTinKH.PerformLayout();
            gbDSCTHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgrvHienThiListSPChon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChiTietDon;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label3;
        private GroupBox gbThongTinKH;
        private Label label2;
        private TextBox txtDC;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private TextBox txtMaD;
        private Label label8;
        private TextBox txtMaNV;
        private GroupBox gbDSCTHD;
        private DataGridView dtgrvHienThiListSPChon;
        private DataGridViewTextBoxColumn clMaSP;
        private DataGridViewTextBoxColumn clTenSP;
        private DataGridViewTextBoxColumn clSoLuong;
        private DataGridViewTextBoxColumn clGiaTien;
        private DataGridViewTextBoxColumn clThanhTien;
    }
}