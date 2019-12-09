using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models.ViewModel
{
    public class SANPHAMViewModel
    {
        public SANPHAM SANPHAM { get; set; }

        public IEnumerable<LOAISANPHAM> LOAISANPHAM { get; set; }

        public IEnumerable<NHASANXUAT> NHASANXUAT { get; set; }
    }
}
