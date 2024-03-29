﻿namespace _04._Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
            List<Product> productList = new List<Product>();

            try
            {
                AddPersonsToList(listOfPersons);

                AddProductsToList(productList);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            BuyingProducts(productList, listOfPersons);

            PrintBuyings(listOfPersons);
        }

        private static void PrintBuyings(List<Person> listOfPersons)
        {
            foreach (var person in listOfPersons)
            {
                Person currentPerson = person;
                if (currentPerson.BagOfProducts.Count > 0)
                {
                    List<string> currentBagOfProductsNames = new List<string>();
                    foreach (var product in currentPerson.BagOfProducts)
                    {
                        currentBagOfProductsNames.Add(product.ProductName);
                    }
                    Console.Write($"{currentPerson.PersonName} - ");
                    Console.WriteLine(string.Join(", ", currentBagOfProductsNames));
                }
                else
                {
                    Console.WriteLine($"{currentPerson.PersonName} - Nothing bought");
                }
            }
        }

        private static void BuyingProducts(List<Product> productList, List<Person> listOfPersons)
        {
            while (true)
            {
                string inputLine = Console.ReadLine().Trim();
                if (inputLine == "END")
                {
                    return;
                }

                string[] purchase = inputLine.Split(' ');
                string buyer = purchase[0];
                string purchasedProduct = purchase[1];

                foreach (var person in listOfPersons)
                {
                    Person currentPerson = person;

                    if (currentPerson.PersonName == buyer)
                    {
                        decimal price = productList
                            .Find(p => p.ProductName == purchasedProduct)
                            .ProductPrice;

                        if (person.Money >= price)
                        {
                            Product newProduct = new Product(purchasedProduct, price);
                            currentPerson.BagOfProducts.Add(newProduct);
                            currentPerson.Money -= price;
                            Console.WriteLine($"{currentPerson.PersonName} bought {purchasedProduct}");
                        }
                        else
                        {
                            Console.WriteLine($"{currentPerson.PersonName} can't afford {purchasedProduct}");
                        }
                    }
                }
            }
        }

        private static void AddProductsToList(List<Product> productList)
        {
            string[] groceries = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var element in groceries)
            {
                string[] product = element.Split('=');
                string productName = product[0];
                decimal productPrice = decimal.Parse(product[1]);
                Product newProduct = new Product(productName, productPrice);
                productList.Add(newProduct);
            }
        }

        private static void AddPersonsToList(List<Person> listOfPersons)
        {
            string[] individuals = Console.ReadLine()
                .Split(';');

            foreach (var individual in individuals)
            {
                string[] person = individual.Split('=');
                string personName = person[0];
                decimal personMoney = decimal.Parse(person[1]);

                Person newPerson = new Person(personName, personMoney);

                listOfPersons.Add(newPerson);
            }
        }
    }
}
