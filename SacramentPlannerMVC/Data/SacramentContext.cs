using SacramentPlannerMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SacramentPlannerMVC.Data
{
    public class SacramentContext : DbContext
    {
        public SacramentContext(DbContextOptions<SacramentContext> options) : base(options)
        {

        }

        public DbSet<Bishopric> Bishoprics { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bishopric>().ToTable("Bishopric");
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
        }
    }
}
