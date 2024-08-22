using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNoSQL.Models
{
    public class CustomerViewModel
    {
        public string MaKhachHang { get; set; }
        public string MaDinhDanh { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string ChucDanh { get; set; }
        public string BenhLy { get; set; }
        public string SoNhaVaTenDuong { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanhPho { get; set; }

        public CustomerViewModel()
        {
        }

        public CustomerViewModel(Models.Customer customer)
        {
            MaKhachHang = customer.MaKhachHang ?? string.Empty;
            MaDinhDanh = customer.MaDinhDanh ?? string.Empty;
            HoTen = customer.HoVaTen ?? string.Empty;
            NgaySinh = customer.NgaySinh;
            GioiTinh = customer.GioiTinh ?? string.Empty;
            SoDienThoai = customer.LienHe?.SoDienThoai ?? string.Empty;
            DiaChi = $"{customer.DiaChi?.SoNhaVaTenDuong ?? string.Empty}, {customer.DiaChi?.QuanHuyen ?? string.Empty}, {customer.DiaChi?.TinhThanhPho ?? string.Empty}";
            SoNhaVaTenDuong = customer.DiaChi?.SoNhaVaTenDuong ?? string.Empty;
            QuanHuyen = customer.DiaChi?.QuanHuyen ?? string.Empty;
            TinhThanhPho = customer.DiaChi?.TinhThanhPho ?? string.Empty;
            Email = customer.LienHe?.Email ?? string.Empty;
            ChucDanh = customer.NgheNghiep?.ChucDanh ?? string.Empty;
            BenhLy = string.Join(", ", customer.ThongTinSucKhoe?.BenhLy ?? new List<string>());
        }
    }
}
