using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Console.WriteLine("---------- Example 1: user from USA ------------");
        Console.WriteLine();
        Order order1 = new Order("Henrry Guzman");
        order1.ShippingAddress("Dr Whitetail", "McAllen", "Texas", "USA");

        order1.AddProduct(name: "chips", id: 1, price: 2, quantity: 3);
        order1.AddProduct(name: "oil", id: 2, price: 4, quantity: 1);
        order1.AddProduct(name: "watermelon", id: 3, price: 8, quantity: 1);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"shipping price: ${order1.ShippingCalc()}");
        Console.WriteLine($"Total price including shipping: ${order1.OrderTotal()}");
        Console.WriteLine();

        Console.WriteLine("---------- Example 1: user from Mexico (same products) ------------");
        Console.WriteLine();
        Order order2 = new Order("Daniel Guzman");
        order2.ShippingAddress("Las Lomas", "Monterrey", "Nuevo Leon", "MX");

        order2.AddProduct(name: "chips", id: 1, price: 2, quantity: 3);
        order2.AddProduct(name: "oil", id: 2, price: 4, quantity: 1);
        order2.AddProduct(name: "watermelon", id: 3, price: 8, quantity: 1);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"shipping price: ${order2.ShippingCalc()}");
        Console.WriteLine($"Total price including shipping: ${order2.OrderTotal()}");
        Console.WriteLine();

    }
}