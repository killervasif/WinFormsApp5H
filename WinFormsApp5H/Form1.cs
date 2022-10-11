namespace WinFormsApp5H
{
    public partial class WendingMachine : Form
    {
        public static double Money { get; set; }
        public WendingMachine()
        {
            InitializeComponent();
            foreach  (Product p in FakeRepo.GetProducts())
            {
                WendingMachineShelf wending = new(p);
            }

        }

        
    }
}