using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.RuleEngine.DiscountRules
{
    public class Discount: IRuleResult
    {
        public double Amount { get; set; }
        public Discount(double amount) => Amount = amount;
        public Discount() => Amount = 0;
    }
}
