using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pathik
{
    class Activity
    {
        ActivityDal dal = new ActivityDal();

        public Activity(int laneNumber, string vehicleNumber, int vehicleType)
        {
            double amount=0;
            switch (vehicleType) 
            {
                case 0: // Car
                    amount = 30;
                    break;
                case 1: // Tempo
                    amount = 50;
                    break;
                case 2: // Truck
                    amount = 100;
                    break;
                case 3: // Trailer
                    amount = 500;
                    break;
            }

            dal.Transaction(laneNumber, vehicleNumber, vehicleType, amount);
        }

    }
}
