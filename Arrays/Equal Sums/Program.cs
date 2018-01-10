using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isIndex = false;
            for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
            {
                int sumleft = 0;
                int sumright = 0;
                for (int i = currentElement+1; i < numbers.Length; i++)
                {
                    sumright += numbers[i];
                }
                for (int i = 0; i < currentElement; i++)
                {
                    sumleft += numbers[i];
                }

                if (sumright==sumleft)
                {
                    Console.WriteLine(currentElement);
                    isIndex = true;
                    break;
                }
            }

            if (!isIndex)
            {
                Console.WriteLine("no");
            }
        }
    }
}
