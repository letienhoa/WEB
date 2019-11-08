using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WEBBANMAYTINH.Models;

namespace WEBBANMAYTINH.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ACCOUNT> ACCOUNT { get; set; }
        public DbSet<MAYTINH> MAYTINH { get; set; }
        public DbSet<NHASANXUAT> NHASANXUAT { get; set; }
        public DbSet<LOAIMAYTINH> LOAIMAYTINH { get; set; }
    }
}
