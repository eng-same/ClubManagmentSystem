using ClubClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Interfaces
{
    public interface IMembershipTypeRepository
    {
        Task<MembershipType> GetById(int id);  // Fetch membershipType by ID
        Task<IEnumerable<MembershipType>> GetAll();  // Fetch all membershipType
        Task Add(MembershipType membershipType); // Insert new membershipType
        Task Update(MembershipType membershipType); // Update membershipType
        Task Delete(int id); // Delete membershipType by ID
        Task Save(); // Save changes
    }
}
