namespace AddressLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string EvaluateFields()
        {
            string message = "";

            // If text boxes are blank, focuses on them for user input
            if (ZipCodeTextBox.Text == "")
            {
                ZipCodeTextBox.Focus();
                message += "Zip Code is Required\n";
            }
            if (StateTextBox.Text == "")
            {
                StateTextBox.Focus();
                message += "State is Required\n";
            }
            if (CityTextBox.Text == "")
            {
                CityTextBox.Focus();
                message += "Phone number is Required.\n";
            }
            if (StreetAddressTextBox.Text == "")
            {
                StreetAddressTextBox.Focus();
                message += "Age is Required.\n";
            }
            if (LastNameTextBox.Text == "")
            {
                LastNameTextBox.Focus();
                message += "Last Name is Required.\n";
            }
            if (FirstNameTextBox.Text == "")
            {
                //MessageBox.Show("Please Enter a First Name.");
                FirstNameTextBox.Focus();
                message += "First Name is Required.\n";
            }
            if (message != "")
            {
                // Displays message if not empty
                MessageBox.Show($"ERROR:\n{message}");
            }
            return message;
        }
        void DisplayContent()
        {
            if (EvaluateFields() != "")
            {
                MessageBox.Show(EvaluateFields());
            }
            else
            {
                // Displays user-input data
                AddressLabelTextBox.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}\n" +
                        $"{StreetAddressTextBox.Text}\n" +
                        $"{CityTextBox.Text}, {StateTextBox.Text}\n" +
                        $"{ZipCodeTextBox.Text}";
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close window/program when pressed
            this.Close();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all text when pressed
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            StreetAddressTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            StateTextBox.Text = string.Empty;
            ZipCodeTextBox.Text = string.Empty;
            AddressLabelTextBox.Text = string.Empty;
        }
        private void DisplayLabelButton_Click(object sender, EventArgs e)
        {
            // Display entered information
            DisplayContent();
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