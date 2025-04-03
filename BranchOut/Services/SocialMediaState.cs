using BranchOut.Data.Models;
using BranchOut.Repository.Interfaces;

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
            // You could optionally call repository-level batch update here if you had one
            SocialsList = updatedList;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
