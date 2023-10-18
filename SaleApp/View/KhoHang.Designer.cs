namespace SaleApp.View
{
    partial class frmKhoHang
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdbtnKhoHang = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemDSHangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDSHangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDSHangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdbtnKhoHang});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(992, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdbtnKhoHang
            // 
            this.tsdbtnKhoHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdbtnKhoHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDSHangTon,
            this.itemDSHangNhap,
            this.itemDSHangXuat});
            this.tsdbtnKhoHang.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsdbtnKhoHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsdbtnKhoHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdbtnKhoHang.Name = "tsdbtnKhoHang";
            this.tsdbtnKhoHang.Size = new System.Drawing.Size(104, 26);
            this.tsdbtnKhoHang.Text = "Kho Hàng";
            // 
            // itemDSHangTon
            // 
            this.itemDSHangTon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemDSHangTon.Name = "itemDSHangTon";
            this.itemDSHangTon.Size = new System.Drawing.Size(274, 26);
            this.itemDSHangTon.Text = "Danh Sách Hàng Tồn";
            // 
            // itemDSHangNhap
            // 
            this.itemDSHangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemDSHangNhap.Name = "itemDSHangNhap";
            this.itemDSHangNhap.Size = new System.Drawing.Size(274, 26);
            this.itemDSHangNhap.Text = "Nhập Kho";
            // 
            // itemDSHangXuat
            // 
            this.itemDSHangXuat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemDSHangXuat.Name = "itemDSHangXuat";
            this.itemDSHangXuat.Size = new System.Drawing.Size(274, 26);
            this.itemDSHangXuat.Text = "Xuất Kho";
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 601);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhoHang";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsdbtnKhoHang;
        private ToolStripMenuItem itemDSHangTon;
        private ToolStripMenuItem itemDSHangNhap;
        private ToolStripMenuItem itemDSHangXuat;
    }
}