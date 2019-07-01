using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var phoneBook = new Dictionary<string, string>();
            List<string> namesToSearch = new List<string>();

            while (input[0] != "END")
            {
                string command = input[0];
                if (command == "A")
                {
                    string name = input[1];
                    string number = input[2];
                    phoneBook[name] = number;
                }
                else if (command == "S")
                {
                    string name = input[1];
                    namesToSearch.Add(name);
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (string name in namesToSearch)
            {
                if (!phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
            }
        }
    }
}
