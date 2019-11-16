using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEBSITEBANMAYTINH.Data;
using WEBSITEBANMAYTINH.Models;

namespace WEBSITEBANMAYTINH.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KHACHHANGController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KHACHHANGController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/KHACHHANG
        public async Task<IActionResult> Index()
        {
            return View(await _context.KHACHHANG.ToListAsync());
        }

        // GET: Admin/KHACHHANG/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kHACHHANG = await _context.KHACHHANG
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kHACHHANG == null)
            {
                return NotFound();
            }

            return View(kHACHHANG);
        }

        // GET: Admin/KHACHHANG/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/KHACHHANG/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenKhachHang,SoDienThoai,DiaChi,GioiTinh,DiemTich")] KHACHHANG kHACHHANG)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kHACHHANG);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kHACHHANG);
        }

        // GET: Admin/KHACHHANG/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kHACHHANG = await _context.KHACHHANG.FindAsync(id);
            if (kHACHHANG == null)
            {
                return NotFound();
            }
            return View(kHACHHANG);
        }

        // POST: Admin/KHACHHANG/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenKhachHang,SoDienThoai,DiaChi,GioiTinh,DiemTich")] KHACHHANG kHACHHANG)
        {
            if (id != kHACHHANG.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kHACHHANG);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KHACHHANGExists(kHACHHANG.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(kHACHHANG);
        }

        // GET: Admin/KHACHHANG/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kHACHHANG = await _context.KHACHHANG
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kHACHHANG == null)
            {
                return NotFound();
            }

            return View(kHACHHANG);
        }

        // POST: Admin/KHACHHANG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kHACHHANG = await _context.KHACHHANG.FindAsync(id);
            _context.KHACHHANG.Remove(kHACHHANG);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KHACHHANGExists(int id)
        {
            return _context.KHACHHANG.Any(e => e.Id == id);
        }
    }
}
