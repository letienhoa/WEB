using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBBANMAYTINH.Models
{
    public class NHASANXUAT
    {
        public NHASANXUAT()
        {
            MAYTINH = new HashSet<MAYTINH>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string TenNhaSanXuat { get; set; }

        public string NoiSanXuat { get; set; }

        public ICollection<MAYTINH> MAYTINH { get; set; }
    }
}
