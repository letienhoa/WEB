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
    public class ACCOUNTController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ACCOUNTController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ACCOUNT
        public async Task<IActionResult> Index()
        {
            return View(await _context.ACCOUNT.ToListAsync());
        }

        // GET: Admin/ACCOUNT/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCOUNT = await _context.ACCOUNT
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aCCOUNT == null)
            {
                return NotFound();
            }

            return View(aCCOUNT);
        }

        // GET: Admin/ACCOUNT/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ACCOUNT/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,PassWord,Type")] ACCOUNT aCCOUNT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aCCOUNT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aCCOUNT);
        }

        // GET: Admin/ACCOUNT/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCOUNT = await _context.ACCOUNT.FindAsync(id);
            if (aCCOUNT == null)
            {
                return NotFound();
            }
            return View(aCCOUNT);
        }

        // POST: Admin/ACCOUNT/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,PassWord,Type")] ACCOUNT aCCOUNT)
        {
            if (id != aCCOUNT.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aCCOUNT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ACCOUNTExists(aCCOUNT.Id))
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
            return View(aCCOUNT);
        }

        // GET: Admin/ACCOUNT/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCOUNT = await _context.ACCOUNT
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aCCOUNT == null)
            {
                return NotFound();
            }

            return View(aCCOUNT);
        }

        // POST: Admin/ACCOUNT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aCCOUNT = await _context.ACCOUNT.FindAsync(id);
            _context.ACCOUNT.Remove(aCCOUNT);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ACCOUNTExists(int id)
        {
            return _context.ACCOUNT.Any(e => e.Id == id);
        }
    }
}
