using BranchOut.Data;
using BranchOut.Data.Models;
using BranchOut.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BranchOut.Repository
{
    public class GradientRepository : IGradientRepository
    {
        private readonly ApplicationDbContext _db;

        public GradientRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IQueryable<Gradient>> GetAllAsync()
        {
            var gradients = await _db.Gradient.ToListAsync();
            return gradients.AsQueryable();
        }

        public async Task<Gradient?> GetByIdAsync(int id)
        {
            return await _db.Gradient.FindAsync(id);
        }

        public async Task<Gradient> CreateAsync(Gradient gradient)
        {
            _db.Gradient.Add(gradient);
            await _db.SaveChangesAsync();
            return gradient;
        }

        public async Task<bool> UpdateAsync(Gradient gradient)
        {
            var existingGradient = await _db.Gradient.FindAsync(gradient.Id);
            if (existingGradient == null)
            {
                return false;
            }

            _db.Entry(existingGradient).CurrentValues.SetValues(gradient);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var gradient = await _db.Gradient.FindAsync(id);
            if (gradient == null)
            {
                return false;
            }

            _db.Gradient.Remove(gradient);
            await _db.SaveChangesAsync();
            return true;
        }
    }

}
