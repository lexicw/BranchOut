using BranchOut.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BranchOut.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Link> Link { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Gradient> Gradient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profile>()
                .HasOne(p => p.ApplicationUser)
                .WithOne(a => a.Profile)
                .HasForeignKey<Profile>(p => p.UserID);
        }
    }

}
