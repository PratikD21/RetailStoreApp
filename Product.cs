using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        
        public Product(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
    }
}
