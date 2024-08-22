namespace DoAnNoSQL.Views
{
    partial class Customer
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
            groupBox1 = new GroupBox();
            txt_benhly = new TextBox();
            label13 = new Label();
            txt_nghenghiep = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            txt_email = new TextBox();
            txt_sdt = new TextBox();
            label11 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            cbo_district = new ComboBox();
            cbo_province = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            txt_sonha = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txt_madinhdanh = new TextBox();
            cbo_gioitinh = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtp_ngaysinh = new DateTimePicker();
            txt_tenkh = new TextBox();
            txt_makh = new TextBox();
            panel1 = new Panel();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btn_lammoi = new Button();
            btn_timkiem = new Button();
            dgv_customer = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(511, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_benhly);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txt_nghenghiep);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_madinhdanh);
            groupBox1.Controls.Add(cbo_gioitinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtp_ngaysinh);
            groupBox1.Controls.Add(txt_tenkh);
            groupBox1.Controls.Add(txt_makh);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 633);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm khách hàng";
            // 
            // txt_benhly
            // 
            txt_benhly.Location = new Point(586, 249);
            txt_benhly.Multiline = true;
            txt_benhly.Name = "txt_benhly";
            txt_benhly.Size = new Size(230, 99);
            txt_benhly.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(488, 286);
            label13.Name = "label13";
            label13.Size = new Size(73, 25);
            label13.TabIndex = 16;
            label13.Text = "Bệnh lý:";
            // 
            // txt_nghenghiep
            // 
            txt_nghenghiep.Location = new Point(586, 199);
            txt_nghenghiep.Name = "txt_nghenghiep";
            txt_nghenghiep.Size = new Size(230, 31);
            txt_nghenghiep.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(442, 205);
            label12.Name = "label12";
            label12.Size = new Size(119, 25);
            label12.TabIndex = 13;
            label12.Text = "Nghề nghiệp:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_email);
            groupBox3.Controls.Add(txt_sdt);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(403, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 150);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin liên hệ";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(80, 83);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(194, 31);
            txt_email.TabIndex = 3;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(80, 38);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(194, 31);
            txt_sdt.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 89);
            label11.Name = "label11";
            label11.Size = new Size(58, 25);
            label11.TabIndex = 1;
            label11.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 44);
            label10.Name = "label10";
            label10.Size = new Size(53, 25);
            label10.TabIndex = 0;
            label10.Text = "SĐT: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbo_district);
            groupBox2.Controls.Add(cbo_province);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txt_sonha);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(15, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 207);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Địa chỉ";
            // 
            // cbo_district
            // 
            cbo_district.FormattingEnabled = true;
            cbo_district.Location = new Point(136, 143);
            cbo_district.Name = "cbo_district";
            cbo_district.Size = new Size(228, 33);
            cbo_district.TabIndex = 5;
            // 
            // cbo_province
            // 
            cbo_province.FormattingEnabled = true;
            cbo_province.Location = new Point(136, 89);
            cbo_province.Name = "cbo_province";
            cbo_province.Size = new Size(228, 33);
            cbo_province.TabIndex = 4;
            cbo_province.SelectedIndexChanged += cbo_province_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 97);
            label9.Name = "label9";
            label9.Size = new Size(104, 25);
            label9.TabIndex = 3;
            label9.Text = "Tỉnh/Thành:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 151);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 2;
            label8.Text = "Quận huyện:";
            // 
            // txt_sonha
            // 
            txt_sonha.Location = new Point(177, 43);
            txt_sonha.Name = "txt_sonha";
            txt_sonha.Size = new Size(228, 31);
            txt_sonha.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 46);
            label7.Name = "label7";
            label7.Size = new Size(164, 25);
            label7.TabIndex = 0;
            label7.Text = "Số nhà, tên đường:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 255);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 10;
            label6.Text = "CCCD:";
            // 
            // txt_madinhdanh
            // 
            txt_madinhdanh.Location = new Point(123, 255);
            txt_madinhdanh.Name = "txt_madinhdanh";
            txt_madinhdanh.Size = new Size(256, 31);
            txt_madinhdanh.TabIndex = 9;
            // 
            // cbo_gioitinh
            // 
            cbo_gioitinh.FormattingEnabled = true;
            cbo_gioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbo_gioitinh.Location = new Point(123, 199);
            cbo_gioitinh.Name = "cbo_gioitinh";
            cbo_gioitinh.Size = new Size(256, 33);
            cbo_gioitinh.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 199);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 7;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 147);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 5;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 91);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên KH:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 36);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 3;
            label2.Text = "Mã KH:";
            // 
            // dtp_ngaysinh
            // 
            dtp_ngaysinh.Format = DateTimePickerFormat.Short;
            dtp_ngaysinh.Location = new Point(123, 147);
            dtp_ngaysinh.Name = "dtp_ngaysinh";
            dtp_ngaysinh.Size = new Size(256, 31);
            dtp_ngaysinh.TabIndex = 2;
            // 
            // txt_tenkh
            // 
            txt_tenkh.Location = new Point(123, 88);
            txt_tenkh.Name = "txt_tenkh";
            txt_tenkh.Size = new Size(256, 31);
            txt_tenkh.TabIndex = 1;
            // 
            // txt_makh
            // 
            txt_makh.Location = new Point(123, 36);
            txt_makh.Name = "txt_makh";
            txt_makh.Size = new Size(256, 31);
            txt_makh.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(26, 365);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 655);
            panel1.TabIndex = 3;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa.Image = Properties.Resources.minus;
            btn_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa.Location = new Point(979, 480);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(120, 60);
            btn_xoa.TabIndex = 5;
            btn_xoa.Text = "Xóa";
            btn_xoa.TextAlign = ContentAlignment.MiddleRight;
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.Image = Properties.Resources.repair;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(979, 573);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(120, 60);
            btn_sua.TabIndex = 6;
            btn_sua.Text = "Sửa";
            btn_sua.TextAlign = ContentAlignment.MiddleRight;
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_them.Image = Properties.Resources.plus;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(979, 390);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(120, 60);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm";
            btn_them.TextAlign = ContentAlignment.MiddleRight;
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lammoi.Image = Properties.Resources.refresh;
            btn_lammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi.Location = new Point(1132, 390);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(155, 60);
            btn_lammoi.TabIndex = 8;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.TextAlign = ContentAlignment.MiddleRight;
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_timkiem.Image = Properties.Resources.search;
            btn_timkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_timkiem.Location = new Point(1132, 473);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(161, 71);
            btn_timkiem.TabIndex = 9;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.TextAlign = ContentAlignment.MiddleRight;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // dgv_customer
            // 
            dgv_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Location = new Point(29, 50);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowHeadersWidth = 62;
            dgv_customer.Size = new Size(1264, 293);
            dgv_customer.TabIndex = 10;
            dgv_customer.CellClick += dgv_customer_CellClick;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 1032);
            Controls.Add(dgv_customer);
            Controls.Add(btn_timkiem);
            Controls.Add(btn_lammoi);
            Controls.Add(btn_them);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_makh;
        private DateTimePicker dtp_ngaysinh;
        private TextBox txt_tenkh;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbo_gioitinh;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox txt_sonha;
        private Label label7;
        private Label label6;
        private TextBox txt_madinhdanh;
        private Panel panel1;
        private ComboBox cbo_district;
        private ComboBox cbo_province;
        private Label label9;
        private Label label8;
        private TextBox txt_nghenghiep;
        private Label label12;
        private GroupBox groupBox3;
        private TextBox txt_email;
        private TextBox txt_sdt;
        private Label label11;
        private Label label10;
        private TextBox txt_benhly;
        private Label label13;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_lammoi;
        private Button btn_timkiem;
        private DataGridView dgv_customer;
    }
}