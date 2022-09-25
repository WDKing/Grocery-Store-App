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

namespace Grocery_Store_App.Forms
{
    /// <summary>
    /// The Stock move window is to update location of items.  Default is all items under $1.  Expanded capabilities will be able to update pricing,
    /// and discount of items, as well as selection of items based on current location, discount, or individual selection. 
    /// </summary>
    public partial class StockMoveForm : Form
    {
        internal List<GroceryStoreItem> groceryStoreItemList;

        public StockMoveForm()
        {
            InitializeComponent();
            groceryStoreItemList = GroceryStoreItemList.Instance;
        }

        private void StockMoveForm_Load(object sender, EventArgs e)
        {
            Aisle14Contents_TextChanged(sender, e);
        }

        private void ReturnHomeButton_Click(object sender, EventArgs e)
        {
            JSONHelpers.StoreJSON();
            this.Close();
        }

        private void MoveUnderADollarButton_Click(object sender, EventArgs e)
        {
            foreach(GroceryStoreItem groceryItem in groceryStoreItemList)
            {
                if(groceryItem.GroceryItem?.Sales?.Price < 1)
                {
                    groceryItem.GroceryItem?.Internal?.UpdateAisle(14);
                }
            }

            Aisle14Contents_TextChanged(sender, e);
        }

        private void Aisle14Contents_TextChanged(object sender, EventArgs e)
        {
            string aisleBoxText = @"Items in Aisle 14:"; 

            foreach(GroceryStoreItem groceryItem in groceryStoreItemList)
            {
                if(groceryItem.GroceryItem?.Internal?.Aisle == 14)
                {
                    aisleBoxText = aisleBoxText + Environment.NewLine + groceryItem.GroceryItem.Name;
                }

            }

            Aisle14ContentsText.Text = aisleBoxText;
        }
    }
}
