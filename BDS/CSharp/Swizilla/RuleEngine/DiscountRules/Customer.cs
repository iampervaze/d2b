using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.RuleEngine.DiscountRules
{
    public class Customer : IRuleParameters
    {
        public Customer(string customerName, DateTime customerSince, DateTime dateOfLastPurchase, DateTime birthday)
        {
            CustomerName = customerName;
            CustomerSince = customerSince;
            DateOfLastPurchase = dateOfLastPurchase;
            Birthday = birthday;
        }
        public string CustomerName { get; set; }
        public DateTime CustomerSince { get; set; }
        public DateTime DateOfLastPurchase { get; set; }
        public DateTime Birthday { get; set; }
    }
}
