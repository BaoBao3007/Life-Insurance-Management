using DoAnNoSQL.Controllers;
using DoAnNoSQL.DataAccess;
using DoAnNoSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNoSQL.Views
{
    public partial class Frm_TimHD : Form
    {
        private readonly CustomerController customerController;
        public Frm_TimHD()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            customerController = new CustomerController(repository);

            LoadContractTypes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btn_timKiem_Click(object sender, EventArgs e)
        {



        }
        private void LoadContractTypes()
        {
            try
            {
                // Lấy danh sách các loại hợp đồng từ CustomerController
                var contractTypes = customerController.GetUniqueContractTypes();

                // Cập nhật cbo_loaiHD với danh sách các loại hợp đồng
                cbo_LoaiHD.DataSource = contractTypes;
                cbo_LoaiHD.SelectedIndex = -1; // Không chọn mục nào khi vừa load
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải loại hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_timKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    string tenKH = txt_tenkh.Text;
                    var contracts = customerController.GetContractsByCustomerName(tenKH);
                    if (contracts != null && contracts.Any())
                    {
                        DisplayContracts(contracts);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hợp đồng với mã này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioButton2.Checked)
                {
                    string loaiHopDong = cbo_LoaiHD.SelectedItem.ToString();
                    var contracts = customerController.GetContractsByContractType(loaiHopDong);

                    if (contracts.Any())
                    {
                        DisplayContracts(contracts);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hợp đồng cho loại hợp đồng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một loại tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu ngày bắt đầu và ngày kết thúc hợp lệ
                if (DateTime.TryParse(txt_ngayky.Text, out DateTime startDate) &&
                    DateTime.TryParse(txt_ngayketthuc.Text, out DateTime endDate))
                {
                    startDate = startDate.Date;
                    endDate = endDate.Date.AddDays(1).AddTicks(-1);
                    // Gọi phương thức từ CustomerController để lấy hợp đồng theo ngày
                    var contracts = customerController.GetContractsByDateRange(startDate, endDate);

                    if (contracts.Any())
                    {
                        DisplayContracts(contracts);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hợp đồng trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ngày hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lọc hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayContracts(List<HopDongBaoHiem> contracts)
        {
            try
            {
                var dataTable = new DataTable();
                dataTable.Columns.Add("Mã Hợp Đồng", typeof(string));
                dataTable.Columns.Add("Loại Hợp Đồng", typeof(string));
                dataTable.Columns.Add("Ngày Bắt Đầu", typeof(DateTime));
                dataTable.Columns.Add("Ngày Kết Thúc", typeof(DateTime));
                dataTable.Columns.Add("Phí Bảo Hiểm", typeof(decimal));
                dataTable.Columns.Add("Số Tiền Bảo Hiểm", typeof(decimal));
                dataTable.Columns.Add("Tên Đại Lý", typeof(string));

                // Thêm dữ liệu vào DataTable
                foreach (var contract in contracts)
                {
                    dataTable.Rows.Add(
                        contract.MaHopDong,
                        contract.LoaiHopDong,
                        contract.NgayBatDau.Date,
                        contract.NgayKetThuc.Date,
                        contract.PhiBaoHiem,
                        contract.SoTienBaoHiem,
                        contract.DaiLy?.TenDaiLy ?? "Không có thông tin"
                    );
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi hiển thị hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
