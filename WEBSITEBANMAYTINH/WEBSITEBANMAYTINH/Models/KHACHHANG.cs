using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models
{
    public class KHACHHANG
    {
        public int Id { get; set; }

        public string TenKhachHang { get; set; }

        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }

        public bool GioiTinh { get; set; }

        public int DiemTich { get; set; }

        public KHACHHANG()
        {
            HOADON = new HashSet<HOADON>();
        }
        public ICollection<HOADON> HOADON { get; set; }
    }
}
