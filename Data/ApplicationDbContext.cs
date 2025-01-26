using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SaudiGuide.Models;

namespace SaudiGuide.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
    }
}
