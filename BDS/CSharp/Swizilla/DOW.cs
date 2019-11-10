using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class DOW
    {
        public static string DayOfWeek(int day)
        {
            string dow = "Error";

            switch (day)
            {
                case 1:
                    dow = "Monday";
                    break;

                case 2:
                    dow = "Tuesday";
                    break;

                case 3:
                    dow = "Wednesday";
                    break;

                case 4:
                    dow = "Thursday";
                    break;

                case 5:
                    dow = "Friday";
                    break;

                case 6:
                    dow = "Saturday";
                    break;

                case 7:
                    dow = "Sunday";
                    break;
            }
            return dow;
        }

        public static string DayOfWeekNew(int day)
        {
            var filePath = Directory.GetCurrentDirectory() + @"\Files\dow.txt";
            var days = File.ReadLines(filePath).ToArray();
            return day < 1 || day > days.Length ? "Error" : days[day - 1];
        }
    }
}
