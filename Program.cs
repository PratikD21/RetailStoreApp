using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ReatailStore");

            Console.WriteLine("\n****************************");

            Category category = new Category();
            List<Product> list = category.ShowProducts();

            foreach(var item in list)
            {
                Console.WriteLine("Product Name:"+ item.Name + ",Product Price:" + item.Price + ",Product Category:" + item.Type +"\n");
            }

            Console.WriteLine("*******************************\n");
            Console.WriteLine("Select Products to add in Cart\n");
            var yesno="";
            List<Items> listItems = new List<Items>();
            do
            {
                Console.WriteLine("Enter Product Name:");
                var itemName = Console.ReadLine(); // Product Name

                Console.WriteLine("Enter Product Qunatity:");
                var itemQty =Convert.ToInt32( Console.ReadLine()); // Product Name
                listItems.Add(new Items(itemName, itemQty));
              
                Console.WriteLine("Do you want to continue:Y/N");
                yesno= Console.ReadLine();
            } while (yesno=="y");

            foreach (var item in listItems)
            {
                Console.WriteLine("Item Name:" + item.ItemName + ",Item Quantity" + item.Quantity+"\n");
            }

            Console.WriteLine("Do you want to generate bill(Y/N)\n");
            var choice = Console.ReadLine().ToString();
            
            if (choice == "y")
            {
                GenerateBill(listItems);
            }

            void GenerateBill(List<Items> items)
            {
                Bill bill = new Bill();
                double totalCost = 0;
                double totalTax = 0;

                foreach (var item in items)
                {
                    foreach (var product in list)
                    {
                        if (item.ItemName.Equals(product.Name))
                        {
                            totalCost += product.Price * item.Quantity;
                            totalTax += (CalculateTax(product.Type, product.Price * item.Quantity)); 
                        }
                    }

                    bill.TotalCost = totalCost;
                    bill.TotalTax = totalTax;
                }

                Console.WriteLine("Total Cost " + bill.TotalCost +"Total Tax " + bill.TotalTax  + "\n");
            }

            double CalculateTax(string type, double price)
            {
                double tax = 0;

                switch (type)
                {
                    case "A" :
                        tax = price * 0.1;
                        break;
                    case "B":
                        tax = price * 0.2;
                        break;
                    case "C":
                        tax = 0;
                        break;
                }
                return tax;
            }
        }
    }
}
