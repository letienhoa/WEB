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
    public class HOADONController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HOADONController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/HOADON
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.HOADON.Include(h => h.KHACHHANG).Include(h => h.SANPHAM);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/HOADON/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOADON = await _context.HOADON
                .Include(h => h.KHACHHANG)
                .Include(h => h.SANPHAM)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hOADON == null)
            {
                return NotFound();
            }

            return View(hOADON);
        }

        // GET: Admin/HOADON/Create
        public IActionResult Create()
        {
            ViewData["KhachHangId"] = new SelectList(_context.KHACHHANG, "Id", "Id");
            ViewData["SanPhamId"] = new SelectList(_context.SANPHAM, "Id", "Id");
            return View();
        }

        // POST: Admin/HOADON/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KhachHangId,SanPhamId,SoLuongSanPham,TongDonGia,NgayLap")] HOADON hOADON)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hOADON);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KhachHangId"] = new SelectList(_context.KHACHHANG, "Id", "Id", hOADON.KhachHangId);
            ViewData["SanPhamId"] = new SelectList(_context.SANPHAM, "Id", "Id", hOADON.SanPhamId);
            return View(hOADON);
        }

        // GET: Admin/HOADON/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOADON = await _context.HOADON.FindAsync(id);
            if (hOADON == null)
            {
                return NotFound();
            }
            ViewData["KhachHangId"] = new SelectList(_context.KHACHHANG, "Id", "Id", hOADON.KhachHangId);
            ViewData["SanPhamId"] = new SelectList(_context.SANPHAM, "Id", "Id", hOADON.SanPhamId);
            return View(hOADON);
        }

        // POST: Admin/HOADON/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KhachHangId,SanPhamId,SoLuongSanPham,TongDonGia,NgayLap")] HOADON hOADON)
        {
            if (id != hOADON.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hOADON);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HOADONExists(hOADON.Id))
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
            ViewData["KhachHangId"] = new SelectList(_context.KHACHHANG, "Id", "Id", hOADON.KhachHangId);
            ViewData["SanPhamId"] = new SelectList(_context.SANPHAM, "Id", "Id", hOADON.SanPhamId);
            return View(hOADON);
        }

        // GET: Admin/HOADON/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOADON = await _context.HOADON
                .Include(h => h.KHACHHANG)
                .Include(h => h.SANPHAM)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hOADON == null)
            {
                return NotFound();
            }

            return View(hOADON);
        }

        // POST: Admin/HOADON/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hOADON = await _context.HOADON.FindAsync(id);
            _context.HOADON.Remove(hOADON);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HOADONExists(int id)
        {
            return _context.HOADON.Any(e => e.Id == id);
        }
    }
}
