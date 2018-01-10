using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var strins = Console.ReadLine().Split(' ').ToArray();
            var reverstStrins = strins.Reverse();
            Console.WriteLine(string.Join(" ", reverstStrins));
        }
    }
}
