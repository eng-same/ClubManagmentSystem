using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Models
{
    public class MembershipType
    {
        public int Id { get; set; }

        public string Name { get; set; }//name of the membership type

        public string Description { get; set; }

        public decimal BasePrice { get; set; } //base price of the membership type

        // Navigation Property
        public List<Membership> Memberships { get; set; }//one membership type can have multiple memberships
    }
}
