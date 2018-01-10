using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int cntCurrSeq = 0;
            int startCurrSeq = 0;
            int cntMaxSeq = 0;
            int startMaxSeq = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    cntCurrSeq++;
                    startCurrSeq = i - cntCurrSeq;

                    if (cntCurrSeq > cntMaxSeq)
                    {
                        cntMaxSeq = cntCurrSeq;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    cntCurrSeq = 0;
                }
            }
            for (int iWrite = startMaxSeq; iWrite <= (startMaxSeq + cntMaxSeq); iWrite++)
            {
                Console.Write(numbers[iWrite] + " ");
            }
            Console.WriteLine();
        }
    }
}
