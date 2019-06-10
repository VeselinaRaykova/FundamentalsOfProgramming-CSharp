using System;

class Program
{
    static void Main(string[] args)
    {
        int flaps = int.Parse(Console.ReadLine());
        double meters = double.Parse(Console.ReadLine()); // 1000wing flaps per these meters
        int endurance = int.Parse(Console.ReadLine()); //wing flaps before break
        int flapsPerSecond = 100; //rest 5 seconds, 100 flap per second

        double metersTotal = (flaps / 1000) * meters;
        double breaksCount = flaps / endurance;
        double secondsInBreaks = breaksCount * 5;
        double secondsTotal = (flaps / flapsPerSecond) + secondsInBreaks;

        Console.WriteLine("{0:f2} m.", metersTotal);
        Console.WriteLine($"{secondsTotal} s.");
    }
}


