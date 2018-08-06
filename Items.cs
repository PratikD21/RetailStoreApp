using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public class Items
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }

        public Items(string itemName, int qty)
        {
            this.ItemName = itemName;
            this.Quantity = qty;
        }
    }
}
