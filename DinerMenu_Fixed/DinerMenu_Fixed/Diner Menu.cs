namespace DinerMenu_Fixed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DefaultMenuText();
        }

        // Program Logic -------------------------------------------
        void SoupDisplay()
        {
            // Display Soup menu
            MenuTopTextBox.Text = "~ Soup of the Day ~";
            MenuBottomTextBox.Text = "Ma's Homemade Chicken Noodle Soup";
            MenuVeryBottomTextBox.Text = "";
        }
        void SaladDisplay()
        {
            // Display Salad menu
            MenuTopTextBox.Text = "~ Salad Menu ~";
            MenuBottomTextBox.Text = "Grilled Chicken Salad";
            MenuVeryBottomTextBox.Text = "";
        }
        void FishDisplay()
        {
            // Display Fish menu
            MenuTopTextBox.Text = "~ Fish Menu ~";
            MenuBottomTextBox.Text = "World Famous Fish and Chips";
            MenuVeryBottomTextBox.Text = "Fresh Rainbow Trout caught locally";
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
        private void DefaultMenuText()
        {
            MenuTopTextBox.Text = MenuBottomTextBox.Text = MenuVeryBottomTextBox.Text = "";
        }
    }
}
