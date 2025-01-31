
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaudiGuide.Data;
using SaudiGuide.Models;

namespace SaudiGuide.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            var events = _context.Events.ToList();
            return View(events);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Img,Description,Price")] Events events)
        {
            if (id != events.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(events);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                }
                return RedirectToAction(nameof(Index));
            }
            return View(events);
        }
        // GET: Dashboard/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var events = await _context.Events.FindAsync(id);
            if (events == null)
            {
                return NotFound();
            }
            return View(events);
        }
        // POST: Dashboard/Create
        [HttpPost]
        public IActionResult Create(Events events)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(events);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(events);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var events = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (events == null)
            {
                return NotFound();
            }

            return View(events);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var events = await _context.Events.FindAsync(id);
            _context.Events.Remove(events);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public IActionResult Order()
        {
            var reservations = _context.Reservations .ToList();

            return View(reservations);
        }



    }

}