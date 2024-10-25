using KlassiDBtarpe23.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KlassiDBtarpe23.Controllers
{
    public class CouponController : Controller
    {
        private readonly KlassiDBtarpe23DbContext _context;

        public CouponController(KlassiDBtarpe23DbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var KlassiDBtarpe23DbContext = _context.Coupon;
            return View(await KlassiDBtarpe23DbContext.ToListAsync());
        }
    }
}
