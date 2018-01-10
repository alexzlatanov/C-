using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfWords = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
                                                                   StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (var letter in listOfWords)
            {
                bool isAllLowerCase = true;
                bool isAllUpperrCase = true;
                for (int i = 0; i < letter.Length; i++)
                {
                    if (char.IsLower(letter[i]))
                    {
                        isAllUpperrCase = false;
                    }
                    else if (char.IsUpper(letter[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperrCase = false;
                    }

                }
                if (isAllLowerCase)
                {
                    lowerCase.Add(letter);
                }
                else if (isAllUpperrCase)
                {
                    upperCase.Add(letter);
                }
                else
                {
                    mixedCase.Add(letter);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
