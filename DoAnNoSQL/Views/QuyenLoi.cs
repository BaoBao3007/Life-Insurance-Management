using DoAnNoSQL.Controllers;
using DoAnNoSQL.DataAccess;
using DoAnNoSQL.Models;
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
    public partial class QuyenLoi : Form
    {
        private readonly CustomerController customerController; // bắt buộc có
        public QuyenLoi()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";// bắt buộc có
            var databaseName = "QLBaoHiemNhanTho";// bắt buộc có
            var context = new MongoDbContext(connectionString, databaseName);// bắt buộc có
            var repository = new CustomerRepository(context);// bắt buộc có
            customerController = new CustomerController(repository);// bắt buộc có
            //gọi hàm
            LoadBenefitTypes();
            LoadBenefitDetails();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadBenefitDetails()
        {
            try
            {
                // Lấy danh sách quyền lợi từ CustomerController
                var benefitDetails = customerController.GetAllBenefitDetailsWithCustomerId();

                // Tạo danh sách để chứa dữ liệu cho DataGridView
                var dataSource = new List<BenefitDetailViewModel>();

                // Chuyển đổi dữ liệu thành danh sách các đối tượng BenefitDetailViewModel
                foreach (var item in benefitDetails)
                {
                    var viewModel = new BenefitDetailViewModel
                    {
                        MaKhachHang = item.MaKhachHang,
                        MaQuyenLoi = item.ChiTietQuyenLoi.MaQuyenLoi,
                        LoaiQuyenLoi = item.ChiTietQuyenLoi.LoaiQuyenLoi,
                        SoTienBaoHiem = item.ChiTietQuyenLoi.SoTienBaoHiem,
                        DieuKien = item.ChiTietQuyenLoi.DieuKien
                    };

                    dataSource.Add(viewModel);
                }

                // Đặt DataSource của DataGridView
                dataGridView1.DataSource = dataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        public class BenefitDetailViewModel
        {
            public string MaKhachHang { get; set; }
            public string MaQuyenLoi { get; set; }
            public string LoaiQuyenLoi { get; set; }
            public decimal SoTienBaoHiem { get; set; }
            public string DieuKien { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddbutton_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mã khách hàng từ TextBox (hoặc nguồn khác)
            string maKhachHang = txtMaKhachHang.Text;

            // Tạo đối tượng ChiTietQuyenLoi mới với thông tin từ giao diện
            ChiTietQuyenLoi chiTietQuyenLoi = new ChiTietQuyenLoi
            {
                MaQuyenLoi = txtMaQuyenLoi.Text,
                LoaiQuyenLoi = txtLoaiQuyenLoi.Text,
                SoTienBaoHiem = decimal.Parse(txtSoTienBaoHiem.Text),
                DieuKien = txtDieuKien.Text
            };

            // Gọi phương thức thêm quyền lợi từ controller
            customerController.ThemQuyenLoiChoKhachHang(maKhachHang, chiTietQuyenLoi);

            // Cập nhật lại danh sách quyền lợi trên giao diện
            LoadBenefitDetails();
            ClearTextBoxes();
        }

        //hàm xóa các txt
        private void ClearTextBoxes()
        {
            txtMaKhachHang.Text = string.Empty;
            txtMaQuyenLoi.Text = string.Empty;
            txtLoaiQuyenLoi.Text = string.Empty;
            txtSoTienBaoHiem.Text = string.Empty;
            txtDieuKien.Text = string.Empty;
        }
        private void btnDeleetebutton_Click(object sender, EventArgs e)
        {


            // Kiểm tra xem có dòng nào đang được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ dòng đang chọn
                var selectedRow = dataGridView1.SelectedRows[0];
                var maKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
                var maQuyenLoi = selectedRow.Cells["MaQuyenLoi"].Value.ToString();

                // Xác nhận việc xóa
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa quyền lợi này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Gọi phương thức xóa quyền lợi từ controller
                    customerController.XoaQuyenLoiChoKhachHang(maKhachHang, maQuyenLoi);
                    // Cập nhật lại danh sách quyền lợi
                    LoadBenefitDetails();
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một quyền lợi để xóa.");
            }
        }
        private void EnableEditing(bool isEnabled)
        {
            txtMaQuyenLoi.Enabled = isEnabled;
            txtLoaiQuyenLoi.Enabled = isEnabled;
            txtSoTienBaoHiem.Enabled = isEnabled;
            txtDieuKien.Enabled = isEnabled;
            btnEditbutton.Enabled = isEnabled;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấn vào dòng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy thông tin quyền lợi từ dòng
                txtMaQuyenLoi.Text = row.Cells["MaQuyenLoi"].Value.ToString();
                txtLoaiQuyenLoi.Text = row.Cells["LoaiQuyenLoi"].Value.ToString();
                txtSoTienBaoHiem.Text = row.Cells["SoTienBaoHiem"].Value.ToString();
                txtDieuKien.Text = row.Cells["DieuKien"].Value.ToString();

                // Bật chế độ chỉnh sửa
                EnableEditing(true);
            }
        }

        private void btnEditbutton_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string maKhachHang = txtMaKhachHang.Text;
            string maQuyenLoi = txtMaQuyenLoi.Text;
            string loaiQuyenLoi = txtLoaiQuyenLoi.Text;
            decimal soTienBaoHiem;
            string dieuKien = txtDieuKien.Text;

            // Chuyển đổi giá trị từ string sang decimal
            if (!decimal.TryParse(txtSoTienBaoHiem.Text, out soTienBaoHiem))
            {
                MessageBox.Show("Vui lòng nhập số tiền bảo hiểm hợp lệ.");
                return;
            }

            var chiTietQuyenLoi = new ChiTietQuyenLoi
            {
                MaQuyenLoi = maQuyenLoi,
                LoaiQuyenLoi = loaiQuyenLoi,
                SoTienBaoHiem = soTienBaoHiem,
                DieuKien = dieuKien
            };

            // Gọi phương thức từ controller
            customerController.CapNhatQuyenLoiChoKhachHang(maKhachHang, chiTietQuyenLoi);

            // Cập nhật lại danh sách quyền lợi
            LoadBenefitDetails();
            ClearTextBoxes();
        }

        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKhachHang = txtSearch.Text.Trim(); // Trim để loại bỏ khoảng trắng không cần thiết
                if (string.IsNullOrEmpty(tenKhachHang))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng để tìm kiếm.");
                    return;
                }

                // Gọi phương thức tìm kiếm từ controller
                var benefitDetails = customerController.TimQuyenLoiTheoTenKhachHang(tenKhachHang);

                // Kiểm tra dữ liệu trả về
                if (benefitDetails == null || !benefitDetails.Any())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu.");
                    dataGridView1.DataSource = null;
                    return;
                }

                var dataSource = new List<BenefitDetailViewModel>();

                foreach (var item in benefitDetails)
                {
                    var viewModel = new BenefitDetailViewModel
                    {
                        MaKhachHang = item.MaKhachHang,
                        MaQuyenLoi = item.ChiTietQuyenLoi.MaQuyenLoi,
                        LoaiQuyenLoi = item.ChiTietQuyenLoi.LoaiQuyenLoi,
                        SoTienBaoHiem = item.ChiTietQuyenLoi.SoTienBaoHiem,
                        DieuKien = item.ChiTietQuyenLoi.DieuKien
                    };
                    dataSource.Add(viewModel);
                }

                // Đặt DataSource của DataGridView
                dataGridView1.DataSource = dataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm dữ liệu: {ex.Message}");
            }
        }

        //nạp dữ liệu cho ComboBox
        private void LoadBenefitTypes()
        {
            try
            {
                // Lấy danh sách loại quyền lợi từ CustomerController
                var benefitTypes = customerController.GetDistinctBenefitTypes();

                // Cập nhật ComboBox
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(benefitTypes.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu loại quyền lợi: {ex.Message}");
            }
        }




        // nạp dữ liệu cho DataGridView dựa trên loại quyền lợi:
        private void LoadBenefitDetailsByType(string benefitType)
        {
            try
            {
                // Lấy danh sách quyền lợi từ CustomerController với loại quyền lợi đã chọn
                var benefitDetails = customerController.GetAllBenefitDetailsWithCustomerId()
                    .Where(b => b.ChiTietQuyenLoi.LoaiQuyenLoi == benefitType)
                    .ToList();

                // Tạo danh sách để chứa dữ liệu cho DataGridView
                var dataSource = new List<BenefitDetailViewModel>();

                // Chuyển đổi dữ liệu thành danh sách các đối tượng BenefitDetailViewModel
                foreach (var item in benefitDetails)
                {
                    var viewModel = new BenefitDetailViewModel
                    {
                        MaKhachHang = item.MaKhachHang,
                        MaQuyenLoi = item.ChiTietQuyenLoi.MaQuyenLoi,
                        LoaiQuyenLoi = item.ChiTietQuyenLoi.LoaiQuyenLoi,
                        SoTienBaoHiem = item.ChiTietQuyenLoi.SoTienBaoHiem,
                        DieuKien = item.ChiTietQuyenLoi.DieuKien
                    };

                    dataSource.Add(viewModel);
                }

                // Đặt DataSource của DataGridView
                dataGridView1.DataSource = dataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu theo loại quyền lợi: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy loại quyền lợi được chọn
            var selectedBenefitType = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedBenefitType))
            {
                // Nếu không chọn loại quyền lợi, hiển thị tất cả quyền lợi
                LoadBenefitDetails();
            }
            else
            {
                // Nếu chọn loại quyền lợi, lọc dữ liệu dựa trên loại quyền lợi
                LoadBenefitDetailsByType(selectedBenefitType);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng hiện tại được chọn
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Lấy thông tin quyền lợi từ dòng và hiển thị trong các TextBox
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtMaQuyenLoi.Text = row.Cells["MaQuyenLoi"].Value.ToString();
                txtLoaiQuyenLoi.Text = row.Cells["LoaiQuyenLoi"].Value.ToString();
                txtSoTienBaoHiem.Text = row.Cells["SoTienBaoHiem"].Value.ToString();
                txtDieuKien.Text = row.Cells["DieuKien"].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBenefitDetails();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
