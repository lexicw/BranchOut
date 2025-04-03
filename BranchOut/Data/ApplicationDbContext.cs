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

        public DbSet<Font> Font { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profile>()
                .HasOne(p => p.ApplicationUser)
                .WithOne(a => a.Profile)
                .HasForeignKey<Profile>(p => p.UserID);

            modelBuilder.Entity<Gradient>().HasData(
                new Gradient { Id = 1, Value = "None", CssClass = null },
                new Gradient { Id = 2, Value = "Cherry Blossom", CssClass = "gradient-cherry-blossom" },
                new Gradient { Id = 3, Value = "Tropical", CssClass = "gradient-tropical" },
                new Gradient { Id = 4, Value = "Northern Lights", CssClass = "gradient-northern-lights" },
                new Gradient { Id = 5, Value = "Vibrant", CssClass = "gradient-vibrant" },
                new Gradient { Id = 6, Value = "Lime", CssClass = "gradient-lime" },
                new Gradient { Id = 7, Value = "Ocean", CssClass = "gradient-ocean" },
                new Gradient { Id = 8, Value = "Fire", CssClass = "gradient-fire" },
                new Gradient { Id = 9, Value = "Solar", CssClass = "gradient-solar" }
            );

            modelBuilder.Entity<Font>().HasData(
                new Font { Id = 1, Name = "Inter", CssClass = "font-inter" },
                new Font { Id = 2, Name = "Sofia", CssClass = "font-sofia" },
                new Font { Id = 3, Name = "Merriweather", CssClass = "font-merriweather" },
                new Font { Id = 4, Name = "Miniver", CssClass = "font-miniver" },
                new Font { Id = 5, Name = "Oswald", CssClass = "font-oswald" },
                new Font { Id = 6, Name = "Raleway", CssClass = "font-raleway" },
                new Font { Id = 7, Name = "Yomogi", CssClass = "font-yomogi" },
                new Font { Id = 8, Name = "Silkscreen", CssClass = "font-silkscreen" },
                new Font { Id = 9, Name = "Fresca", CssClass = "font-fresca" }
            );

        }
    }

}
