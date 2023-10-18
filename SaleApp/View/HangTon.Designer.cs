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
            this.gbDSHangTon = new System.Windows.Forms.GroupBox();
            this.dtgvDSHangTon = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.gbDSHangTon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHangTon)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDSHangTon
            // 
            this.gbDSHangTon.Controls.Add(this.dtgvDSHangTon);
            this.gbDSHangTon.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDSHangTon.Location = new System.Drawing.Point(27, 48);
            this.gbDSHangTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDSHangTon.Name = "gbDSHangTon";
            this.gbDSHangTon.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDSHangTon.Size = new System.Drawing.Size(954, 453);
            this.gbDSHangTon.TabIndex = 0;
            this.gbDSHangTon.TabStop = false;
            this.gbDSHangTon.Text = "Danh sách hàng tồn";
            // 
            // dtgvDSHangTon
            // 
            this.dtgvDSHangTon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHangTon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDSHangTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHangTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.clTenSP,
            this.clSoLuongTon,
            this.clNgayNhap});
            this.dtgvDSHangTon.Location = new System.Drawing.Point(5, 27);
            this.dtgvDSHangTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvDSHangTon.Name = "dtgvDSHangTon";
            this.dtgvDSHangTon.RowHeadersWidth = 62;
            this.dtgvDSHangTon.RowTemplate.Height = 33;
            this.dtgvDSHangTon.Size = new System.Drawing.Size(934, 421);
            this.dtgvDSHangTon.TabIndex = 0;
            // 
            // clMaSP
            // 
            this.clMaSP.HeaderText = "Mã Sản Phẩm ";
            this.clMaSP.MinimumWidth = 8;
            this.clMaSP.Name = "clMaSP";
            // 
            // clTenSP
            // 
            this.clTenSP.HeaderText = "Tên Sản Phẩm ";
            this.clTenSP.MinimumWidth = 8;
            this.clTenSP.Name = "clTenSP";
            // 
            // clSoLuongTon
            // 
            this.clSoLuongTon.HeaderText = "Số lượng tồn ";
            this.clSoLuongTon.MinimumWidth = 8;
            this.clSoLuongTon.Name = "clSoLuongTon";
            // 
            // clNgayNhap
            // 
            this.clNgayNhap.HeaderText = "Ngày nhập ";
            this.clNgayNhap.MinimumWidth = 8;
            this.clNgayNhap.Name = "clNgayNhap";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(456, 530);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(166, 51);
            this.btnXuatFile.TabIndex = 1;
            this.btnXuatFile.Text = "Xuất File ";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // frmHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 601);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.gbDSHangTon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHangTon";
            this.Text = "Hàng tồn ";
            this.gbDSHangTon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHangTon)).EndInit();
            this.ResumeLayout(false);

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