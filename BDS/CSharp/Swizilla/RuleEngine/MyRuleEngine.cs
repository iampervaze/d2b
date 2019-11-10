using Swizilla.DI;
using Swizilla.RuleEngine.DiscountRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.RuleEngine
{
    public class MyRuleEngine
    {
        public List<IRuleResult> Execute(IRuleParameters input, List<IRule> rules)
        {
            var results = new List<IRuleResult>();
            rules.ForEach(rule =>
             {
                 var result = rule.Execute(input);
                 results.Add(result);
             });

            return results;
        }
    }
}
