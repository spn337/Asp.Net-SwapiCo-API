using Microsoft.EntityFrameworkCore;
using SWAPICO.Models;
using System.Linq;

namespace SWAPICO.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }

        public DbSet<DbPlanet> Planets { get; set; }
        public DbSet<DbPerson> People { get; set; }
        public DbSet<DbStarship> Starships { get; set; }
    }
}
