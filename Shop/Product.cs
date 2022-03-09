using System;

namespace Shop
{
    public class Product
    {
        private string Name { get; set; }
        private double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        
    }
}