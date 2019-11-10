using Swizilla.Bank;
using Swizilla.DI;
using Swizilla.RuleEngine;
using Swizilla.RuleEngine.DiscountRules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class Program
    {
        static void Main(string[] args)
        {
            //START ------- RULE Engine 
            var di = new DIEngine();
            var engine = new MyRuleEngine();


            var rules = di.GetRules();
            var customer = new Customer("Anders Hejlsberg", new DateTime(2017, 07, 07), new DateTime(2017, 10, 5), new DateTime(1960, 12, 2));

            var results = engine.Execute(customer, rules);
            var discount = results.Select(o => ((Discount)o).Amount).Aggregate((a, b) => a + b);

            Console.WriteLine($"Customer {customer.CustomerName} got {discount} discount");
            //END ------- RULE Engine 


            ////Shapes with DI
            //var engine = new DIEngine();
            //engine.Init();

            //var rectangleParams = new List<object>() { new Point(100, 100), new Point(150, 150) };
            //var circleParams = new List<object>() { new Point(200, 200), 10 };
            //var inst = engine.GetInstance<Circle>(circleParams);

            //Shapes
            //MyShapeCreator.Run();


            ////Add new Converters
            //ChangeCase.AddConverter(Case.Camel, CamelCaseConverter);
            //var c = ChangeCase.Convert(Case.Camel, new string[] { "HWLLO", "hey", "HamEer" });

            //Console.WriteLine(c);
            Console.ReadKey();
        }

        public static string CamelCaseConverter(string[] words)
        {
            return "CamelCase";
        }


        static void Main2(string[] args)
        {
            // Value replace switch (fixed)
            Console.WriteLine(DOW.DayOfWeek(1));

            // Value replace switch (dynamic over time)
            Console.WriteLine(KeyCode.GetKeyMap(38));

            // Value Action switch
            //Console.WriteLine(ChangeCase.convert(ChangeCase.Case.Pascal, new string[] { "Numeric", "Value" }));

            // Value Action if-else ladder
            Console.WriteLine(Billing.calculateTariff(274));

            //// Varied condition if-else ladder
            //CustomerDiscount anders = new CustomerDiscount("Anders Hejlsberg", new DateTime(2017, 07, 07), new DateTime(2017, 10, 5), new DateTime(1960, 12, 2));
            //Console.WriteLine(anders);
            //Console.WriteLine(CustomerDiscount.calculateDiscount(anders) * 100 + "%");

            // Multiple switch-case statements
            Account dmr = new Account(Account.Type.SavingsAccount, 1, "Dennis M. Ritchie", 1000);
            Console.WriteLine(dmr);
            dmr.Withdraw(500);
            Console.WriteLine(dmr);
            dmr.Deposit(10000);
            Console.WriteLine(dmr);

            // Dynamically creating object of a type
            Circle circle = (Circle)ShapeCreator.NewShape("circle");
            circle.CenterPoint = new Point(10, 10);
            circle.Radius = 10;
            Console.WriteLine(circle.calculateArea());

            Rectangle rectangle = (Rectangle)ShapeCreator.NewShape("rectangle");
            rectangle.StartPoint = new Point(10, 10);
            rectangle.EndPoint = new Point(20, 20);
            Console.WriteLine(rectangle.calculateArea());



        }
    }
}
