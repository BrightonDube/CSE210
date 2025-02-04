using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Order
    {
       private List<Product> _products;
       private Customer _customer;
       public Order(Customer customer)
       {
        _customer = customer;
        _products = new List<Product>();
       } 
       public void AddProduct(Product product)
       {
        _products.Add(product);
       }
       public double CalculateTotalCost()
       {
        double productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.CalculateProductTotal();
        }
       }
    }
}