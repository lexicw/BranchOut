using BranchOut.Data.Models;

namespace BranchOut.Repository.Interfaces
{
    public interface ILinkRepository
    {
        Task<Link> CreateAsync(Link link, string userId);
        Task<bool> DeleteAsync(int id);
        Task<List<Link>> GetAllAsync(string userId);
        Task<Link> GetAsync(int id);
        Task<Link> UpdateAsync(Link link);
        Task UpdateLinksOrderAsync(IEnumerable<Link> links);
    }
}