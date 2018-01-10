using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger zeroCount = 0;
            BigInteger goldFive = 5;

            while (goldFive <= n)
            {
                zeroCount += n / goldFive;
                goldFive *= 5;
            }

            Console.WriteLine(zeroCount);
        }
    }
}
