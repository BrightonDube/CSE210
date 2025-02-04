using System;

namespace OnlineOrdering
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Address usaAddress = new Address("123 Main St", "Los Angeles", "CA", "USA");
            Address internationalAddress = new Address("456 Oxford Rd", "Johannesburg", "Gauteng", "South Africa");

        
            Customer customer1 = new Customer("John Smith", usaAddress);
            Customer customer2 = new Customer("Jane Doe", internationalAddress);

            Product product1 = new Product("Laptop", "LP001", 1200.00, 1);
            Product product2 = new Product("Mouse", "MS002", 25.00, 2);
            Product product3 = new Product("Keyboard", "KB003", 75.00, 1);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);
            order2.AddProduct(product1);

        }
        
    }
}