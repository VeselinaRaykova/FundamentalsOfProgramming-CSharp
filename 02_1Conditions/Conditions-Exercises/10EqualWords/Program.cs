using System;
class Program
{
    static void Main(string[] args)
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();

        if (firstWord.ToLower() == secondWord.ToLower())
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
