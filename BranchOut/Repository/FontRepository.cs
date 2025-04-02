using BranchOut.Data;
using BranchOut.Data.Models;
using BranchOut.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BranchOut.Repository
{
    public class FontRepository : IFontRepository
    {
        private readonly ApplicationDbContext _db;

        public FontRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IQueryable<Font>> GetAllAsync(string searchKeyword = null)
        {
            var fontsQuery = _db.Font.AsQueryable();

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                fontsQuery = fontsQuery.Where(f => f.Name.Contains(searchKeyword));
            }

            var fonts = await fontsQuery.ToListAsync();
            return fonts.AsQueryable();
        }

        public async Task<Font?> GetByIdAsync(int id)
        {
            return await _db.Font.FindAsync(id);
        }

        public async Task<Font> CreateAsync(Font font)
        {
            _db.Font.Add(font);
            await _db.SaveChangesAsync();
            return font;
        }

        public async Task<bool> UpdateAsync(Font font)
        {
            var existingFont = await _db.Font.FindAsync(font.Id);
            if (existingFont == null)
            {
                return false;
            }

            _db.Entry(existingFont).CurrentValues.SetValues(font);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var font = await _db.Font.FindAsync(id);
            if (font == null)
            {
                return false;
            }

            _db.Font.Remove(font);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
