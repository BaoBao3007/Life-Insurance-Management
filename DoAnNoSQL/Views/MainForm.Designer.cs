
namespace DoAnNoSQL.Views
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            cácChứcNăngToolStripMenuItem = new ToolStripMenuItem();
            mni_qlkh = new ToolStripMenuItem();
            mni_hdbh = new ToolStripMenuItem();
            mni_ycbt = new ToolStripMenuItem();
            mni_lichsugd = new ToolStripMenuItem();
            mni_quyenloi = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            mni_logout = new ToolStripMenuItem();
            mni_exit = new ToolStripMenuItem();
            mni_saoluu = new ToolStripMenuItem();
            mni_phuchoi = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cácChứcNăngToolStripMenuItem, trợGiúpToolStripMenuItem, mni_logout, mni_exit, mni_saoluu, mni_phuchoi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(949, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cácChứcNăngToolStripMenuItem
            // 
            cácChứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mni_qlkh, mni_hdbh, mni_ycbt, mni_lichsugd, mni_quyenloi });
            cácChứcNăngToolStripMenuItem.Name = "cácChứcNăngToolStripMenuItem";
            cácChứcNăngToolStripMenuItem.Size = new Size(76, 29);
            cácChứcNăngToolStripMenuItem.Text = "Tác vụ";
            // 
            // mni_qlkh
            // 
            mni_qlkh.Name = "mni_qlkh";
            mni_qlkh.Size = new Size(340, 34);
            mni_qlkh.Text = "Quản lý khách hàng";
            mni_qlkh.Click += mni_qlkh_Click;
            // 
            // mni_hdbh
            // 
            mni_hdbh.Name = "mni_hdbh";
            mni_hdbh.Size = new Size(340, 34);
            mni_hdbh.Text = "Quản lý hợp đồng bảo hiểm";
            mni_hdbh.Click += mni_hdbh_Click;
            // 
            // mni_ycbt
            // 
            mni_ycbt.Name = "mni_ycbt";
            mni_ycbt.Size = new Size(340, 34);
            mni_ycbt.Text = "Yêu cầu bồi thường";
            mni_ycbt.Click += mni_ycbt_Click;
            // 
            // mni_lichsugd
            // 
            mni_lichsugd.Name = "mni_lichsugd";
            mni_lichsugd.Size = new Size(340, 34);
            mni_lichsugd.Text = "Lịch sử giao dịch";
            mni_lichsugd.Click += mni_lichsugd_Click;
            // 
            // mni_quyenloi
            // 
            mni_quyenloi.Name = "mni_quyenloi";
            mni_quyenloi.Size = new Size(340, 34);
            mni_quyenloi.Text = "Quyền lợi";
            mni_quyenloi.Click += mni_quyenloi_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(93, 29);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // mni_logout
            // 
            mni_logout.Name = "mni_logout";
            mni_logout.Size = new Size(109, 29);
            mni_logout.Text = "Đăng xuất";
            mni_logout.Click += mni_logout_Click;
            // 
            // mni_exit
            // 
            mni_exit.Name = "mni_exit";
            mni_exit.Size = new Size(73, 29);
            mni_exit.Text = "Thoát";
            mni_exit.Click += mni_exit_Click;
            // 
            // mni_saoluu
            // 
            mni_saoluu.Name = "mni_saoluu";
            mni_saoluu.Size = new Size(92, 29);
            mni_saoluu.Text = "Sao Lưu";
            mni_saoluu.Click += mni_saoluu_Click;
            // 
            // mni_phuchoi
            // 
            mni_phuchoi.Name = "mni_phuchoi";
            mni_phuchoi.Size = new Size(99, 29);
            mni_phuchoi.Text = "Phục Hồi";
            mni_phuchoi.Click += mni_phuchoi_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(949, 595);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cácChứcNăngToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem mni_logout;
        private ToolStripMenuItem mni_exit;
        private ToolStripMenuItem mni_qlkh;
        private ToolStripMenuItem mni_hdbh;
        private ToolStripMenuItem mni_ycbt;
        private ToolStripMenuItem mni_lichsugd;
        private ToolStripMenuItem mni_quyenloi;
        private ToolStripMenuItem mni_saoluu;
        private ToolStripMenuItem mni_phuchoi;
    }
}