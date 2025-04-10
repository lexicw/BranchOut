using BranchOut.Data.Models;
using BranchOut.Repository.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BranchOut.Services
{
    public class SocialMediaState
    {
        public SocialMedia CurrentSocial { get; private set; } = new();
        public List<SocialMedia> SocialsList { get; set; } = new List<SocialMedia>();

        public event Action? OnChange;

        public async Task UpdateSocialAsync(SocialMedia updated, ISocialMediaRepository repository)
        {
            await repository.UpdateAsync(updated);
            CurrentSocial = updated;
            NotifyStateChanged();
        }

        public async Task UpdateStateAsync(List<SocialMedia> updatedList, ISocialMediaRepository repository)
        {
            SocialsList = updatedList;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
