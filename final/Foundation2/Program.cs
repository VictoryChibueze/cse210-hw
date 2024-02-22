using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("23 Peiros Crescent","Tallahassee","Florida","USA");
        Customer customer1 = new Customer("Jeffrey Dow",address1);
        Product product1 = new Product("Pong Monster Cakes","Moe 1647",12,3);
        Product product2 = new Product("Samsung Galaxy","Ace 4",103,6);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total cost: ${order1.ProductTotalCost()}");
        Console.WriteLine("");

        Address address2 = new Address("23 Nkrumah Street,Fegge","Onitsha","Anambra","Nigeria");
        Customer customer2 = new Customer("Marcus Akika",address2);
        Product product11 = new Product("Starlinks","9012 TH",500,2);
        Product product21 = new Product("X-Box","XE 4",104,2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product11);
        order2.AddProduct(product21);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total cost: ${order2.ProductTotalCost()}");
        Console.WriteLine("");

       

    }
}