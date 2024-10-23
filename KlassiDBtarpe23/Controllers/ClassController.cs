using KlassiDBtarpe23.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KlassiDBtarpe23.Controllers
{
    public class ClassController : Controller
    {
        private readonly KlassiDBtarpe23DbContext _context;

        public ClassController(KlassiDBtarpe23DbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var KlassiDBtarpe23DbContext = _context.Class;
            return View(await KlassiDBtarpe23DbContext.ToListAsync());
        }
    }
}
