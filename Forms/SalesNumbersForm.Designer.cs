namespace Grocery_Store_App.Forms
{
    partial class SalesNumbersForm
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
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.TopSalesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.Location = new System.Drawing.Point(0, 0);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(36, 32);
            this.returnHomeButton.TabIndex = 0;
            this.returnHomeButton.Text = "<--";
            this.returnHomeButton.UseVisualStyleBackColor = true;
            this.returnHomeButton.Click += new System.EventHandler(this.ReturnHomeButton_Click);
            // 
            // TopSalesBox
            // 
            this.TopSalesBox.Location = new System.Drawing.Point(40, 50);
            this.TopSalesBox.Multiline = true;
            this.TopSalesBox.Name = "TopSalesBox";
            this.TopSalesBox.Size = new System.Drawing.Size(250, 88);
            this.TopSalesBox.TabIndex = 1;
            this.TopSalesBox.TextChanged += new System.EventHandler(this.TopSalesBox_TextChanged);
            // 
            // SalesNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 193);
            this.Controls.Add(this.TopSalesBox);
            this.Controls.Add(this.returnHomeButton);
            this.Name = "SalesNumbersForm";
            this.Text = "SalesNumbersForm";
            this.Load += new System.EventHandler(this.SalesNumbersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button returnHomeButton;
        private TextBox TopSalesBox;
    }
}