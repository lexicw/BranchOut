using BranchOut.Data.Models;

namespace BranchOut.Repository.Interfaces
{
    public interface IGradientRepository
    {
        IQueryable<Gradient> GetAll();
    }
}