using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Store_App.Classes
{
    internal class GroceryStoreItemList
    {
        private static List<GroceryStoreItem>? ItemList = null;

        private GroceryStoreItemList()
        {

        }

        public static List<GroceryStoreItem> Instance
        {
            get
            {
                if (ItemList == null)
                {
                    ItemList = JSONHelpers.LoadJSON();
                }
                return ItemList;
            }
        }

        internal static void SortByTotalSales()
        {
            ItemList = ItemList?.OrderByDescending(item => item.GroceryItem?.Internal?.TimesSold?.Today + item.GroceryItem?.Internal?.TimesSold?.Yesterday).ToList();
        }

        internal static List<GroceryStoreItem> ReturnFruits()
        {
            List<GroceryStoreItem> groceryItemList = new List<GroceryStoreItem>();

            foreach(GroceryStoreItem groceryStoreItem in Instance)
            {
                if(groceryStoreItem.GroceryItem?.ItemInfo?.Category == "Fruit")
                {
                    groceryItemList.Add(groceryStoreItem);
                }
            }

            return groceryItemList;
        }

        internal static void SortByName()
        {
            ItemList = ItemList?.OrderBy(item => item.GroceryItem?.Name).ToList();
        }
        
    }
}
