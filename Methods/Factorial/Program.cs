using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Factorial(n);
        }

        public static void Factorial(BigInteger n)
        {
            BigInteger sum = 1;
            do
            {
                sum = sum * n;
                n--;
            } while (n > 1);
            Console.WriteLine(sum);
        }
    }
}
