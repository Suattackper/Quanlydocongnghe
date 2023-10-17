namespace SaleApp.View
{
    partial class frmHangTon
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
            gbDSHangTon = new GroupBox();
            dtgvDSHangTon = new DataGridView();
            clMaSP = new DataGridViewTextBoxColumn();
            clTenSP = new DataGridViewTextBoxColumn();
            clSoLuongTon = new DataGridViewTextBoxColumn();
            clNgayNhap = new DataGridViewTextBoxColumn();
            btnXuatFile = new Button();
            gbDSHangTon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDSHangTon).BeginInit();
            SuspendLayout();
            // 
            // gbDSHangTon
            // 
            gbDSHangTon.Controls.Add(dtgvDSHangTon);
            gbDSHangTon.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbDSHangTon.Location = new Point(34, 60);
            gbDSHangTon.Name = "gbDSHangTon";
            gbDSHangTon.Size = new Size(1299, 566);
            gbDSHangTon.TabIndex = 0;
            gbDSHangTon.TabStop = false;
            gbDSHangTon.Text = "Danh sách hàng tồn";
            // 
            // dtgvDSHangTon
            // 
            dtgvDSHangTon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDSHangTon.BackgroundColor = SystemColors.ButtonFace;
            dtgvDSHangTon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDSHangTon.Columns.AddRange(new DataGridViewColumn[] { clMaSP, clTenSP, clSoLuongTon, clNgayNhap });
            dtgvDSHangTon.Location = new Point(6, 34);
            dtgvDSHangTon.Name = "dtgvDSHangTon";
            dtgvDSHangTon.RowHeadersWidth = 62;
            dtgvDSHangTon.RowTemplate.Height = 33;
            dtgvDSHangTon.Size = new Size(1287, 526);
            dtgvDSHangTon.TabIndex = 0;
            // 
            // clMaSP
            // 
            clMaSP.HeaderText = "Mã Sản Phẩm ";
            clMaSP.MinimumWidth = 8;
            clMaSP.Name = "clMaSP";
            // 
            // clTenSP
            // 
            clTenSP.HeaderText = "Tên Sản Phẩm ";
            clTenSP.MinimumWidth = 8;
            clTenSP.Name = "clTenSP";
            // 
            // clSoLuongTon
            // 
            clSoLuongTon.HeaderText = "Số lượng tồn ";
            clSoLuongTon.MinimumWidth = 8;
            clSoLuongTon.Name = "clSoLuongTon";
            // 
            // clNgayNhap
            // 
            clNgayNhap.HeaderText = "Ngày nhập ";
            clNgayNhap.MinimumWidth = 8;
            clNgayNhap.Name = "clNgayNhap";
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.FromArgb(0, 122, 204);
            btnXuatFile.FlatStyle = FlatStyle.Flat;
            btnXuatFile.Font = new Font("Cascadia Code", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatFile.ForeColor = Color.White;
            btnXuatFile.Location = new Point(570, 663);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(207, 64);
            btnXuatFile.TabIndex = 1;
            btnXuatFile.Text = "Xuất File ";
            btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // frmHangTon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 802);
            Controls.Add(btnXuatFile);
            Controls.Add(gbDSHangTon);
            Name = "frmHangTon";
            Text = "Hàng tồn ";
            gbDSHangTon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDSHangTon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDSHangTon;
        private DataGridView dtgvDSHangTon;
        private DataGridViewTextBoxColumn clMaSP;
        private DataGridViewTextBoxColumn clTenSP;
        private DataGridViewTextBoxColumn clSoLuongTon;
        private DataGridViewTextBoxColumn clNgayNhap;
        private Button btnXuatFile;
    }
}