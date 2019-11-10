using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swizilla
{
    public struct Point
    {
        public int PointX { get; set; }
        public int PointY { get; set; }
        public Point(int pointX=0, int pointY=0)
        {
            PointX = pointX;
            PointY = pointY;
        }
    }

    public interface IShape
    {
        double calculateArea();
    }

    public class Rectangle : IShape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Rectangle(Point startPoint =new Point(), Point endPoint=new Point())
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
        public double calculateArea()
        {
            return Math.Abs(EndPoint.PointX - StartPoint.PointX) * Math.Abs(EndPoint.PointY - StartPoint.PointY);
        }
    }

    public class Circle : IShape
    {
        public Point CenterPoint { get; set; }
        public double Radius;

        public Circle(Point centerPoint = new Point(), double radius=0)
        {
            CenterPoint = centerPoint;
            Radius = radius;
        }
        public double calculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    class ShapeCreator
    {
        public static IShape NewShape(string name)
        {
            switch (name.ToLower())
            {
                case "rectangle":
                case "rect":
                    return new Rectangle();

                case "circle":
                case "circ":
                    return new Circle();
            }
            return null;
        }
    }
}
