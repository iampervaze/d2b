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
        public List<IRuleResult> Execute<T>(T input, List<IRule> rules)
            where T : IRuleParameters
        {
            var results = new List<IRuleResult>();
            foreach(var rule in rules)
            {
                var result = rule.Execute(input);
                if (!result.RunNext) break;
                results.Add(result);
            }
            return results;
        }
    }
}
