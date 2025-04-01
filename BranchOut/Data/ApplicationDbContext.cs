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

            //modelBuilder.Entity<Gradient>().HasData(
            //    new Gradient { Id = 1, Value = "None", CssClass = null },
            //    new Gradient { Id = 2, Value = "Cherry Blossom", CssClass = "gradient-cherry-blossom" },
            //    new Gradient { Id = 3, Value = "Tropical", CssClass = "gradient-tropical" },
            //    new Gradient { Id = 4, Value = "Northern Lights", CssClass = "gradient-northern-lights" },
            //    new Gradient { Id = 5, Value = "Vibrant", CssClass = "gradient-vibrant" },
            //    new Gradient { Id = 6, Value = "Lime", CssClass = "gradient-lime" },
            //    new Gradient { Id = 7, Value = "Ocean", CssClass = "gradient-ocean" },
            //    new Gradient { Id = 8, Value = "Fire", CssClass = "gradient-fire" },
            //    new Gradient { Id = 9, Value = "Solar", CssClass = "gradient-space" }
            //);
        }
    }

}
