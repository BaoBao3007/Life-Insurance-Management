using DoAnNoSQL.Controllers;
using DoAnNoSQL.DataAccess;
using DoAnNoSQL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows.Forms;

namespace DoAnNoSQL.Views
{
    public partial class Transaction : Form
    {
        private CustomerController controller;
        private List<TransactionHistoryViewModel> allTransactions;

        public Transaction()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            controller = new CustomerController(repository);

            allTransactions = new List<TransactionHistoryViewModel>();

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            dataGridViewTransaction.CellClick += DataGridViewTransaction_CellClick;

            LoadTransactionData();
        }
        private void DataGridViewTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the row index is valid
            {
                DataGridViewRow row = dataGridViewTransaction.Rows[e.RowIndex];

                txtMaGiaoDich.Text = row.Cells["MaGiaoDich"].Value?.ToString();
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value?.ToString(); // Update this if using ViewModel
                if (DateTime.TryParse(row.Cells["NgayGiaoDich"].Value?.ToString(), out DateTime dateValue))
                {
                    dateTimePickerNgayGiaoDich.Value = dateValue;
                }
                else
                {
                    dateTimePickerNgayGiaoDich.Value = DateTime.Now; // Default value in case of parse failure
                }
                txtSoTien.Text = row.Cells["SoTien"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
            }
            dataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = txtMaKhachHang.Text;
                if (string.IsNullOrEmpty(customerId))
                {
                    MessageBox.Show("Mã khách hàng không được để trống.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newTransaction = new LichSuGiaoDich
                {
                    MaGiaoDich = txtMaGiaoDich.Text,
                    MoTa = txtMoTa.Text,
                    NgayGiaoDich = dateTimePickerNgayGiaoDich.Value,
                    SoTien = decimal.Parse(txtSoTien.Text)
                };
                controller.AddTransactionHistory(customerId, newTransaction);
                LoadTransactionData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = txtMaKhachHang.Text;
                if (string.IsNullOrEmpty(customerId))
                {
                    MessageBox.Show("Mã khách hàng không được để trống.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string transactionId = txtMaGiaoDich.Text;
                string newDescription = txtMoTa.Text;
                DateTime newDate = dateTimePickerNgayGiaoDich.Value;
                decimal newAmount = decimal.Parse(txtSoTien.Text);

                controller.UpdateTransactionHistory(customerId, transactionId, newDescription, newDate, newAmount);
                LoadTransactionData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error editing transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = txtMaKhachHang.Text;
                if (string.IsNullOrEmpty(customerId))
                {
                    MessageBox.Show("Mã khách hàng không được để trống.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string transactionId = txtMaGiaoDich.Text;
                controller.DeleteTransactionHistory(customerId, transactionId);
                LoadTransactionData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ClearInputs()
        {
            txtMaGiaoDich.Clear();
            dateTimePickerNgayGiaoDich.Value = DateTime.Now; // Reset DateTimePicker
            txtSoTien.Clear();
            txtMoTa.Clear();
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
        }

        private void LoadTransactionData()
        {
            try
            {
                var transactionHistories = controller.GetAllTransactionHistoriess();
                allTransactions = transactionHistories.Select(item => new TransactionHistoryViewModel
                {
                    MaKhachHang = item.MaKhachHang,
                    MaGiaoDich = item.LichSuGiaoDich.MaGiaoDich,
                    NgayGiaoDich = item.LichSuGiaoDich.NgayGiaoDich,
                    SoTien = item.LichSuGiaoDich.SoTien,
                    MoTa = item.LichSuGiaoDich.MoTa
                }).ToList();

                dataGridViewTransaction.DataSource = allTransactions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
            dataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        public class TransactionHistoryViewModel
        {
            public string MaKhachHang { get; set; }
            public string MaGiaoDich { get; set; }
            public DateTime NgayGiaoDich { get; set; }
            public decimal SoTien { get; set; }
            public string MoTa { get; set; }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;


            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<LichSuGiaoDich> transactions = controller.FilterTransactionByDate(startDate, endDate);

                // Hiển thị kết quả trong DataGridView hoặc bất kỳ control nào khác
                dataGridViewTransaction.DataSource = transactions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = txtMaKhachHang.Text.Trim();
                string customerName = txtTenKhachHang.Text.Trim();

                List<TransactionHistoryViewModel> viewModelList = new List<TransactionHistoryViewModel>();

                if (string.IsNullOrEmpty(customerId) && string.IsNullOrEmpty(customerName))
                {
                    // Trả về tất cả dữ liệu nếu không có mã khách hàng hoặc tên khách hàng
                    LoadTransactionData();
                    return;
                }

                if (!string.IsNullOrEmpty(customerId))
                {
                    // Tìm kiếm theo mã khách hàng
                    var transactions = controller.GetTransactionHistoryByCustomerId(customerId);
                    viewModelList = transactions.Select(t => new TransactionHistoryViewModel
                    {
                        MaKhachHang = customerId, // Sử dụng mã khách hàng đã cho
                        MaGiaoDich = t.MaGiaoDich,
                        NgayGiaoDich = t.NgayGiaoDich,
                        SoTien = t.SoTien,
                        MoTa = t.MoTa
                    }).ToList();
                }
                else if (!string.IsNullOrEmpty(customerName))
                {
                    // Tìm kiếm theo tên khách hàng
                    var customer = controller.GetCustomerByName1(customerName);
                    if (customer != null)
                    {
                        var transactions = controller.GetTransactionHistoryByCustomerId(customer.MaKhachHang);
                        viewModelList = transactions.Select(t => new TransactionHistoryViewModel
                        {
                            MaKhachHang = customer.MaKhachHang, // Sử dụng mã khách hàng từ đối tượng khách hàng
                            MaGiaoDich = t.MaGiaoDich,
                            NgayGiaoDich = t.NgayGiaoDich,
                            SoTien = t.SoTien,
                            MoTa = t.MoTa
                        }).ToList();

                        // Cập nhật mã khách hàng vào ô nhập liệu
                        txtMaKhachHang.Text = customer.MaKhachHang;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với tên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                dataGridViewTransaction.DataSource = viewModelList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm dữ liệu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
