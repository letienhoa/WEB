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
    public class ACCOUNTController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ACCOUNTController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.ACCOUNT.ToList());
        }
        //Get Create Action Method
        public IActionResult Create()
        {
            return View();
        }
        //Post Create Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ACCOUNT Account)
        {
            if(ModelState.IsValid)
            {
                _db.Add(Account);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Account);
        }
    }
}