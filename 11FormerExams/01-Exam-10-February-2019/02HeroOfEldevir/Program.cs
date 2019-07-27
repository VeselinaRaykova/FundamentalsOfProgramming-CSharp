using System;
using System.Collections.Generic;
using System.Linq;

namespace _02HeroOfEldevir
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "Battle")
            {

                string command = input[0];
                string item = input[1];

                if (command == "Loot")
                {
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                        Console.WriteLine($"{item} has been added to the inventory.");
                    }
                }
                else if (command == "Disenchant")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        if (items.Count == 0) //items.Any()
                        {
                            Console.WriteLine("The inventory is empty.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"{item} has been disenchanted.");
                        }
                    }
                }
                else if (command == "Upgrade")
                {
                    string firstItem = item.Split('/')[0];
                    string secondItem = item.Split('/')[1];

                    if (items.Contains(firstItem))
                    {
                        items[items.IndexOf(firstItem)] += " ~ " + secondItem;
                        Console.WriteLine($"{firstItem} has been upgraded to {firstItem} ~ {secondItem}.");
                    }
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine("Red Paladin's inventory :");
            foreach (var itemName in items)
            {
                Console.WriteLine($"--> {itemName}");
            }
        }
    }
}
