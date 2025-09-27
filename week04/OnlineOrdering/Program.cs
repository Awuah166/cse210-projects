using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Create an address
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        // Create a customer
        Customer customer1 = new Customer("John Doe", address1);
        // Create an order for the customer
        Order order1 = new Order(customer1);
        // Add products to the order
        order1.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50, 2));
        // Display packing label
        Console.WriteLine(order1.GetPackingLabel());
        // Display shipping label
        Console.WriteLine(order1.GetShippingLabel());
        // Display total price
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");

        // Create another address
        Address address2 = new Address("456 Elm St", "New-Weija", "ACCRA", "GHANA");
        // Create another customer
        Customer customer2 = new Customer("Sosu Christabel", address2);
        // Create another order for the second customer
        Order order2 = new Order(customer2);
        // Add products to the second order
        order2.AddProduct(new Product("Smartphone", "P003", 699.99, 1));
        order2.AddProduct(new Product("Headphones", "P004", 89.99, 1));
        // Display packing label for the second order
        Console.WriteLine(order2.GetPackingLabel());
        // Display the shipping label for the second order
        Console.WriteLine(order2.GetShippingLabel());
        // Display total price for the second order
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");

    }
}