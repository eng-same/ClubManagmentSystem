using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Models
{
    public  class Membership
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; }
        
        public decimal Price { get; set; } //if any discount is applied, it will be calculated in the business logic

        // Foreign Key
        public int MemberId { get; set; } //one member can have multiple memberships
        public int MembershipTypeId { get; set; } //one membership type can have multiple memberships

        // Navigation Property
        public Member Member { get; set; } 
        public MembershipType MembershipType { get; set; }
        public List<Payment> Payments { get; set; }//one membership can have multiple payments
    }
}
