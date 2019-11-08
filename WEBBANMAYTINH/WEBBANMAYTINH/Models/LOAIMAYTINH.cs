using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBBANMAYTINH.Models
{
    public class LOAIMAYTINH
    {
        public LOAIMAYTINH()
        {
            MAYTINH = new HashSet<MAYTINH>();
        }
        [Required]
        public int Id { get; set; }

        [Required]
        public string LoaiMay { get; set; }

        public ICollection<MAYTINH> MAYTINH { get; set; }
    }
}
