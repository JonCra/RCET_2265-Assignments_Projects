namespace DinerMenu_Fixed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Ensures "menu" is empty on startup
        }

        // Program Logic -------------------------------------------
        void SoupDisplay()
        {
            // Display Soup menu

        }
        void SaladDisplay()
        {
            // Display Salad menu

        }
        void FishDisplay()
        {
            // Display Fish menu

        }

        // Event Handlers ------------------------------------------
        private void FishButton_Click(object sender, EventArgs e)
        {
            // Display Fish menu
            FishDisplay();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaladButton_Click(object sender, EventArgs e)
        {
            // Display Salad menu
            SaladDisplay();
        }
        private void SoupButton_Click(object sender, EventArgs e)
        {
            // Display Soup menu
            SoupDisplay();
        }
    }
}
