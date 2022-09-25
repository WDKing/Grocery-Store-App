using Grocery_Store_App.Classes;
using Grocery_Store_App.Forms;

namespace Grocery_Store_App
{
    /// <summary>
    /// The Grocery Store Home has options to open each other window who has their own different capabilities and functions.
    /// </summary>
    public partial class GroceryStoreHomeForm : Form
    {
        private List<GroceryStoreItem> groceryStoreItems;
        public GroceryStoreHomeForm()
        {
            InitializeComponent();
        }

        private void GroceryStoreHomeForm_Load(object sender, EventArgs e)
        {
            groceryStoreItems = GroceryStoreItemList.Instance;
        }

        private void SalesWindowFormButton_Click(object sender, EventArgs e)
        {
            Form salesWindowForm = new SalesWindowForm();
            salesWindowForm.Show();
        }

        private void StockMoveButton_Click(object sender, EventArgs e)
        {
            Form stockMoveWindow = new StockMoveForm();
            stockMoveWindow.Show();
        }

        private void SalesNumbersWindow_Click(object sender, EventArgs e)
        {
            Form salesNumbersWindow = new SalesNumbersForm();
            salesNumbersWindow.Show();
        }
    }
}