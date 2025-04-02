using BranchOut.Data.Models;

namespace BranchOut.Repository.Interfaces
{
    public interface IFontRepository
    {
        Task<IQueryable<Font>> GetAllAsync(string searchKeyword = null);
        Task<Font?> GetByIdAsync(int id);
        Task<Font> CreateAsync(Font font);
        Task<bool> UpdateAsync(Font font);
        Task<bool> DeleteAsync(int id);
    }
}
