using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models
{
    public class NHASANXUAT
    {
        public NHASANXUAT()
        {
            SANPHAM = new HashSet<SANPHAM>();
        }
        public int Id { get; set; }

        public string TenNhaSanXuat { get; set; }


        public int SoDienThoai { get; set; }

        public string DiaChi { get; set; }

        public ICollection<SANPHAM> SANPHAM { get; set; }
    }
}
