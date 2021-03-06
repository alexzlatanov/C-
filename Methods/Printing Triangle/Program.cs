﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        public static void PrintColumns(int row)
        {
            for (int cow = 1; cow <= row; cow++)
            {
                Console.Write($"{cow} ");
            }

            Console.WriteLine();
        }

        public static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintColumns(row);
            }

            for (int row = n -1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}
