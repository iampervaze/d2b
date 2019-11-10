using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynaCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            DynaFactory repo = new DynaFactory("ClassRepository.xml");
            string assembly = @"F:\MEGA\CodeKhazana\BDS\CSharp\DynaCreate\bin\Debug\" + repo.getNodeValue("/repository/service/class/assembly[../name='Rates']");
            Console.WriteLine(assembly);
            string classname = "Rates." + repo.getNodeValue("/repository/service/class/type-name[../name='Rates']");
            Console.WriteLine(classname);
            var DLL = Assembly.LoadFile(assembly);
            foreach (var name in DLL.GetTypes())
            {
                Console.WriteLine(name.FullName);
                if (classname == name.FullName)
                {
                    Console.WriteLine("yes");
                    dynamic obj = Activator.CreateInstance(name);
                    Console.WriteLine(obj.getRate(0));
                }
            }


        }
    }
}
