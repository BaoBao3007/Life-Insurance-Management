namespace DoAnNoSQL.Views
{
    partial class Frm_HopDongBH
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
            label1 = new Label();
            panel1 = new Panel();
            grid_KhachHang = new DataGridView();
            label2 = new Label();
            panel2 = new Panel();
            cbo_loaiHD = new ComboBox();
            cbo_daily = new ComboBox();
            label5 = new Label();
            Cbo_MaKH = new ComboBox();
            txt_ngayky = new TextBox();
            txt_tenkh = new TextBox();
            txt_thoihanHD = new TextBox();
            txt_mucphi = new TextBox();
            txt_nguoithuhuong = new TextBox();
            txt_sotienBH = new TextBox();
            txt_soHD = new TextBox();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            btn_themKH = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_themHD = new Button();
            btn_TimHD = new Button();
            btn_thoat = new Button();
            btn_clear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_KhachHang).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(373, 25);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 0;
            label1.Text = "HỢP ĐỒNG BẢO HIỂM";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(grid_KhachHang);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(41, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 229);
            panel1.TabIndex = 1;
            // 
            // grid_KhachHang
            // 
            grid_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_KhachHang.Location = new Point(18, 3);
            grid_KhachHang.Name = "grid_KhachHang";
            grid_KhachHang.RowHeadersWidth = 62;
            grid_KhachHang.Size = new Size(915, 221);
            grid_KhachHang.TabIndex = 0;
            grid_KhachHang.CellClick += grid_KhachHang_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 440);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 2;
            label2.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbo_loaiHD);
            panel2.Controls.Add(cbo_daily);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Cbo_MaKH);
            panel2.Controls.Add(txt_ngayky);
            panel2.Controls.Add(txt_tenkh);
            panel2.Controls.Add(txt_thoihanHD);
            panel2.Controls.Add(txt_mucphi);
            panel2.Controls.Add(txt_nguoithuhuong);
            panel2.Controls.Add(txt_sotienBH);
            panel2.Controls.Add(txt_soHD);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(41, 60);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(955, 334);
            panel2.TabIndex = 3;
            // 
            // cbo_loaiHD
            // 
            cbo_loaiHD.FormattingEnabled = true;
            cbo_loaiHD.Location = new Point(237, 288);
            cbo_loaiHD.Name = "cbo_loaiHD";
            cbo_loaiHD.Size = new Size(239, 33);
            cbo_loaiHD.TabIndex = 28;
            // 
            // cbo_daily
            // 
            cbo_daily.FormattingEnabled = true;
            cbo_daily.Location = new Point(692, 298);
            cbo_daily.Name = "cbo_daily";
            cbo_daily.Size = new Size(239, 33);
            cbo_daily.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(523, 296);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 26;
            label5.Text = "Đại lý";
            // 
            // Cbo_MaKH
            // 
            Cbo_MaKH.FormattingEnabled = true;
            Cbo_MaKH.Location = new Point(237, 77);
            Cbo_MaKH.Name = "Cbo_MaKH";
            Cbo_MaKH.Size = new Size(239, 33);
            Cbo_MaKH.TabIndex = 25;
            Cbo_MaKH.SelectedIndexChanged += Cbo_MaKH_SelectedIndexChanged;
            // 
            // txt_ngayky
            // 
            txt_ngayky.Location = new Point(692, 26);
            txt_ngayky.Name = "txt_ngayky";
            txt_ngayky.Size = new Size(239, 31);
            txt_ngayky.TabIndex = 24;
            // 
            // txt_tenkh
            // 
            txt_tenkh.Location = new Point(692, 71);
            txt_tenkh.Name = "txt_tenkh";
            txt_tenkh.Size = new Size(239, 31);
            txt_tenkh.TabIndex = 23;
            // 
            // txt_thoihanHD
            // 
            txt_thoihanHD.Location = new Point(692, 245);
            txt_thoihanHD.Name = "txt_thoihanHD";
            txt_thoihanHD.Size = new Size(239, 31);
            txt_thoihanHD.TabIndex = 22;
            // 
            // txt_mucphi
            // 
            txt_mucphi.Location = new Point(692, 181);
            txt_mucphi.Name = "txt_mucphi";
            txt_mucphi.Size = new Size(239, 31);
            txt_mucphi.TabIndex = 21;
            // 
            // txt_nguoithuhuong
            // 
            txt_nguoithuhuong.Location = new Point(237, 172);
            txt_nguoithuhuong.Name = "txt_nguoithuhuong";
            txt_nguoithuhuong.Size = new Size(239, 31);
            txt_nguoithuhuong.TabIndex = 18;
            // 
            // txt_sotienBH
            // 
            txt_sotienBH.Location = new Point(237, 233);
            txt_sotienBH.Name = "txt_sotienBH";
            txt_sotienBH.Size = new Size(239, 31);
            txt_sotienBH.TabIndex = 15;
            // 
            // txt_soHD
            // 
            txt_soHD.Location = new Point(237, 26);
            txt_soHD.Name = "txt_soHD";
            txt_soHD.Size = new Size(239, 31);
            txt_soHD.TabIndex = 13;
            txt_soHD.TextChanged += txt_soHD_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(518, 184);
            label14.Name = "label14";
            label14.Size = new Size(168, 25);
            label14.TabIndex = 11;
            label14.Text = "Mức phí BH định kỳ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 288);
            label12.Name = "label12";
            label12.Size = new Size(129, 25);
            label12.TabIndex = 9;
            label12.Text = "Loại hợp đồng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(521, 245);
            label11.Name = "label11";
            label11.Size = new Size(165, 25);
            label11.TabIndex = 8;
            label11.Text = "Thời hạn hơp đồng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(521, 77);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 7;
            label10.Text = "Tên KH";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 172);
            label9.Name = "label9";
            label9.Size = new Size(148, 25);
            label9.TabIndex = 6;
            label9.Text = "Người hưởng BH";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 77);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 5;
            label8.Text = "Mã KH";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 236);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 4;
            label7.Text = "Số tiền BH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 26);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 3;
            label6.Text = "Ngày ký";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 26);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 1;
            label4.Text = "Số hợp đồng";
            // 
            // btn_themKH
            // 
            btn_themKH.BackColor = SystemColors.Highlight;
            btn_themKH.ForeColor = SystemColors.ButtonHighlight;
            btn_themKH.Location = new Point(884, 400);
            btn_themKH.Name = "btn_themKH";
            btn_themKH.Size = new Size(112, 34);
            btn_themKH.TabIndex = 4;
            btn_themKH.Text = "Thêm KH";
            btn_themKH.UseVisualStyleBackColor = false;
            btn_themKH.Click += btn_themKH_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = SystemColors.Highlight;
            btn_sua.ForeColor = SystemColors.ButtonFace;
            btn_sua.Location = new Point(524, 400);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(112, 34);
            btn_sua.TabIndex = 5;
            btn_sua.Text = "Sửa HĐ";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = SystemColors.Highlight;
            btn_xoa.ForeColor = SystemColors.ButtonHighlight;
            btn_xoa.Location = new Point(673, 400);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(112, 34);
            btn_xoa.TabIndex = 6;
            btn_xoa.Text = "Xóa HĐ";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_themHD
            // 
            btn_themHD.BackColor = SystemColors.Highlight;
            btn_themHD.ForeColor = SystemColors.ButtonFace;
            btn_themHD.Location = new Point(374, 400);
            btn_themHD.Name = "btn_themHD";
            btn_themHD.Size = new Size(112, 34);
            btn_themHD.TabIndex = 7;
            btn_themHD.Text = "Thêm HĐ";
            btn_themHD.UseVisualStyleBackColor = false;
            btn_themHD.Click += btn_themHD_Click;
            // 
            // btn_TimHD
            // 
            btn_TimHD.BackColor = SystemColors.Highlight;
            btn_TimHD.ForeColor = SystemColors.ButtonHighlight;
            btn_TimHD.Location = new Point(713, 718);
            btn_TimHD.Name = "btn_TimHD";
            btn_TimHD.Size = new Size(149, 34);
            btn_TimHD.TabIndex = 8;
            btn_TimHD.Text = "Tìm hợp đồng";
            btn_TimHD.UseVisualStyleBackColor = false;
            btn_TimHD.Click += btn_TimHD_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = SystemColors.Highlight;
            btn_thoat.ForeColor = SystemColors.ButtonHighlight;
            btn_thoat.Location = new Point(868, 718);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(112, 34);
            btn_thoat.TabIndex = 10;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.Highlight;
            btn_clear.ForeColor = SystemColors.ButtonHighlight;
            btn_clear.Location = new Point(224, 400);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(112, 34);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Làm mới ";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // Frm_HopDongBH
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 764);
            Controls.Add(btn_clear);
            Controls.Add(btn_thoat);
            Controls.Add(btn_TimHD);
            Controls.Add(btn_themHD);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_themKH);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Frm_HopDongBH";
            Text = "HopDongBaoHiem";
            Load += HopDongBaoHiem_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_KhachHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btn_themKH;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_themHD;
        private Label label14;
        private TextBox txt_soHD;
        private TextBox txt_nguoithuhuong;
        private TextBox txt_sotienBH;
        private TextBox txt_ngayky;
        private TextBox txt_tenkh;
        private TextBox txt_thoihanHD;
        private TextBox txt_mucphi;
        private ComboBox Cbo_MaKH;
        private Button btn_TimHD;
        private Button btn_thoat;
        private DataGridView grid_KhachHang;
        private Label label5;
        private ComboBox cbo_daily;
        private ComboBox cbo_loaiHD;
        private Button btn_clear;
    }
}