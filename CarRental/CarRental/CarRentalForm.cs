namespace CarRental
{
    /*
    TODO (Details in appropriate object/method):
        [ ] Input Validation
        [ ] Calculations
        [ ] Ouptut Display
        [ ] Summary
        [ ] Clear Form
        [X] Yes/No confirm closing program
    */

    public partial class CarRentalForm : Form
    {
        public CarRentalForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        // Program Logic -----------------------------------------
        private void SetDefaults()
        {
            MilesRadioButton.Checked = true;
            KM_RadioButton.Checked = AAA_DiscountCheckBox.Checked = SeniorDiscountCheckBox.Checked = false;
            
        }

        private void ClearForm()
        {

        }


        // Event Handlers ----------------------------------------
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Calculate based on user input
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // User-confirmed program close
            var result = MessageBox.Show("Are you sure you want to quit?", "Quit program", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // DO NOT CLEAR SUMMARY DETAILS
            SetDefaults();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            /* Disabled until AT LEAST ONE rental has been completed
                Display summary in pop up
                Total number of customers.
                Total distance driven in miles.
                Total charges.
                Perform all “Clearing the Form” actions
                Do not clear the summary totals.
            */

            ClearForm();
        }
    }
}