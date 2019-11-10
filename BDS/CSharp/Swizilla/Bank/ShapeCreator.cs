using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.Bank
{
    public class MyShapeCreator
    {
        public static void Run()
        {
            var rectangleParams = new List<object>() { new Point(100, 100), new Point(150, 150) };
            var circleParams = new List<object>() { new Point(200, 200), 10 };

            var circle = CreateShape("Circle", circleParams);
            var area = circle.calculateArea();
            Console.WriteLine($"The are is : {area}");

            var rect = CreateShape("Rectangle", rectangleParams);
            area = rect.calculateArea();
            Console.WriteLine($"The are is : {area}");
        }
        public static IShape CreateShape(string shapeName, IEnumerable<object> points)
        {
            var instance =(IShape) Activator.CreateInstance(Type.GetType($"Swizilla.{shapeName}"), points.ToArray());
            return instance;
        }
    }
}
