

using ClubClassLibrary.Models;

namespace ClubClassLibrary.Interfaces
{
    public interface IMemberRepository
    {
        
        Task<Member> GetById(int id);  // Fetch member by ID
        Task<List<Member>> GetAll();  // Fetch all member
        Task Add(Member member); // Insert new member
        Task Update(Member member); // Update member
        Task Delete(int id); // Delete member by ID
        Task Save(); // Save changes
    }
}
