using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEBSITEBANMAYTINH.Data;
using WEBSITEBANMAYTINH.Models;
using WEBSITEBANMAYTINH.Models.ViewModel;

namespace WEBSITEBANMAYTINH.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HOADONController : Controller
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public HOADONViewModel HoaDonVM { get; set; }

        public HOADONController(ApplicationDbContext context)
        {
            _context = context;

            HoaDonVM = new HOADONViewModel()
            {
                SANPHAM = _context.SANPHAM.ToList(),
                KHACHHANG=_context.KHACHHANG.ToList(),
                HOADON=new Models.HOADON()
            };
        }

        // GET: Admin/HOADON
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.HOADON.Include(h => h.KHACHHANG).Include(h => h.SANPHAM);
            return View(await applicationDbContext.ToListAsync());
        }



        //
        public IActionResult Create()
        {
            return View(HoaDonVM);
        }

        //Post
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(HoaDonVM);
            }
            _context.HOADON.Add(HoaDonVM.HOADON);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            HoaDonVM.HOADON = await _context.HOADON.Include(m => m.KHACHHANG).Include(m => m.SANPHAM).SingleOrDefaultAsync(m => m.Id == id);
            if (HoaDonVM.HOADON == null)
            {
                return NotFound();
            }
            return View(HoaDonVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var HoaDonFromDb = _context.HOADON.Where(m => m.Id == HoaDonVM.HOADON.Id).FirstOrDefault();

                HoaDonFromDb.KhachHangId = HoaDonVM.HOADON.KhachHangId;
                HoaDonFromDb.SanPhamId= HoaDonVM.HOADON.SanPhamId;
                HoaDonFromDb.SoLuongSanPham = HoaDonVM.HOADON.SoLuongSanPham;
                HoaDonFromDb.TongDonGia = HoaDonVM.HOADON.TongDonGia;
                HoaDonFromDb.NgayLap = HoaDonVM.HOADON.NgayLap;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(HoaDonVM);
        }

        //Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            HoaDonVM.HOADON = await _context.HOADON.Include(m => m.KHACHHANG).Include(m => m.SANPHAM).SingleOrDefaultAsync(m => m.Id == id);
            if (HoaDonVM.HOADON == null)
            {
                return NotFound();
            }
            return View(HoaDonVM);
        }

        //Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            HoaDonVM.HOADON = await _context.HOADON.Include(m => m.KHACHHANG).Include(m => m.SANPHAM).SingleOrDefaultAsync(m => m.Id == id);
            if (HoaDonVM.HOADON == null)
            {
                return NotFound();
            }
            return View(HoaDonVM);
        }

        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            HOADON HoaDon = await _context.HOADON.FindAsync(id);

            if (HoaDon == null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(HoaDon);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

        }
    }
}
