using BranchOut.Data;
using BranchOut.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BranchOut.Services
{
    public class UserProfileState
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProfileRepository _profileRepository;

        public UserProfileState(
            UserManager<ApplicationUser> userManager,
            IProfileRepository profileRepository)
        {
            _userManager = userManager;
            _profileRepository = profileRepository;
        }

        public Profile? Profile { get; private set; }
        public bool UserExists { get; private set; } = true;

        public async Task LoadProfileAsync(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                UserExists = false;
                return;
            }

            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                UserExists = false;
                return;
            }

            Profile = await _profileRepository.GetAsync(user.Id);
            if (Profile == null)
            {
                UserExists = false;
            }
        }
    }
}
