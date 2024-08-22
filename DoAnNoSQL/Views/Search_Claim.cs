using DoAnNoSQL.Controllers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DoAnNoSQL.DataAccess;
using DoAnNoSQL.Models;

namespace DoAnNoSQL.Views
{
    public partial class Search_Claim : Form
    {
        private readonly CustomerController customerController;

        public Search_Claim()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            customerController = new CustomerController(repository);
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                // Lấy tất cả khách hàng từ controller
                var customers = customerController.GetCustomers();

                // Tạo một DataTable để chứa dữ liệu yêu cầu bồi thường
                var dataTable = new DataTable();

                // Tạo các cột cho DataTable
                dataTable.Columns.Add("Mã Khách Hàng", typeof(string));
                dataTable.Columns.Add("Tên Khách Hàng", typeof(string));
                dataTable.Columns.Add("Mã Yêu Cầu", typeof(string));
                dataTable.Columns.Add("Ngày Yêu Cầu", typeof(DateTime));
                dataTable.Columns.Add("Trạng Thái", typeof(string));
                dataTable.Columns.Add("Số Tiền Yêu Cầu", typeof(decimal));
                dataTable.Columns.Add("Mô Tả", typeof(string));

                // Thêm các hàng vào DataTable
                foreach (var customer in customers)
                {
                    if (customer.YeuCauBoiThuong != null)
                    {
                        foreach (var claim in customer.YeuCauBoiThuong)
                        {
                            dataTable.Rows.Add(
                                customer.MaKhachHang,
                                customer.HoVaTen,
                                claim.MaYeuCau,
                                claim.NgayYeuCau,
                                claim.TrangThai,
                                claim.SoTienYeuCau,
                                claim.MoTa
                            );
                        }
                    }
                }

                // Gán DataTable cho DataGridView
                danhsach.DataSource = dataTable;
                // Định dạng cột "Ngày Yêu Cầu"
                danhsach.Columns["Ngày Yêu Cầu"].DefaultCellStyle.Format = "dd-MM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            txt_tenKH.Text = string.Empty;
            choxacnhan.Checked = false;
            chopheduyet.Checked = false;
            dangxuli.Checked = false;
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;

            LoadDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        // Tìm kiếm theo tên khách hàng
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên khách hàng từ TextBox
                string tenKhachHang = txt_tenKH.Text.Trim();

                if (string.IsNullOrEmpty(tenKhachHang))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách yêu cầu bồi thường từ repository
                var name = customerController.GetCustomersByName(tenKhachHang);

                // Tạo một DataTable để chứa dữ liệu yêu cầu bồi thường
                var dataTable = new DataTable();

                // Tạo các cột cho DataTable
                dataTable.Columns.Add("Mã Khách Hàng", typeof(string));
                dataTable.Columns.Add("Tên Khách Hàng", typeof(string));
                dataTable.Columns.Add("Mã Yêu Cầu", typeof(string));
                dataTable.Columns.Add("Ngày Yêu Cầu", typeof(DateTime));
                dataTable.Columns.Add("Trạng Thái", typeof(string));
                dataTable.Columns.Add("Số Tiền Yêu Cầu", typeof(decimal));
                dataTable.Columns.Add("Mô Tả", typeof(string));

                // Thêm các hàng vào DataTable
                foreach (var customer in name)
                {
                    if (customer.YeuCauBoiThuong != null)
                    {
                        foreach (var claim in customer.YeuCauBoiThuong)
                        {
                            dataTable.Rows.Add(
                                customer.MaKhachHang,
                                customer.HoVaTen,
                                claim.MaYeuCau,
                                claim.NgayYeuCau,
                                claim.TrangThai,
                                claim.SoTienYeuCau,
                                claim.MoTa
                            );
                        }
                    }
                }

                // Gán DataTable cho DataGridView
                danhsach.DataSource = dataTable;
                // Định dạng cột ngày yêu cầu để chỉ hiển thị ngày, tháng, năm
                danhsach.Columns["Ngày Yêu Cầu"].DefaultCellStyle.Format = "dd-MM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var status = GetSelectedStatus();
                DateTime startDate = startdate.Value.Date;
                DateTime endDate = enddate.Value.Date;


                // Kiểm tra nếu trạng thái là null hoặc chuỗi rỗng
                bool hasStatus = !string.IsNullOrEmpty(status);


                // Đảm bảo endDate không trước startDate
                if (endDate < startDate)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Khoảng thời gian không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo một DataTable để chứa dữ liệu yêu cầu bồi thường
                var dataTable = new DataTable();

                // Tạo các cột cho DataTable
                dataTable.Columns.Add("Mã Khách Hàng", typeof(string));
                dataTable.Columns.Add("Tên Khách Hàng", typeof(string));
                dataTable.Columns.Add("Mã Yêu Cầu", typeof(string));
                dataTable.Columns.Add("Ngày Yêu Cầu", typeof(DateTime));
                dataTable.Columns.Add("Trạng Thái", typeof(string));
                dataTable.Columns.Add("Số Tiền Yêu Cầu", typeof(decimal));
                dataTable.Columns.Add("Mô Tả", typeof(string));

                List<(Models.Customer, YeuCauBoiThuong)> claims;

                if (hasStatus)
                {

                    claims = customerController.GetClaimsByCustomerStatus(status);
                }
                else
                {

                    claims = customerController.GetClaimsByRequestDateRange(startDate, endDate);
                }

                // Thêm các hàng vào DataTable
                foreach (var (customer, claim) in claims)
                {
                    dataTable.Rows.Add(
                        customer.MaKhachHang,
                        customer.HoVaTen,
                        claim.MaYeuCau,
                        claim.NgayYeuCau.ToString("dd-MM-yyyy"),
                        claim.TrangThai,
                        claim.SoTienYeuCau,
                        claim.MoTa
                    ); ;
                }

                // Gán DataTable cho DataGridView
                danhsach.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm yêu cầu bồi thường: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedStatus()
        {
            // Xác định trạng thái đã chọn từ các radio button
            if (choxacnhan.Checked)
                return "Chờ xác nhận";
            if (chopheduyet.Checked)
                return "Chờ phê duyệt";
            if (dangxuli.Checked)
                return "Đang xử lý";
            if (choxuli.Checked)
                return "Chờ xử lý";

            return null;
        }

        private void Search_Claim_Load(object sender, EventArgs e)
        {

        }
    }
}
