using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Security.Claims;
using System.Windows.Forms;
using DoAnNoSQL.Controllers;
using DoAnNoSQL.DataAccess;
using DoAnNoSQL.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DoAnNoSQL.Views
{
    public partial class Claim : Form
    {
        private readonly CustomerController customerController;


        public Claim()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            customerController = new CustomerController(repository);

            danhsachYC.CellClick += DanhSachYC_CellClick;
            danhsachYC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            LoadDataGridView();
            LoadComboBoxData();

        }

        private void LoadComboBoxData()
        {


            try
            {
                // Lấy danh sách khách hàng
                var customers = customerController.GetCustomers();
                cmb_maKH.DataSource = customers.Select(c => c.MaKhachHang).ToList();

                // Lấy danh sách trạng thái
                var claimStatuses = customerController.GetClaimStatuses();
                cmb_trangthai.Items.Clear();
                cmb_trangthai.Items.AddRange(claimStatuses.ToArray());



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

                // Gán DataTable cho DataGridView
                danhsachYC.DataSource = dataTable;
                // Định dạng cột "Ngày Yêu Cầu"
                danhsachYC.Columns["Ngày Yêu Cầu"].DefaultCellStyle.Format = "dd-MM-yyyy";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_maKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var customers = customerController.GetCustomers();//lấy ds khách hàng lên

                // Kiểm tra nếu danh sách customers là null hoặc trống
                if (customers == null || !customers.Any())
                {
                    MessageBox.Show("Danh sách khách hàng trống hoặc chưa được tải.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu SelectedItem là null
                if (cmb_maKH.SelectedItem == null)
                {

                    return;
                }

                // Lấy Mã Khách Hàng hiện tại từ ComboBox
                string maKhachHang = cmb_maKH.SelectedItem.ToString();

                // Tìm khách hàng tương ứng
                var customer = customers.FirstOrDefault(c => c.MaKhachHang == maKhachHang);

                if (customer != null)
                {
                    // Hiển thị tên khách hàng trên Label
                    txt_tenKH.Text = customer.HoVaTen ?? "Không có tên"; // Đảm bảo rằng HoVaTen không phải là null
                }
                else
                {
                    txt_tenKH.Text = "Không tìm thấy khách hàng"; // Hiển thị thông báo nếu không tìm thấy khách hàng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi chọn khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Khai báo biến lưu trữ hợp đồng được chọn để sửa
        private YeuCauBoiThuong selectedClaim;

        private void DanhSachYC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String maKhachHang = danhsachYC.Rows[e.RowIndex].Cells["Mã Khách Hàng"].Value.ToString();
                String tenKhachHang = danhsachYC.Rows[e.RowIndex].Cells["Tên Khách Hàng"].Value.ToString();
                String maYeuCau = danhsachYC.Rows[e.RowIndex].Cells["Mã Yêu Cầu"].Value.ToString();


                selectedClaim = customerController.GetClaimById(maYeuCau);

                if (selectedClaim != null)
                {
                    // Hiển thị dữ liệu lên các trường tương ứng
                    cmb_maKH.SelectedItem = maKhachHang;
                    txt_tenKH.Text = tenKhachHang;
                    txt_maYC.Text = selectedClaim.MaYeuCau;
                    date_ngayYC.Value = selectedClaim.NgayYeuCau;
                    cmb_trangthai.SelectedItem = selectedClaim.TrangThai;
                    txt_sotienYC.Text = selectedClaim.SoTienYeuCau.ToString();
                    txt_moTa.Text = selectedClaim.MoTa;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy yêu cầu bồi thường
                    MessageBox.Show("Không tìm thấy yêu cầu bồi thường.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //làm mới
        private void clear()
        {
            txt_tenKH.Text = string.Empty;
            cmb_maKH.SelectedIndex = 0;
            txt_maYC.Text = string.Empty;
            cmb_trangthai.SelectedIndex = -1;
            txt_sotienYC.Text = string.Empty;
            txt_moTa.Text = string.Empty;
            date_ngayYC.Value = DateTime.Now;

            LoadDataGridView();
            selectedClaim = null;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }


        //xóa
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có yêu cầu được chọn
                if (selectedClaim == null)
                {
                    MessageBox.Show("Không có yêu cầu bồi thường nào được chọn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xóa hợp đồng khỏi cơ sở dữ liệu
                customerController.RemoveClaims(selectedClaim.MaYeuCau);

                MessageBox.Show("Xóa yêu cầu bồi thường thành công!", "Thông báo");
                LoadDataGridView();

                selectedClaim = null;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //them yeu cầu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = cmb_maKH.SelectedItem.ToString();
                string maYeuCau = txt_maYC.Text;
                DateTime ngayYeuCau = date_ngayYC.Value.Date; // Chỉ lấy phần ngày
                decimal soTienYeuCau = decimal.Parse(txt_sotienYC.Text);
                string trangThai = cmb_trangthai.SelectedItem.ToString();
                string moTa = txt_moTa.Text;

                YeuCauBoiThuong newClaim = new YeuCauBoiThuong
                {
                    MaYeuCau = maYeuCau,
                    NgayYeuCau = ngayYeuCau,
                    SoTienYeuCau = soTienYeuCau,
                    TrangThai = trangThai,
                    MoTa = moTa
                };

                try
                {
                    customerController.AddClaimToCustomer(maKhachHang, newClaim);
                    MessageBox.Show("Yêu cầu bồi thường đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Mã yêu cầu đã tồn tại. Vui lòng kiểm tra lại mã yêu cầu và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = cmb_maKH.SelectedItem.ToString();
                string maYeuCau = txt_maYC.Text;
                DateTime ngayYeuCau = date_ngayYC.Value.Date; // Chỉ lấy phần ngày
                decimal soTienYeuCau = decimal.Parse(txt_sotienYC.Text);
                string trangThai = cmb_trangthai.SelectedItem?.ToString();
                string moTa = txt_moTa.Text;

                YeuCauBoiThuong updatedClaim = new YeuCauBoiThuong
                {
                    MaYeuCau = maYeuCau,
                    NgayYeuCau = ngayYeuCau,
                    SoTienYeuCau = soTienYeuCau,
                    TrangThai = trangThai,
                    MoTa = moTa
                };

                customerController.UpdateClaims(updatedClaim);

                MessageBox.Show("Yêu cầu bồi thường đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Tìm kiếm

        private void button7_Click_1(object sender, EventArgs e)
        {
            Search_Claim timYeuCauBoiThuong = new Search_Claim();

            // Hiển thị form TimYeuCauBoiThuong
            timYeuCauBoiThuong.Show();
        }

        private void Claim_Load(object sender, EventArgs e)
        {

        }
    }
}
