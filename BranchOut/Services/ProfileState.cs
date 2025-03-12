using BranchOut.Data.Models;
using BranchOut.Repository.Interfaces;

namespace BranchOut.Services
{
    public class ProfileState
    {
        public Profile CurrentProfile { get; private set; } = new Profile();

        public event Action? OnChange;

        public async Task UpdateProfileAsync(Profile newProfile, IProfileRepository repository)
        {
            await repository.UpdateAsync(newProfile);

            CurrentProfile = newProfile;

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
