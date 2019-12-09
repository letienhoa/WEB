using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEBSITEBANMAYTINH.Data;
using WEBSITEBANMAYTINH.Models;
using WEBSITEBANMAYTINH.Utility;

namespace WEBSITEBANMAYTINH.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class LOAISANPHAMController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LOAISANPHAMController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/LOAISANPHAM
        public async Task<IActionResult> Index()
        {
            return View(await _context.LOAISANPHAM.ToListAsync());
        }

        // GET: Admin/LOAISANPHAM/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lOAISANPHAM = await _context.LOAISANPHAM
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lOAISANPHAM == null)
            {
                return NotFound();
            }

            return View(lOAISANPHAM);
        }

        // GET: Admin/LOAISANPHAM/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LOAISANPHAM/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenLoaiSanPham")] LOAISANPHAM lOAISANPHAM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lOAISANPHAM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lOAISANPHAM);
        }

        // GET: Admin/LOAISANPHAM/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lOAISANPHAM = await _context.LOAISANPHAM.FindAsync(id);
            if (lOAISANPHAM == null)
            {
                return NotFound();
            }
            return View(lOAISANPHAM);
        }

        // POST: Admin/LOAISANPHAM/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenLoaiSanPham")] LOAISANPHAM lOAISANPHAM)
        {
            if (id != lOAISANPHAM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lOAISANPHAM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LOAISANPHAMExists(lOAISANPHAM.Id))
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
            return View(lOAISANPHAM);
        }

        // GET: Admin/LOAISANPHAM/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lOAISANPHAM = await _context.LOAISANPHAM
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lOAISANPHAM == null)
            {
                return NotFound();
            }

            return View(lOAISANPHAM);
        }

        // POST: Admin/LOAISANPHAM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lOAISANPHAM = await _context.LOAISANPHAM.FindAsync(id);
            _context.LOAISANPHAM.Remove(lOAISANPHAM);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LOAISANPHAMExists(int id)
        {
            return _context.LOAISANPHAM.Any(e => e.Id == id);
        }
    }
}
