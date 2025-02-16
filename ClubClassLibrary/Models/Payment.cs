using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; } //cash, credit card, debit card, etc.

        public DateTime PaymentDate { get; set; } = DateTime.Now;


        // Foreign Keys
        public int MemberId { get; set; } //one member can have multiple payments
        public int MembershipId { get; set; }//one membership can have multiple payments

        // Navigation Properties
        public Member Member { get; set; }
        public Membership Membership { get; set; }
    }
}
