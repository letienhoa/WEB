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
    public class NHASANXUATController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NHASANXUATController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/NHASANXUAT
        public async Task<IActionResult> Index()
        {
            return View(await _context.NHASANXUAT.ToListAsync());
        }

        // GET: Admin/NHASANXUAT/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nHASANXUAT = await _context.NHASANXUAT
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nHASANXUAT == null)
            {
                return NotFound();
            }

            return View(nHASANXUAT);
        }

        // GET: Admin/NHASANXUAT/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/NHASANXUAT/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenNhaSanXuat,SoDienThoai,DiaChi")] NHASANXUAT nHASANXUAT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nHASANXUAT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nHASANXUAT);
        }

        // GET: Admin/NHASANXUAT/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nHASANXUAT = await _context.NHASANXUAT.FindAsync(id);
            if (nHASANXUAT == null)
            {
                return NotFound();
            }
            return View(nHASANXUAT);
        }

        // POST: Admin/NHASANXUAT/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenNhaSanXuat,SoDienThoai,DiaChi")] NHASANXUAT nHASANXUAT)
        {
            if (id != nHASANXUAT.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nHASANXUAT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NHASANXUATExists(nHASANXUAT.Id))
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
            return View(nHASANXUAT);
        }

        // GET: Admin/NHASANXUAT/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nHASANXUAT = await _context.NHASANXUAT
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nHASANXUAT == null)
            {
                return NotFound();
            }

            return View(nHASANXUAT);
        }

        // POST: Admin/NHASANXUAT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nHASANXUAT = await _context.NHASANXUAT.FindAsync(id);
            _context.NHASANXUAT.Remove(nHASANXUAT);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NHASANXUATExists(int id)
        {
            return _context.NHASANXUAT.Any(e => e.Id == id);
        }
    }
}
