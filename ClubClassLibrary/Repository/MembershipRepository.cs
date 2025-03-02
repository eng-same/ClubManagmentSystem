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
            return await _context.Memberships.Include(m=> m.Member).Include(m=>m.MembershipType).ToListAsync();
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

        public async Task<List<Membership>> GetByPrice (decimal price_from, decimal price_to)
        {
            return await _context.Memberships.Where(m => m.Price >= price_from && m.Price<= price_to).Include(m => m.Member).Include(m => m.MembershipType).ToListAsync();
        }

        public async Task<List<Membership>> GetByStartDate(DateTime DateStart_from, DateTime DateStart_to)
        {
            return await _context.Memberships.Where(m => m.StartDate>= DateStart_from &&m.StartDate<= DateStart_to).ToListAsync();
        }

        public async Task<List<Membership>> GetByEndDate(DateTime DateEnd_from, DateTime DateEnd_to)
        {
            return await _context.Memberships.Where(m => m.EndDate >= DateEnd_from && m.EndDate <= DateEnd_to).ToListAsync();
        }
    }
}
