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
            // Clear all input/output text boxes, discount boxes, select miles checkbox
            // DO NOT CLEAR SUMMARY

            MilesRadioButton.Checked = true;
            KM_RadioButton.Checked = false;

        }

        private double kmToMiles(double kilometers)
        {
            return kilometers * 0.62;
        }

        // Event Handlers ----------------------------------------
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Calculate based on user input
            /*
             * Charge is $15/day
             * first 200 miles is free
             * all miles between 201-500 $0.12/mi
             * 500+ miles = $0.10/mi
             * 1km = 0.62mi
             * AAA gets 5% discount
             * seniors get 3% discount
             * CAN GET BOTH DISCOUNTS; DO NOT ACCOUNT FOR UNTIL CACLULATE BUTTON IS CLICKED
             */

            if (KM_RadioButton.Checked)
            {
                kmToMiles();
            }
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
            Make it into a 2D Array??
            */

            ClearForm();
        }
    }
}