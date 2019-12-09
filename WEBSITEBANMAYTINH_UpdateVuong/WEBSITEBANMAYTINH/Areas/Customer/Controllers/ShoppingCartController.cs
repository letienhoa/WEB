using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBSITEBANMAYTINH.Data;
using WEBSITEBANMAYTINH.Extensions;
using WEBSITEBANMAYTINH.Models;
using WEBSITEBANMAYTINH.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace WEBSITEBANMAYTINH.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public ShoppingCartViewModel ShoppingCartVM { get; set; }
        public ShoppingCartController(ApplicationDbContext db)
        {
            _db = db;
            ShoppingCartVM = new ShoppingCartViewModel()
            {
                SANPHAM = new List<Models.SANPHAM>()
            };
        }
        //Get Index Shopping Cart
        public async Task<IActionResult> Index()
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if(lstShoppingCart.Count>0)
            {
                foreach(int cartItem in lstShoppingCart)
                {
                    SANPHAM SanPham = _db.SANPHAM.Include(p=>p.NHASANXUAT).Include(p=>p.LOAISANPHAM).Where(p => p.Id == cartItem).FirstOrDefault();
                    ShoppingCartVM.SANPHAM.Add(SanPham);
                }
            }
            return View(ShoppingCartVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public IActionResult IndexPost()
        {
            List<int> lstCartItem = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            ShoppingCartVM.Appointments.NgayLap = ShoppingCartVM.Appointments.NgayLap
                                                    .AddHours(ShoppingCartVM.Appointments.ThoiGian.Hour)
                                                    .AddMinutes(ShoppingCartVM.Appointments.ThoiGian.Minute);
            Appointments appointments = ShoppingCartVM.Appointments;
            _db.Appointments.Add(appointments);
            _db.SaveChanges();
            int appointmentId = appointments.Id;

            foreach(int sanphamId in lstCartItem)
            {
                SanPhamChonChoHoaDon sanPhamChonChoHoaDon = new SanPhamChonChoHoaDon()
                {
                    AppointmentId = appointmentId,
                    SanPhamId = sanphamId
                };
                _db.SanPhamChonChoHoaDon.Add(sanPhamChonChoHoaDon);
            }
            _db.SaveChanges();
            lstCartItem = new List<int>();
            HttpContext.Session.Set("ssShoppingCart", lstCartItem);

            return RedirectToAction("XacNhanDonHang","ShoppingCart",new { Id=appointmentId});
        }

        public IActionResult Remove(int id)
        {
            List<int> lstCartItem = HttpContext.Session.Get<List<int>>("ssShoppingCart");

            if(lstCartItem.Count>0)
            {
                if(lstCartItem.Contains(id))
                {
                    lstCartItem.Remove(id);
                }
            }

            HttpContext.Session.Set("ssShoppingCart", lstCartItem);
            return RedirectToAction(nameof(Index));
        }
        
        //Get
        public IActionResult XacNhanDonHang(int id)
        {
            ShoppingCartVM.Appointments = _db.Appointments.Where(a => a.Id == id).FirstOrDefault();
            List<SanPhamChonChoHoaDon> danhsachSanPham = _db.SanPhamChonChoHoaDon.Where(p => p.AppointmentId == id).ToList();
            
            foreach(SanPhamChonChoHoaDon item in danhsachSanPham)
            {
                ShoppingCartVM.SANPHAM.Add(_db.SANPHAM.Include(p => p.LOAISANPHAM).Include(p => p.NHASANXUAT).Where(p => p.Id == item.SanPhamId).FirstOrDefault());
            }

            return View(ShoppingCartVM);
        }
    }
}