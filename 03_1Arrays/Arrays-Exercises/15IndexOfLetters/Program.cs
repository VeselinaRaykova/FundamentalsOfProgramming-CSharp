using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] alphabet = new char[26];
            int i = 0;
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                alphabet[i] = letter;
                i++;
            }
            //option 2 to generate alphabet
            //char[] alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();

            for (i = 0; i < word.Length; i++)
            {
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (word[i] == alphabet[k])
                    {
                        Console.WriteLine($"{word[i]} -> {k}");
                        break;
                    }
                }
            }





            Console.WriteLine(alphabet);
        }
    }
}
