using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using N8DatVeRapChieuPhim.Data;
using N8DatVeRapChieuPhim.Models.ViewModel;

namespace N8DatVeRapChieuPhim.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Admin/Dashboard
        public async Task<IActionResult> Dashboard()
        {
            ViewData["Title"] = "Dashboard";

            var viewModel = new DashboardViewModel
            {
                TongPhim = await _context.Phims.CountAsync(),
                /*
                TongPhongChieu = await _context.PhongChieus.CountAsync(),
                TongSuatChieu = await _context.SuatChieus.CountAsync(),
                TongVeDaBan = await _context.Ves.CountAsync(),

                // Tổng doanh thu
                TongDoanhThu = await _context.Ves.SumAsync(v => (decimal?)v.GiaVe) ?? 0 
                */
            };

            return View(viewModel);
        }

        // Điều hướng nhanh
        public IActionResult Movies()
        {
            return RedirectToAction("Index", "Phims");
        }

        public IActionResult Rooms()
        {
            return RedirectToAction("Index", "PhongChieus");
        }

        public IActionResult Showtimes()
        {
            return RedirectToAction("Index", "SuatChieus");
        }

        public IActionResult Tickets()
        {
            return RedirectToAction("Index", "Ves");
        }

        // GET: /Admin/Statistics
        public IActionResult Statistics()
        {
            ViewData["Title"] = "Thống kê";
            return View();
        }
    }
}
