namespace DoAnNoSQL.Views
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtLogin = new Button();
            chk_ghinhodn = new CheckBox();
            ckb_showmatkhau = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coverimg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(526, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(676, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Tên đăng nhập";
            txtUsername.Size = new Size(342, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(676, 297);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " Mật khẩu";
            txtPassword.Size = new Size(342, 31);
            txtPassword.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(770, 407);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(146, 55);
            txtLogin.TabIndex = 3;
            txtLogin.Text = "Đăng nhập";
            txtLogin.UseVisualStyleBackColor = true;
            txtLogin.Click += txtLogin_Click;
            // 
            // chk_ghinhodn
            // 
            chk_ghinhodn.AutoSize = true;
            chk_ghinhodn.Location = new Point(676, 358);
            chk_ghinhodn.Name = "chk_ghinhodn";
            chk_ghinhodn.Size = new Size(158, 29);
            chk_ghinhodn.TabIndex = 4;
            chk_ghinhodn.Text = "Lưu đăng nhập";
            chk_ghinhodn.UseVisualStyleBackColor = true;
            // 
            // ckb_showmatkhau
            // 
            ckb_showmatkhau.AutoSize = true;
            ckb_showmatkhau.Location = new Point(840, 358);
            ckb_showmatkhau.Name = "ckb_showmatkhau";
            ckb_showmatkhau.Size = new Size(178, 29);
            ckb_showmatkhau.TabIndex = 5;
            ckb_showmatkhau.Text = "Hiển thị mật khẩu";
            ckb_showmatkhau.UseVisualStyleBackColor = true;
            ckb_showmatkhau.CheckedChanged += ckb_showmatkhau_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(635, 221);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(633, 297);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.login;
            pictureBox4.Location = new Point(766, 98);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(170, 105);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 552);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(ckb_showmatkhau);
            Controls.Add(chk_ghinhodn);
            Controls.Add(txtLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "MainForm";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button txtLogin;
        private CheckBox chk_ghinhodn;
        private CheckBox ckb_showmatkhau;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}