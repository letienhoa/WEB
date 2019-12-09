using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models
{
    public class LOAISANPHAM
    {
        public LOAISANPHAM()
        {
            SANPHAM = new HashSet<SANPHAM>();
        }

        public int Id { get; set; }


        public string TenLoaiSanPham { get; set; }

        public ICollection<SANPHAM> SANPHAM { get; set; }
    }
}
