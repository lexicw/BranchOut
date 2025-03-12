using BranchOut.Data;
using BranchOut.Data.Models;
using BranchOut.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BranchOut.Repository
{
    public class LinkRepository : ILinkRepository
    {
        private readonly ApplicationDbContext _db;

        public LinkRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Link> CreateAsync(Link link, string userId)
        {
            var profile = await _db.Profile.FirstOrDefaultAsync(p => p.UserID == userId);

            link.ProfileId = profile.Id;
            link.UserID = userId;
            link.DateAdded = DateTime.Now;
            link.Visible = true;

            var maxSort = await _db.Link
                .Where(l => l.UserID == userId)
                .Select(l => (int?)l.Sort)
                .MaxAsync() ?? 0;
            link.Sort = maxSort + 1;

            await _db.Link.AddAsync(link);
            await _db.SaveChangesAsync();

            return link;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var link = await _db.Link.FirstOrDefaultAsync(x => x.Id == id);
            if (link != null)
            {
                _db.Link.Remove(link);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<Link> GetAsync(int id)
        {
            var link = await _db.Link.FirstOrDefaultAsync(x => x.Id == id);
            if (link == null)
            {
                return new Link();
            }

            return link;
        }

        public async Task<List<Link>> GetAllAsync(string userId)
        {
            return await _db.Link
                .Where(link => link.UserID == userId)
                .OrderBy(x => x.Sort)
                .ToListAsync();
        }

        public async Task<Link> UpdateAsync(Link link)
        {
            var linkFromDb = await _db.Link.FirstOrDefaultAsync(x => x.Id == link.Id);
            if (linkFromDb != null)
            {
                linkFromDb.Name = link.Name;
                _db.Link.Update(linkFromDb);
                await _db.SaveChangesAsync();
                return linkFromDb;
            }
            return link;
        }

        public async Task UpdateLinksOrderAsync(IEnumerable<Link> links)
        {
            foreach (var link in links)
            {
                _db.Link.Attach(link);

                _db.Entry(link).Property(x => x.Sort).IsModified = true;
            }

            await _db.SaveChangesAsync();
        }
    }
}