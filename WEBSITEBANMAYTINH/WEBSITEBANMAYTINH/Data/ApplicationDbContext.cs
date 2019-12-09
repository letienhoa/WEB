using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WEBSITEBANMAYTINH.Models;

namespace WEBSITEBANMAYTINH.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ACCOUNT> ACCOUNT { get; set; }
        public DbSet<SANPHAM> SANPHAM { get; set; }

        public DbSet<LOAISANPHAM> LOAISANPHAM { get; set; }

        public DbSet<NHASANXUAT> NHASANXUAT { get; set; }

        public DbSet<KHACHHANG> KHACHHANG { get; set; }

        public DbSet<HOADON> HOADON { get; set; }

        public DbSet<Appointments> Appointments{ get; set; }
        public DbSet<SanPhamChonChoHoaDon> SanPhamChonChoHoaDon{ get; set; }

    }
}
