using BranchOut.Data;
using BranchOut.Repository.Interfaces;

namespace BranchOut.Services
{
    public class LinksState
    {
        public Link CurrentLink { get; private set; } = new();
        public List<Link> LinksList { get; private set; } = new();

        public event Action? OnChange;

        public async Task UpdateLinkAsync(Link newLink, ILinkRepository repository)
        {
            await repository.UpdateAsync(newLink);
            CurrentLink = newLink;
            NotifyStateChanged();
        }

        public async Task UpdateLinkOrderAsync(List<Link> newLinks, ILinkRepository repository)
        {
            await repository.UpdateLinksOrderAsync(newLinks);
            LinksList = newLinks;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
