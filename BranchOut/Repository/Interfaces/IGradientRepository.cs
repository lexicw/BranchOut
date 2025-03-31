using BranchOut.Data.Models;

namespace BranchOut.Repository.Interfaces
{
    public interface IGradientRepository
    {
        Task<Gradient> CreateAsync(Gradient gradient);
        Task<bool> DeleteAsync(int id);
        Task<IQueryable<Gradient>> GetAllAsync(string searchKeyword = null);
        Task<Gradient?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(Gradient gradient);
    }
}