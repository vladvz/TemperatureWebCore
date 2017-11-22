using Microsoft.EntityFrameworkCore;
using TemperatureWebCore.Models;

namespace TemperatureWebCore.Data
{
    public class TemperatureContext : DbContext
    {
        public DbSet<Measure> Measures { get; set; }
        public DbSet<DailyTemperature> DailyTemperatures { get; set; }

        public TemperatureContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Measure>().ToTable("Measure");
        }
    }
}
