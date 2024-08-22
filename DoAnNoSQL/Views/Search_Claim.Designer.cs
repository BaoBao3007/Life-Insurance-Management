namespace DoAnNoSQL.Views
{
    partial class Search_Claim
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
            danhsach = new DataGridView();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            startdate = new DateTimePicker();
            enddate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            choxuli = new RadioButton();
            dangxuli = new RadioButton();
            choxacnhan = new RadioButton();
            chopheduyet = new RadioButton();
            groupBox4 = new GroupBox();
            txt_tenKH = new TextBox();
            button3 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)danhsach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // danhsach
            // 
            danhsach.AccessibleDescription = " ";
            danhsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhsach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            danhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhsach.Location = new Point(30, 308);
            danhsach.Name = "danhsach";
            danhsach.RowHeadersWidth = 51;
            danhsach.Size = new Size(1023, 205);
            danhsach.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(340, 24);
            label1.Name = "label1";
            label1.Size = new Size(397, 25);
            label1.TabIndex = 7;
            label1.Text = "TÌM KIẾM YÊU CẦU BỒI THƯỜNG";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Location = new Point(30, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1023, 165);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(startdate);
            groupBox3.Controls.Add(enddate);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(414, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(403, 118);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ngày yêu cầu";
            // 
            // startdate
            // 
            startdate.CustomFormat = " dd-MM-yyyy";
            startdate.Format = DateTimePickerFormat.Custom;
            startdate.ImeMode = ImeMode.NoControl;
            startdate.Location = new Point(132, 31);
            startdate.Name = "startdate";
            startdate.Size = new Size(250, 27);
            startdate.TabIndex = 20;
            // 
            // enddate
            // 
            enddate.CustomFormat = " dd-MM-yyyy";
            enddate.Format = DateTimePickerFormat.Custom;
            enddate.Location = new Point(132, 72);
            enddate.Name = "enddate";
            enddate.Size = new Size(250, 27);
            enddate.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 38);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 11;
            label2.Text = "Ngày bắt đầu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 77);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 18;
            label3.Text = "Ngày kết thúc :";
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Location = new Point(893, 115);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Mặc Định";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(893, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Lọc";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(choxuli);
            groupBox1.Controls.Add(dangxuli);
            groupBox1.Controls.Add(choxacnhan);
            groupBox1.Controls.Add(chopheduyet);
            groupBox1.Location = new Point(6, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 118);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng Thái";
            // 
            // choxuli
            // 
            choxuli.AutoSize = true;
            choxuli.Location = new Point(156, 75);
            choxuli.Name = "choxuli";
            choxuli.Size = new Size(88, 24);
            choxuli.TabIndex = 12;
            choxuli.TabStop = true;
            choxuli.Text = "Chờ xử lí";
            choxuli.UseVisualStyleBackColor = true;
            // 
            // dangxuli
            // 
            dangxuli.AutoSize = true;
            dangxuli.Location = new Point(156, 36);
            dangxuli.Name = "dangxuli";
            dangxuli.Size = new Size(98, 24);
            dangxuli.TabIndex = 11;
            dangxuli.TabStop = true;
            dangxuli.Text = "Đang xử lí";
            dangxuli.UseVisualStyleBackColor = true;
            // 
            // choxacnhan
            // 
            choxacnhan.AutoSize = true;
            choxacnhan.Location = new Point(6, 75);
            choxacnhan.Name = "choxacnhan";
            choxacnhan.Size = new Size(118, 24);
            choxacnhan.TabIndex = 10;
            choxacnhan.TabStop = true;
            choxacnhan.Text = "Chờ xác nhận";
            choxacnhan.UseVisualStyleBackColor = true;
            // 
            // chopheduyet
            // 
            chopheduyet.AutoSize = true;
            chopheduyet.Location = new Point(6, 36);
            chopheduyet.Name = "chopheduyet";
            chopheduyet.Size = new Size(126, 24);
            chopheduyet.TabIndex = 9;
            chopheduyet.TabStop = true;
            chopheduyet.Text = "Chờ phê duyệt";
            chopheduyet.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_tenKH);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(28, 232);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1025, 70);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // txt_tenKH
            // 
            txt_tenKH.Location = new Point(178, 27);
            txt_tenKH.Name = "txt_tenKH";
            txt_tenKH.Size = new Size(455, 27);
            txt_tenKH.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Location = new Point(797, 25);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Tìm kiếm";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 34);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên khách hàng :";
            // 
            // Search_Claim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 535);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(danhsach);
            Name = "Search_Claim";
            Text = "Search_Claim";
            Load += Search_Claim_Load;
            ((System.ComponentModel.ISupportInitialize)danhsach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView danhsach;
        private Label label1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton choxuli;
        private RadioButton dangxuli;
        private RadioButton choxacnhan;
        private RadioButton chopheduyet;
        private GroupBox groupBox4;
        private TextBox txt_tenKH;
        private Button button3;
        private Label label4;
        private Label label2;
        private GroupBox groupBox3;
        private DateTimePicker startdate;
        private DateTimePicker enddate;
        private Label label3;
    }
}