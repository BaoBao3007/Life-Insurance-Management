namespace DoAnNoSQL.Views
{
    partial class Claim
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
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            cmb_maKH = new ComboBox();
            txt_tenKH = new TextBox();
            cmb_trangthai = new ComboBox();
            txt_sotienYC = new TextBox();
            label13 = new Label();
            txt_maYC = new TextBox();
            label8 = new Label();
            label20 = new Label();
            label18 = new Label();
            date_ngayYC = new DateTimePicker();
            txt_moTa = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            groupBox4 = new GroupBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label12 = new Label();
            danhsachYC = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhsachYC).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 138);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 121);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã yêu cầu :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 235);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_maKH);
            groupBox1.Controls.Add(txt_tenKH);
            groupBox1.Controls.Add(cmb_trangthai);
            groupBox1.Controls.Add(txt_sotienYC);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txt_maYC);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(date_ngayYC);
            groupBox1.Controls.Add(txt_moTa);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(32, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1023, 277);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin ";
            // 
            // cmb_maKH
            // 
            cmb_maKH.FormattingEnabled = true;
            cmb_maKH.Location = new Point(181, 34);
            cmb_maKH.Name = "cmb_maKH";
            cmb_maKH.Size = new Size(288, 28);
            cmb_maKH.TabIndex = 39;
            cmb_maKH.SelectedIndexChanged += cmb_maKH_SelectedIndexChanged;
            // 
            // txt_tenKH
            // 
            txt_tenKH.Location = new Point(181, 74);
            txt_tenKH.Name = "txt_tenKH";
            txt_tenKH.Size = new Size(288, 27);
            txt_tenKH.TabIndex = 38;
            // 
            // cmb_trangthai
            // 
            cmb_trangthai.FormattingEnabled = true;
            cmb_trangthai.Location = new Point(696, 73);
            cmb_trangthai.Name = "cmb_trangthai";
            cmb_trangthai.Size = new Size(286, 28);
            cmb_trangthai.TabIndex = 26;
            // 
            // txt_sotienYC
            // 
            txt_sotienYC.Location = new Point(696, 118);
            txt_sotienYC.Name = "txt_sotienYC";
            txt_sotienYC.Size = new Size(286, 27);
            txt_sotienYC.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 81);
            label13.Name = "label13";
            label13.Size = new Size(118, 20);
            label13.TabIndex = 31;
            label13.Text = "Tên khách hàng :";
            // 
            // txt_maYC
            // 
            txt_maYC.Location = new Point(181, 114);
            txt_maYC.Name = "txt_maYC";
            txt_maYC.Size = new Size(288, 27);
            txt_maYC.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(529, 121);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 11;
            label8.Text = "Số tiền yêu cầu :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(15, 271);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 21;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 42);
            label18.Name = "label18";
            label18.Size = new Size(116, 20);
            label18.TabIndex = 19;
            label18.Text = "Mã khách hàng :";
            // 
            // date_ngayYC
            // 
            date_ngayYC.CustomFormat = " dd-MM-yyyy";
            date_ngayYC.Format = DateTimePickerFormat.Custom;
            date_ngayYC.Location = new Point(696, 35);
            date_ngayYC.Name = "date_ngayYC";
            date_ngayYC.Size = new Size(286, 27);
            date_ngayYC.TabIndex = 16;
            date_ngayYC.Value = new DateTime(2024, 8, 5, 8, 54, 43, 0);
            // 
            // txt_moTa
            // 
            txt_moTa.Location = new Point(181, 165);
            txt_moTa.Multiline = true;
            txt_moTa.Name = "txt_moTa";
            txt_moTa.Size = new Size(288, 96);
            txt_moTa.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 168);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 13;
            label10.Text = "Mô tả :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(529, 81);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 12;
            label9.Text = "Trạng thái :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(529, 42);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 7;
            label7.Text = "Ngày yêu cầu :";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(46, 40);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 11;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Location = new Point(228, 40);
            button2.Name = "button2";
            button2.Size = new Size(135, 43);
            button2.TabIndex = 12;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Location = new Point(626, 40);
            button3.Name = "button3";
            button3.Size = new Size(135, 43);
            button3.TabIndex = 13;
            button3.Text = "Làm mới";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Cyan;
            button4.Location = new Point(426, 40);
            button4.Name = "button4";
            button4.Size = new Size(135, 43);
            button4.TabIndex = 14;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Cyan;
            button7.Location = new Point(846, 40);
            button7.Name = "button7";
            button7.Size = new Size(136, 43);
            button7.TabIndex = 23;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button4);
            groupBox4.Location = new Point(32, 353);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1023, 104);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thao tác";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Cyan;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label12.Location = new Point(411, 24);
            label12.Name = "label12";
            label12.Size = new Size(353, 25);
            label12.TabIndex = 25;
            label12.Text = "PHIẾU YÊU CẦU BỒI THƯỜNG";
            // 
            // danhsachYC
            // 
            danhsachYC.AccessibleDescription = " ";
            danhsachYC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhsachYC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            danhsachYC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhsachYC.Location = new Point(32, 463);
            danhsachYC.Name = "danhsachYC";
            danhsachYC.RowHeadersWidth = 51;
            danhsachYC.Size = new Size(1023, 259);
            danhsachYC.TabIndex = 0;
            // 
            // Claim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 745);
            Controls.Add(danhsachYC);
            Controls.Add(label12);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label3);
            Name = "Claim";
            Text = "Claim";
            Load += Claim_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)danhsachYC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox4;
        private DateTimePicker date_ngayYC;
        private TextBox txt_moTa;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label20;
        private Label label18;
        private Button button7;
        private GroupBox groupBox4;
        private TextBox textBox6;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label4;
        private Label label5;
        private TextBox txt_maYC;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox txt_sotienYC;
        private ComboBox cmb_trangthai;
        private TextBox txt_tenKH;
        private ComboBox cmb_maKH;
        private DataGridView danhsachYC;
    }
}