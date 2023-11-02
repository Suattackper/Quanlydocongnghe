namespace SaleApp.View
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.gbDSHangTon = new System.Windows.Forms.GroupBox();
            this.dtgvDSDonHang = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.laTong = new System.Windows.Forms.Label();
            this.btnXemCTDH = new System.Windows.Forms.Button();
            this.gbDSHangTon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.btnXuatFile, "btnXuatFile");
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // gbDSHangTon
            // 
            this.gbDSHangTon.Controls.Add(this.dtgvDSDonHang);
            resources.ApplyResources(this.gbDSHangTon, "gbDSHangTon");
            this.gbDSHangTon.Name = "gbDSHangTon";
            this.gbDSHangTon.TabStop = false;
            // 
            // dtgvDSDonHang
            // 
            this.dtgvDSDonHang.AllowUserToAddRows = false;
            this.dtgvDSDonHang.AllowUserToDeleteRows = false;
            this.dtgvDSDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSDonHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDSDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgvDSDonHang, "dtgvDSDonHang");
            this.dtgvDSDonHang.Name = "dtgvDSDonHang";
            this.dtgvDSDonHang.ReadOnly = true;
            this.dtgvDSDonHang.RowHeadersVisible = false;
            this.dtgvDSDonHang.RowTemplate.Height = 33;
            this.dtgvDSDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSDonHang_CellClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.btnrefresh, "btnrefresh");
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnTimKiem, "btnTimKiem");
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.UseCompatibleTextRendering = true;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            resources.ApplyResources(this.txtTimKiem, "txtTimKiem");
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimKiem.Name = "txtTimKiem";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // laTong
            // 
            resources.ApplyResources(this.laTong, "laTong");
            this.laTong.ForeColor = System.Drawing.Color.Red;
            this.laTong.Name = "laTong";
            // 
            // btnXemCTDH
            // 
            this.btnXemCTDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.btnXemCTDH, "btnXemCTDH");
            this.btnXemCTDH.ForeColor = System.Drawing.Color.White;
            this.btnXemCTDH.Name = "btnXemCTDH";
            this.btnXemCTDH.UseVisualStyleBackColor = false;
            this.btnXemCTDH.Click += new System.EventHandler(this.btnXemCTDH_Click);
            // 
            // frmThongKe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXemCTDH);
            this.Controls.Add(this.laTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.gbDSHangTon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.gbDSHangTon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnXuatFile;
        private GroupBox gbDSHangTon;
        private DataGridView dtgvDSDonHang;
        private Button btnrefresh;
        private Label label1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label2;
        private Label laTong;
        private Button btnXemCTDH;
    }
}