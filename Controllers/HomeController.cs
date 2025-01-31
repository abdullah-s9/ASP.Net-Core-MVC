using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaudiGuide.Data;
using SaudiGuide.Models;

namespace SaudiGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Qassim()
        {
            return View();
        }
        public IActionResult HasatAlNasla()
        {
            var events = _context.Events.Where(e => e.Id == 2).ToList();
            return View(events);
        }
        public IActionResult sheeb()
        {
            var events = _context.Events.Where(e => e.Id == 5).ToList();
            return View(events);
        }
        public IActionResult JabalTumayyah()
        {
            var events = _context.Events.Where(e => e.Id == 7).ToList();
            return View(events);
        }
        public IActionResult UyunAlJawaaVillage()
        {
            var events = _context.Events.Where(e => e.Id == 8).ToList();
            return View(events);
        }
        public IActionResult JadiahCastle()
        {
            var events = _context.Events.Where(e => e.Id == 9).ToList();
            return View(events);
        }
        public IActionResult BurjAlShananah()
        {
            var events = _context.Events.Where(e => e.Id == 10).ToList();
            return View(events);
        }
        public IActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Booking(Reservations reservation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(reservation);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Confirmation));
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", "ÕœÀ Œÿ√ √À‰«¡ Õ›Ÿ «·»Ì«‰« . Ì—ÃÏ «·„Õ«Ê·… „—… √Œ—Ï.");
                    _logger.LogError(ex, "Error saving reservation");
                }
            }
            return View(reservation);
        }

   
        public IActionResult Confirmation()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
