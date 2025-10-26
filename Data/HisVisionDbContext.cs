using Microsoft.EntityFrameworkCore;
using HisVisionHCS.Web.Models;

namespace HisVisionHCS.Web.Data
{
    public class HisVisionDbContext : DbContext
    {
        public HisVisionDbContext(DbContextOptions<HisVisionDbContext> options)
            : base(options)
        {
        }

        public DbSet<Referral> Referrals { get; set; }
        public DbSet<CareerApplication> CareerApplications { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<CommunityEngagement> CommunityEngagements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Referrals table
            modelBuilder.Entity<Referral>(entity =>
            {
                entity.ToTable("Referrals");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
                entity.Property(e => e.Status).HasDefaultValue("New");
            });

            // Configure CareerApplications table
            modelBuilder.Entity<CareerApplication>(entity =>
            {
                entity.ToTable("CareersApplications");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
                entity.Property(e => e.Status).HasDefaultValue("New");
            });

            // Configure ContactMessages table
            modelBuilder.Entity<ContactMessage>(entity =>
            {
                entity.ToTable("ContactMessages");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
                entity.Property(e => e.Status).HasDefaultValue("New");
            });

            // Configure CommunityEngagements table
            modelBuilder.Entity<CommunityEngagement>(entity =>
            {
                entity.ToTable("CommunityEngagements");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
                entity.Property(e => e.Date).HasDefaultValueSql("GETDATE()");
            });
        }
    }
}



