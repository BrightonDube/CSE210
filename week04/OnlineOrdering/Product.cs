using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _price;
        private int _quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetProductId()
        {
            return _productId;
        }
        public double CalculateProductTotal()
        {
            return _price * _quantity;
        }
        
    }
}