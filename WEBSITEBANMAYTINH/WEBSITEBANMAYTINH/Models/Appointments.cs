using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        
        public DateTime NgayLap { get; set; }

        [NotMapped]
        public DateTime ThoiGian { get; set; }

        public string TenKhachHang { get; set; }
        
        public string SoDienThoai { get; set; }

        public string Email { get; set; }

        public bool isConfirmed { get; set; }
    }
}
