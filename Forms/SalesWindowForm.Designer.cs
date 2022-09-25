namespace Grocery_Store_App
{
    partial class SalesWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReturnHomeButton = new System.Windows.Forms.Button();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.GroceryItemSelector = new System.Windows.Forms.ComboBox();
            this.TotalButton = new System.Windows.Forms.Button();
            this.TotalDisplay = new System.Windows.Forms.TextBox();
            this.QuantitySelector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.QuantitySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnHomeButton
            // 
            this.ReturnHomeButton.Location = new System.Drawing.Point(0, 0);
            this.ReturnHomeButton.Name = "ReturnHomeButton";
            this.ReturnHomeButton.Size = new System.Drawing.Size(36, 32);
            this.ReturnHomeButton.TabIndex = 0;
            this.ReturnHomeButton.Text = "<--";
            this.ReturnHomeButton.UseVisualStyleBackColor = true;
            this.ReturnHomeButton.Click += new System.EventHandler(this.ReturnHomeButton_Click);
            // 
            // AddToListButton
            // 
            this.AddToListButton.Location = new System.Drawing.Point(513, 51);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(78, 23);
            this.AddToListButton.TabIndex = 1;
            this.AddToListButton.Text = "Add";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // GroceryItemSelector
            // 
            this.GroceryItemSelector.FormattingEnabled = true;
            this.GroceryItemSelector.Location = new System.Drawing.Point(29, 51);
            this.GroceryItemSelector.Name = "GroceryItemSelector";
            this.GroceryItemSelector.Size = new System.Drawing.Size(405, 23);
            this.GroceryItemSelector.TabIndex = 2;
            this.GroceryItemSelector.SelectedIndexChanged += new System.EventHandler(this.GroceryItemSelector_SelectedIndexChanged);
            // 
            // TotalButton
            // 
            this.TotalButton.Location = new System.Drawing.Point(29, 154);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(75, 23);
            this.TotalButton.TabIndex = 3;
            this.TotalButton.Text = "Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // TotalDisplay
            // 
            this.TotalDisplay.Location = new System.Drawing.Point(274, 154);
            this.TotalDisplay.Name = "TotalDisplay";
            this.TotalDisplay.Size = new System.Drawing.Size(160, 23);
            this.TotalDisplay.TabIndex = 4;
            // 
            // QuantitySelector
            // 
            this.QuantitySelector.Location = new System.Drawing.Point(440, 51);
            this.QuantitySelector.Name = "QuantitySelector";
            this.QuantitySelector.Size = new System.Drawing.Size(67, 23);
            this.QuantitySelector.TabIndex = 6;
            // 
            // SalesWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 225);
            this.Controls.Add(this.QuantitySelector);
            this.Controls.Add(this.TotalDisplay);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.GroceryItemSelector);
            this.Controls.Add(this.AddToListButton);
            this.Controls.Add(this.ReturnHomeButton);
            this.Name = "SalesWindowForm";
            this.Text = "Sales_Window";
            this.Load += new System.EventHandler(this.SalesWindowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantitySelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ReturnHomeButton;
        private Button AddToListButton;
        private ComboBox GroceryItemSelector;
        private Button TotalButton;
        private TextBox TotalDisplay;
        private NumericUpDown QuantitySelector;
    }
}