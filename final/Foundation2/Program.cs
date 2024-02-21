using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("89 Mendy Street", "Townhall", "HB", "USA");
        Customer customer1 = new Customer("Henry Parker", address1);

        Address address2 = new Address("23 Park Street", "Lakeside", "CA", "Canada");
        Customer customer2 = new Customer("Ehis Uriah", address2);

        Product product1 = new Product("Headset", "H1802", 18.2, 3);
        Product product2 = new Product("Controller", "C0456", 10.5, 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Price: $" + order1.CalculateTotalCost());

        Console.WriteLine("_____________________________________");
        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Price: $" + order2.CalculateTotalCost());
    }
}
