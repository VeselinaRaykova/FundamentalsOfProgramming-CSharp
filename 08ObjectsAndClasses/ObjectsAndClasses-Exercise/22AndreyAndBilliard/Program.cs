using System;
using System.Collections.Generic;
using System.Linq;

namespace _22AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> products = ReadProducts(n);
            Dictionary<string, Customer> customers = new Dictionary<string, Customer>();
            string command = Console.ReadLine();
            string[] input;

            while (command.ToLower() != "end of clients")
            {
                input = command.Split('-');
                string name = input[0];
                string[] order = input[1].Split(',').ToArray();
                if (products.ContainsKey(order[0]))
                {
                    if (customers.ContainsKey(name))
                    {
                        customers[name].AddOrder(order[0], int.Parse(order[1]));
                    }
                    else
                    {
                        Customer c = new Customer(name, order);
                        customers.Add(name, c);
                    }
                }

                command = Console.ReadLine();
            }

            List<Customer> ordered = customers.Values.ToList().OrderBy(c => c.Name).ToList();
            PrintOrders(ordered, products);
        }

        static Dictionary<string, double> ReadProducts(int n)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split('-').ToArray();
                string product = input[0];
                double price = double.Parse(input[1]);

                if (products.ContainsKey(product))
                {
                    products[product] = price;
                }
                else
                {
                    products.Add(product, price);
                }
            }

            return products;
        }

        static void PrintOrders(List<Customer> customers, Dictionary<string, double> products)
        {

            double totalBill = 0;

            foreach (Customer c in customers)
            {
                double bill = 0;
                string product;
                int quantity;

                Console.WriteLine(c.Name);
                foreach (var o in c.Orders)
                {
                    product = o.Key;
                    quantity = o.Value;
                    bill += quantity * products[product];

                    Console.WriteLine($"-- {product} - {quantity}");
                }

                Console.WriteLine($"Bill: {bill:f2}");
                totalBill += bill;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Orders { get; set; }

        public Customer() { }

        public Customer(string name, string[] order)
        {
            Name = name;
            this.Orders = new Dictionary<string, int>();
            this.AddOrder(order[0], int.Parse(order[1]));
        }

        internal void AddOrder(string product, int quantity)
        {
            if (this.Orders.ContainsKey(product))
            {
                this.Orders[product] += quantity;
            }
            else
            {
                this.Orders[product] = quantity;
            }
        }
    }
}
