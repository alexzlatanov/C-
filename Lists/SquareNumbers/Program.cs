using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> squares = new List<int>();


            foreach (var number in squares)
            {
                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    squares.Add(number);
                }

            }
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
