namespace Grocery_Store_App.Forms
{
    partial class StockMoveForm
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
            this.MoveUnderADollerButton = new System.Windows.Forms.Button();
            this.Aisle14ContentsText = new System.Windows.Forms.TextBox();
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
            // MoveUnderADollerButton
            // 
            this.MoveUnderADollerButton.Location = new System.Drawing.Point(64, 41);
            this.MoveUnderADollerButton.Name = "MoveUnderADollerButton";
            this.MoveUnderADollerButton.Size = new System.Drawing.Size(204, 34);
            this.MoveUnderADollerButton.TabIndex = 1;
            this.MoveUnderADollerButton.Text = "Move Items Under $1 to Aisle 14";
            this.MoveUnderADollerButton.UseVisualStyleBackColor = true;
            this.MoveUnderADollerButton.Click += new System.EventHandler(this.MoveUnderADollarButton_Click);
            // 
            // Aisle14ContentsText
            // 
            this.Aisle14ContentsText.Location = new System.Drawing.Point(32, 81);
            this.Aisle14ContentsText.Multiline = true;
            this.Aisle14ContentsText.Name = "Aisle14ContentsText";
            this.Aisle14ContentsText.Size = new System.Drawing.Size(271, 226);
            this.Aisle14ContentsText.TabIndex = 2;
            this.Aisle14ContentsText.TextChanged += new System.EventHandler(this.Aisle14Contents_TextChanged);
            // 
            // StockMoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 350);
            this.Controls.Add(this.Aisle14ContentsText);
            this.Controls.Add(this.MoveUnderADollerButton);
            this.Controls.Add(this.ReturnHomeButton);
            this.Name = "StockMoveForm";
            this.Text = "StockMoveForm";
            this.Load += new System.EventHandler(this.StockMoveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ReturnHomeButton;
        private Button MoveUnderADollerButton;
        private TextBox Aisle14ContentsText;
    }
}