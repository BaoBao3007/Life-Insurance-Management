using DoAnNoSQL.Controllers;
using DoAnNoSQL.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace DoAnNoSQL.Views
{
    public partial class frm_SearchCustomer : Form
    {
        private readonly CustomerController customerController;
        private DataTable dataTable;

        public frm_SearchCustomer()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            customerController = new CustomerController(repository);
            SetUpDataTable();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var customers = customerController.SearchCustomers(searchText);
                UpdateDataTable(customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetUpDataTable()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("Mã khách hàng", typeof(string));
            dataTable.Columns.Add("Mã định danh", typeof(string));
            dataTable.Columns.Add("Họ tên", typeof(string));
            dataTable.Columns.Add("Ngày sinh", typeof(DateTime));
            dataTable.Columns.Add("Giới tính", typeof(string));
            dataTable.Columns.Add("Số điện thoại", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Nghề nghiệp", typeof(string));
            dataTable.Columns.Add("Bệnh lý", typeof(string));
            dataTable.Columns.Add("Số nhà và tên đường", typeof(string));
            dataTable.Columns.Add("Quận huyện", typeof(string));
            dataTable.Columns.Add("Tỉnh/ Thành Phố", typeof(string));

            dgv_customer.DataSource = dataTable;
        }

        private void UpdateDataTable(List<Models.Customer> customers)
        {
            dataTable.Rows.Clear();

            foreach (var customer in customers)
            {
                dataTable.Rows.Add(
                    customer.MaKhachHang,
                    customer.MaDinhDanh,
                    customer.HoVaTen,
                    customer.NgaySinh,
                    customer.GioiTinh,
                    customer.LienHe.SoDienThoai,
                    customer.LienHe.Email,
                    customer.NgheNghiep?.ChucDanh, 
                    string.Join(", ", customer.ThongTinSucKhoe?.BenhLy)
                );
                dataTable.Rows[dataTable.Rows.Count - 1]["Số nhà và tên đường"] = customer.DiaChi?.SoNhaVaTenDuong;
                dataTable.Rows[dataTable.Rows.Count - 1]["Quận huyện"] = customer.DiaChi?.QuanHuyen;
                dataTable.Rows[dataTable.Rows.Count - 1]["Tỉnh/ Thành Phố"] = customer.DiaChi?.TinhThanhPho;
            }
        }
    }
}
