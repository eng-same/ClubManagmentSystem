using ClubClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Interfaces
{
    public interface IMembershipRepository
    {
        Task<Membership> GetById(int id);  // Fetch membership by ID
        Task<List<Membership>> GetAll();  // Fetch all membership
        Task Add(Membership membership); // Insert new membership
        Task Update(Membership membership); // Update membership
        Task Delete(int id); // Delete membership by ID
        Task Save(); // Save changes
    }
}
