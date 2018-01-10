using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int cow = 0; cow < n; cow++)
                {
                    var num = row + cow + 1;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
