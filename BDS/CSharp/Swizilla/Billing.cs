using Swizilla.ParamObjects;
using Swizilla.RuleEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class Billing
    {
        public static decimal calculateTariff(int units)
        {
            if (units <= 100)
                return units * 1.35M;

            if (units <= 300)
                return (100 * 1.35M) + ((units - 100) * 4.05M);

            if (units <= 500)
                return (100 * 1.35M) + (200 * 4.05M) + ((units - 300) * 6.75M);

            return (100 * 1.35M) + (200 * 4.05M) + (300 * 6.75M) + ((units - 500) * 8.0M);
        }
    }

    public class UnitsBelow100 : IRule
    {
        public IRuleResult Execute(IRuleParameters parameters)
        {
            var billInfo = parameters as BillInfo;
            if (billInfo.Units <= 100) billInfo.Bill = billInfo.Units * 1.35M;
            return billInfo as IRuleResult;
        }
    }

    public class UnitsBelow300 : IRule
    {
        public IRuleResult Execute(IRuleParameters parameters)
        {
            var billInfo = parameters as BillInfo;
            if (billInfo.Units <= 300)
            {
                billInfo.Bill = (100 * 1.35M) + ((billInfo.Units - 100) * 4.05M);
                billInfo.RunNext = false;
            };
            return billInfo as IRuleResult;
        }
    }

    public class UnitsBelow500 : IRule
    {
        public IRuleResult Execute(IRuleParameters parameters)
        {
            var billInfo = parameters as BillInfo;

            if (billInfo.Units <= 500)
            {
                billInfo.Bill = (100 * 1.35M) + (200 * 4.05M) + ((billInfo.Units - 300) * 6.75M); billInfo.RunNext = false;
            };
            return billInfo as IRuleResult;
        }
    }

    public class UnitsGreaterThan500 : IRule
    {
        public IRuleResult Execute(IRuleParameters parameters)
        {
            var billInfo = parameters as BillInfo;
            if (billInfo.Units > 500)
            {
                billInfo.Bill = (100 * 1.35M) + (200 * 4.05M) + (300 * 6.75M) + ((billInfo.Units - 500) * 8.0M);
                billInfo.RunNext = false;
            };
            return billInfo as IRuleResult;
        }
    }
}
