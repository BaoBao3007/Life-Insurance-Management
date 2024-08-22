using DoAnNoSQL.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoAnNoSQL.Views.Transaction;

namespace DoAnNoSQL.DataAccess
{
    public class CustomerRepository
    {
        private readonly MongoDbContext context;

        public CustomerRepository(MongoDbContext context)
        {
            this.context = context;
        }
        //Khách hàng
        // Phương thức để lấy tất cả khách hàng
        public List<Customer> GetAllCustomers()
        {
            return context.khachhang.Find(_ => true).ToList();
        }
        // Lấy khách hàng theo mã
        public Customer GetCustomerById(string customerId)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, customerId);
            return context.khachhang.Find(filter).FirstOrDefault();
        }
        //Lấy khách hàng theo Email
        public Customer GetCustomerByEmail(string email)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.LienHe.Email, email);
            return context.khachhang.Find(filter).FirstOrDefault();
        }
        //Thêm khách hàng
        public void AddCustomer(Customer customer)
        {
            context.khachhang.InsertOne(customer);
        }
        // Xóa khách hàng theo mã khách hàng
        public void DeleteCustomer(string customerID)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, customerID);
            context.khachhang.DeleteOne(filter);
        }
        // Cập nhật thông tin khách hàng
        public void UpdateCustomer(Customer customer)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, customer.MaKhachHang);
            var updateDefinition = Builders<Customer>.Update
                .Set(c => c.MaDinhDanh, customer.MaDinhDanh)
                .Set(c => c.HoVaTen, customer.HoVaTen)
                .Set(c => c.NgaySinh, customer.NgaySinh)
                .Set(c => c.GioiTinh, customer.GioiTinh)
                .Set(c => c.DiaChi, customer.DiaChi)
                .Set(c => c.LienHe, customer.LienHe)
                .Set(c => c.NgheNghiep, customer.NgheNghiep)
                .Set(c => c.ThongTinSucKhoe, customer.ThongTinSucKhoe);

            context.khachhang.UpdateOne(filter, updateDefinition);
        }
        //Tìm kiếm khách hàng theo tên
        public List<Customer> SearchCustomers(string searchText)
        {
            var nameFilter = Builders<Customer>.Filter.Regex(c => c.HoVaTen, new MongoDB.Bson.BsonRegularExpression(searchText, "i"));
            var phoneFilter = Builders<Customer>.Filter.Eq(c => c.LienHe.SoDienThoai, searchText);
            var combinedFilter = Builders<Customer>.Filter.Or(nameFilter, phoneFilter);
            return context.khachhang.Find(combinedFilter).ToList();
        }













        //Hợp đồng bảo hiểm
        // Lấy hợp đồng bảo hiểm theo ID khách hàng
        public List<HopDongBaoHiem> GetHopDongBaoHiemByCustomerId(string customerId)
        {
            var customer = GetCustomerById(customerId);
            return customer?.HopDongBaoHiem ?? new List<HopDongBaoHiem>();
        }

        //thêm hợp đồng
        public void AddInsuranceContractToCustomer(string maKhachHang, HopDongBaoHiem hopDongBaoHiem)
        {
            var collection = context.khachhang;
            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, maKhachHang);
            var update = Builders<Customer>.Update.Push(c => c.HopDongBaoHiem, hopDongBaoHiem);
            collection.UpdateOne(filter, update);
        }

        // Lấy danh sách đại lý
        public List<DaiLy> GetAllDaiLy()
        {
            var collection = context.khachhang;
            return collection.AsQueryable()
                             .SelectMany(c => c.HopDongBaoHiem.Select(hd => hd.DaiLy))
                             .Distinct()
                             .ToList();
        }

        // Lấy danh sách loại hợp đồng
        public List<string> GetAllLoaiHopDong()
        {
            var collection = context.khachhang;
            return collection.AsQueryable()
                             .SelectMany(c => c.HopDongBaoHiem.Select(hd => hd.LoaiHopDong))
                             .Distinct()
                             .ToList();
        }

        // Xóa hợp đồng khỏi khách hàng
        public void RemoveContractFromCustomer(string maHopDong)
        {
            var collection = context.khachhang;

            // Tìm khách hàng có hợp đồng cần xóa
            var filter = Builders<Customer>.Filter.ElemMatch(c => c.HopDongBaoHiem, hd => hd.MaHopDong == maHopDong);
            var update = Builders<Customer>.Update.PullFilter(c => c.HopDongBaoHiem, hd => hd.MaHopDong == maHopDong);

            collection.UpdateOne(filter, update);
        }

        // Cập nhật hợp đồng của khách hàng
        public void UpdateContractInCustomer(HopDongBaoHiem updatedContract)
        {
            var collection = context.khachhang;

            // Lọc khách hàng có hợp đồng bảo hiểm cần cập nhật
            var filter = Builders<Customer>.Filter.ElemMatch(c => c.HopDongBaoHiem, hd => hd.MaHopDong == updatedContract.MaHopDong);

            // Tạo update để cập nhật các trường trong hợp đồng bảo hiểm
            var update = Builders<Customer>.Update
                .Set("HopDongBaoHiem.$.NgayBatDau", updatedContract.NgayBatDau)
                .Set("HopDongBaoHiem.$.NgayKetThuc", updatedContract.NgayKetThuc)
                .Set("HopDongBaoHiem.$.SoTienBaoHiem", updatedContract.SoTienBaoHiem)
                .Set("HopDongBaoHiem.$.PhiBaoHiem", updatedContract.PhiBaoHiem)
                .Set("HopDongBaoHiem.$.NguoiThuHuong", updatedContract.NguoiThuHuong)
                .Set("HopDongBaoHiem.$.LoaiHopDong", updatedContract.LoaiHopDong)
                .Set("HopDongBaoHiem.$.DaiLy", updatedContract.DaiLy);

            // Cập nhật hợp đồng bảo hiểm trong cơ sở dữ liệu
            collection.UpdateOne(filter, update);
        }


        // Phương thức tìm hợp đồng theo mã hợp đồng
        public HopDongBaoHiem FindContractById(string maHopDong)
        {
            var filter = Builders<Customer>.Filter.ElemMatch(c => c.HopDongBaoHiem, hd => hd.MaHopDong == maHopDong);
            var customer = context.khachhang.Find(filter).FirstOrDefault();

            if (customer != null)
            {
                return customer.HopDongBaoHiem.FirstOrDefault(hd => hd.MaHopDong == maHopDong);
            }

            return null;
        }

        // Phương thức tìm hợp đồng theo tên khách hàng
        public List<HopDongBaoHiem> FindContractsByCustomerName(string tenKhachHang)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.HoVaTen, tenKhachHang);
            var customer = context.khachhang.Find(filter).FirstOrDefault();

            if (customer != null)
            {
                return customer.HopDongBaoHiem;
            }

            return new List<HopDongBaoHiem>();
        }

        // Phương thức lấy danh sách các loại hợp đồng duy nhất
        public List<string> GetUniqueContractTypes()
        {
            var contractTypes = context.khachhang.AsQueryable()
                .SelectMany(c => c.HopDongBaoHiem.Select(hd => hd.LoaiHopDong))
                .Distinct()
                .ToList();

            return contractTypes;
        }

        // Phương thức tìm hợp đồng theo loại hợp đồng
        public List<HopDongBaoHiem> FindContractsByContractType(string loaiHopDong)
        {
            var filter = Builders<Customer>.Filter.ElemMatch(c => c.HopDongBaoHiem, hd => hd.LoaiHopDong == loaiHopDong);
            var customers = context.khachhang.Find(filter).ToList();

            var contracts = customers.SelectMany(c => c.HopDongBaoHiem.Where(hd => hd.LoaiHopDong == loaiHopDong)).ToList();

            return contracts;
        }

        // Phương thức lọc hợp đồng theo ngày bắt đầu và ngày kết thúc
        public List<HopDongBaoHiem> FindContractsByDateRange(DateTime startDate, DateTime endDate)
        {
            var filter = Builders<Customer>.Filter.ElemMatch(c =>
                c.HopDongBaoHiem,
                hd => hd.NgayBatDau >= startDate && hd.NgayKetThuc <= endDate
            );

            var customers = context.khachhang.Find(filter).ToList();

            var contracts = customers.SelectMany(c =>
                c.HopDongBaoHiem.Where(hd => hd.NgayBatDau >= startDate && hd.NgayKetThuc <= endDate)
            ).ToList();

            return contracts;
        }

        // Phương thức tìm hợp đồng theo mã hợp đồng
        public HopDongBaoHiem GetContractById(string maHopDong)
        {
            var customer = context.khachhang.Find(c => c.HopDongBaoHiem.Any(hd => hd.MaHopDong == maHopDong)).FirstOrDefault();
            return customer?.HopDongBaoHiem.FirstOrDefault(hd => hd.MaHopDong == maHopDong);
        }



        //Quyền lợi
        public List<(string MaKhachHang, ChiTietQuyenLoi ChiTietQuyenLoi)> GetAllBenefitDetailsWithCustomerId()
        {
            var pipeline = new[]
            {
                new BsonDocument("$unwind", "$chiTietQuyenLoi"),
                new BsonDocument("$project", new BsonDocument
                {
                    { "maKhachHang", 1 },
                    { "chiTietQuyenLoi", 1 }
                }),
                new BsonDocument("$replaceRoot", new BsonDocument
                {
                    { "newRoot", new BsonDocument
                        {
                            { "MaKhachHang", "$maKhachHang" },
                            { "ChiTietQuyenLoi", "$chiTietQuyenLoi" }
                        }
                    }
                })
            };

            var benefitDetails = context.khachhang.Aggregate<BsonDocument>(pipeline).ToList();
            var result = benefitDetails.Select(doc => (
                MaKhachHang: doc["MaKhachHang"].AsString,
                ChiTietQuyenLoi: BsonSerializer.Deserialize<ChiTietQuyenLoi>(doc["ChiTietQuyenLoi"].AsBsonDocument)
            )).ToList();
            return result;
        }


        public void ThemQuyenLoiChoKhachHang(string maKhachHang, ChiTietQuyenLoi chiTietQuyenLoi)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, maKhachHang);
            var update = Builders<Customer>.Update.Push(c => c.ChiTietQuyenLoi, chiTietQuyenLoi);
            context.khachhang.UpdateOne(filter, update);
        }
        public void XoaQuyenLoiChoKhachHang(string maKhachHang, string maQuyenLoi)
        {
            var filter = Builders<Customer>.Filter.And(
                Builders<Customer>.Filter.Eq(c => c.MaKhachHang, maKhachHang),
                Builders<Customer>.Filter.ElemMatch(c => c.ChiTietQuyenLoi, q => q.MaQuyenLoi == maQuyenLoi)
            );

            var update = Builders<Customer>.Update.PullFilter(c => c.ChiTietQuyenLoi, q => q.MaQuyenLoi == maQuyenLoi);

            context.khachhang.UpdateOne(filter, update);
        }

        // Thêm phương thức cập nhật quyền lợi khách hàng
        public void CapNhatQuyenLoiChoKhachHang(string maKhachHang, ChiTietQuyenLoi chiTietQuyenLoi)
        {
            var filter = Builders<Customer>.Filter.And(
                Builders<Customer>.Filter.Eq(c => c.MaKhachHang, maKhachHang),
                Builders<Customer>.Filter.ElemMatch(c => c.ChiTietQuyenLoi, q => q.MaQuyenLoi == chiTietQuyenLoi.MaQuyenLoi)
            );

            var update = Builders<Customer>.Update.Set("chiTietQuyenLoi.$", chiTietQuyenLoi);

            context.khachhang.UpdateOne(filter, update);
        }


        //Tìm quyền lợi theo tên khách hàng
        public List<(string MaKhachHang, ChiTietQuyenLoi ChiTietQuyenLoi)> TimQuyenLoiTheoTenKhachHang(string tenKhachHang)
        {
            var khachHang = GetCustomerByName(tenKhachHang);
            if (khachHang != null)
            {
                var quyenLoiList = new List<(string MaKhachHang, ChiTietQuyenLoi ChiTietQuyenLoi)>();
                foreach (var quyenLoi in khachHang.ChiTietQuyenLoi)
                {
                    quyenLoiList.Add((khachHang.MaKhachHang, quyenLoi));
                }
                return quyenLoiList;
            }
            return new List<(string MaKhachHang, ChiTietQuyenLoi ChiTietQuyenLoi)>();
        }

        private Customer GetCustomerByName(string tenKhachHang)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.HoVaTen, tenKhachHang);
            return context.khachhang.Find(filter).FirstOrDefault();
        }

        // lấy tất cả quyền lợi từ cơ sợ dữ liệu 
        public List<string> GetDistinctBenefitTypes()
        {
            var pipeline = new[]
            {
                new BsonDocument("$unwind", "$chiTietQuyenLoi"),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", "$chiTietQuyenLoi.loaiQuyenLoi" }
                }),
                new BsonDocument("$project", new BsonDocument
                {
                    { "loaiQuyenLoi", "$_id" }
                })
            };

            var result = context.khachhang.Aggregate<BsonDocument>(pipeline).ToList();
            return result.Select(doc => doc["loaiQuyenLoi"].AsString).ToList();
        }





        //Lịch sử giao dịch
        // Lấy tất cả lịch sử giao dịch
        public List<LichSuGiaoDich> GetAllTransactionHistories()
        {
            var pipeline = new[]
            {
                new BsonDocument("$unwind", "$lichSuGiaoDich"),
                new BsonDocument("$replaceRoot", new BsonDocument("newRoot", "$lichSuGiaoDich"))
            };

            var transactionHistories = context.khachhang.Aggregate<LichSuGiaoDich>(pipeline).ToList();

            return transactionHistories;
        }

        // Tìm kiếm lịch sử giao dịch theo tên khách hàng
        public List<LichSuGiaoDich> GetTransactionHistoryByCustomerName(string customerName)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.HoVaTen, customerName);
            var customer = context.khachhang.Find(filter).FirstOrDefault();
            if (customer == null) return new List<LichSuGiaoDich>();

            return customer.LichSuGiaoDich;
        }

        // Tìm kiếm khách hàng theo tên
        public Customer GetCustomerByName1(string customerName)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.HoVaTen, customerName);
            return context.khachhang.Find(filter).FirstOrDefault();
        }

        // Tìm kiếm lịch sử giao dịch theo mã khách hàng
        public List<LichSuGiaoDich> GetTransactionHistoryByCustomerId(string customerId)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, customerId);
            var customer = context.khachhang.Find(filter).FirstOrDefault();
            if (customer == null) return new List<LichSuGiaoDich>();

            return customer.LichSuGiaoDich;
        }

        // Thêm lịch sử giao dịch
        public void AddTransactionHistory(string customerId, LichSuGiaoDich newTransaction)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentException("Mã khách hàng không được để trống.");
            }

            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, customerId);
            var update = Builders<Customer>.Update.Push(c => c.LichSuGiaoDich, newTransaction);
            context.khachhang.UpdateOne(filter, update);
        }

        // Xóa lịch sử giao dịch
        public void DeleteTransactionHistory(string customerId, string transactionId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentException("Mã khách hàng không được để trống.");
            }

            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, customerId);
            var update = Builders<Customer>.Update.PullFilter(c => c.LichSuGiaoDich, Builders<LichSuGiaoDich>.Filter.Eq(t => t.MaGiaoDich, transactionId));
            context.khachhang.UpdateOne(filter, update);
        }

        // Sửa lịch sử giao dịch
        public void UpdateTransactionHistory(string customerId, string transactionId, string newDescription, DateTime newDate, decimal newAmount)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new ArgumentException("Mã khách hàng không được để trống.");
            }

            var filter = Builders<Customer>.Filter.And(
                Builders<Customer>.Filter.Eq(c => c.MaKhachHang, customerId),
                Builders<Customer>.Filter.ElemMatch(c => c.LichSuGiaoDich, Builders<LichSuGiaoDich>.Filter.Eq(t => t.MaGiaoDich, transactionId))
            );

            var update = Builders<Customer>.Update
                .Set("LichSuGiaoDich.$.MoTa", newDescription)
                .Set("LichSuGiaoDich.$.NgayGiaoDich", newDate)
                .Set("LichSuGiaoDich.$.SoTien", newAmount);

            context.khachhang.UpdateOne(filter, update);
        }

        // Lọc lịch sử giao dịch theo khoảng thời gian (ngayGiaoDich)
        public List<LichSuGiaoDich> FilterTransactionByDate(DateTime startDate, DateTime endDate)
        {
            var start = startDate.Date;
            var end = endDate.Date.AddDays(1).AddTicks(-1);

            var filter = Builders<Customer>.Filter.And(
                Builders<Customer>.Filter.ElemMatch(c => c.LichSuGiaoDich,
                    Builders<LichSuGiaoDich>.Filter.And(
                        Builders<LichSuGiaoDich>.Filter.Gte(t => t.NgayGiaoDich, start),
                        Builders<LichSuGiaoDich>.Filter.Lte(t => t.NgayGiaoDich, end)
                    )
                )
            );

            var customers = context.khachhang.Find(filter).ToList();

            var transactionHistories = customers.SelectMany(c =>
                c.LichSuGiaoDich.Where(t =>
                    t.NgayGiaoDich >= start && t.NgayGiaoDich <= end
                )
            ).ToList();

            return transactionHistories;
        }







        // Lấy tất cả lịch sử giao dịch và mã khách hàng
        public List<(string MaKhachHang, LichSuGiaoDich LichSuGiaoDich)> GetAllTransactionHistoriess()
        {
            var pipeline = new[]
            {
                new BsonDocument("$unwind", "$lichSuGiaoDich"),
                new BsonDocument("$project", new BsonDocument
                {
                    { "maKhachHang", 1 },
                    { "lichSuGiaoDich", 1 }
                }),
                new BsonDocument("$replaceRoot", new BsonDocument
                {
                    { "newRoot", new BsonDocument
                        {
                            { "MaKhachHang", "$maKhachHang" },
                            { "LichSuGiaoDich", "$lichSuGiaoDich" }
                        }
                    }
                })
            };

            var transactionHistories = context.khachhang.Aggregate<BsonDocument>(pipeline).ToList();

            // Chuyển đổi BsonDocument thành tuple với mã khách hàng và đối tượng lịch sử giao dịch
            var result = transactionHistories.Select(doc => (
                MaKhachHang: doc["MaKhachHang"].AsString,
                LichSuGiaoDich: BsonSerializer.Deserialize<LichSuGiaoDich>(doc["LichSuGiaoDich"].AsBsonDocument)
            )).ToList();

            return result;
        }


        // Yêu cầu bồi thường
        //Phương thức yêu cầu bồi thường theo mã yêu cầu 
        public YeuCauBoiThuong GetClaimById(string maYeuCau)
        {
            var customer = context.khachhang.Find(c => c.YeuCauBoiThuong.Any(yc => yc.MaYeuCau == maYeuCau)).FirstOrDefault();
            return customer?.YeuCauBoiThuong.FirstOrDefault(yc => yc.MaYeuCau == maYeuCau);
        }

        // Phương thức lấy tất cả trạng thái yêu cầu bồi thường
        public List<string> GetAllClaimStatuses()
        {
            var pipeline = new[]
            {
                new BsonDocument("$unwind", "$yeuCauBoiThuong"),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", "$yeuCauBoiThuong.trangThai" }
                }),
                new BsonDocument("$project", new BsonDocument
                {
                    { "trangThai", "$_id" },
                    { "_id", 0 }
                })
            };

            var distinctStatuses = context.khachhang.Aggregate<BsonDocument>(pipeline).ToList();
            return distinctStatuses.Select(doc => doc["trangThai"].AsString).ToList();
        }



        // Phương thức kiểm tra trùng lặp mã yêu cầu bồi thường
        public bool IsClaimCodeDuplicate(string maYeuCau)
        {
            var filter = Builders<Customer>.Filter.ElemMatch(c => c.YeuCauBoiThuong, yc => yc.MaYeuCau == maYeuCau);
            return context.khachhang.Find(filter).Any();
        }

        // Phương thức thêm yêu cầu bồi thường của khách hàng
        public void AddClaimToCustomer(string maKhachHang, YeuCauBoiThuong newClaim)
        {
            // Kiểm tra xem mã yêu cầu đã tồn tại chưa
            var existingClaim = GetClaimById(newClaim.MaYeuCau);

            var filter = Builders<Customer>.Filter.Eq(c => c.MaKhachHang, maKhachHang);
            var update = Builders<Customer>.Update.Push(c => c.YeuCauBoiThuong, newClaim);

            var result = context.khachhang.UpdateOne(filter, update);
        }



        // Phương thức xóa yêu cầu bồi thường ra khỏi khách hàng
        public void RemoveClaim(string maYeuCau)
        {

            // Tìm khách hàng có hợp đồng cần xóa
            var filter = Builders<Customer>.Filter.ElemMatch(c => c.YeuCauBoiThuong, yc => yc.MaYeuCau == maYeuCau);
            var update = Builders<Customer>.Update.PullFilter(c => c.YeuCauBoiThuong, yc => yc.MaYeuCau == maYeuCau);

            context.khachhang.UpdateOne(filter, update);
        }


        // Phương thức sửa yêu cầu bồi thường của khách hàng
        public void UpdateClaim(YeuCauBoiThuong updatedClaim)
        {

            var filter = Builders<Customer>.Filter.And(
                Builders<Customer>.Filter.ElemMatch(c => c.YeuCauBoiThuong, yc => yc.MaYeuCau == updatedClaim.MaYeuCau)
            );

            var update = Builders<Customer>.Update
                .Set("YeuCauBoiThuong.$.NgayYeuCau", updatedClaim.NgayYeuCau)
                .Set("YeuCauBoiThuong.$.SoTienYeuCau", updatedClaim.SoTienYeuCau)
                .Set("YeuCauBoiThuong.$.TrangThai", updatedClaim.TrangThai)
                .Set("YeuCauBoiThuong.$.MoTa", updatedClaim.MoTa);

            var result = context.khachhang.UpdateOne(filter, update);


        }

        //Phương thức tìm kiếm yêu cầu bồi thường theo tên khách hàng
        public List<Customer> GetCustomersByName(string name)
        {
            var pipeline = new[]
            {
            new BsonDocument("$match",
                new BsonDocument("hoVaTen",
                    new BsonRegularExpression(name, "i"))),


            new BsonDocument("$project",
                new BsonDocument
                {
                    { "_id", 0 },
                    { "maKhachHang", 1 },
                    { "hoVaTen", 1 },
                    { "yeuCauBoiThuong", 1 }
                })
        };

            var results = context.khachhang.Aggregate<BsonDocument>(pipeline).ToList();

            var customers = results.Select(result => BsonSerializer.Deserialize<Customer>(result)).ToList();

            return customers;
        }



        //Phương thức lọc trạng  thái
        public List<(Customer, YeuCauBoiThuong)> GetClaimsByCustomerStatus(string status)
        {
            var filter = Builders<Customer>.Filter.ElemMatch(c => c.YeuCauBoiThuong, y => y.TrangThai == status);
            var customers = context.khachhang.Find(filter).ToList();

            var claims = new List<(Customer, YeuCauBoiThuong)>();

            foreach (var customer in customers)
            {
                if (customer.YeuCauBoiThuong != null)
                {
                    claims.AddRange(customer.YeuCauBoiThuong.Where(claim => claim.TrangThai == status).Select(claim => (customer, claim)));
                }
            }

            return claims;
        }

        //lọc theo ngày yêu cầu khoảng thời gian
        public List<(Customer, YeuCauBoiThuong)> GetClaimsByRequestDateRange(DateTime startDate, DateTime endDate)
        {

            // Tạo filter để tìm yêu cầu bồi thường theo ngày yêu cầu
            var filter = Builders<Customer>.Filter.ElemMatch(
                c => c.YeuCauBoiThuong,
                Builders<YeuCauBoiThuong>.Filter.And(
                    Builders<YeuCauBoiThuong>.Filter.Gte(yc => yc.NgayYeuCau, startDate),
                    Builders<YeuCauBoiThuong>.Filter.Lte(yc => yc.NgayYeuCau, endDate)
                )
            );

            // Tìm tất cả khách hàng phù hợp với điều kiện lọc
            var customers = context.khachhang.Find(filter).ToList();

            var claims = new List<(Customer, YeuCauBoiThuong)>();

            foreach (var customer in customers)
            {
                if (customer.YeuCauBoiThuong != null)
                {
                    claims.AddRange(customer.YeuCauBoiThuong
                        .Where(claim => claim.NgayYeuCau >= startDate && claim.NgayYeuCau <= endDate)
                        .Select(claim => (customer, claim)));
                }
            }

            return claims;
        }






    }
}
