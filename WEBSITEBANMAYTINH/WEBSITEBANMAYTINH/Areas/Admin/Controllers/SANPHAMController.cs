using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEBSITEBANMAYTINH.Data;
using WEBSITEBANMAYTINH.Models;
using WEBSITEBANMAYTINH.Models.ViewModel;
using WEBSITEBANMAYTINH.Utility;

namespace WEBSITEBANMAYTINH.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SANPHAMController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hosting;
        [BindProperty]
        public SANPHAMViewModel SANPHAMVM { get; set; }

        public SANPHAMController(ApplicationDbContext context,IHostingEnvironment hosting)
        {
            _context = context;
          
            _hosting = hosting;
            SANPHAMVM = new SANPHAMViewModel()
            {
                LOAISANPHAM = _context.LOAISANPHAM.ToList(),
                NHASANXUAT = _context.NHASANXUAT.ToList(),
                SANPHAM = new Models.SANPHAM()
                
            };
        }

        // GET: Admin/SANPHAM
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SANPHAM.Include(s => s.LOAISANPHAM).Include(s => s.NHASANXUAT);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/SANPHAM/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sANPHAM = await _context.SANPHAM
                .Include(s => s.LOAISANPHAM)
                .Include(s => s.NHASANXUAT)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sANPHAM == null)
            {
                return NotFound();
            }

            return View(sANPHAM);
        }

        //GetAction Create 
        public IActionResult Create()
        {
            return View(SANPHAMVM);
        }
        // Post
        [HttpPost,ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if(!ModelState.IsValid)
            {
                return View(SANPHAMVM);
            }
            _context.SANPHAM.Add(SANPHAMVM.SANPHAM);
            await _context.SaveChangesAsync();
            //image being saved
            string WebRootPath = _hosting.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var SanPhamFromDb = _context.SANPHAM.Find(SANPHAMVM.SANPHAM.Id);

            if(files.Count!=0)
            {
                //Upload Image
                var uploads = Path.Combine(WebRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using(var filestream=new FileStream(Path.Combine(uploads,SANPHAMVM.SANPHAM.Id+extension),FileMode.Create))
                {
                    files[0].CopyTo(filestream);

                }
                SanPhamFromDb.Image = @"\" + SD.ImageFolder + @"\" + SANPHAMVM.SANPHAM.Id + extension;
            }
            else
            {
                //When user does not upload image
                var uploads = Path.Combine(WebRootPath, SD.ImageFolder + @"\" + SD.DefaultSANPHAMImage);
                System.IO.File.Copy(uploads, WebRootPath + @"\" + SD.ImageFolder + @"\" + SANPHAMVM.SANPHAM.Id + ".png");
                SanPhamFromDb.Image = @"\" + SD.ImageFolder + @"\" + SANPHAMVM.SANPHAM.Id + ".png";

            }
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        //// GET: Admin/SANPHAM/Create
        //public IActionResult Create()
        //{
        //    ViewData["LoaiSanPhamId"] = new SelectList(_context.LOAISANPHAM, "Id", "TenLoaiSanPham");
        //    ViewData["NhaSanXuatId"] = new SelectList(_context.NHASANXUAT, "Id", "TenNhaSanXuat");
        //    return View();
        //}

        //// POST: Admin/SANPHAM/Create
        
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,TenSanPham,SoLuong,Image,DonGia,LoaiSanPhamId,NhaSanXuatId")] SANPHAM sANPHAM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(sANPHAM);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["LoaiSanPhamId"] = new SelectList(_context.LOAISANPHAM, "Id", "TenLoaiSanPham", sANPHAM.LOAISANPHAM.TenLoaiSanPham);
        //    ViewData["NhaSanXuatId"] = new SelectList(_context.NHASANXUAT, "Id", "TenNhaSanXuat", sANPHAM.NHASANXUAT.TenNhaSanXuat);
        //    return View(sANPHAM);
        //}

        // GET: Admin/SANPHAM/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sANPHAM = await _context.SANPHAM.FindAsync(id);
        //    if (sANPHAM == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["LoaiSanPhamId"] = new SelectList(_context.LOAISANPHAM, "Id", "Id", sANPHAM.LoaiSanPhamId);
        //    ViewData["NhaSanXuatId"] = new SelectList(_context.NHASANXUAT, "Id", "Id", sANPHAM.NhaSanXuatId);
        //    return View(sANPHAM);
        //}

        //// POST: Admin/SANPHAM/Edit/5
        
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,TenSanPham,SoLuong,Image,DonGia,LoaiSanPhamId,NhaSanXuatId")] SANPHAM sANPHAM)
        //{
        //    if (id != sANPHAM.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(sANPHAM);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SANPHAMExists(sANPHAM.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["LoaiSanPhamId"] = new SelectList(_context.LOAISANPHAM, "Id", "Id", sANPHAM.LoaiSanPhamId);
        //    ViewData["NhaSanXuatId"] = new SelectList(_context.NHASANXUAT, "Id", "Id", sANPHAM.NhaSanXuatId);
        //    return View(sANPHAM);
        //}
        //Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound(); 
            }
            SANPHAMVM.SANPHAM = await _context.SANPHAM.Include(m => m.LOAISANPHAM).Include(m => m.NHASANXUAT).SingleOrDefaultAsync(m => m.Id == id);
            if(SANPHAMVM.SANPHAM==null)
            {
                return NotFound();
            }
            return View(SANPHAMVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if(ModelState.IsValid)
            {
                string webRootPath = _hosting.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                var SanPhamFromDb = _context.SANPHAM.Where(m => m.Id == SANPHAMVM.SANPHAM.Id).FirstOrDefault();

                if(files[0].Length>0 && files[0]!=null)
                {
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(SanPhamFromDb.Image);

                    if(System.IO.File.Exists(Path.Combine(uploads,SANPHAMVM.SANPHAM.Id+extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, SANPHAMVM.SANPHAM.Id + extension_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, SANPHAMVM.SANPHAM.Id + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);

                    }
                    SANPHAMVM.SANPHAM.Image = @"\" + SD.ImageFolder + @"\" + SANPHAMVM.SANPHAM.Id + extension_new;
                }
                if(SANPHAMVM.SANPHAM.Image !=null)
                {
                    SanPhamFromDb.Image = SANPHAMVM.SANPHAM.Image;
                }
                SanPhamFromDb.TenSanPham = SANPHAMVM.SANPHAM.TenSanPham;
                SanPhamFromDb.SoLuong = SANPHAMVM.SANPHAM.SoLuong;
                SanPhamFromDb.DonGia = SANPHAMVM.SANPHAM.DonGia;
                SanPhamFromDb.LoaiSanPhamId = SANPHAMVM.SANPHAM.LoaiSanPhamId;
                SanPhamFromDb.NhaSanXuatId = SANPHAMVM.SANPHAM.NhaSanXuatId;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));


            }

            return View(SANPHAMVM);
        }
        // GET: Admin/SANPHAM/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sANPHAM = await _context.SANPHAM
                .Include(s => s.LOAISANPHAM)
                .Include(s => s.NHASANXUAT)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sANPHAM == null)
            {
                return NotFound();
            }

            return View(sANPHAM);
        }

        // POST: Admin/SANPHAM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sANPHAM = await _context.SANPHAM.FindAsync(id);
            _context.SANPHAM.Remove(sANPHAM);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SANPHAMExists(int id)
        {
            return _context.SANPHAM.Any(e => e.Id == id);
        }
    }
}
