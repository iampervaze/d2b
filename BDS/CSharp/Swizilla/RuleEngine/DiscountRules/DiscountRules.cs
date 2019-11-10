using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.RuleEngine.DiscountRules
{
    public class BirthDayDiscountRule : IRule
    {
        public IRuleResult Execute(IRuleParameters parameters)
        {
            var customer = parameters as Customer;
            if ((DateTime.Today.Day == customer.Birthday.Day) && (DateTime.Today.Month == customer.Birthday.Month))
                return new Discount(.15);
            return new Discount();
        }
    }

    public class LongTermCustomerDiscountRule : IRule
    {
        public IRuleResult Execute(IRuleParameters parameters)
        {
            var customer = parameters as Customer;
            if ((DateTime.Today.Day - customer.CustomerSince.Day) < 30)
                return new Discount(.08);
            return new Discount();
        }
    }


    public class NewPurchaseDiscountRule : IRule
    {
        public IRuleResult Execute(IRuleParameters parameters)
        {
            var customer = parameters as Customer;
            if ((DateTime.Today - customer.CustomerSince).Days / 365 > 10)
                return new Discount(0.20);
            return new Discount();
        }
    }


}
