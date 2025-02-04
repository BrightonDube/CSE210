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

        }
        
    }
}