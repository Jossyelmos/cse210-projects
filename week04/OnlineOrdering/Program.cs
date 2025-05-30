using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("MacBook", "MPC023", 300, 1);
        Product product2 = new Product("Macmillian", "P0013", 15, 5);
        Product product3 = new Product("Electronics", "PS-10343", 27, 15);
        Product product4 = new Product("Video Game", "PS4-082", 120, 2);

        Address address1 = new Address("15 Edenvale Rd", "Califonia", "CA", "USA");
        Address address2 = new Address("231 Bedfordview Rd", "Johannesburg", "Gauteng", "South Africa");

        Customer customer1 = new Customer("Inny Jeffrey", address1);
        Customer customer2 = new Customer("Ifeoluwa Jason", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product4);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");

    }
}