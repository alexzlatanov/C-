using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var leftSide = new int[arr.Length/4];
            var rightSide = new int[arr.Length / 4];
            var result = new int[arr.Length / 2];

            for (int i = 0; i < (arr.Length/4); i++)
            {
                leftSide[i] = arr[(arr.Length/4) - 1-i];
                rightSide[i] = arr[arr.Length - 1 - i];
            }
            for (int i = 0; i < (arr.Length/4); i++)
            {
                result[i] = leftSide[i] + arr[arr.Length/4 + i];
                result[arr.Length / 4 + i] = rightSide[i] + arr[arr.Length / 2 + i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
