using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Jason", new Address("8th st", "Atlanta", "GA", "USA"));
        Customer customer2 = new Customer("Barbara", new Address("Village st", "Boston", "MA", "USA"));

        Order order1 = new Order(customer1, new Product("Apple", 1, 3.50f, 6));
        Order order2 = new Order(customer2, new Product("Banana", 5, 2.8f, 4));

        order1.AddProduct(new Product("Water", 3, 0.34f, 2));
        order1.AddProduct(new Product("Milk", 4, 1.68f, 1));
        order1.AddProduct(new Product("Bread", 9, 0.99f, 2));

        order2.AddProduct(new Product("Water", 3, 0.34f, 4));
        order2.AddProduct(new Product("Cereal", 2, 1.50f, 1));


        Console.Clear();
        Console.Write($"Order 1: {order1.GetCustomerName()}\n");
        order1.PackLabel();
        Console.Write("\n\n");
        order1.ShippingLabel();
        Console.Write($"\nTotal Price: {order1.TotalCost().ToString("C")}");

        Console.Write("\n\n#################################################\n\n");

        Console.Write($"Order 2: {order1.GetCustomerName()}\n");
        order2.PackLabel();
        Console.Write("\n\n");
        order2.ShippingLabel();
        Console.Write($"\nTotal Price: {order2.TotalCost().ToString("C")}\n");
    }
}