using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.RuleEngine.VehicleRules
{
    public class Vehicle : IRuleParameters
    {
        public string VehicleNumber { get; set; }
        public string VehicleType { get; set; }
        public DateTime PurchasedOn { get; set; }
    }
}
