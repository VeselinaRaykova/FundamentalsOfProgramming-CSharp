using System;
using System.Linq;
using System.Numerics;

namespace _01AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ').ToArray();
                string siteName = data[0];
                long siteVisits = long.Parse(data[1]);
                decimal pricePerVisit = decimal.Parse(data[2]);

                totalLoss += siteVisits * pricePerVisit;

                Console.WriteLine(siteName);
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), n)}");
        }
    }
}
