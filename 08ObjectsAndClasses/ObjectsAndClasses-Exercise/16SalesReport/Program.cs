using System;
using System.Collections.Generic;
using System.Linq;

namespace _16SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int salesCount = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < salesCount; i++)
            {
                sales.Add(new Sale(Console.ReadLine().Split(' ').ToList()));
            }

            SortedDictionary<string, double> salesPerTown = CalculateSales(sales);
            foreach (var sale in salesPerTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }

        }

        static SortedDictionary<string, double> CalculateSales(List<Sale> sales)
        {
            SortedDictionary<string, double> salesPerTown = new SortedDictionary<string, double>();
            double currSales = 0;

            foreach (Sale sale in sales)
            {
                currSales = sale.Price * sale.Quantity;

                if (salesPerTown.ContainsKey(sale.Town))
                {
                    salesPerTown[sale.Town] += currSales;
                }
                else
                {
                    salesPerTown[sale.Town] = currSales;
                }
            }

            return salesPerTown;
            //with standard Dictionary<K,V>
            //return salesPerTown.Keys.OrderBy(k => k).ToDictionary(k => k, k => salesPerTown[k]);
        }
    }

    public class Sale
    {
        private string town;
        private string product;
        private double price;
        private double quantity;

        public Sale(List<string> input)
        {
            this.town = input[0];
            this.product = input[1];
            this.price = double.Parse(input[2]);
            this.quantity = double.Parse(input[3]);
        }

        public string Town
        {
            get { return this.town; }
            set { this.town = value; }
        }

        public string Product
        {
            get { return this.product; }
            set { this.product = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public double Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}
