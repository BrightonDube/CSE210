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
    }
}