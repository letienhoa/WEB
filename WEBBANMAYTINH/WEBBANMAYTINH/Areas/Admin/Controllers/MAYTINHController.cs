using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBBANMAYTINH.Data;
using WEBBANMAYTINH.Models;

namespace WEBBANMAYTINH.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MAYTINHController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MAYTINHController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.MAYTINH.ToList());
        }
        // Get Create Action method
        public IActionResult Create()
        {
            return View();
        }
        //Post Create Action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MAYTINH MayTinh)
        {
            if(ModelState.IsValid)
            {
                _db.Add(MayTinh);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(MayTinh);
        }
    }
}