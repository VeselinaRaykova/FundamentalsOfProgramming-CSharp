using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] commandArgs = Console.ReadLine().Split().ToArray();
                string command = commandArgs[0];
                if (command == "print")
                {
                    break;
                }

                if (command == "add")
                {
                    int index = int.Parse(commandArgs[1]);
                    int toAdd = int.Parse(commandArgs[2]);
                    numbers.Insert(index, toAdd);
                }
                else if (command == "addMany")
                {
                    int index = int.Parse(commandArgs[1]);
                    int[] toAdd = commandArgs.Skip(2).Select(int.Parse).ToArray();
                    numbers.InsertRange(index, toAdd);
                }
                else if (command == "contains")
                {
                    int element = int.Parse(commandArgs[1]);
                    if (numbers.Contains(element))
                    {
                        Console.WriteLine(numbers.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (command == "remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (numbers.Count - 1 >= index)
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command == "shift")
                {
                    List<int> temp = new List<int>();
                    int shiftIndex = int.Parse(commandArgs[1]);
                    while (shiftIndex > 0)
                    {
                        int first = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(first);
                        shiftIndex--;
                    }
                }
                else if (command == "sumPairs")
                {
                    List<int> temp = new List<int>();
                    if (numbers.Count % 2 != 0)
                    {
                        numbers.Add(0);
                    }
                    for (int i = 0; i < numbers.Count - 1; i += 2)
                    {
                        temp.Add(numbers[i] + numbers[i + 1]);
                    }
                    numbers = temp;
                }
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }


    }


}
