namespace DoAnNoSQL.Views
{
    partial class Frm_TimHD
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
            cbo_LoaiHD = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dataGridView1 = new DataGridView();
            btn_timKiem = new Button();
            txt_tenkh = new TextBox();
            label4 = new Label();
            txt_ngayky = new TextBox();
            txt_ngayketthuc = new TextBox();
            label2 = new Label();
            btn_loc = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(256, 38);
            label1.Name = "label1";
            label1.Size = new Size(258, 32);
            label1.TabIndex = 0;
            label1.Text = "TÌM KIẾM HỢP ĐỒNG";
            // 
            // cbo_LoaiHD
            // 
            cbo_LoaiHD.FormattingEnabled = true;
            cbo_LoaiHD.Location = new Point(232, 150);
            cbo_LoaiHD.Name = "cbo_LoaiHD";
            cbo_LoaiHD.Size = new Size(206, 33);
            cbo_LoaiHD.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 102);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(159, 29);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tên khách hàng";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(29, 154);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(154, 29);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Loại hợp đồng";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(695, 147);
            dataGridView1.TabIndex = 7;
            // 
            // btn_timKiem
            // 
            btn_timKiem.BackColor = SystemColors.Highlight;
            btn_timKiem.ForeColor = SystemColors.ButtonHighlight;
            btn_timKiem.Location = new Point(641, 151);
            btn_timKiem.Name = "btn_timKiem";
            btn_timKiem.Size = new Size(112, 34);
            btn_timKiem.TabIndex = 8;
            btn_timKiem.Text = "Tìm kiếm";
            btn_timKiem.UseVisualStyleBackColor = false;
            btn_timKiem.Click += btn_timKiem_Click_1;
            // 
            // txt_tenkh
            // 
            txt_tenkh.Location = new Point(232, 100);
            txt_tenkh.Name = "txt_tenkh";
            txt_tenkh.Size = new Size(203, 31);
            txt_tenkh.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 227);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 10;
            label4.Text = "Ngày đăng ký";
            // 
            // txt_ngayky
            // 
            txt_ngayky.Location = new Point(232, 227);
            txt_ngayky.Name = "txt_ngayky";
            txt_ngayky.Size = new Size(150, 31);
            txt_ngayky.TabIndex = 11;
            // 
            // txt_ngayketthuc
            // 
            txt_ngayketthuc.Location = new Point(603, 227);
            txt_ngayketthuc.Name = "txt_ngayketthuc";
            txt_ngayketthuc.Size = new Size(150, 31);
            txt_ngayketthuc.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 227);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 13;
            label2.Text = "Ngày hết hạn";
            // 
            // btn_loc
            // 
            btn_loc.BackColor = SystemColors.Highlight;
            btn_loc.ForeColor = SystemColors.ControlLightLight;
            btn_loc.Location = new Point(641, 273);
            btn_loc.Name = "btn_loc";
            btn_loc.Size = new Size(112, 34);
            btn_loc.TabIndex = 14;
            btn_loc.Text = "Lọc";
            btn_loc.UseVisualStyleBackColor = false;
            btn_loc.Click += btn_loc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 333);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 15;
            label3.Text = "Thông tin tìm kiếm";
            // 
            // Frm_TimHD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(label3);
            Controls.Add(btn_loc);
            Controls.Add(label2);
            Controls.Add(txt_ngayketthuc);
            Controls.Add(txt_ngayky);
            Controls.Add(label4);
            Controls.Add(txt_tenkh);
            Controls.Add(btn_timKiem);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(cbo_LoaiHD);
            Controls.Add(label1);
            Name = "Frm_TimHD";
            Text = "Frm_TimHD";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_ngayky;
        private ComboBox cbo_LoaiHD;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
        private Button btn_timKiem;
        private TextBox txt_tenkh;
        private Label label4;
        private TextBox txt_ngayketthuc;
        private Button btn_loc;
    }
}