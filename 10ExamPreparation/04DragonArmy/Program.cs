using System;
using System.Collections.Generic;
using System.Linq;

namespace _04DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, DragonType> types = new Dictionary<string, DragonType>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string type = input[0];
                string name = input[1];
                int damage = int.TryParse(input[2], out damage) ? damage : -1;
                int health = int.TryParse(input[3], out health) ? health : -1;
                int armor = int.TryParse(input[4], out armor) ? armor : -1;

                if (!types.ContainsKey(type))
                {
                    types.Add(type, new DragonType(type));
                }

                Dragon currentDragon = new Dragon(name, damage, health, armor);
                if (types[type].Dragons.Any(d => d.Name == name))
                {
                    Dragon dragonRemove = types[type].Dragons.First(d => d.Name == name);
                    types[type].Dragons.Remove(dragonRemove);
                }

                types[type].Dragons.Add(currentDragon);
            }

            foreach (DragonType t in types.Values)
            {
                Console.WriteLine($"{t.Name}::({t.GetAverageDamage():f2}/{t.GetAverageHealth():f2}/{t.GetAverageArmor():f2})");
                foreach (Dragon d in t.Dragons.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{d.Name} -> damage: {d.Damage}, health: {d.Health}, armor: {d.Armor}");
                }
            }
        }
    }

    public class DragonType
    {
        public string Name { get; set; }
        public List<Dragon> Dragons { get; set; }

        public DragonType(string name)
        {
            this.Name = name;
            this.Dragons = new List<Dragon>();
        }

        public double GetAverageDamage()
        {
            double average = 0;

            foreach (Dragon d in this.Dragons)
            {
                average += d.Damage;
            }

            return average / Dragons.Count;
        }

        public double GetAverageHealth()
        {
            double average = 0;

            foreach (Dragon d in this.Dragons)
            {
                average += d.Health;
            }

            return average / Dragons.Count;
        }

        public double GetAverageArmor()
        {
            double average = 0;

            foreach (Dragon d in this.Dragons)
            {
                average += d.Armor;
            }

            return average / Dragons.Count;
        }
    }

    public class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            this.Name = name;
            this.Damage = damage != -1 ? damage : 45;
            this.Health = health != -1 ? health : 250;
            this.Armor = armor != -1 ? armor : 10;
        }

        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
