using Swizilla.RuleEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.ParamObjects
{
    public class BillInfo: ParamObj, IRuleParameters, IRuleResult
    {
       public string CustomerName { get; set; }
        public int Units { get; set; }
        public decimal Bill { get; set; }
        public bool RunNext { get; set; }

        public BillInfo() { Bill = 0; RunNext = true; }
    }
}
