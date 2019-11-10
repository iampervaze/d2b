using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.RuleEngine
{
    public interface IRule
    {
        IRuleResult Execute(IRuleParameters parameters);
    }

    public interface IRuleResult
    {

    }

    public interface IRuleParameters
    {

    }
}
