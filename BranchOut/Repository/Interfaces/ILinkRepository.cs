using BranchOut.Data;

namespace BranchOut.Repository.Interfaces
{
    public interface ILinkRepository
    {
        Task<Link> CreateAsync(Link link);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<Link>> GetAllAsync();
        Task<Link> GetAsync(int id);
        Task<Link> UpdateAsync(Link link);
    }
}