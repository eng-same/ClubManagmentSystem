using ClubClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Interfaces
{
    public interface IPaymentRepository
    {
        Task<Payment> GetById(int id);  // Fetch payment by ID
        Task<List<Payment>> GetAll();  // Fetch all payment
        Task Add(Payment payment); // Insert new payment
        Task Update(Payment payment); // Update payment
        Task Delete(int id); // Delete payment by ID
        Task Save(); // Save changes
    }
}
