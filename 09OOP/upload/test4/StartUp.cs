using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Person> people = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).Select(CreatePerson).ToList();
        List<Product> products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).Select(CreateProduct).ToList();

        List<string> data = Console.ReadLine().Split(' ').ToList();

        while (data[0] != "END")
        {
            string personName = data[0];
            string productName = data[1];

            Person currentPerson = people.Where(p => p.Name == personName).First();
            Product currentProduct = products.Where(p => p.Name == productName).First();

            currentPerson.Buy(currentProduct);


            data = Console.ReadLine().Split(' ').ToList();
        }

        foreach (Person person in people)
        {
            if (person.GetProductsNames().Count == 0)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.GetProductsNames())}");
            }
        }
    }

    static Person CreatePerson(string personData)
    {
        string name = personData.Split('=').ToList()[0];
        decimal money = decimal.Parse(personData.Split('=').ToList()[1]);
        Person person = new Person(name, money);
        return person;
    }

    static Product CreateProduct(string productData)
    {
        List<string> data = productData.Split('=').ToList();
        string name = data[0];
        decimal cost = decimal.Parse(data[1]);
        Product product = new Product(name, cost);
        return product;
    }

}

class Product
{
    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Name cannot be empty");
                Environment.Exit(0);
            }
            this.name = value;
        }
    }

    public decimal Cost
    {
        get { return this.cost; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Money cannot be negative");
                Environment.Exit(0);
            }
            this.cost = value;
        }
    }
}

class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.products = new List<Product>();
    }

    public List<string> GetProductsNames()
    {
        return this.products.Select(p => p.Name).ToList();
    }

    public void Buy(Product product)
    {
        if (this.Money >= product.Cost)
        {
            this.products.Add(product);
            Console.WriteLine($"{this.Name} bought {product.Name}");
            this.Money -= product.Cost;
        }
        else
        {
            Console.WriteLine($"{this.Name} can't afford {product.Name}");
        }
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value == " ")
            {
                Console.WriteLine("Name cannot be empty");
                Environment.Exit(0);
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Money cannot be negative");
                Environment.Exit(0);
            }
            this.money = value;
        }
    }
}