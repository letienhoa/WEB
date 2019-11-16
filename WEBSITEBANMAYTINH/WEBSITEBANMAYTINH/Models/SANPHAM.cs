using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models
{
    public class SANPHAM
    {
        public SANPHAM()
        {
            HOADON = new HashSet<HOADON>();
        }
        public int Id { get; set; }


        public string TenSanPham { get; set; }


        public int SoLuong { get; set; }


        public string Image { get; set; }


        public double DonGia { get; set; }
        //
        [ForeignKey("LoaiSanPhamId")]
        public LOAISANPHAM LOAISANPHAM { get; set; }
        [Display(Name = "Loai San Pham")]
        public int LoaiSanPhamId { get; set; }
        //
        [ForeignKey("NhaSanXuatId")]
        public NHASANXUAT NHASANXUAT { get; set; }

        [Display(Name = "Nha San Xuat")]
        public int NhaSanXuatId { get; set; }

        //
        public ICollection<HOADON> HOADON { get; set; }
    }
}
