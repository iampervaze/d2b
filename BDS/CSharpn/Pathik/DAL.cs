using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathik
{
    class ActivityDal
    {
        string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";

        public void Transaction(int laneNumber, string vehicleNumber, int vehicleType, double fare)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                using (SqlCommand command = new SqlCommand("INSERT INTO activity(lane_id, vehicle_number, vehicle_type, fare_collected) VALUES (@lane, @vehicle, @type, @fare)", connection))
                {
                    command.Parameters.AddWithValue("lane", laneNumber);
                    command.Parameters.AddWithValue("vehicle", vehicleNumber);
                    command.Parameters.AddWithValue("type", vehicleType);
                    command.Parameters.AddWithValue("fare", fare);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
