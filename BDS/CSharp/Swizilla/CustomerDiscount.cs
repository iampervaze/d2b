using Swizilla.RuleEngine.DiscountRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class CustomerDiscount
    {
        public string CustomerName { get;  }
        public DateTime CustomerSince { get; }
        public DateTime DateOfLastPurchase { get;  }
        public DateTime Birthday { get; }

        public CustomerDiscount(string customerName, DateTime customerSince, DateTime dateOfLastPurchase, DateTime birthday)
        {
            CustomerName = customerName;
            CustomerSince = customerSince;
            DateOfLastPurchase = dateOfLastPurchase;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return 
                "{" +
                "Name: " + CustomerName + ", " +
                "Since: " + CustomerSince.ToShortDateString() + ", " +
                "Last Purchase: " + DateOfLastPurchase.ToShortDateString() + ", " +
                "Birthday " + Birthday.ToShortDateString() +
                "}";
        }
    }

    //class CustomerDiscount
    //{
    //    public static double calculateDiscount(Customer customer)
    //    {
    //        // If Longterm customer (more than 10 years)
    //        if ((DateTime.Today - customer.CustomerSince).Days / 365 > 10)
    //            return 0.20;

    //        // Happy Birthday
    //        if ((DateTime.Today.Day == customer.Birthday.Day) && (DateTime.Today.Month == customer.Birthday.Month))
    //            return .15;

    //        // If last purchase in 30 days
    //        if ((DateTime.Today.Day - customer.CustomerSince.Day) < 30)
    //            return .08;
    //        return 0;
    //    }
    //}
}
