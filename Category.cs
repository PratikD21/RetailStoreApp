using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public class Category
    {
        public static List<Product> productList = new List<Product>()
        {
            new Product("Mens shoes", 500, "A"),
            new Product("Mens wallet", 100, "A"),
            new Product("Power Bank",1500, "B"),
            new Product("Trimmer", 2500, "B"),
            new Product("Book", 50, "C"),
            new Product("Pen",90,"C")
        };

        public List<Product> ShowProducts()
        {
            return productList;
        }
    }
}
