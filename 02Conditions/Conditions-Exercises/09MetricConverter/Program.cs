using System;

class Program
{
    static void Main(string[] args)
    {
        decimal value = decimal.Parse(Console.ReadLine());
        string inputType = Console.ReadLine();
        string outputType = Console.ReadLine();
        decimal result = 0;
        decimal valueInMeters = 0;

        if (inputType == "mm")
        {
            valueInMeters = value / 1000;
        }
        else if (inputType == "cm")
        {
            valueInMeters = value / 100;
        }
        else if (inputType == "mi")
        {
            valueInMeters = value / 0.000621371192M;
        }
        else if (inputType == "in")
        {
            valueInMeters = value / 39.3700787M;
        }
        else if (inputType == "km")
        {
            valueInMeters = value / 0.001M;
        }
        else if (inputType == "ft")
        {
            valueInMeters = value / 3.2808399M;
        }
        else if (inputType == "yd")
        {
            valueInMeters = value / 1.0936133M;
        }
        else if (inputType == "m")
        {
            valueInMeters = value;
        }

        if (outputType == "mm")
        {
            result = valueInMeters * 1000;
        }
        else if (outputType == "cm")
        {
            result = valueInMeters * 100;
        }
        else if (outputType == "mi")
        {
            result = valueInMeters * 0.000621371192M;
        }
        else if (outputType == "in")
        {
            result = valueInMeters * 39.3700787M;
        }
        else if (outputType == "km")
        {
            result = valueInMeters * 0.001M;
        }
        else if (outputType == "ft")
        {
            result = valueInMeters * 3.2808399M;
        }
        else if (outputType == "yd")
        {
            result = valueInMeters * 1.0936133M;
        }
        else if (outputType == "m")
        {
            result = valueInMeters;
        }

        Console.WriteLine(Math.Round(result, 8));

    }
}
