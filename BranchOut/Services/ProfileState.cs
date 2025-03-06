using BranchOut.Data;

namespace BranchOut.Services
{
    public class ProfileState
    {
        public event Action OnChange;

        private Profile _profile { get; set; } = new Profile();
        private List<Link> _links { get; set; } = new();

        public Profile Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                NotifyStateChanged();
            }
        }

        public List<Link> Links
        {
            get => _links;
            set
            {
                _links = value;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
