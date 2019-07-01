using System;

class Program
{
    static void Main(string[] args)
    {
        string town = Console.ReadLine();
        decimal sales = decimal.Parse(Console.ReadLine());
        decimal commission = 0;

        if (town.ToLower() == "sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                commission = 5m / 100;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = 7m / 100;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = 8m / 100;
            }
            else if (sales > 10000)
            {
                commission = 12m / 100;
            }
        }
        else if (town.ToLower() == "varna")
        {
            if (sales >= 0 && sales <= 500)
            {
                commission = 4.5m / 100;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = 7.5m / 100;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = 10m / 100;
            }
            else if (sales > 10000)
            {
                commission = 13m / 100;
            }
        }
        else if (town.ToLower() == "plovdiv")
        {
            if (sales >= 0 && sales <= 500)
            {
                commission = 5.5m / 100;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = 8m / 100;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = 12m / 100;
            }
            else if (sales > 10000)
            {
                commission = 14.5m / 100;
            }
        }

        if (commission > 0)
        {
            Console.WriteLine("{0:f2}", commission * sales);
        }
        else
        {
            Console.WriteLine("error");
        }

    }
}
