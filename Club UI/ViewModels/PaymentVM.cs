using ClubClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_UI.ViewModels
{
    public  class PaymentVM
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int MembershipId { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountPaid { get; set; }

        public string PaymentMethod { get; set; } //cash, credit card, debit card, etc.

        public DateTime PaymentDate { get; set; }

        public string  MemberName { get; set; }

        public string  MembershipName { get; set; }
                    
    }
}
