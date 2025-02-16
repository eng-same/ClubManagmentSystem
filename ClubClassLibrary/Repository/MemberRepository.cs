using ClubClassLibrary.Data;
using ClubClassLibrary.Interfaces;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubClassLibrary.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public async Task Add(Member member)
        {
            await _context.Members.AddAsync(member);
            await Save();
        }

        public async Task Delete(int id)
        {
            var member = await _context.Members.FindAsync(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                await Save();
            }
        }

        public async Task<List<Member>> GetAll()
        {
            return await _context.Members.ToListAsync();
        }

        public async Task<Member> GetById(int id)
        {
            return await _context.Members.FindAsync(id);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(Member member)
        {
            _context.Members.Update(member);
            await Save();
        }
    }
}
