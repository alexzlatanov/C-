﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first,second));
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                Console.WriteLine((char)GetMax(first, second));
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first,second));
            }

        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) < 0 )
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }
}
