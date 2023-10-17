namespace SaleApp.View
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            gbThongTinNCC = new GroupBox();
            btnXuatE = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            txtTenNCC = new TextBox();
            txtSDTNCC = new TextBox();
            txtDiaChiNCC = new TextBox();
            txtMaNCC = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbDanhSachNCC = new GroupBox();
            dtgrDSNCC = new DataGridView();
            clMaNCC = new DataGridViewTextBoxColumn();
            clTenNCC = new DataGridViewTextBoxColumn();
            clSDTNCC = new DataGridViewTextBoxColumn();
            clDiaChiNCC = new DataGridViewTextBoxColumn();
            gbThongTinNCC.SuspendLayout();
            gbDanhSachNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrDSNCC).BeginInit();
            SuspendLayout();
            // 
            // gbThongTinNCC
            // 
            gbThongTinNCC.Controls.Add(btnXuatE);
            gbThongTinNCC.Controls.Add(btnSua);
            gbThongTinNCC.Controls.Add(btnXoa);
            gbThongTinNCC.Controls.Add(btnReset);
            gbThongTinNCC.Controls.Add(btnThem);
            gbThongTinNCC.Controls.Add(btnTimKiem);
            gbThongTinNCC.Controls.Add(txtTimKiem);
            gbThongTinNCC.Controls.Add(txtTenNCC);
            gbThongTinNCC.Controls.Add(txtSDTNCC);
            gbThongTinNCC.Controls.Add(txtDiaChiNCC);
            gbThongTinNCC.Controls.Add(txtMaNCC);
            gbThongTinNCC.Controls.Add(label4);
            gbThongTinNCC.Controls.Add(label3);
            gbThongTinNCC.Controls.Add(label2);
            gbThongTinNCC.Controls.Add(label1);
            gbThongTinNCC.Font = new Font("Cascadia Code", 11F, FontStyle.Bold, GraphicsUnit.Point);
            gbThongTinNCC.Location = new Point(13, 41);
            gbThongTinNCC.Margin = new Padding(4, 2, 4, 2);
            gbThongTinNCC.Name = "gbThongTinNCC";
            gbThongTinNCC.Padding = new Padding(4, 2, 4, 2);
            gbThongTinNCC.Size = new Size(1279, 379);
            gbThongTinNCC.TabIndex = 1;
            gbThongTinNCC.TabStop = false;
            gbThongTinNCC.Text = "Thông tin Nhà Cung Cấp";
            // 
            // btnXuatE
            // 
            btnXuatE.BackColor = Color.FromArgb(0, 122, 204);
            btnXuatE.FlatAppearance.BorderSize = 0;
            btnXuatE.FlatStyle = FlatStyle.Flat;
            btnXuatE.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatE.ForeColor = Color.White;
            btnXuatE.Location = new Point(991, 293);
            btnXuatE.Name = "btnXuatE";
            btnXuatE.Size = new Size(150, 50);
            btnXuatE.TabIndex = 14;
            btnXuatE.Text = "Xuất Excel";
            btnXuatE.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 122, 204);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(991, 96);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 50);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 122, 204);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(991, 162);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 50);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 122, 204);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(991, 228);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 50);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 122, 204);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(991, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 50);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.White;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(430, 267);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(30, 30);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.ForeColor = SystemColors.GrayText;
            txtTimKiem.Location = new Point(52, 254);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(421, 55);
            txtTimKiem.TabIndex = 8;
            txtTimKiem.Text = "Tìm kiếm  ";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(237, 162);
            txtTenNCC.Margin = new Padding(3, 2, 3, 2);
            txtTenNCC.Multiline = true;
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(267, 41);
            txtTenNCC.TabIndex = 7;
            // 
            // txtSDTNCC
            // 
            txtSDTNCC.Location = new Point(578, 74);
            txtSDTNCC.Margin = new Padding(3, 2, 3, 2);
            txtSDTNCC.Name = "txtSDTNCC";
            txtSDTNCC.Size = new Size(186, 33);
            txtSDTNCC.TabIndex = 6;
            // 
            // txtDiaChiNCC
            // 
            txtDiaChiNCC.Location = new Point(635, 163);
            txtDiaChiNCC.Margin = new Padding(3, 2, 3, 2);
            txtDiaChiNCC.Multiline = true;
            txtDiaChiNCC.Name = "txtDiaChiNCC";
            txtDiaChiNCC.Size = new Size(287, 49);
            txtDiaChiNCC.TabIndex = 5;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(233, 74);
            txtMaNCC.Margin = new Padding(3, 2, 3, 2);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(186, 33);
            txtMaNCC.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(521, 180);
            label4.Name = "label4";
            label4.Size = new Size(108, 27);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(529, 79);
            label3.Name = "label3";
            label3.Size = new Size(60, 27);
            label3.TabIndex = 2;
            label3.Text = "SDT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 170);
            label2.Name = "label2";
            label2.Size = new Size(216, 27);
            label2.TabIndex = 1;
            label2.Text = "Tên Nhà cung cấp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 79);
            label1.Name = "label1";
            label1.Size = new Size(204, 27);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhà cung cấp:";
            // 
            // gbDanhSachNCC
            // 
            gbDanhSachNCC.Controls.Add(dtgrDSNCC);
            gbDanhSachNCC.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbDanhSachNCC.Location = new Point(4, 436);
            gbDanhSachNCC.Name = "gbDanhSachNCC";
            gbDanhSachNCC.Size = new Size(1293, 329);
            gbDanhSachNCC.TabIndex = 2;
            gbDanhSachNCC.TabStop = false;
            gbDanhSachNCC.Text = "Danh Sách Nhà cung cấp ";
            // 
            // dtgrDSNCC
            // 
            dtgrDSNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrDSNCC.BackgroundColor = Color.White;
            dtgrDSNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrDSNCC.Columns.AddRange(new DataGridViewColumn[] { clMaNCC, clTenNCC, clSDTNCC, clDiaChiNCC });
            dtgrDSNCC.Location = new Point(18, 31);
            dtgrDSNCC.Name = "dtgrDSNCC";
            dtgrDSNCC.RowHeadersWidth = 62;
            dtgrDSNCC.RowTemplate.Height = 33;
            dtgrDSNCC.Size = new Size(1254, 277);
            dtgrDSNCC.TabIndex = 0;
            // 
            // clMaNCC
            // 
            clMaNCC.HeaderText = "Mã Nhà CC";
            clMaNCC.MinimumWidth = 8;
            clMaNCC.Name = "clMaNCC";
            // 
            // clTenNCC
            // 
            clTenNCC.HeaderText = "Tên Nhà CC";
            clTenNCC.MinimumWidth = 8;
            clTenNCC.Name = "clTenNCC";
            // 
            // clSDTNCC
            // 
            clSDTNCC.HeaderText = "Số Điện Thoại ";
            clSDTNCC.MinimumWidth = 8;
            clSDTNCC.Name = "clSDTNCC";
            // 
            // clDiaChiNCC
            // 
            clDiaChiNCC.HeaderText = "Địa Chỉ ";
            clDiaChiNCC.MinimumWidth = 8;
            clDiaChiNCC.Name = "clDiaChiNCC";
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 796);
            Controls.Add(gbDanhSachNCC);
            Controls.Add(gbThongTinNCC);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhaCungCap";
            gbThongTinNCC.ResumeLayout(false);
            gbThongTinNCC.PerformLayout();
            gbDanhSachNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgrDSNCC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbThongTinNCC;
        private Button btnXuatE;
        private Button btnSua;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private TextBox txtTenNCC;
        private TextBox txtSDTNCC;
        private TextBox txtDiaChiNCC;
        private TextBox txtMaNCC;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbDanhSachNCC;
        private DataGridView dtgrDSNCC;
        private DataGridViewTextBoxColumn clMaNCC;
        private DataGridViewTextBoxColumn clTenNCC;
        private DataGridViewTextBoxColumn clSDTNCC;
        private DataGridViewTextBoxColumn clDiaChiNCC;
    }
}