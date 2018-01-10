using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        public static int GetMultipleOfEvenAndOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
        }

        public static int GetSumOfEvenDigits(int number)
        {
            return GetSumOfDigits(number, 0);
        }

        public static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, 1);
        }

        public static int GetSumOfDigits(int number, int remainder)
        {
            var result = 0;

            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == remainder)
                {
                    result += digit;
                }
            }
            return result;
        }
    }
}
