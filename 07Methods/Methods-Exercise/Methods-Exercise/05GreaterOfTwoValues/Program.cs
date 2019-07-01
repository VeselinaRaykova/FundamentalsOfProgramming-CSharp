using System;

namespace _05GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string max = GetMax(a, b);
                Console.WriteLine(max);
            }

        }

        static int GetMax(int a, int b)
        {
            int max = a > b ? a : b;
            return max;
        }

        static char GetMax(char a, char b)
        {
            char max = a > b ? a : b;
            return max;
        }
        static string GetMax(string a, string b)
        {
            string max = a.CompareTo(b) > 0 ? a : b;
            return max;
        }
    }
}
