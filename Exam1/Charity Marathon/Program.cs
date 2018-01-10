using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var MarathonInDays = decimal.Parse(Console.ReadLine());
            var numbersOfRunners = decimal.Parse(Console.ReadLine());
            var laps = decimal.Parse(Console.ReadLine());
            var lenghtOfTrack = decimal.Parse(Console.ReadLine());
            var TrackCapacity = decimal.Parse(Console.ReadLine());
            var MoneyPerKillometer = decimal.Parse(Console.ReadLine());

            var totalRunners = Math.Min(numbersOfRunners, TrackCapacity * MarathonInDays);
            var totalMeters = totalRunners * laps * lenghtOfTrack;
            var totalKilometers = totalMeters / 1000;
            var moneyRaised = totalKilometers * MoneyPerKillometer;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
