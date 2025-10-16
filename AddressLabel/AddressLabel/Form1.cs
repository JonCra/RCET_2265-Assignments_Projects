namespace AddressLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close window/program when pressed
            this.Close();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all text when pressed
        }
        private void DisplayLabelButton_Click(object sender, EventArgs e)
        {
            // Display entered information
            if ()
            {

            }
            else
            {
                // Displays entered data
                AddressLabelTextBox.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}\n" +
                    $"{StreetAddressTextBox.Text}\n" +
                    $"{CityTextBox.Text}" +
                    $"{StateTextBox.Text}" +
                    $"{ZipCodeTextBox.Text}";
            }
        }
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void StreetAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void StateTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddressLabelTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}