using System;

class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int resultHours = hours;
        int resultMinutes = minutes + 15;

        if (resultMinutes >= 60)
        {
            resultMinutes -= 60;
            resultHours += 1;
            if (resultHours >=24)
            {
                resultHours -= 24;
            }
        }
        if (resultMinutes < 10)
        {
            Console.WriteLine($"{resultHours}:0{resultMinutes}");
        }
        else
        {
            Console.WriteLine($"{resultHours}:{resultMinutes}");

        }
    }
}
