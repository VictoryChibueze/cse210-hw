using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Pong Monster Cakes","moe1647",12,3);
        Address address1 = new Address("23 Peiros Crescent","Tallahassee","Florida","USA");
        Customer customer1 = new Customer("Jeffrey Dow",address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());

    }
}