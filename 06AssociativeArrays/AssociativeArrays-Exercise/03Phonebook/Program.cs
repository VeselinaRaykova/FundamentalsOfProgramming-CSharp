﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (input[0].ToLower() != "end")
            {
                string command = input[0];
                string name = input[1];

                if (command == "A")
                {
                    string number = input[2];
                    phoneBook[name] = number;
                }
                else if (command == "S")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}