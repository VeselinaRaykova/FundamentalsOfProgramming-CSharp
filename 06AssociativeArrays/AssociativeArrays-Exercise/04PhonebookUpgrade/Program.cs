using System;
using System.Collections.Generic;
using System.Linq;

namespace _04PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            while (input[0].ToLower() != "end")
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

                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var contact in phoneBook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
