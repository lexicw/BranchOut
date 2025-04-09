using BranchOut.Data.Models;

namespace BranchOut.Repository.Interfaces
{
    public interface ISocialMediaRepository
    {
        Task<List<SocialMedia>> GetAllAsync(string userId);
        Task<SocialMedia?> GetAsync(int id);
        Task CreateAsync(SocialMedia socialMedia, string userId);
        Task UpdateAsync(SocialMedia socialMedia);
        Task DeleteAsync(int id);
        Task UpdateListAsync(IEnumerable<SocialMedia> socialMediaList);
    }

}