using System;
using System.Text;

namespace _01SpaceTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string planet = Console.ReadLine();
                string message = Console.ReadLine();
                StringBuilder decodedMessage = new StringBuilder();

                for (int i = 0; i < message.Length - 1; i += 2)
                {
                    int symbol = int.Parse(message.Substring(i, 2));
                    decodedMessage.Append((char)symbol);
                }

                Console.WriteLine(decodedMessage);

                if (decodedMessage.ToString() == "GO HOME")
                {
                    Console.WriteLine("Going home.");
                    return;
                }
            }
        }
    }
}
