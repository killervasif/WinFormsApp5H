namespace WinFormsApp5H
{
    partial class WendingMachine
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
            this.Moneylbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Moneylbl
            // 
            this.Moneylbl.AutoSize = true;
            this.Moneylbl.Location = new System.Drawing.Point(687, 42);
            this.Moneylbl.Name = "Moneylbl";
            this.Moneylbl.Size = new System.Drawing.Size(44, 15);
            this.Moneylbl.TabIndex = 0;
            this.Moneylbl.Text = " label 1";
            // 
            // WendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Moneylbl);
            this.Name = "WendingMachine";
            this.Text = "WendingMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Moneylbl;
    }
}