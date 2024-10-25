using KlassiDBtarpe23.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KlassiDBtarpe23.Controllers
{
    public class StudentController : Controller
    {
        private readonly KlassiDBtarpe23DbContext _context;

        public StudentController(KlassiDBtarpe23DbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var KlassiDBtarpe23DbContext = _context.Student;
            return View(await KlassiDBtarpe23DbContext.ToListAsync());
        }
    }
}
