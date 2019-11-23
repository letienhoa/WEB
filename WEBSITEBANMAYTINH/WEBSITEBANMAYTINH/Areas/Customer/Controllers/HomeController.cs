using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WEBSITEBANMAYTINH.Data;
using WEBSITEBANMAYTINH.Models;

namespace WEBSITEBANMAYTINH.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        

        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Home()
        {
            return View();
        }

       

        public async Task<IActionResult> Index()
        {
            var SanPhamList = await _db.SANPHAM.Include(m => m.LOAISANPHAM).Include(m => m.NHASANXUAT).ToListAsync();
            return View(SanPhamList);
        }

        public async Task<IActionResult> Details(int id)
        {
            var SanPham = await _db.SANPHAM.Include(m => m.LOAISANPHAM).Include(m => m.NHASANXUAT).Where(m=>m.Id==id).FirstOrDefaultAsync();

            return View(SanPham);
        }
    }
}
