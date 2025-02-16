using ClubClassLibrary.Data;
using ClubClassLibrary.Interfaces;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubClassLibrary.Repository
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public async Task Add(Membership membership)
        {
            await _context.Memberships.AddAsync(membership);
            await Save();
        }

        public async Task Delete(int id)
        {
            var membership = await _context.Memberships.FindAsync(id);
            if (membership != null)
            {
                _context.Memberships.Remove(membership);
                await Save();
            }
        }

        public async Task<List<Membership>> GetAll()
        {
            return await _context.Memberships.ToListAsync();
        }

        public async Task<Membership> GetById(int id)
        {
            return await _context.Memberships.FindAsync(id);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(Membership membership)
        {
            _context.Memberships.Update(membership);
            await Save();
        }
    }
}
