using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models
{
    public class HOADON
    {
        public int Id { get; set; }

        [ForeignKey("KhachHangId")]
        public KHACHHANG KHACHHANG { get; set; }

        [Display(Name = "Khach Hang")]
        public int KhachHangId { get; set; }



        [ForeignKey("SanPhamId")]
        public SANPHAM SANPHAM { get; set; }

        [Display(Name = "San Pham")]
        public int SanPhamId { get; set; }

        public int SoLuongSanPham { get; set; }

        public double TongDonGia { get; set; }

        public DateTime? NgayLap { get; set; }


    }
}
