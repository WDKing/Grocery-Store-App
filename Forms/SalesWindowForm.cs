using Grocery_Store_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Store_App
{
    /// <summary>
    /// The Sales Window is to simulate a register when purchasing items.  Expanded capabilities would be manual entry of items and prices.
    /// </summary>
    public partial class SalesWindowForm : Form
    {
        internal List<GroceryStoreItem> groceryStoreItems = new();
        internal List<string> groceryItemDisplayList = new();
        internal List<Tuple<long, int>> shoppingList = new();

        public SalesWindowForm()
        {
            InitializeComponent();
        }

        private void SalesWindowForm_Load(object sender, EventArgs e)
        {
            GroceryStoreItemList.SortByName();
            groceryStoreItems = GroceryStoreItemList.Instance;

            foreach(GroceryStoreItem groceryItem in groceryStoreItems)
            {
                float costWithDiscount = groceryItem.GroceryItem.Sales.TotalAmount();
                groceryItemDisplayList.Add("" + groceryItem.GroceryItem.Name + " - " + costWithDiscount.ToString("c2"));
            }


            GroceryItemSelector.DataSource = groceryItemDisplayList;
            QuantitySelector.Value = 1;
            TotalDisplay.Hide();
        }

        private void ReturnHomeButton_Click(object sender, EventArgs e)
        {
            JSONHelpers.StoreJSON();
            this.Close();
        }

        private void GroceryItemSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            TotalDisplay.Hide();
            GroceryStoreItem itemToAdd = groceryStoreItems[GroceryItemSelector.SelectedIndex];

            shoppingList.Add(new Tuple<long, int>(itemToAdd.GroceryItem.ID, (int)QuantitySelector.Value));
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            float total = 0.0f;
            foreach(Tuple<long, int> item in shoppingList)
            {
                #pragma warning disable CS8629 // This will not be null as the only items added to the shopping list exist in the groceryStoreItemsList
                total += (float)groceryStoreItems.Find(groceryItem => groceryItem.GroceryItem.ID == item.Item1)?.GroceryItem.Sales.TotalAmount() * item.Item2;
                #pragma warning restore CS8629
            }
            TotalDisplay.Show();
            TotalDisplay.Text = total.ToString("c2");
        }
    }
}
