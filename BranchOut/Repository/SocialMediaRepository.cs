using BranchOut.Data.Models;
using BranchOut.Data;
using Microsoft.EntityFrameworkCore;
using BranchOut.Repository.Interfaces;

namespace BranchOut.Repository
{
    public class SocialMediaRepository : ISocialMediaRepository
    {
        private readonly ApplicationDbContext _context;

        public SocialMediaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SocialMedia>> GetAllAsync(string userId)
        {
            return await _context.SocialMedia
                .Where(s => s.UserId == userId)
                .ToListAsync();
        }

        public async Task<SocialMedia?> GetAsync(int id)
        {
            return await _context.SocialMedia
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task CreateAsync(SocialMedia socialMedia, string userId)
        {
            socialMedia.UserId = userId;
            _context.SocialMedia.Add(socialMedia);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SocialMedia socialMedia)
        {
            _context.SocialMedia.Update(socialMedia);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var socialMedia = await _context.SocialMedia.FindAsync(id);
            if (socialMedia != null)
            {
                _context.SocialMedia.Remove(socialMedia);
                await _context.SaveChangesAsync();
            }
        }
    }


}
