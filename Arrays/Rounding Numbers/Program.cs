using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundNumbers = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                roundNumbers[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} -> {roundNumbers[i]}");
            }
        }
    }
}
