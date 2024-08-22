using DoAnNoSQL.Controllers;
using DoAnNoSQL.DataAccess;
using DoAnNoSQL.Models;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoAnNoSQL.Models.Province_District;

namespace DoAnNoSQL.Views
{
    public partial class Customer : Form
    {
        private readonly CustomerController customerController;
        private static readonly HttpClient client = new HttpClient();

        public Customer()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            customerController = new CustomerController(repository);
            loadCustomers();
            LoadTinhThanh();
        }

        public void loadCustomers()
        {
            try
            {
                List<Models.Customer> customersFromDatabase = customerController.GetCustomers();
                List<CustomerViewModel> viewModels = new List<CustomerViewModel>();
                foreach (var customer in customersFromDatabase)
                {
                    CustomerViewModel viewModel = new CustomerViewModel(customer);
                    viewModels.Add(viewModel);
                }
                setUpDGV();
                dgv_customer.DataSource = viewModels;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setUpDGV()
        {
            dgv_customer.Columns.Clear();
            dgv_customer.AutoGenerateColumns = false;
            dgv_customer.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "MaKhachHang", HeaderText = "Mã khách hàng", DataPropertyName = "MaKhachHang" },
                new DataGridViewTextBoxColumn { Name = "MaDinhDanh", HeaderText = "CCCD", DataPropertyName = "MaDinhDanh" },
                new DataGridViewTextBoxColumn { Name = "HoTen", HeaderText = "Họ và tên", DataPropertyName = "HoTen" },
                new DataGridViewTextBoxColumn { Name = "NgaySinh", HeaderText = "Ngày sinh", DataPropertyName = "NgaySinh" },
                new DataGridViewTextBoxColumn { Name = "GioiTinh", HeaderText = "Giới tính", DataPropertyName = "GioiTinh" },
                new DataGridViewTextBoxColumn { Name = "SoDienThoai", HeaderText = "Số điện thoại", DataPropertyName = "SoDienThoai" },
                new DataGridViewTextBoxColumn { Name = "DiaChi", HeaderText = "Địa chỉ", DataPropertyName = "DiaChi" },
                new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", DataPropertyName = "Email" },
                new DataGridViewTextBoxColumn { Name = "ChucDanh", HeaderText = "Chức danh", DataPropertyName = "ChucDanh" },
                new DataGridViewTextBoxColumn { Name = "BenhLy", HeaderText = "Bệnh lý", DataPropertyName = "BenhLy", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "SoNhaVaTenDuong", HeaderText = "Số nhà", DataPropertyName = "SoNhaVaTenDuong", Visible = false },
                new DataGridViewTextBoxColumn { Name = "QuanHuyen", HeaderText = "Quận/Huyện", DataPropertyName = "QuanHuyen", Visible = false },
                new DataGridViewTextBoxColumn { Name = "TinhThanhPho", HeaderText = "Tỉnh/Thành phố", DataPropertyName = "TinhThanhPho", Visible = false }
            );
        }

        private Province_District GetLocationData(string url)
        {
            var response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            var jsonData = response.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Province_District>(jsonData);
        }

        private void LoadTinhThanh()
        {
            try
            {
                var a = 1;
                var b = 0;
                var url = $"https://esgoo.net/api-tinhthanh/{a}/{b}.htm";
                var response = GetLocationData(url);
                cbo_province.DataSource = null;
                cbo_province.Items.Clear();
                if (response != null && response.error == 0)
                {
                    var cleanedData = response.data.Select(d => new Location
                    {
                        id = d.id,
                        name = CleanName(d.name)
                    }).ToList();
                    cbo_province.DataSource = cleanedData;
                    cbo_province.DisplayMember = "name";
                    cbo_province.ValueMember = "id";
                }
                cbo_province.SelectedIndex = 0; 
                LoadQuanHuyen(((Location)cbo_province.SelectedItem).id); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadQuanHuyen(string provinceId)
        {
            try
            {
                var a = 2;
                var url = $"https://esgoo.net/api-tinhthanh/{a}/{provinceId}.htm";
                var response = GetLocationData(url);
                cbo_district.DataSource = null;
                cbo_district.Items.Clear();

                if (response != null && response.error == 0)
                {
                    var cleanedData = response.data.Select(d => new Location
                    {
                        id = d.id,
                        name = CleanName(d.name)
                    }).ToList();
                    cbo_district.DataSource = cleanedData;
                    cbo_district.DisplayMember = "name";
                    cbo_district.ValueMember = "id";
                }

                if (cbo_district.Items.Count > 0)
                {
                    cbo_district.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_district.DataSource = null;
                cbo_district.Items.Clear();
                cbo_district.SelectedIndex = -1;
            }
        }


        private string CleanName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }
            return name.Replace("Huyện ", "").Replace("Thành phố ", "").Replace("Tỉnh", "").Trim();
        }

        private void cbo_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_province.SelectedItem is Location selectedLocation && !string.IsNullOrEmpty(selectedLocation.id))
            {
                LoadQuanHuyen(selectedLocation.id);
            }
            else
            {
                cbo_district.DataSource = null;
                cbo_district.Items.Clear();
                cbo_district.SelectedIndex = -1;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProvince = cbo_province.SelectedItem as Location;
                var selectedDistrict = cbo_district.SelectedItem as Location;
                var gioiTinh = cbo_gioitinh.SelectedItem != null ? cbo_gioitinh.SelectedItem.ToString() : string.Empty;
                var validationResult = ValidateCustomerData(txt_makh.Text, txt_email.Text);
                if (validationResult != null)
                {
                    MessageBox.Show(validationResult, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var customer = new Models.Customer
                {
                    MaDinhDanh = txt_madinhdanh.Text,
                    MaKhachHang = txt_makh.Text,
                    HoVaTen = txt_tenkh.Text,
                    NgaySinh = dtp_ngaysinh.Value.Date,
                    GioiTinh = gioiTinh,
                    DiaChi = new DiaChi
                    {
                        SoNhaVaTenDuong = txt_sonha.Text,
                        QuanHuyen = selectedDistrict?.name,  
                        TinhThanhPho = selectedProvince?.name 
                    },
                    LienHe = new LienHe
                    {
                        SoDienThoai = txt_sdt.Text,
                        Email = txt_email.Text
                    },
                    NgheNghiep = new NgheNghiep
                    {
                        ChucDanh = txt_nghenghiep.Text
                    },
                    ThongTinSucKhoe = new ThongTinSucKhoe
                    {
                        BenhLy = txt_benhly.Text.Split(',').ToList()
                    }
                };
                customerController.AddCustomer(customer);

                MessageBox.Show("Khách hàng đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetValueFromCell(DataGridViewCell cell)
        {
            return cell.Value?.ToString() ?? "";
        }

        private DateTime GetDateTimeFromCell(DataGridViewCell cell)
        {
            if (cell.Value != null && DateTime.TryParse(cell.Value.ToString(), out DateTime result))
            {
                return result;
            }
            return DateTime.Now;
        }

        private string ValidateCustomerData(string customerCode, string email)
        {
            if (IsCustomerCodeExists(customerCode))
            {
                return "Mã khách hàng đã tồn tại. Vui lòng nhập mã khác.";
            }
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                return "Email không hợp lệ. Vui lòng kiểm tra lại.";
            }
            if (IsEmailExists(email))
            {
                return "Email đã được sử dụng. Vui lòng nhập email khác.";
            }

            return null;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            }
            catch
            {
                return false;
            }
        }



        private bool IsCustomerCodeExists(string customerId)
        {
            return customerController.GetCustomerById(customerId) != null;
        }

        private bool IsEmailExists(string email)
        {
            return customerController.GetCustomerByEmail(email) != null;
        }
        private void RefreshForm()
        {
            loadCustomers();
            LoadTinhThanh();
            dgv_customer.ClearSelection();
            cbo_district.SelectedIndex = -1;
            cbo_province.SelectedIndex = -1;
            txt_madinhdanh.Clear();
            txt_makh.Clear();
            txt_makh.Enabled = true;
            txt_tenkh.Clear();
            dtp_ngaysinh.Value = DateTime.Now;
            cbo_gioitinh.SelectedIndex = -1;
            txt_sonha.Clear();
            txt_sdt.Clear();
            txt_email.Clear();
            txt_nghenghiep.Clear();
            txt_benhly.Clear();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string customerCode = txt_makh.Text;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customerController.DeleteCustomer(customerCode);
                    MessageBox.Show("Khách hàng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCustomers();
                    RefreshForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProvince = cbo_province.SelectedItem as Location;
                var selectedDistrict = cbo_district.SelectedItem as Location;
                var gioiTinh = cbo_gioitinh.SelectedItem != null ? cbo_gioitinh.SelectedItem.ToString() : string.Empty;
                var customer = new Models.Customer
                {
                    MaDinhDanh = txt_madinhdanh.Text,
                    MaKhachHang = txt_makh.Text,
                    HoVaTen = txt_tenkh.Text,
                    NgaySinh = dtp_ngaysinh.Value,
                    GioiTinh = gioiTinh,
                    DiaChi = new DiaChi
                    {
                        SoNhaVaTenDuong = txt_sonha.Text,
                        QuanHuyen = selectedDistrict?.name ?? "",
                        TinhThanhPho = selectedProvince?.name ?? "" 
                    },
                    LienHe = new LienHe
                    {
                        SoDienThoai = txt_sdt.Text,
                        Email = txt_email.Text
                    },
                    NgheNghiep = new NgheNghiep
                    {
                        ChucDanh = txt_nghenghiep.Text
                    },
                    ThongTinSucKhoe = new ThongTinSucKhoe
                    {
                        BenhLy = txt_benhly.Text.Split(',').ToList()
                    }
                };
                customerController.UpdateCustomer(customer);

                MessageBox.Show("Khách hàng đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_SearchCustomer frmSearch = new frm_SearchCustomer();
            frmSearch.ShowDialog();
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_customer.Rows[e.RowIndex];
                txt_madinhdanh.Text = selectedRow.Cells["MaDinhDanh"].Value != DBNull.Value ? selectedRow.Cells["MaDinhDanh"].Value.ToString() : string.Empty;
                txt_makh.Text = selectedRow.Cells["MaKhachHang"].Value != DBNull.Value ? selectedRow.Cells["MaKhachHang"].Value.ToString() : string.Empty;
                txt_tenkh.Text = selectedRow.Cells["HoTen"].Value != DBNull.Value ? selectedRow.Cells["HoTen"].Value.ToString() : string.Empty;
                dtp_ngaysinh.Value = selectedRow.Cells["NgaySinh"].Value != DBNull.Value ? Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value) : DateTime.Now;
                cbo_gioitinh.SelectedItem = selectedRow.Cells["GioiTinh"].Value != DBNull.Value ? selectedRow.Cells["GioiTinh"].Value.ToString() : string.Empty;
                txt_sonha.Text = selectedRow.Cells["SoNhaVaTenDuong"].Value != DBNull.Value ? selectedRow.Cells["SoNhaVaTenDuong"].Value.ToString() : string.Empty;
                txt_sdt.Text = selectedRow.Cells["SoDienThoai"].Value != DBNull.Value ? selectedRow.Cells["SoDienThoai"].Value.ToString() : string.Empty;
                txt_email.Text = selectedRow.Cells["Email"].Value != DBNull.Value ? selectedRow.Cells["Email"].Value.ToString() : string.Empty;
                txt_nghenghiep.Text = selectedRow.Cells["ChucDanh"].Value != DBNull.Value ? selectedRow.Cells["ChucDanh"].Value.ToString() : string.Empty;
                txt_benhly.Text = selectedRow.Cells["BenhLy"].Value != DBNull.Value ? selectedRow.Cells["BenhLy"].Value.ToString() : string.Empty;

                string tinhThanhPho = selectedRow.Cells["TinhThanhPho"].Value != DBNull.Value ? CleanName(selectedRow.Cells["TinhThanhPho"].Value.ToString()) : string.Empty;
                string quanHuyen = selectedRow.Cells["QuanHuyen"].Value != DBNull.Value ? CleanName(selectedRow.Cells["QuanHuyen"].Value.ToString()) : string.Empty;

                if (cbo_province.Items.Count > 0)
                {
                    int provinceIndex = cbo_province.FindStringExact(tinhThanhPho);
                    cbo_province.SelectedIndex = provinceIndex != -1 ? provinceIndex : -1;
                }
                if (cbo_district.Items.Count > 0)
                {
                    int districtIndex = cbo_district.FindStringExact(quanHuyen);
                    cbo_district.SelectedIndex = districtIndex != -1 ? districtIndex : -1;
                }
            }
        }

    }
}
