using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using N8DatVeRapChieuPhim.Data;
using N8DatVeRapChieuPhim.Models;

namespace N8DatVeRapChieuPhim.Controllers
{
    public class PhimsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhimsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Phims
        public async Task<IActionResult> Index()
        {
            return View(await _context.Phims.ToListAsync());
        }

        // GET: Phims/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var phim = await _context.Phims
                .FirstOrDefaultAsync(p => p.Id == id);

            if (phim == null)
                return NotFound();

            return View(phim);
        }

        // GET: Phims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Phims/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phim);
        }

        // GET: Phims/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var phim = await _context.Phims.FindAsync(id);
            if (phim == null)
                return NotFound();

            return View(phim);
        }

        // POST: Phims/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Phim phim)
        {
            if (id != phim.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phim);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Phims.Any(p => p.Id == id))
                        return NotFound();
                    else
                        throw;
                }
            }
            return View(phim);
        }

        // GET: Phims/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var phim = await _context.Phims
                .FirstOrDefaultAsync(p => p.Id == id);

            if (phim == null)
                return NotFound();

            return View(phim);
        }

        // POST: Phims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phim = await _context.Phims.FindAsync(id);
            if (phim != null)
            {
                _context.Phims.Remove(phim);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
