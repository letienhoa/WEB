using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBBANMAYTINH.Models
{
    public class ACCOUNT
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string PassWord { get; set; }
    }
}
