﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                var oldb = b;
                b = a % b;
                a = oldb;
            }
            Console.WriteLine("GDC = {0}", a);
        }
    }
}
