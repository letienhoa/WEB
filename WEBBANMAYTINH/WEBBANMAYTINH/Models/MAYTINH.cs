using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBBANMAYTINH.Models
{
    public class MAYTINH
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TenMayTinh { get; set; }

        public DateTime NgaySanXuat { get; set; }

        public NHASANXUAT NhaSanXuat { get; set; }

        public LOAIMAYTINH LoaiMayTinh { get; set; }
    }
}
