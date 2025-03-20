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
    }
}
