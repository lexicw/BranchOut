using Microsoft.AspNetCore.Identity;

namespace BranchOut.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public Profile? Profile { get; set; }
    }

}
