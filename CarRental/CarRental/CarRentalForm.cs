namespace CarRental
{
    public partial class CarRentalForm : Form
    {
        public CarRentalForm()
        {
            InitializeComponent();
        }

        // Program Logic -----------------------------------------


        // Event Handlers ----------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
