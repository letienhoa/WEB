using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WEBSITEBANMAYTINH.Data;
using WEBSITEBANMAYTINH.Extensions;
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
 
        public async Task<IActionResult> Home()
        {
            var SanPhamList = await _db.SANPHAM.Include(m => m.LOAISANPHAM).Include(m => m.NHASANXUAT).ToListAsync();
            return View(SanPhamList);
        }

       

        //public async Task<IActionResult> Index()
        //{
        //    var SanPhamList = await _db.SANPHAM.Include(m => m.LOAISANPHAM).Include(m => m.NHASANXUAT).ToListAsync();
        //    return View(SanPhamList);
        //}

        public async Task<IActionResult> Details(int id)
        {
            var SanPham = await _db.SANPHAM.Include(m => m.LOAISANPHAM).Include(m => m.NHASANXUAT).Where(m=>m.Id==id).FirstOrDefaultAsync();

            return View(SanPham);
        }

 
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailsPost(int id)
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if (lstShoppingCart == null)
            {
                lstShoppingCart = new List<int>();

            }
            lstShoppingCart.Add(id);
            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);
            return RedirectToAction("Home", "Home", new { Areas = "Customer" });
        }

        public IActionResult Remove(int id)
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if(lstShoppingCart.Count>0)
            {
                if(lstShoppingCart.Contains(id))
                {
                    lstShoppingCart.Remove(id);
                }
            }
            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);
            return RedirectToAction("Home", "Home", new { Areas = "Customer" });

        }
    }
}
