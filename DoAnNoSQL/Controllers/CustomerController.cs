using DoAnNoSQL.DataAccess;
using DoAnNoSQL.Models;
using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoAnNoSQL.Views.Transaction;

namespace DoAnNoSQL.Controllers
{
    internal class CustomerController
    {
        private CustomerRepository repository;

        public CustomerController(CustomerRepository repository)
        {
            this.repository = repository;
        }
        // Lấy danh sách khách hàng
        public List<Customer> GetCustomers()
        {
            return repository.GetAllCustomers();
        }
        // Thêm khách hàng
        public void AddCustomer(Customer customer)
        {
            repository.AddCustomer(customer);
        }
        // Lấy khách hàng theo mã
        public Customer GetCustomerById(string customerId)
        {
            return repository.GetCustomerById(customerId);
        }
        // Lấy khách hàng theo email
        public Customer GetCustomerByEmail(string email)
        {
            return repository.GetCustomerByEmail(email);
        }
        // Xóa khách hàng
        public void DeleteCustomer(string customerID)
        {
            repository.DeleteCustomer(customerID);
        }
        // Sửa khách hàng
        public void UpdateCustomer(Customer customer)
        {
            repository.UpdateCustomer(customer);
        }
        //Tìm kiếm khách hàng theo tên hoặc mã định danh
        public List<Customer> SearchCustomers(string searchText)
        {
            return repository.SearchCustomers(searchText);
        }




        // Lấy hợp đồng bảo hiểm của khách hàng theo mã khách hàng
        public List<HopDongBaoHiem> GetHopDongBaoHiemByCustomerId(string customerId)
        {
            return repository.GetHopDongBaoHiemByCustomerId(customerId);
        }

        public void AddInsuranceContractToCustomer(string maKhachHang, HopDongBaoHiem hopDongBaoHiem)
        {
            repository.AddInsuranceContractToCustomer(maKhachHang, hopDongBaoHiem);
        }

        // Lấy danh sách đại lý
        public List<DaiLy> GetDaiLy()
        {
            return repository.GetAllDaiLy();
        }

        // Lấy danh sách loại hợp đồng
        public List<string> GetLoaiHopDong()
        {
            return repository.GetAllLoaiHopDong();
        }

        // Xóa hợp đồng khỏi khách hàng
        public void RemoveContract(string maHopDong)
        {
            repository.RemoveContractFromCustomer(maHopDong);
        }

        // Cập nhật hợp đồng của khách hàng
        public void UpdateContract(HopDongBaoHiem updatedContract)
        {
            repository.UpdateContractInCustomer(updatedContract);
        }



        // Phương thức tìm hợp đồng theo tên khách hàng
        public List<HopDongBaoHiem> GetContractsByCustomerName(string tenKhachHang)
        {
            return repository.FindContractsByCustomerName(tenKhachHang);
        }

        // Phương thức lấy danh sách các loại hợp đồng duy nhất
        public List<string> GetUniqueContractTypes()
        {
            return repository.GetUniqueContractTypes();
        }

        // Phương thức tìm hợp đồng theo loại hợp đồng
        public List<HopDongBaoHiem> GetContractsByContractType(string loaiHopDong)
        {
            return repository.FindContractsByContractType(loaiHopDong);
        }

        // Phương thức tìm hợp đồng theo ngày bắt đầu và ngày kết thúc
        public List<HopDongBaoHiem> GetContractsByDateRange(DateTime startDate, DateTime endDate)
        {
            return repository.FindContractsByDateRange(startDate, endDate);
        }

        // Phương thức lấy hợp đồng theo mã hợp đồng
        public HopDongBaoHiem GetContractById(string maHopDong)
        {
            return repository.GetContractById(maHopDong);
        }



        //Quyền lợi
        //Lấy danh sách quyền lợi
        public List<(string MaKhachHang, ChiTietQuyenLoi ChiTietQuyenLoi)> GetAllBenefitDetailsWithCustomerId()
        {
            return repository.GetAllBenefitDetailsWithCustomerId();
        }

        public void ThemQuyenLoiChoKhachHang(string maKhachHang, ChiTietQuyenLoi chiTietQuyenLoi)
        {
            repository.ThemQuyenLoiChoKhachHang(maKhachHang, chiTietQuyenLoi);
        }

        public void XoaQuyenLoiChoKhachHang(string maKhachHang, string maQuyenLoi)
        {
            repository.XoaQuyenLoiChoKhachHang(maKhachHang, maQuyenLoi);
        }


        // Thêm phương thức gọi cập nhật quyền lợi
        public void CapNhatQuyenLoiChoKhachHang(string maKhachHang, ChiTietQuyenLoi chiTietQuyenLoi)
        {
            repository.CapNhatQuyenLoiChoKhachHang(maKhachHang, chiTietQuyenLoi);
        }

        //tìm kiếm theo tên khách hàng
        public List<(string MaKhachHang, ChiTietQuyenLoi ChiTietQuyenLoi)> TimQuyenLoiTheoTenKhachHang(string tenKhachHang)
        {
            return repository.TimQuyenLoiTheoTenKhachHang(tenKhachHang);
        }
        // Lấy danh sách các loại quyền lợi
        public List<string> GetDistinctBenefitTypes()
        {
            return repository.GetDistinctBenefitTypes();
        }





        // Giao dịch
        // Lấy danh sách giao dịch
        public List<LichSuGiaoDich> GetAllTransactionHistories()
        {
            return repository.GetAllTransactionHistories();
        }

        // Thêm lịch sử giao dịch
        public void AddTransactionHistory(string customerId, LichSuGiaoDich newTransaction)
        {
            repository.AddTransactionHistory(customerId, newTransaction);
        }

        // Sửa lịch sử giao dịch
        public void UpdateTransactionHistory(string customerId, string transactionId, string newDescription, DateTime newDate, decimal newAmount)
        {
            repository.UpdateTransactionHistory(customerId, transactionId, newDescription, newDate, newAmount);
        }

        // Xóa lịch sử giao dịch
        public void DeleteTransactionHistory(string customerId, string transactionId)
        {
            repository.DeleteTransactionHistory(customerId, transactionId);
        }

        // Tìm kiếm lịch sử giao dịch theo mã khách hàng
        public List<LichSuGiaoDich> GetTransactionHistoryByCustomerId(string customerId)
        {
            return repository.GetTransactionHistoryByCustomerId(customerId);
        }
        public List<LichSuGiaoDich> GetTransactionHistoryByCustomerName(string customerName)
        {
            return repository.GetTransactionHistoryByCustomerName(customerName);
        }

        // Lấy tất cả lịch sử giao dịch và mã khách hàng
        public List<(string MaKhachHang, LichSuGiaoDich LichSuGiaoDich)> GetAllTransactionHistoriess()
        {
            return repository.GetAllTransactionHistoriess();
        }
        public Customer GetCustomerByName1(string customerName)
        {
            // Giả sử phương thức này gọi một phương thức tương ứng trong CustomerRepository
            return repository.GetCustomerByName1(customerName);
        }
        // Phương thức lấy lịch sử giao dịch theo khoảng thời gian
        public List<LichSuGiaoDich> FilterTransactionByDate(DateTime starDate, DateTime endDate)
        {
            return repository.FilterTransactionByDate(starDate, endDate);
        }


        //Yêu cầu bồi thường
        // Lấy yêu cầu bồi thường theo mã yêu cầu 
        public YeuCauBoiThuong GetClaimById(string maYeuCau)
        {
            return repository.GetClaimById(maYeuCau);
        }

        // Lấy tất cả trạng thái yêu cầu bồi thường
        public List<string> GetClaimStatuses()
        {
            try
            {
                return repository.GetAllClaimStatuses();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Lỗi khi lấy trạng thái yêu cầu bồi thường.", ex);
            }
        }



        // Thêm yêu cầu bồi thường cho khách hàng
        public void AddClaimToCustomer(string maKhachHang, YeuCauBoiThuong newClaim)
        {
            try
            {
                repository.AddClaimToCustomer(maKhachHang, newClaim);
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Lỗi khi thêm yêu cầu bồi thường cho khách hàng.", ex);
            }
        }

        // Xóa yêu cầu bồi thường của khách hàng
        public void RemoveClaims(string maYeuCau)
        {
            try
            {
                repository.RemoveClaim(maYeuCau);
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Lỗi khi xóa yêu cầu bồi thường của khách hàng.", ex);
            }
        }


        // Cập nhật yêu cầu bồi thường của khách hàng
        public void UpdateClaims(YeuCauBoiThuong updatedClaim)
        {
            repository.UpdateClaim(updatedClaim);
        }

        //tìm kiếm yêu cầu bồi thường theo tên khách hàng
        public List<Customer> GetCustomersByName(string name)
        {
            return repository.GetCustomersByName(name);
        }


        // Lọc yêu cầu bồi thường theo trạng thái
        public List<(Customer, YeuCauBoiThuong)> GetClaimsByCustomerStatus(string status)
        {
            return repository.GetClaimsByCustomerStatus(status);
        }

        //Lọc yêu cầu bồi thường theo ngày yêu cầu
        public List<(Customer, YeuCauBoiThuong)> GetClaimsByRequestDateRange(DateTime startDate, DateTime endDate)
        {
            return repository.GetClaimsByRequestDateRange(startDate, endDate);
        }

    }
}
