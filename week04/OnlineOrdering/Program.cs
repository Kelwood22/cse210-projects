using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", 101, 999.99, 1),
            new Product("Mouse", 102, 25.50, 2),
            new Product("Keyboard", 103, 45.00, 1)

        };

        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Springfield", "IL", "62701", "USA"));
        Order order1 = new Order(customer1);
        foreach (var product in products1)
        {
            order1.AddProduct(product);
        }

        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Order Price: ${order1.TotalOrderPrice()}");

        List<Product> products2 = new List<Product>
        {
            new Product("Smartphone", 201, 699.99, 1),
            new Product("Charger", 202, 19.99, 1),
            new Product("Headphones", 203, 89.99, 1)
        };

        Customer customer2 = new Customer("Jane Smith", new Address("456 Elm St", "Los Angeles", "CA", "90001", "USA"));
        Order order2 = new Order(customer2);
        foreach (var product in products2)
        {
            order2.AddProduct(product);
        }

        Console.WriteLine("\n=== Order 2 ===");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Order Price: ${order2.TotalOrderPrice()}");

        


    }
}