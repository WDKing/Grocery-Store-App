using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Store_App.Classes
{
    public class GroceryStoreItem
    {
        public GroceryItem GroceryItem { get; set; } = new();
    }

    public class GroceryItem
    {
        public string Name { get; set; } = "";
        public long ID { get; set; } = 0;
        public Iteminfo ItemInfo { get; set; } = new();
        public Sales Sales { get; set; } = new();
        public Internal Internal { get; set; } = new();

    }

    public class Iteminfo
    {
        public string Desc { get; set; } = "";
        public string Category { get; set; } = "";
    }

    public class Sales
    {
        public float Price { get; set; } = 0.0f;
        public float Discount { get; set; } = 0.0f;

        public float TotalAmount()
        {
            return Price - Discount;
        }
    }

    public class Internal
    {
        public int Aisle { get; set; } = 0;
        public TimesSold TimesSold { get; set; } = new();

        internal void UpdateAisle(int aisle) => Aisle = aisle;
    }

    public class TimesSold
    {
        public int Today { get; set; } = 0;
        public int Yesterday { get; set; } = 0;
    }

}






