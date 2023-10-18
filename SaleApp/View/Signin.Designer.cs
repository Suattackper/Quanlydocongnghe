
namespace SaleApp
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbRole = new ComboBox();
            btnLogin = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 956);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(486, 872);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 3;
            label3.Text = "Developed By G";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(228, 146);
            label2.Name = "label2";
            label2.Size = new Size(369, 37);
            label2.TabIndex = 2;
            label2.Text = "SALE MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(356, 41);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO THE";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 218);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(667, 738);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(941, 68);
            label4.Name = "label4";
            label4.Size = new Size(125, 47);
            label4.TabIndex = 1;
            label4.Text = "LOGIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(726, 219);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(726, 345);
            label6.Name = "label6";
            label6.Size = new Size(140, 32);
            label6.TabIndex = 3;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(712, 462);
            label7.Name = "label7";
            label7.Size = new Size(154, 32);
            label7.TabIndex = 4;
            label7.Text = "User role:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(872, 210);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(354, 55);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(872, 336);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(354, 55);
            txtPassword.TabIndex = 6;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Nhân Viên", "Quản Lý ", "Admin", "" });
            cbRole.Location = new Point(882, 461);
            cbRole.Margin = new Padding(3, 4, 3, 4);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(251, 33);
            cbRole.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(909, 669);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(196, 75);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1253, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(62, 50);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1314, 956);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(cbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Signin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cbRole;
        private Button btnLogin;
        private Button btnClose;
    }
}