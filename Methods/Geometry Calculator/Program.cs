using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", TriangleArea(side, height));
                    break;
                case "Square":
                    double side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", SquareArea(side1));
                    break;
                case "rectangle":
                    double side2 = double.Parse(Console.ReadLine());
                    double side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", RectangleArea(side2,side3));
                    break;
                case "circle":
                    double side4 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", CircleArea(side4));
                    break;
            }

        }

        private static double CircleArea(double side4)
        {
            return Math.PI *side4 * side4;
        }

        private static double RectangleArea(double side2, double side3)
        {
            return side2 * side3;
        }

        private static double SquareArea(double side1)
        {
            return side1*side1;
        }

        private static double TriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
