namespace DoAnNoSQL.Views
{
    partial class QuyenLoi
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnAddbutton = new Button();
            btnDeleetebutton = new Button();
            btnEditbutton = new Button();
            btnFilterbutton = new Button();
            txtSearch = new TextBox();
            btnSearchButton = new Button();
            txtMaKhachHang = new TextBox();
            txtMaQuyenLoi = new TextBox();
            txtLoaiQuyenLoi = new TextBox();
            txtSoTienBaoHiem = new TextBox();
            txtDieuKien = new TextBox();
            comboBox1 = new ComboBox();
            btnRefresh = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(149, 146);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(924, 235);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(419, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(404, 48);
            label1.TabIndex = 1;
            label1.Text = "Quyền Lợi Khách Hàng";
            label1.Click += label1_Click;
            // 
            // btnAddbutton
            // 
            btnAddbutton.Location = new Point(506, 386);
            btnAddbutton.Margin = new Padding(4, 4, 4, 4);
            btnAddbutton.Name = "btnAddbutton";
            btnAddbutton.Size = new Size(118, 42);
            btnAddbutton.TabIndex = 2;
            btnAddbutton.Text = "Thêm ";
            btnAddbutton.UseVisualStyleBackColor = true;
            btnAddbutton.Click += btnAddbutton_Click;
            // 
            // btnDeleetebutton
            // 
            btnDeleetebutton.Location = new Point(506, 494);
            btnDeleetebutton.Margin = new Padding(4, 4, 4, 4);
            btnDeleetebutton.Name = "btnDeleetebutton";
            btnDeleetebutton.Size = new Size(118, 42);
            btnDeleetebutton.TabIndex = 3;
            btnDeleetebutton.Text = "Xóa";
            btnDeleetebutton.UseVisualStyleBackColor = true;
            btnDeleetebutton.Click += btnDeleetebutton_Click;
            // 
            // btnEditbutton
            // 
            btnEditbutton.Location = new Point(506, 436);
            btnEditbutton.Margin = new Padding(4, 4, 4, 4);
            btnEditbutton.Name = "btnEditbutton";
            btnEditbutton.Size = new Size(118, 46);
            btnEditbutton.TabIndex = 4;
            btnEditbutton.Text = "Sửa";
            btnEditbutton.UseVisualStyleBackColor = true;
            btnEditbutton.Click += btnEditbutton_Click;
            // 
            // btnFilterbutton
            // 
            btnFilterbutton.Enabled = false;
            btnFilterbutton.Location = new Point(955, 386);
            btnFilterbutton.Margin = new Padding(4, 4, 4, 4);
            btnFilterbutton.Name = "btnFilterbutton";
            btnFilterbutton.Size = new Size(118, 42);
            btnFilterbutton.TabIndex = 5;
            btnFilterbutton.Text = "Lọc ";
            btnFilterbutton.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(739, 101);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 42);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // btnSearchButton
            // 
            btnSearchButton.Location = new Point(976, 101);
            btnSearchButton.Margin = new Padding(4, 4, 4, 4);
            btnSearchButton.Name = "btnSearchButton";
            btnSearchButton.Size = new Size(99, 42);
            btnSearchButton.TabIndex = 7;
            btnSearchButton.Text = "Tìm";
            btnSearchButton.UseVisualStyleBackColor = true;
            btnSearchButton.Click += btnSearchButton_Click;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(258, 386);
            txtMaKhachHang.Margin = new Padding(4, 4, 4, 4);
            txtMaKhachHang.Multiline = true;
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(240, 42);
            txtMaKhachHang.TabIndex = 8;
            // 
            // txtMaQuyenLoi
            // 
            txtMaQuyenLoi.Location = new Point(258, 436);
            txtMaQuyenLoi.Margin = new Padding(4, 4, 4, 4);
            txtMaQuyenLoi.Multiline = true;
            txtMaQuyenLoi.Name = "txtMaQuyenLoi";
            txtMaQuyenLoi.Size = new Size(240, 42);
            txtMaQuyenLoi.TabIndex = 9;
            // 
            // txtLoaiQuyenLoi
            // 
            txtLoaiQuyenLoi.Location = new Point(258, 490);
            txtLoaiQuyenLoi.Margin = new Padding(4, 4, 4, 4);
            txtLoaiQuyenLoi.Multiline = true;
            txtLoaiQuyenLoi.Name = "txtLoaiQuyenLoi";
            txtLoaiQuyenLoi.Size = new Size(240, 42);
            txtLoaiQuyenLoi.TabIndex = 10;
            // 
            // txtSoTienBaoHiem
            // 
            txtSoTienBaoHiem.Location = new Point(258, 540);
            txtSoTienBaoHiem.Margin = new Padding(4, 4, 4, 4);
            txtSoTienBaoHiem.Multiline = true;
            txtSoTienBaoHiem.Name = "txtSoTienBaoHiem";
            txtSoTienBaoHiem.Size = new Size(240, 42);
            txtSoTienBaoHiem.TabIndex = 11;
            // 
            // txtDieuKien
            // 
            txtDieuKien.Location = new Point(258, 590);
            txtDieuKien.Margin = new Padding(4, 4, 4, 4);
            txtDieuKien.Multiline = true;
            txtDieuKien.Name = "txtDieuKien";
            txtDieuKien.Size = new Size(240, 42);
            txtDieuKien.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(705, 391);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 33);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(149, 96);
            btnRefresh.Margin = new Padding(4, 4, 4, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 42);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Tải lại";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 395);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 15;
            label2.Text = "MAKH:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 444);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 16;
            label3.Text = "MAQL:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 494);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 17;
            label4.Text = "LoaiQL:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 544);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 18;
            label5.Text = "SoTien:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 594);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 25);
            label6.TabIndex = 19;
            label6.Text = "DK:";
            // 
            // QuyenLoi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 665);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(comboBox1);
            Controls.Add(txtDieuKien);
            Controls.Add(txtSoTienBaoHiem);
            Controls.Add(txtLoaiQuyenLoi);
            Controls.Add(txtMaQuyenLoi);
            Controls.Add(txtMaKhachHang);
            Controls.Add(btnSearchButton);
            Controls.Add(txtSearch);
            Controls.Add(btnFilterbutton);
            Controls.Add(btnEditbutton);
            Controls.Add(btnDeleetebutton);
            Controls.Add(btnAddbutton);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "QuyenLoi";
            Text = "QuyenLoi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnAddbutton;
        private Button btnDeleetebutton;
        private Button btnEditbutton;
        private Button btnFilterbutton;
        private TextBox txtSearch;
        private Button btnSearchButton;
        private TextBox txtMaKhachHang;
        private TextBox txtMaQuyenLoi;
        private TextBox txtLoaiQuyenLoi;
        private TextBox txtSoTienBaoHiem;
        private TextBox txtDieuKien;
        private ComboBox comboBox1;
        private Button btnRefresh;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}