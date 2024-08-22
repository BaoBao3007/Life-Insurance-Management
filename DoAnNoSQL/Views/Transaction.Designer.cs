using System;
using System.Windows.Forms;

namespace DoAnNoSQL.Views
{
    partial class Transaction
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
            txtMaGiaoDich = new TextBox();
            dateTimePickerNgayGiaoDich = new DateTimePicker();
            txtSoTien = new TextBox();
            txtMoTa = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnFilter = new Button();
            dataGridViewTransaction = new DataGridView();
            txtMaKhachHang = new TextBox();
            txtTenKhachHang = new TextBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            lblMaGiaoDich = new Label();
            lblNgayGiaoDich = new Label();
            lblSoTien = new Label();
            lblMoTa = new Label();
            lblMaKhachHang = new Label();
            lblTenKhachHang = new Label();
            lblNgayBatDau = new Label();
            lblNgayKetThuc = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).BeginInit();
            SuspendLayout();
            // 
            // txtMaGiaoDich
            // 
            txtMaGiaoDich.Location = new Point(15, 71);
            txtMaGiaoDich.Margin = new Padding(4, 5, 4, 5);
            txtMaGiaoDich.Name = "txtMaGiaoDich";
            txtMaGiaoDich.Size = new Size(274, 31);
            txtMaGiaoDich.TabIndex = 0;
            // 
            // dateTimePickerNgayGiaoDich
            // 
            dateTimePickerNgayGiaoDich.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayGiaoDich.Location = new Point(15, 140);
            dateTimePickerNgayGiaoDich.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerNgayGiaoDich.Name = "dateTimePickerNgayGiaoDich";
            dateTimePickerNgayGiaoDich.Size = new Size(274, 31);
            dateTimePickerNgayGiaoDich.TabIndex = 1;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(15, 202);
            txtSoTien.Margin = new Padding(4, 5, 4, 5);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(274, 31);
            txtSoTien.TabIndex = 2;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(15, 265);
            txtMoTa.Margin = new Padding(4, 5, 4, 5);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(274, 31);
            txtMoTa.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(315, 55);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 58);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(315, 154);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 58);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(315, 241);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 58);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(971, 99);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 75);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(822, 256);
            btnFilter.Margin = new Padding(4, 5, 4, 5);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(130, 58);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // dataGridViewTransaction
            // 
            dataGridViewTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaction.Location = new Point(15, 335);
            dataGridViewTransaction.Margin = new Padding(4, 5, 4, 5);
            dataGridViewTransaction.Name = "dataGridViewTransaction";
            dataGridViewTransaction.RowHeadersWidth = 51;
            dataGridViewTransaction.RowTemplate.Height = 24;
            dataGridViewTransaction.Size = new Size(938, 252);
            dataGridViewTransaction.TabIndex = 9;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(520, 78);
            txtMaKhachHang.Margin = new Padding(4, 5, 4, 5);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(443, 31);
            txtMaKhachHang.TabIndex = 10;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(520, 154);
            txtTenKhachHang.Margin = new Padding(4, 5, 4, 5);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(443, 31);
            txtTenKhachHang.TabIndex = 11;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(520, 222);
            dateTimePickerStart.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(249, 31);
            dateTimePickerStart.TabIndex = 12;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(520, 291);
            dateTimePickerEnd.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(249, 31);
            dateTimePickerEnd.TabIndex = 13;
            // 
            // lblMaGiaoDich
            // 
            lblMaGiaoDich.AutoSize = true;
            lblMaGiaoDich.Location = new Point(15, 38);
            lblMaGiaoDich.Margin = new Padding(4, 0, 4, 0);
            lblMaGiaoDich.Name = "lblMaGiaoDich";
            lblMaGiaoDich.Size = new Size(119, 25);
            lblMaGiaoDich.TabIndex = 15;
            lblMaGiaoDich.Text = "Mã giao dịch:";
            // 
            // lblNgayGiaoDich
            // 
            lblNgayGiaoDich.AutoSize = true;
            lblNgayGiaoDich.Location = new Point(15, 110);
            lblNgayGiaoDich.Margin = new Padding(4, 0, 4, 0);
            lblNgayGiaoDich.Name = "lblNgayGiaoDich";
            lblNgayGiaoDich.Size = new Size(136, 25);
            lblNgayGiaoDich.TabIndex = 16;
            lblNgayGiaoDich.Text = "Ngày giao dịch:";
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(15, 172);
            lblSoTien.Margin = new Padding(4, 0, 4, 0);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(71, 25);
            lblSoTien.TabIndex = 17;
            lblSoTien.Text = "Số tiền:";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(15, 235);
            lblMoTa.Margin = new Padding(4, 0, 4, 0);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(63, 25);
            lblMoTa.TabIndex = 18;
            lblMoTa.Text = "Mô tả:";
            // 
            // lblMaKhachHang
            // 
            lblMaKhachHang.AutoSize = true;
            lblMaKhachHang.Location = new Point(522, 48);
            lblMaKhachHang.Margin = new Padding(4, 0, 4, 0);
            lblMaKhachHang.Name = "lblMaKhachHang";
            lblMaKhachHang.Size = new Size(137, 25);
            lblMaKhachHang.TabIndex = 19;
            lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(520, 124);
            lblTenKhachHang.Margin = new Padding(4, 0, 4, 0);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(138, 25);
            lblTenKhachHang.TabIndex = 20;
            lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Location = new Point(520, 192);
            lblNgayBatDau.Margin = new Padding(4, 0, 4, 0);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(124, 25);
            lblNgayBatDau.TabIndex = 21;
            lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Location = new Point(520, 261);
            lblNgayKetThuc.Margin = new Padding(4, 0, 4, 0);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(126, 25);
            lblNgayKetThuc.TabIndex = 22;
            lblNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(418, -4);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 48);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "GIAO DỊCH";
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 701);
            Controls.Add(lblTitle);
            Controls.Add(lblNgayKetThuc);
            Controls.Add(lblNgayBatDau);
            Controls.Add(lblTenKhachHang);
            Controls.Add(lblMaKhachHang);
            Controls.Add(lblMoTa);
            Controls.Add(lblSoTien);
            Controls.Add(lblNgayGiaoDich);
            Controls.Add(lblMaGiaoDich);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtMaKhachHang);
            Controls.Add(dataGridViewTransaction);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtMoTa);
            Controls.Add(txtSoTien);
            Controls.Add(dateTimePickerNgayGiaoDich);
            Controls.Add(txtMaGiaoDich);
            Margin = new Padding(4);
            Name = "Transaction";
            Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaGiaoDich;
        private DateTimePicker dateTimePickerNgayGiaoDich;
        private TextBox txtSoTien;
        private TextBox txtMoTa;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnFilter;
        private DataGridView dataGridViewTransaction;
        private TextBox txtMaKhachHang;
        private TextBox txtTenKhachHang;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label lblMaGiaoDich;
        private Label lblNgayGiaoDich;
        private Label lblSoTien;
        private Label lblMoTa;
        private Label lblMaKhachHang;
        private Label lblTenKhachHang;
        private Label lblNgayBatDau;
        private Label lblNgayKetThuc;
        private Label lblTitle;
    }
}
