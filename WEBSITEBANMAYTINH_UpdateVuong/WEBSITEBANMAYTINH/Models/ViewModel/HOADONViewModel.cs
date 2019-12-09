using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models.ViewModel
{
    public class HOADONViewModel
    {
        public HOADON HOADON { get; set; }

        public IEnumerable<SANPHAM> SANPHAM { get; set; }

        public IEnumerable<KHACHHANG> KHACHHANG { get; set; }
    }
}
