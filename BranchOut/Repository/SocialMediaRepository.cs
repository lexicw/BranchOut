using BranchOut.Data.Models;
using BranchOut.Data;
using Microsoft.EntityFrameworkCore;
using BranchOut.Repository.Interfaces;
using BranchOut.Components.Pages.Main.Links;

namespace BranchOut.Repository
{
    public class SocialMediaRepository : ISocialMediaRepository
    {
        private readonly ApplicationDbContext _db;

        public SocialMediaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<SocialMedia>> GetAllAsync(string userId)
        {
            return await _db.SocialMedia
                .Where(s => s.UserId == userId)
                .ToListAsync();
        }

        public async Task<SocialMedia?> GetAsync(int id)
        {
            return await _db.SocialMedia
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task CreateAsync(SocialMedia socialMedia, string userId)
        {
            var profile = await _db.Profile.FirstOrDefaultAsync(p => p.UserID == userId);
            socialMedia.ProfileId = profile.Id;
            socialMedia.UserId = userId;
            socialMedia.DateAdded = DateTime.Now;

            _db.SocialMedia.Add(socialMedia);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(SocialMedia socialMedia)
        {
            _db.SocialMedia.Update(socialMedia);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var socialMedia = await _db.SocialMedia.FindAsync(id);
            if (socialMedia != null)
            {
                _db.SocialMedia.Remove(socialMedia);
                await _db.SaveChangesAsync();
            }
        }

    }


}
