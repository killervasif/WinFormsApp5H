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
        public Product product { get; set; }
        public Action<double, bool> PaymentStuff { get; set; }     

        public WendingMachineShelf(Product p)
        {
            InitializeComponent();
            this.product = p;
            productName.Text = p.Name;
            productPrice.Text=p.Price.ToString();
            Quantitybtn.Text=p.Quantity.ToString();                
        }

        
    }
}
