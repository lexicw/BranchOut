using BranchOut.Data;

namespace BranchOut.Repository.Interfaces
{
    public interface IProfileRepository
    {
        Task<Profile> CreateAsync(Profile profile);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<Profile>> GetAllAsync();
        Task<Profile> GetAsync(string id);
        Task<Profile> UpdateAsync(Profile profile);
    }
}