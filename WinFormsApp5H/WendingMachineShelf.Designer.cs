namespace WinFormsApp5H
{
    partial class WendingMachineShelf
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productName = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.Quantitybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(36, 33);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(49, 15);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Location = new System.Drawing.Point(36, 62);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(33, 15);
            this.productPrice.TabIndex = 1;
            this.productPrice.Text = "Price";
            // 
            // Quantitybtn
            // 
            this.Quantitybtn.Location = new System.Drawing.Point(20, 93);
            this.Quantitybtn.Name = "Quantitybtn";
            this.Quantitybtn.Size = new System.Drawing.Size(75, 23);
            this.Quantitybtn.TabIndex = 2;
            this.Quantitybtn.Text = "Quantity";
            this.Quantitybtn.UseVisualStyleBackColor = true;
            this.Quantitybtn.Click += new System.EventHandler(this.Quantitybtn_Click);
            // 
            // WendingMachineShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Quantitybtn);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Name = "WendingMachineShelf";
            this.Size = new System.Drawing.Size(117, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productName;
        private Label productPrice;
        private Button Quantitybtn;
    }
}
