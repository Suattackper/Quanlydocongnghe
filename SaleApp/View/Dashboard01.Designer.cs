﻿namespace SaleApp.View
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

        /// <summary    
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbNhanVien = new System.Windows.Forms.PictureBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.taskbar = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnNhaCC = new System.Windows.Forms.Button();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.PBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhanVien)).BeginInit();
            this.taskbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pbNhanVien);
            this.panel1.Controls.Add(this.lblChucVu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 81);
            this.panel1.TabIndex = 0;
            // 
            // pbNhanVien
            // 
            this.pbNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("pbNhanVien.Image")));
            this.pbNhanVien.Location = new System.Drawing.Point(430, 11);
            this.pbNhanVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbNhanVien.Name = "pbNhanVien";
            this.pbNhanVien.Size = new System.Drawing.Size(64, 64);
            this.pbNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNhanVien.TabIndex = 7;
            this.pbNhanVien.TabStop = false;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(612, 31);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(56, 25);
            this.lblChucVu.TabIndex = 6;
            this.lblChucVu.Text = "NULL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(498, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chức vụ:";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1464, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // taskbar
            // 
            this.taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.taskbar.Controls.Add(this.btnThoat);
            this.taskbar.Controls.Add(this.btnThongKe);
            this.taskbar.Controls.Add(this.btnNhanVien);
            this.taskbar.Controls.Add(this.btnKhoHang);
            this.taskbar.Controls.Add(this.btnSP);
            this.taskbar.Controls.Add(this.btnNhaCC);
            this.taskbar.Controls.Add(this.btnTaoDon);
            this.taskbar.Controls.Add(this.btnTrangChu);
            this.taskbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskbar.Location = new System.Drawing.Point(0, 81);
            this.taskbar.Margin = new System.Windows.Forms.Padding(2);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(323, 669);
            this.taskbar.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(11, 600);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(299, 57);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = " Đăng Xuất";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(10, 518);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(299, 54);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống kê ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click_1);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(10, 433);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(299, 54);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.FlatAppearance.BorderSize = 0;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhoHang.ForeColor = System.Drawing.Color.White;
            this.btnKhoHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoHang.Image")));
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(10, 347);
            this.btnKhoHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(299, 54);
            this.btnKhoHang.TabIndex = 5;
            this.btnKhoHang.Text = "Kho Hàng ";
            this.btnKhoHang.UseVisualStyleBackColor = true;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnSP
            // 
            this.btnSP.FlatAppearance.BorderSize = 0;
            this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSP.ForeColor = System.Drawing.Color.White;
            this.btnSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSP.Image")));
            this.btnSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSP.Location = new System.Drawing.Point(10, 90);
            this.btnSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(299, 58);
            this.btnSP.TabIndex = 4;
            this.btnSP.Text = "Sản Phẩm";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.FlatAppearance.BorderSize = 0;
            this.btnNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCC.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhaCC.ForeColor = System.Drawing.Color.White;
            this.btnNhaCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaCC.Image")));
            this.btnNhaCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaCC.Location = new System.Drawing.Point(10, 176);
            this.btnNhaCC.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhaCC.Name = "btnNhaCC";
            this.btnNhaCC.Size = new System.Drawing.Size(299, 54);
            this.btnNhaCC.TabIndex = 3;
            this.btnNhaCC.Text = "Nhà Cung Cấp";
            this.btnNhaCC.UseVisualStyleBackColor = true;
            this.btnNhaCC.Click += new System.EventHandler(this.btnNhaCC_Click);
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.FlatAppearance.BorderSize = 0;
            this.btnTaoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDon.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaoDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoDon.Image")));
            this.btnTaoDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoDon.Location = new System.Drawing.Point(10, 262);
            this.btnTaoDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(299, 54);
            this.btnTaoDon.TabIndex = 1;
            this.btnTaoDon.Text = "Tạo đơn";
            this.btnTaoDon.UseVisualStyleBackColor = true;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(10, 5);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(299, 54);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // PBody
            // 
            this.PBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBody.Location = new System.Drawing.Point(323, 81);
            this.PBody.Name = "PBody";
            this.PBody.Size = new System.Drawing.Size(1183, 669);
            this.PBody.TabIndex = 6;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1506, 750);
            this.Controls.Add(this.PBody);
            this.Controls.Add(this.taskbar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard01";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhanVien)).EndInit();
            this.taskbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Panel taskbar;
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
        private Panel PBody;
    }
}