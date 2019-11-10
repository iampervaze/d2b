using System;

namespace Rates
{
    public class RatesService
    {
        
        public double getRate(int type)
        {
            double []rate = { 30.00, 50.00, 100.00, 500.00 };
            return rate[type];
        }

    }
}
