namespace SaleApp
{
    partial class ChiTietDon
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            txtDC = new TextBox();
            txtMaD = new TextBox();
            label8 = new Label();
            txtMaNV = new TextBox();
            dtgrvHienThiListSPChon = new DataGridView();
            clMaSP = new DataGridViewTextBoxColumn();
            clTenSP = new DataGridViewTextBoxColumn();
            clSoLuong = new DataGridViewTextBoxColumn();
            clGiaTien = new DataGridViewTextBoxColumn();
            clThanhTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrvHienThiListSPChon).BeginInit();
            SuspendLayout();
            // 
            // lblChiTietDon
            // 
            lblChiTietDon.AutoSize = true;
            lblChiTietDon.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblChiTietDon.Location = new Point(367, 28);
            lblChiTietDon.Name = "lblChiTietDon";
            lblChiTietDon.Size = new Size(287, 38);
            lblChiTietDon.TabIndex = 0;
            lblChiTietDon.Text = "Chi Tiết Đơn Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(216, 126);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã Đơn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(361, 58);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 4;
            label4.Text = "Họ và tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(115, 120);
            label5.Name = "label5";
            label5.Size = new Size(45, 22);
            label5.TabIndex = 5;
            label5.Text = "SDT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 58);
            label3.Name = "label3";
            label3.Size = new Size(157, 22);
            label3.TabIndex = 6;
            label3.Text = "Mã Khách Hàng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDC);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(112, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 202);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(361, 120);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 7;
            label2.Text = "Địa Chỉ:";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(185, 53);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(150, 32);
            txtMaKH.TabIndex = 8;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(465, 43);
            txtTenKH.Multiline = true;
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(222, 42);
            txtTenKH.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(185, 123);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(150, 32);
            txtSDT.TabIndex = 10;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(465, 113);
            txtDC.Multiline = true;
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(222, 42);
            txtDC.TabIndex = 11;
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
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(592, 127);
            label8.Name = "label8";
            label8.Size = new Size(184, 22);
            label8.TabIndex = 17;
            label8.Text = "Mã Nhân Viên Xử Lí:";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(791, 122);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(150, 31);
            txtMaNV.TabIndex = 18;
            // 
            // dtgrvHienThiListSPChon
            // 
            dtgrvHienThiListSPChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrvHienThiListSPChon.BackgroundColor = SystemColors.Control;
            dtgrvHienThiListSPChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrvHienThiListSPChon.Columns.AddRange(new DataGridViewColumn[] { clMaSP, clTenSP, clSoLuong, clGiaTien, clThanhTien });
            dtgrvHienThiListSPChon.Location = new Point(40, 416);
            dtgrvHienThiListSPChon.Name = "dtgrvHienThiListSPChon";
            dtgrvHienThiListSPChon.RowHeadersWidth = 62;
            dtgrvHienThiListSPChon.RowTemplate.Height = 33;
            dtgrvHienThiListSPChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrvHienThiListSPChon.Size = new Size(1090, 225);
            dtgrvHienThiListSPChon.TabIndex = 19;
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
            // ChiTietDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 689);
            Controls.Add(dtgrvHienThiListSPChon);
            Controls.Add(txtMaNV);
            Controls.Add(label8);
            Controls.Add(txtMaD);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(lblChiTietDon);
            Name = "ChiTietDon";
            Text = "ChiTietDon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtDC;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private TextBox txtMaD;
        private Label label8;
        private TextBox txtMaNV;
        private DataGridView dtgrvHienThiListSPChon;
        private DataGridViewTextBoxColumn clMaSP;
        private DataGridViewTextBoxColumn clTenSP;
        private DataGridViewTextBoxColumn clSoLuong;
        private DataGridViewTextBoxColumn clGiaTien;
        private DataGridViewTextBoxColumn clThanhTien;
    }
}