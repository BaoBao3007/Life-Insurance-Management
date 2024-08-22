using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DoAnNoSQL.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; } // Trường _id của MongoDB

        [BsonElement("maDinhDanh")]
        public string MaDinhDanh { get; set; } = string.Empty; // Mã định danh duy nhất cho khách hàng

        [BsonElement("maKhachHang")]
        public string MaKhachHang { get; set; } = string.Empty; // Mã khách hàng

        [BsonElement("hoVaTen")]
        public string HoVaTen { get; set; } = string.Empty; // Họ và tên đầy đủ của khách hàng

        [BsonElement("ngaySinh")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime NgaySinh { get; set; } = DateTime.MinValue; // Ngày tháng năm sinh

        [BsonElement("gioiTinh")]
        public string GioiTinh { get; set; } = string.Empty; // Giới tính

        [BsonElement("diaChi")]
        public DiaChi DiaChi { get; set; } = new DiaChi(); // Địa chỉ

        [BsonElement("lienHe")]
        public LienHe LienHe { get; set; } = new LienHe(); // Thông tin liên hệ

        [BsonElement("ngheNghiep")]
        public NgheNghiep NgheNghiep { get; set; } = new NgheNghiep(); // Nghề nghiệp

        [BsonElement("thongTinSucKhoe")]
        public ThongTinSucKhoe ThongTinSucKhoe { get; set; } = new ThongTinSucKhoe(); // Thông tin sức khỏe

        [BsonElement("hopDongBaoHiem")]
        public List<HopDongBaoHiem> HopDongBaoHiem { get; set; } = new List<HopDongBaoHiem>(); // Danh sách các hợp đồng bảo hiểm

        [BsonElement("lichSuGiaoDich")]
        public List<LichSuGiaoDich> LichSuGiaoDich { get; set; } = new List<LichSuGiaoDich>(); // Lịch sử giao dịch

        [BsonElement("yeuCauBoiThuong")]
        public List<YeuCauBoiThuong> YeuCauBoiThuong { get; set; } = new List<YeuCauBoiThuong>(); // Yêu cầu bồi thường

        [BsonElement("chiTietQuyenLoi")]
        public List<ChiTietQuyenLoi> ChiTietQuyenLoi { get; set; } = new List<ChiTietQuyenLoi>(); // Chi tiết quyền lợi

        [BsonElement("lienHeKhanCap")]
        public LienHeKhanCap LienHeKhanCap { get; set; } = new LienHeKhanCap(); // Liên hệ khẩn cấp
    }

    public class DiaChi
    {
        [BsonElement("soNhaVaTenDuong")]
        public string SoNhaVaTenDuong { get; set; } = string.Empty; // Số nhà và tên đường

        [BsonElement("quanHuyen")]
        public string QuanHuyen { get; set; } = string.Empty; // Quận huyện

        [BsonElement("tinhThanhPho")]
        public string TinhThanhPho { get; set; } = string.Empty; // Tỉnh/Thành phố

        [BsonElement("maBuuDien")]
        public string MaBuuDien { get; set; } = string.Empty; // Mã bưu điện

        [BsonElement("quocGia")]
        public string QuocGia { get; set; } = string.Empty; // Quốc gia
    }

    public class LienHe
    {
        [BsonElement("soDienThoai")]
        public string SoDienThoai { get; set; } = string.Empty; // Số điện thoại

        [BsonElement("email")]
        public string Email { get; set; } = string.Empty; // Địa chỉ email
    }

    public class NgheNghiep
    {
        [BsonElement("chucDanh")]
        public string ChucDanh { get; set; } = string.Empty; // Chức danh công việc

        [BsonElement("tenCongTy")]
        public string TenCongTy { get; set; } = string.Empty; // Tên công ty

        [BsonElement("thuNhapHangNam")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal ThuNhapHangNam { get; set; } = 0m; // Thu nhập hàng năm
    }

    public class ThongTinSucKhoe
    {
        [BsonElement("benhLy")]
        public List<string> BenhLy { get; set; } = new List<string>(); // Bệnh lý

        [BsonElement("nhomMau")]
        public string NhomMau { get; set; } = string.Empty; // Nhóm máu

        [BsonElement("chieuCao")]
        public int ChieuCao { get; set; } = 0; // Chiều cao (cm)

        [BsonElement("canNang")]
        public int CanNang { get; set; } = 0; // Cân nặng (kg)
    }

    public class HopDongBaoHiem
    {
        [BsonElement("maHopDong")]
        public string MaHopDong { get; set; } = string.Empty; // Mã hợp đồng bảo hiểm

        [BsonElement("loaiHopDong")]
        public string LoaiHopDong { get; set; } = string.Empty; // Loại hợp đồng bảo hiểm

        [BsonElement("ngayBatDau")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayBatDau { get; set; } = DateTime.MinValue; // Ngày bắt đầu hợp đồng

        [BsonElement("ngayKetThuc")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayKetThuc { get; set; } = DateTime.MinValue; // Ngày kết thúc hợp đồng

        [BsonElement("phiBaoHiem")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal PhiBaoHiem { get; set; } = 0m; // Mức phí bảo hiểm hàng tháng
        [BsonElement("soTienBaoHiem")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal SoTienBaoHiem { get; set; } = 0m;

        [BsonElement("nguoiThuHuong")]
        public List<string> NguoiThuHuong { get; set; } = new List<string>(); // Danh sách người thụ hưởng

        [BsonElement("daiLy")]
        public DaiLy DaiLy { get; set; } = new DaiLy(); // Đại lý bảo hiểm
    }

    public class DaiLy
    {
        [BsonElement("maDaiLy")]
        public string MaDaiLy { get; set; } = string.Empty; // Mã đại lý bảo hiểm

        [BsonElement("tenDaiLy")]
        public string TenDaiLy { get; set; } = string.Empty; // Tên đại lý bảo hiểm

        [BsonElement("lienHe")]
        public LienHe LienHe { get; set; } = new LienHe(); // Thông tin liên hệ của đại lý
    }

    public class LichSuGiaoDich
    {
        [BsonElement("maGiaoDich")]
        public string MaGiaoDich { get; set; } = string.Empty; // Mã giao dịch

        [BsonElement("ngayGiaoDich")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayGiaoDich { get; set; } = DateTime.MinValue; // Ngày giao dịch

        [BsonElement("soTien")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal SoTien { get; set; } = 0m; // Số tiền giao dịch

        [BsonElement("moTa")]
        public string MoTa { get; set; } = string.Empty; // Mô tả giao dịch
    }

    public class YeuCauBoiThuong
    {
        [BsonElement("maYeuCau")]
        public string MaYeuCau { get; set; } = string.Empty; // Mã yêu cầu bồi thường

        [BsonElement("ngayYeuCau")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayYeuCau { get; set; } = DateTime.MinValue; // Ngày yêu cầu

        [BsonElement("soTienYeuCau")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal SoTienYeuCau { get; set; } = 0m; // Số tiền yêu cầu bồi thường

        [BsonElement("trangThai")]
        public string TrangThai { get; set; } = string.Empty; // Trạng thái yêu cầu

        [BsonElement("moTa")]
        public string MoTa { get; set; } = string.Empty; // Mô tả yêu cầu
    }

    public class ChiTietQuyenLoi
    {
        [BsonElement("maQuyenLoi")]
        public string MaQuyenLoi { get; set; } = string.Empty; // Mã quyền lợi bảo hiểm

        [BsonElement("loaiQuyenLoi")]
        public string LoaiQuyenLoi { get; set; } = string.Empty; // Loại quyền lợi

        [BsonElement("soTienBaoHiem")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal SoTienBaoHiem { get; set; } = 0m; // Số tiền bảo hiểm

        [BsonElement("dieuKien")]
        public string DieuKien { get; set; } = string.Empty; // Điều kiện áp dụng
    }

    public class LienHeKhanCap
    {
        [BsonElement("ten")]
        public string Ten { get; set; } = string.Empty; // Tên người liên hệ

        [BsonElement("quanHe")]
        public string QuanHe { get; set; } = string.Empty; // Quan hệ với khách hàng

        [BsonElement("soDienThoai")]
        public string SoDienThoai { get; set; } = string.Empty; // Số điện thoại liên hệ
    }
}
