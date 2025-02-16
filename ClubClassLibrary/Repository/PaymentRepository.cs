using ClubClassLibrary.Interfaces;
using ClubClassLibrary.Models;
using ClubClassLibrary.Data;
using Microsoft.EntityFrameworkCore;

namespace ClubClassLibrary.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public async Task Add(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
            await Save();
        }

        public async Task Delete(int id)
        {
            var payment = await GetById(id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                await Save();
            }
        }

        public async Task<List<Payment>> GetAll()
        {
            return await _context.Payments.ToListAsync();
        }

        public async Task<Payment> GetById(int id)
        {
            if (id != 0)
                return await _context.Payments.FindAsync(id);
            return null;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(Payment payment)
        {
            _context.Payments.Update(payment);
            await Save();
        }
    }
}
