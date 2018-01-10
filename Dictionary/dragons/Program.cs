using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragons
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                var type = tokens[0];
                var name = tokens[1];
                var damage = 0m;
                if (tokens[2] != "null")
                {
                    damage = decimal.Parse(tokens[2]);
                }
                else
                {
                    damage = 45;
                }
                var health = 0m;
                if (tokens[3] != "null")
                {
                    health = decimal.Parse(tokens[3]);
                }
                else
                {
                    health = 250;
                }
                var armor = 0m;
                if (tokens[4] != "null")
                {
                    armor = decimal.Parse(tokens[4]);
                }
                else
                {
                    armor = 10;
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }

                dragons[type][name] = new decimal[] { damage, health, armor };
            }
            foreach (var item in dragons)
            {
                var typeName = item.Key;
                var dragonsByType = item.Value;
                var avarageDamage = dragonsByType.Values.Average(a => a[0]);
                var avarageHealth = dragonsByType.Values.Average(a => a[1]);
                var avarageArmor = dragonsByType.Values.Average(a => a[2]);

                Console.WriteLine($"{typeName}::({avarageDamage:F2}/{avarageHealth:F2}/{avarageArmor:F2})");

                foreach (var dragon in dragonsByType)
                {
                    var name = dragon.Key;
                    var stars = dragon.Value;

                    var damage = stars[0];
                    var health = stars[1];
                    var armor = stars[2];

                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
