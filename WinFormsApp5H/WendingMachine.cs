namespace WinFormsApp5H
{
    public partial class WendingMachine : Form
    {
        public static double Money { get; set; } = 0;
        public WendingMachine()
        {
            InitializeComponent();
            foreach (var p in FakeRepo.GetProducts())
            {
                WendingMachineShelf wending = new(p);
                wending.Click += Wending_Click;
                flowLayoutPanel1.Controls.Add(wending);
            }
           
        }

        private void Wending_Click(object? sender, EventArgs e)
        {
            if(Money<(sender as WendingMachineShelf).product.Price)
            {
                MessageBox.Show($"You're too poor to buy {(sender as WendingMachineShelf).product.Name}");
                return;
            }
            if((sender as WendingMachineShelf).product.Quantity <= 0)
            {
                MessageBox.Show($"{(sender as WendingMachineShelf).product.Name} is out of stock");
                return;
            }

            Money -= (sender as WendingMachineShelf).product.Price;
            (sender as WendingMachineShelf).product.Quantity--;
            Moneylbl.Text = Math.Round(Money, 2).ToString();
            (sender as WendingMachineShelf).Quantitybtn.Text = (sender as WendingMachineShelf).product.Quantity.ToString();

        }

        private void WendingMachine_Load(object sender, EventArgs e)
        {
            Moneylbl.Text = Math.Round(Money, 2).ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Money += double.Parse((sender as Button).Text);
            Moneylbl.Text=Math.Round(Money,2).ToString();
        }
    }
}