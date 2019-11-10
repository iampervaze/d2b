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
            /*
             * Tariff Map
             * First  100 units are at Rs. 1.35
             * Next   200 units are at Rs. 4.05
             * Next   300 units are at Rs. 6.75
             * Beyond 500 units are at Rs. 8.05
             */

            if (units <= 100)
                return units * 1.35M;

            if (units <= 300)
                return (100 * 1.35M) + ((units - 100) * 4.05M);

            if (units <= 500)
                return (100 * 1.35M) + (200 * 4.05M) + ((units - 300) * 6.75M);

            return (100 * 1.35M) + (200 * 4.05M) + (300 * 6.75M) + ((units - 500) * 8.0M);
        }


        public static decimal calculateTariffNew(int units)
        {
            //    List<Func<Predicate<int>, int, decimal>> businessCases = new List<Func<Predicate<int>, int, decimal>>()
            //    {
            //       new Func<Predicate<int>, int, decimal>((u) => true, u) => { return 0.0M; }
            //};

            //Func<Predicate<int>, int, decimal> x = ((u) => true, v) => { return 0.0M; };
            //Predicate<int> x = (y) => true;

            //Func<Predicate<int>, int, decimal> u = ((v) => true, w) => { return 0.0M; };


            return 0.0M;
        }
    }
}
