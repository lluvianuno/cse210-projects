using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Brown", address1);

        Product product1 = new Product("Mouse", 35, "A001", 1);
        Product product2 = new Product("Headphones", 80, "A002", 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");
        Console.WriteLine();

         
        Address address2 = new Address("345 Av. Reina", "Tijuana", "Baja California", "México");
        Customer customer2 = new Customer("Rosa Hinojos", address2);

        Product product3 = new Product("Microphone", 145, "B001", 1);
        Product product4 = new Product("Glasses", 23, "B002", 2);
        Product product5 = new Product("Laptop", 1500, "B003", 1);


        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
        Console.WriteLine();
    }
}