﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double wight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleArea(wight, height);
            Console.WriteLine(area);
        }

        static double TriangleArea(double wight, double height)
        {
            return wight * height / 2;
        }
    }
}
