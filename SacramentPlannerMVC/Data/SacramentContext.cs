using SacramentPlannerMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SacramentPlannerMVC.Data
{
    public class SacramentContext : DbContext
    {
        public SacramentContext(DbContextOptions<SacramentContext> options) : base(options)
        {

        }

        public virtual DbSet<Bishopric> Bishopric { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Speaker> Speakers { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Hymn> Hymns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bishopric>().ToTable("Bishopric");
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Hymn>().ToTable("Hymns");
            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.HasOne(d => d.OpeningHymnNav).WithMany(p => p.MeetingOpeningHymnNav).HasForeignKey(d => d.OpeningHymnID).OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.SacramentHymnNav).WithMany(p => p.MeetingSacramentHymnNav).HasForeignKey(d => d.SacramentHymnID).OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.IntermediateHymnNav).WithMany(p => p.MeetingIntermediateHymnNav).HasForeignKey(d => d.IntermediateHymnID).OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.ClosingHymnNav).WithMany(p => p.MeetingClosingHymnNav).HasForeignKey(d => d.ClosingHymnID).OnDelete(DeleteBehavior.ClientSetNull);
                entity.ToTable("Meeting");
            });

            modelBuilder.Entity<Speaker>().ToTable("Speaker");
        }
    }
}
