using System;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("413 W Knolls Vista Drive", "Moses Lake", "Washington", "USA");
        var customer1 = new Customer("Kyle Boat", address1);

        var address2 = new Address("536 South Glenmoor Drive", "Moses Lake", "Washington", "united states");
        var customer2 = new Customer("Paula Bailey", address2);

        var productsOrder1 = new List<Product>()
        {
            new Product("Laptop",101,1500.99m,1),
            new Product("Monitor",205,2500.89m,2),
            new Product("Desk",101,700.67m,1)
        };

        var productsOrder2 = new List<Product>()
        {
            new Product("Couch",309,2600.72m,1),
            new Product("Entertainment Center",407,3299.99m,1),
            new Product("Dining Table",410,1900.65m,1),
            new Product("Dining Chair",422,89.99m,8)
        };

        var order1 = new Order(customer1, productsOrder1);
        var order2 = new Order(customer2, productsOrder2);

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.FormatTotalCost());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.FormatTotalCost());
        Console.WriteLine();
    }
}