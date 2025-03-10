using BranchOut.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace BranchOut.Services
{
    public class UserService
    {
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(AuthenticationStateProvider authStateProvider, UserManager<ApplicationUser> userManager)
        {
            _authStateProvider = authStateProvider;
            _userManager = userManager;
        }

        public async Task<ApplicationUser?> GetCurrentUserAsync()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            var userPrincipal = authState.User;

            if (userPrincipal?.Identity?.IsAuthenticated != true)
                return null;

            return await _userManager.GetUserAsync(userPrincipal);
        }

        public async Task<ApplicationUser?> GetUserByUsernameAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return null;
            return await _userManager.FindByNameAsync(username);
        }
    }

}
