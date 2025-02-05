using BranchOut.Data;
using BranchOut.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BranchOut.Repository
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ApplicationDbContext _db;

        public ProfileRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Profile> CreateAsync(Profile profile)
        {
            await _db.Profile.AddAsync(profile);
            await _db.SaveChangesAsync();
            return profile;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var profile = await _db.Profile.FirstOrDefaultAsync(x => x.Id == id);
            if (profile != null)
            {
                _db.Profile.Remove(profile);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<Profile> GetAsync(string id)
        {
            return await _db.Profile
                .Include(x => x.Links.Where(l => l.Visible).OrderBy(l => l.Sort))
                .FirstOrDefaultAsync(x => x.UserID == id);
        }

        public async Task<IEnumerable<Profile>> GetAllAsync()
        {
            return await _db.Profile.ToListAsync();
        }

        public async Task<Profile> UpdateAsync(Profile profile)
        {
            var profileFromDb = await _db.Profile.FirstOrDefaultAsync(x => x.Id == profile.Id);
            if (profileFromDb != null)
            {

                _db.Profile.Update(profileFromDb);
                await _db.SaveChangesAsync();
                return profileFromDb;
            }
            return profile;
        }
    }
}
