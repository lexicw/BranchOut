using BranchOut.Data.Models;

namespace BranchOut.Repository.Interfaces
{
    public interface IGradientRepository
    {
        Task<IQueryable<Gradient>> GetAllAsync();
    }
}