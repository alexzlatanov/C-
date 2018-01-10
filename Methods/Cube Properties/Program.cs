using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();
            if (parameter=="face")
            {
                Console.WriteLine("{0:F2}", Face(side));
            }
            if (parameter=="space")
            {
                Console.WriteLine("{0:F2}",Space(side));
            }
            if (parameter=="volume")
            {
                Console.WriteLine("{0:F2}", Volume(side));
            }
            if (parameter=="area")
            {
                Console.WriteLine("{0:f2}", Area(side));
            }

        }

        public static double Face(double side)
        {
            double result = Math.Sqrt(2 * (side * side));
            return result;
        }

        public static double Space(double side)
        {
            double result = Math.Sqrt(3 * (side * side));
            return result;
        }

        public static double Volume(double side)
        {
            double result = side * side * side;
            return result;
        }

        public static double Area(double side)
        {
            double result = 6 * side * side;
            return result;
        }
    }
}
