using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5H
{
    public partial class WendingMachineShelf : UserControl
    {
        Product product;
        public Action<double, bool> PaymentStuff { get; set; }
        public WendingMachineShelf()
        {
            InitializeComponent();
        }

        public WendingMachineShelf(Product p)
        {
            this.product = p;
            productName.Text = p.Name;
            productPrice.Text=p.Price.ToString();
            Quantitybtn.Text=p.Quantity.ToString();                
        }

        private void Quantitybtn_Click(object sender, EventArgs e)
        {
            if (WendingMachine.Money < product.Price)
            {
                MessageBox.Show($"You're too poor for {product.Name}");
                return;
            }
            if (product.Quantity <= 0)
            {
                MessageBox.Show($"{product.Name} is out stock");
                return;
            }

            WendingMachine.Money-=product.Price;            
            product.Quantity--;
            

        }
    }
}
