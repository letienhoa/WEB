using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITEBANMAYTINH.Models
{
    public class SanPhamChonChoHoaDon
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }

        [ForeignKey("AppointmentId")]
        public virtual Appointments Appointments { get; set; }

        public int SanPhamId { get; set; }


        [ForeignKey("SanPhamId")]
        public virtual SANPHAM  SANPHAM { get; set; }
    }
}
