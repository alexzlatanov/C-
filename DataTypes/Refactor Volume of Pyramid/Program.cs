using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length, Width, Height = 0;
            Console.Write("Length: ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());

            double volume = (Length * Width * Height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
