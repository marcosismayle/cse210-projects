using System;

class Program
{
    static void Main()
    {
        Address usaAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Address nonUsaAddress = new Address("456 International Ave", "Global City", "ProvinceX", "Canada");

        Customer customer1 = new Customer("John Doe", usaAddress);
        Customer customer2 = new Customer("Jane Smith", nonUsaAddress);

        Product product1 = new Product("Product1", "P1", 10.99m, 2);
        Product product2 = new Product("Product2", "P2", 7.49m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C2}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C2}");
    }
}
