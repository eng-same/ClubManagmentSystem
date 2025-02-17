using ClubClassLibrary.Data;
using ClubClassLibrary.Interfaces;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubClassLibrary.Repository
{
    public class MembershipTypeRepository : IMembershipTypeRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public async Task Add(MembershipType membershipType)
        {
            await _context.MembershipTypes.AddAsync(membershipType);
            Save();
        }

        public async  Task Delete(int id)
        {
            if (id != 0) { 
                _context.MembershipTypes.Remove(await GetById(id));
                await Save();

            }
        }

        public async Task<List<MembershipType>> GetAll()
        {
            return await _context.MembershipTypes.ToListAsync();
        }

        public async Task<MembershipType> GetById(int id)
        {
            if (id != 0)
                return await _context.MembershipTypes.FindAsync(id);
            return null;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(MembershipType membershipType)
        {
            _context.MembershipTypes.Update(membershipType);
            await Save();
        }
        public List<MembershipType> GetAAll()
        {
            return _context.MembershipTypes.ToList();
        }
    }
}
