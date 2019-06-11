using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SplitbyWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            int lowers = 0;
            int uppers = 0;

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        lowers++;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        uppers++;
                    }
                    else
                    {
                        lowers++;
                        uppers++;
                    }
                }
                if (uppers == 0)
                {
                    lowerCase.Add(word);
                }
                else if (lowers == 0)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
                uppers = 0;
                lowers = 0;
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");


        }
    }
}
