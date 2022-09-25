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
    /// The sales window is to display information based on sales.  Expanded capabilities include the choice of quantity of results, and choice
    /// of different categories.
    /// </summary>
    public partial class SalesNumbersForm : Form
    {
        private List<GroceryStoreItem> groceryStoreItems => new List<GroceryStoreItem>();

        public SalesNumbersForm()
        {
            InitializeComponent();
        }

        private void SalesNumbersForm_Load(object sender, EventArgs e)
        {
            GroceryStoreItemList.SortByTotalSales();
            List<GroceryStoreItem> groceryStoreFruitList = GroceryStoreItemList.ReturnFruits();

            int count = 0;
            string displayString = "Top 2 Fruit Sales With Discount";
            for(int i = 0; i < groceryStoreFruitList.Count; i++)
            {
                if (groceryStoreFruitList[i].GroceryItem?.Sales.Discount > 0) 
                {
                    displayString += Environment.NewLine + groceryStoreFruitList[i].GroceryItem?.Name;
                    count++;
                    if(count >= 2)
                    {
                        break;
                    }
                }
            }

            TopSalesBox.Text = displayString;
        }

        private void ReturnHomeButton_Click(object sender, EventArgs e)
        {
            JSONHelpers.StoreJSON();
            this.Close();
        }

        private void TopSalesBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
