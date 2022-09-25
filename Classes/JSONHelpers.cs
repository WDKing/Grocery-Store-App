using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Grocery_Store_App.Classes
{
    internal static class JSONHelpers
    {
        internal static string DefaultFilePath => @"Files\grocery-store-list.json";

        internal static List<GroceryStoreItem> LoadJSON()
        {
            string jsonFileString;
            List<GroceryStoreItem> groceryItemList;

            using (StreamReader streamReader = new StreamReader(@"..\..\..\" + DefaultFilePath))
            {
                jsonFileString = streamReader.ReadToEnd();
                groceryItemList = JsonSerializer.Deserialize<List<GroceryStoreItem>>(jsonFileString);
            }

            return groceryItemList;
        }

        internal static void StoreJSON()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"..\..\..\" + DefaultFilePath))
            {
                var jsonString = JsonSerializer.Serialize(GroceryStoreItemList.Instance);
                streamWriter.Write(jsonString);
            }
        }
    }
}
