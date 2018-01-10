using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = ExtractMiddleElements(input);

            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }

        public static int[] ExtractMiddleElements(int[] input)
        {
            if (input.Length == 1)
            {
                return input;
            }
            if (input.Length %2==0)
            {
                return new int[] { input[input.Length / 2 - 1], input[input.Length / 2] };
            }
            return new int[] { input[input.Length / 2 - 1], input[input.Length / 2] , input[input.Length/2 + 1]};
        }
    }
}
