using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static dynamic dyna;
        static void Main(string[] args)
        {
            var obj = new Dictionary<int, string>();
            Console.WriteLine(obj.GetType());

            // obj = "abc";

            dyna = 1;
            Console.WriteLine(dyna.GetType());

            dyna = "abc";
            Console.WriteLine(dyna.GetType());

        }
    }
}
