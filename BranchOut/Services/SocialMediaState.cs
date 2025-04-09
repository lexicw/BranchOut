using BranchOut.Data.Models;
using BranchOut.Repository.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BranchOut.Services
{
    public class SocialMediaState
    {
        public SocialMedia CurrentSocial { get; private set; } = new();
        public List<SocialMedia> SocialsList { get; private set; } = new();

        public event Action? OnChange;

        public async Task UpdateSocialAsync(SocialMedia updated, ISocialMediaRepository repository)
        {
            await repository.UpdateAsync(updated);
            CurrentSocial = updated;
            NotifyStateChanged();
        }

        public async Task UpdateStateAsync(List<SocialMedia> updatedList, ISocialMediaRepository repository)
        {
            await repository.UpdateListAsync(updatedList);
            SocialsList = updatedList;
            NotifyStateChanged();
        }

        public async Task InitializeAsync(string userId, ISocialMediaRepository repository)
        {
            SocialsList = await repository.GetAllAsync(userId);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
