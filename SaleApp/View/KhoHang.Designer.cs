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
            toolStrip1 = new ToolStrip();
            tsdbtnKhoHang = new ToolStripDropDownButton();
            tsitemDSHangTon = new ToolStripMenuItem();
            tsitemDSHangNhap = new ToolStripMenuItem();
            tsitemDSHangXuat = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsdbtnKhoHang });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1129, 36);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsdbtnKhoHang
            // 
            tsdbtnKhoHang.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsdbtnKhoHang.DropDownItems.AddRange(new ToolStripItem[] { tsitemDSHangTon, tsitemDSHangNhap, tsitemDSHangXuat });
            tsdbtnKhoHang.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tsdbtnKhoHang.ForeColor = SystemColors.ControlText;
            tsdbtnKhoHang.ImageTransparentColor = Color.Magenta;
            tsdbtnKhoHang.Name = "tsdbtnKhoHang";
            tsdbtnKhoHang.Size = new Size(126, 31);
            tsdbtnKhoHang.Text = "Kho Hàng";
            // 
            // tsitemDSHangTon
            // 
            tsitemDSHangTon.ForeColor = SystemColors.ControlText;
            tsitemDSHangTon.Name = "tsitemDSHangTon";
            tsitemDSHangTon.Size = new Size(330, 36);
            tsitemDSHangTon.Text = "Danh Sách Hàng Tồn";
            // 
            // tsitemDSHangNhap
            // 
            tsitemDSHangNhap.ForeColor = SystemColors.ControlText;
            tsitemDSHangNhap.Name = "tsitemDSHangNhap";
            tsitemDSHangNhap.Size = new Size(330, 36);
            tsitemDSHangNhap.Text = "Nhập Kho";
            // 
            // tsitemDSHangXuat
            // 
            tsitemDSHangXuat.ForeColor = SystemColors.ControlText;
            tsitemDSHangXuat.Name = "tsitemDSHangXuat";
            tsitemDSHangXuat.Size = new Size(330, 36);
            tsitemDSHangXuat.Text = "Xuất Kho";
            // 
            // frmKhoHang
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 580);
            Controls.Add(toolStrip1);
            Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmKhoHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhoHang";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsdbtnKhoHang;
        private ToolStripMenuItem tsitemDSHangTon;
        private ToolStripMenuItem tsitemDSHangNhap;
        private ToolStripMenuItem tsitemDSHangXuat;
    }
}