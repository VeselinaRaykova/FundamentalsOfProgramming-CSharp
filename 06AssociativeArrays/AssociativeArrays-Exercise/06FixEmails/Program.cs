using System;
using System.Collections.Generic;

namespace _06FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            while (input != "stop")
            {
                string name = input;
                string eMail = Console.ReadLine();
                if (!eMail.EndsWith("us") && !eMail.EndsWith("uk"))
                {
                    contacts[name] = eMail;
                }

                input = Console.ReadLine();
            }

            foreach (var c in contacts)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
