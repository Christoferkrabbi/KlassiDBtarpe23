using Microsoft.EntityFrameworkCore;
using KlassiDBtarpe23.Core.Domain;

namespace KlassiDBtarpe23.Data
{
    public class KlassiDBtarpe23DbContext : DbContext
    {
        public KlassiDBtarpe23DbContext(DbContextOptions<KlassiDBtarpe23DbContext> options)
            : base(options) { }

        public DbSet<Class> Class {  get; set; }
        public DbSet<Student> Student {  get; set; }
        public DbSet<Instructor> Instructor {  get; set; }
        public DbSet<Coupon> Coupon { get; set; }


    }
}
