namespace Grocery_Store_App
{
    partial class GroceryStoreHomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalesWindowFormButton = new System.Windows.Forms.Button();
            this.StockMoveButton = new System.Windows.Forms.Button();
            this.SalesNumbersWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalesWindowFormButton
            // 
            this.SalesWindowFormButton.Location = new System.Drawing.Point(190, 87);
            this.SalesWindowFormButton.Name = "SalesWindowFormButton";
            this.SalesWindowFormButton.Size = new System.Drawing.Size(277, 61);
            this.SalesWindowFormButton.TabIndex = 0;
            this.SalesWindowFormButton.Text = "Sales";
            this.SalesWindowFormButton.UseVisualStyleBackColor = true;
            this.SalesWindowFormButton.Click += new System.EventHandler(this.SalesWindowFormButton_Click);
            // 
            // StockMoveButton
            // 
            this.StockMoveButton.Location = new System.Drawing.Point(190, 154);
            this.StockMoveButton.Name = "StockMoveButton";
            this.StockMoveButton.Size = new System.Drawing.Size(277, 71);
            this.StockMoveButton.TabIndex = 1;
            this.StockMoveButton.Text = "Stock Move";
            this.StockMoveButton.UseVisualStyleBackColor = true;
            this.StockMoveButton.Click += new System.EventHandler(this.StockMoveButton_Click);
            // 
            // SalesNumbersWindow
            // 
            this.SalesNumbersWindow.Location = new System.Drawing.Point(190, 231);
            this.SalesNumbersWindow.Name = "SalesNumbersWindow";
            this.SalesNumbersWindow.Size = new System.Drawing.Size(277, 65);
            this.SalesNumbersWindow.TabIndex = 2;
            this.SalesNumbersWindow.Text = "Sales Numbers";
            this.SalesNumbersWindow.UseVisualStyleBackColor = true;
            this.SalesNumbersWindow.Click += new System.EventHandler(this.SalesNumbersWindow_Click);
            // 
            // GroceryStoreHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 403);
            this.Controls.Add(this.SalesNumbersWindow);
            this.Controls.Add(this.StockMoveButton);
            this.Controls.Add(this.SalesWindowFormButton);
            this.Name = "GroceryStoreHomeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GroceryStoreHomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button SalesWindowFormButton;
        private Button StockMoveButton;
        private Button SalesNumbersWindow;
    }
}