namespace SaleApp.View
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
            this.lblChiTietDon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.gbDSCTHD = new System.Windows.Forms.GroupBox();
            this.dtgrvHienThiListSPChon = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinKH.SuspendLayout();
            this.gbDSCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSPChon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChiTietDon
            // 
            this.lblChiTietDon.AutoSize = true;
            this.lblChiTietDon.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChiTietDon.Location = new System.Drawing.Point(345, 22);
            this.lblChiTietDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChiTietDon.Name = "lblChiTietDon";
            this.lblChiTietDon.Size = new System.Drawing.Size(252, 32);
            this.lblChiTietDon.TabIndex = 0;
            this.lblChiTietDon.Text = "Chi Tiết Đơn Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(289, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(92, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Khách Hàng:";
            // 
            // gbThongTinKH
            // 
            this.gbThongTinKH.Controls.Add(this.txtDC);
            this.gbThongTinKH.Controls.Add(this.txtSDT);
            this.gbThongTinKH.Controls.Add(this.txtTenKH);
            this.gbThongTinKH.Controls.Add(this.txtMaKH);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label4);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label5);
            this.gbThongTinKH.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbThongTinKH.Location = new System.Drawing.Point(90, 146);
            this.gbThongTinKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongTinKH.Size = new System.Drawing.Size(565, 162);
            this.gbThongTinKH.TabIndex = 7;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin khách hàng:";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(372, 90);
            this.txtDC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDC.Multiline = true;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(178, 34);
            this.txtDC.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(148, 98);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(121, 25);
            this.txtSDT.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(382, 42);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(178, 34);
            this.txtTenKH.TabIndex = 9;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(148, 42);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(121, 25);
            this.txtMaKH.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(289, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Địa Chỉ:";
            // 
            // txtMaD
            // 
            this.txtMaD.Location = new System.Drawing.Point(250, 98);
            this.txtMaD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaD.Name = "txtMaD";
            this.txtMaD.Size = new System.Drawing.Size(121, 27);
            this.txtMaD.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(474, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã Nhân Viên Xử Lí:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(670, 101);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(121, 27);
            this.txtMaNV.TabIndex = 18;
            // 
            // gbDSCTHD
            // 
            this.gbDSCTHD.Controls.Add(this.dtgrvHienThiListSPChon);
            this.gbDSCTHD.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDSCTHD.Location = new System.Drawing.Point(47, 322);
            this.gbDSCTHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDSCTHD.Name = "gbDSCTHD";
            this.gbDSCTHD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDSCTHD.Size = new System.Drawing.Size(852, 220);
            this.gbDSCTHD.TabIndex = 19;
            this.gbDSCTHD.TabStop = false;
            this.gbDSCTHD.Text = "Dach Sách Chi tiết Hóa đơn ";
            // 
            // dtgrvHienThiListSPChon
            // 
            this.dtgrvHienThiListSPChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListSPChon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrvHienThiListSPChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvHienThiListSPChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.clTenSP,
            this.clSoLuong,
            this.clGiaTien,
            this.clThanhTien});
            this.dtgrvHienThiListSPChon.Location = new System.Drawing.Point(5, 24);
            this.dtgrvHienThiListSPChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrvHienThiListSPChon.Name = "dtgrvHienThiListSPChon";
            this.dtgrvHienThiListSPChon.RowHeadersWidth = 62;
            this.dtgrvHienThiListSPChon.RowTemplate.Height = 33;
            this.dtgrvHienThiListSPChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListSPChon.Size = new System.Drawing.Size(842, 191);
            this.dtgrvHienThiListSPChon.TabIndex = 20;
            // 
            // clMaSP
            // 
            this.clMaSP.HeaderText = "Mã Sản Phẩm";
            this.clMaSP.MinimumWidth = 8;
            this.clMaSP.Name = "clMaSP";
            // 
            // clTenSP
            // 
            this.clTenSP.HeaderText = "Tên Sản Phẩm";
            this.clTenSP.MinimumWidth = 8;
            this.clTenSP.Name = "clTenSP";
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.MinimumWidth = 8;
            this.clSoLuong.Name = "clSoLuong";
            // 
            // clGiaTien
            // 
            this.clGiaTien.HeaderText = "Giá Tiền";
            this.clGiaTien.MinimumWidth = 8;
            this.clGiaTien.Name = "clGiaTien";
            // 
            // clThanhTien
            // 
            this.clThanhTien.HeaderText = "Thành Tiền";
            this.clThanhTien.MinimumWidth = 8;
            this.clThanhTien.Name = "clThanhTien";
            // 
            // frmChiTietDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 601);
            this.Controls.Add(this.gbDSCTHD);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaD);
            this.Controls.Add(this.gbThongTinKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChiTietDon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChiTietDon";
            this.Text = "ChiTietDon";
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.gbDSCTHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSPChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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