using System;

class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        double price = 0;

        if (town=="Sofia")
        {
            switch (product)
            {
                case "coffee": price = 0.50; break;
                case "water": price = 0.80; break;
                case "beer": price = 1.20; break;
                case "sweets": price = 1.45; break;
                default: price = 1.60; break; //peanuts
            }
        }
        else if (town == "Plovdiv")
        {
            switch (product)
            {
                case "coffee": price = 0.40; break;
                case "water": price = 0.70; break;
                case "beer": price = 1.15; break;
                case "sweets": price = 1.30; break;
                default: price = 1.50; break; //peanuts
            }
        }
        else //town == "Varna"
        {
            switch (product)
            {
                case "coffee": price = 0.45; break;
                case "water": price = 0.70; break;
                case "beer": price = 1.10; break;
                case "sweets": price = 1.35; break;
                default: price = 1.55; break; //peanuts
            }
        }

        Console.WriteLine(price * quantity);
    }
}
