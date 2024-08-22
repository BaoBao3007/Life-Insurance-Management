using DoAnNoSQL.Controllers;
using DoAnNoSQL.Models;
using DoAnNoSQL.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNoSQL.Views
{
    public partial class Frm_HopDongBH : Form
    {
        private readonly CustomerController customerController;


        public Frm_HopDongBH()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            customerController = new CustomerController(repository);
            LoadDataGridView();
            LoadComboBoxData();
        }
        private void LoadDataGridView()
        {
            try
            {
                // Lấy tất cả khách hàng từ controller
                var customers = customerController.GetCustomers();

                // Tạo một DataTable để chứa dữ liệu hợp đồng bảo hiểm
                var dataTable = new DataTable();

                // Tạo các cột cho DataTable
                dataTable.Columns.Add("Mã Hợp Đồng", typeof(string));
                dataTable.Columns.Add("Mã Khách Hàng", typeof(string));
                dataTable.Columns.Add("Người Thụ Hưởng", typeof(string));
                dataTable.Columns.Add("Ngày Ký", typeof(DateTime)); // Thêm cột Ngày Ký
                dataTable.Columns.Add("Thời Hạn HD", typeof(DateTime));
                dataTable.Columns.Add("Số Tiền BH", typeof(decimal));
                dataTable.Columns.Add("Phí Bảo Hiểm Định Kỳ", typeof(decimal));
                dataTable.Columns.Add("Đại lý", typeof(string)); // Added field
                dataTable.Columns.Add("Loại", typeof(string)); // Added field

                // Thêm các hàng vào DataTable
                foreach (var customer in customers)
                {
                    foreach (var contract in customer.HopDongBaoHiem)
                    {
                        dataTable.Rows.Add(
                            contract.MaHopDong,
                            customer.MaKhachHang,
                            string.Join(", ", contract.NguoiThuHuong),
                            contract.NgayBatDau.Date, // Ngày Ký
                            contract.NgayKetThuc.Date, // Thời hạn hợp đồng
                            contract.SoTienBaoHiem,
                            contract.PhiBaoHiem,
                            contract.DaiLy.TenDaiLy,
                            contract.LoaiHopDong // Added field
                        );
                    }
                }

                // Gán DataTable cho DataGridView
                grid_KhachHang.DataSource = dataTable;
                txt_soHD.Enabled = false;
                txt_ngayky.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_themHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các textbox và combobox
                string maHopDong = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                string maKhachHang = Cbo_MaKH.SelectedItem.ToString();
                DateTime ngayBatDau = DateTime.Now.Date; // Ngày hiện tại
                DateTime ngayKetThuc = DateTime.Parse(txt_thoihanHD.Text).Date;
                decimal soTienBaoHiem = decimal.Parse(txt_sotienBH.Text);
                decimal phiBaoHiem = decimal.Parse(txt_mucphi.Text);
                string nguoiThuHuong = txt_nguoithuhuong.Text;
                string loaiHopDong = cbo_loaiHD.SelectedItem.ToString();

                // Lấy thông tin đại lý từ ComboBox
                DaiLy selectedDaiLy = cbo_daily.SelectedItem as DaiLy;
                if (selectedDaiLy == null)
                {
                    MessageBox.Show("Chưa chọn đại lý.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng hợp đồng bảo hiểm
                var hopDongBaoHiem = new HopDongBaoHiem
                {
                    MaHopDong = maHopDong,
                    NgayBatDau = ngayBatDau.Date,
                    NgayKetThuc = ngayKetThuc.Date,
                    SoTienBaoHiem = soTienBaoHiem,
                    PhiBaoHiem = phiBaoHiem,
                    NguoiThuHuong = new List<string> { nguoiThuHuong },
                    LoaiHopDong = loaiHopDong,
                    DaiLy = selectedDaiLy // Gán đại lý
                };

                // Thêm hợp đồng bảo hiểm cho khách hàng
                customerController.AddInsuranceContractToCustomer(maKhachHang, hopDongBaoHiem);

                // Cập nhật DataGridView
                LoadDataGridView();
                MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Lỗi khi thêm hợp đồng: " + ex.Message, "Lỗi");
            }
        }


        private void ClearForm()
        {
            // Làm trống các TextBox
            txt_ngayky.Text = string.Empty;
            txt_thoihanHD.Text = string.Empty;
            txt_sotienBH.Text = string.Empty;
            txt_mucphi.Text = string.Empty;
            txt_nguoithuhuong.Text = string.Empty;


            Cbo_MaKH.SelectedIndex = 0;
            cbo_loaiHD.SelectedIndex = -1; // Đặt ComboBox loại hợp đồng về không có lựa chọn
            cbo_daily.SelectedIndex = -1; // Đặt ComboBox đại lý về không có lựa chọn


            // Xóa hợp đồng đã chọn nếu có
            selectedContract = null;

            // Tùy chọn: Cập nhật DataGridView hoặc bất kỳ điều khiển nào khác
            // LoadDataGridView();s

        }


        private void txt_soHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var customers = customerController.GetCustomers();//;ấy ds khách hàng lên

                // Kiểm tra nếu danh sách customers là null hoặc trống
                if (customers == null || !customers.Any())
                {
                    MessageBox.Show("Danh sách khách hàng trống hoặc chưa được tải.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu SelectedItem là null
                if (Cbo_MaKH.SelectedItem == null)
                {
                    MessageBox.Show("Không có Mã Khách Hàng nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy Mã Khách Hàng hiện tại từ ComboBox
                string maKhachHang = Cbo_MaKH.SelectedItem.ToString();

                // Tìm khách hàng tương ứng
                var customer = customers.FirstOrDefault(c => c.MaKhachHang == maKhachHang);

                if (customer != null)
                {
                    // Hiển thị tên khách hàng trên Label
                    txt_tenkh.Text = customer.HoVaTen ?? "Không có tên"; // Đảm bảo rằng HoVaTen không phải là null
                }
                else
                {
                    txt_tenkh.Text = "Không tìm thấy khách hàng"; // Hiển thị thông báo nếu không tìm thấy khách hàng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi chọn khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadComboBoxData()
        {
            try
            {
                // Lấy danh sách khách hàng
                var customers = customerController.GetCustomers();
                Cbo_MaKH.DataSource = customers.Select(c => c.MaKhachHang).ToList();

                // Lấy danh sách đại lý
                var daiLyList = customerController.GetDaiLy();
                cbo_daily.DataSource = daiLyList; // Giữ nguyên danh sách DaiLy đầy đủ
                cbo_daily.DisplayMember = "TenDaiLy"; // Hiển thị tên đại lý
                cbo_daily.ValueMember = "MaDaiLy"; // Lưu trữ MaDaiLy

                // Lấy danh sách loại hợp đồng
                var loaiHopDongList = customerController.GetLoaiHopDong();
                cbo_loaiHD.DataSource = loaiHopDongList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Khai báo biến lưu trữ hợp đồng được chọn để sửa
        private HopDongBaoHiem selectedContract;


        private void grid_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng không nhấp vào tiêu đề cột
            {
                // Lấy mã hợp đồng từ ô đầu tiên trong hàng được chọn
                string maHopDong = grid_KhachHang.Rows[e.RowIndex].Cells["Mã Hợp Đồng"].Value.ToString();

                // Gọi phương thức từ CustomerController để lấy thông tin hợp đồng
                selectedContract = customerController.GetContractById(maHopDong);

                if (selectedContract != null)
                {
                    // Hiển thị thông tin hợp đồng trong các trường nhập liệu
                    txt_soHD.Text = selectedContract.MaHopDong;
                    txt_ngayky.Text = selectedContract.NgayBatDau.ToString("yyyy-MM-dd");
                    txt_thoihanHD.Text = selectedContract.NgayKetThuc.ToString("yyyy-MM-dd");
                    txt_sotienBH.Text = selectedContract.SoTienBaoHiem.ToString();
                    txt_mucphi.Text = selectedContract.PhiBaoHiem.ToString();
                    txt_nguoithuhuong.Text = string.Join(", ", selectedContract.NguoiThuHuong);

                    // Cập nhật cbo_daily để hiển thị đại lý hiện tại của hợp đồng
                    if (cbo_daily.DataSource is List<DaiLy> daiLyList)
                    {
                        // Tìm đại lý khớp với đại lý trong hợp đồng bảo hiểm
                        var selectedDaiLy = daiLyList.FirstOrDefault(d => d.MaDaiLy == selectedContract.DaiLy.MaDaiLy);
                        cbo_daily.SelectedItem = selectedDaiLy;
                    }

                    // Cập nhật cbo_loaiHD
                    cbo_loaiHD.SelectedItem = selectedContract.LoaiHopDong;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy hợp đồng
                    MessageBox.Show("Không tìm thấy hợp đồng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void btn_sua_Click(object sender, EventArgs e)
        {

            try
            {
                // Kiểm tra nếu không có hợp đồng được chọn
                if (selectedContract == null)
                {
                    MessageBox.Show("Không có hợp đồng nào được chọn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật thông tin hợp đồng dựa trên các trường nhập liệu
                selectedContract.NgayBatDau = DateTime.Parse(txt_ngayky.Text);
                selectedContract.NgayKetThuc = DateTime.Parse(txt_thoihanHD.Text);
                selectedContract.SoTienBaoHiem = decimal.Parse(txt_sotienBH.Text);
                selectedContract.PhiBaoHiem = decimal.Parse(txt_mucphi.Text);
                selectedContract.NguoiThuHuong = txt_nguoithuhuong.Text
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .ToList();

                // Lấy thông tin đại lý từ combobox
                var selectedDaiLy = cbo_daily.SelectedItem as DaiLy;
                if (selectedDaiLy == null)
                {
                    MessageBox.Show("Chưa chọn đại lý.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật thông tin đại lý và loại hợp đồng
                selectedContract.LoaiHopDong = cbo_loaiHD.SelectedItem?.ToString();
                selectedContract.DaiLy = selectedDaiLy;

                // Cập nhật hợp đồng trong cơ sở dữ liệu
                customerController.UpdateContract(selectedContract);

                // Cập nhật lại DataGridView
                LoadDataGridView();
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có hợp đồng được chọn
                if (selectedContract == null)
                {
                    MessageBox.Show("Không có hợp đồng nào được chọn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xóa hợp đồng khỏi cơ sở dữ liệu
                customerController.RemoveContract(selectedContract.MaHopDong);

                // Cập nhật lại DataGridView
                LoadDataGridView();
                MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo");

                // Xóa hợp đồng khỏi biến lưu trữ
                selectedContract = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimHD_Click(object sender, EventArgs e)
        {
            Frm_TimHD timHopDongForm = new Frm_TimHD();

            // Hiển thị form TimHopDong
            timHopDongForm.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void HopDongBaoHiem_Load(object sender, EventArgs e)
        {

        }

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.FormClosed += (s, args) => this.Show();
            customer.ShowDialog();
        }
    }
}
