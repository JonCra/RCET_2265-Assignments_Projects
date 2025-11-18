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
        // Variables
        double distance;

        public CarRentalForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        // Program Logic -----------------------------------------
        private void SetDefaults()
        {
            // Enables the following:
            MilesRadioButton.Checked = true;
            
            // Disables the following:
            KM_RadioButton.Checked = AAA_DiscountCheckBox.Checked = SeniorDiscountCheckBox.Checked =
                DistanceTextBox.Enabled = MileageChargeTextBox.Enabled = DayChargeTextBox.Enabled =
                CreditTextBox.Enabled = BalanceTotalTextBox.Enabled = false;

            // Loads blank text/empty for the following:
            CustomerNameTextBox.Text = AddressTextBox.Text = CityTextBox.Text = StateTextBox.Text =
                ZipCodeTextBox.Text = InitialOdometerTextBox.Text = FinalOdometerTextBox.Text =
                NumberOfDaysTextBox.Text = "";

            DistanceTextBox.Text = MileageChargeTextBox.Text = DayChargeTextBox.Text =
                CreditTextBox.Text = BalanceTotalTextBox.Text = "";            
        }

        private void ClearForm()
        {
            // Clear all input/output text boxes, discount boxes, select miles checkbox
            // DO NOT CLEAR SUMMARY

            MilesRadioButton.Checked = true;
            KM_RadioButton.Checked = AAA_DiscountCheckBox.Checked = SeniorDiscountCheckBox.Checked = false;

            CustomerNameTextBox.Text = AddressTextBox.Text = CityTextBox.Text = StateTextBox.Text =
                ZipCodeTextBox.Text = InitialOdometerTextBox.Text = FinalOdometerTextBox.Text =
                NumberOfDaysTextBox.Text = "";
        }

        private void ValidateInputs()
        {

        }

        private double kmToMiles()
        {
            return distance * 0.62;
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

            // Day Charge calculated here

            // Mileage converted/calculatd here
            if (KM_RadioButton.Checked == true && MilesRadioButton.Checked == false)
            {
                //kmToMiles();
            }
            else 
            {

            }


            // Mileage Charge calculated here

            // Discount calculated here

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // User-confirmed program close
            var result = MessageBox.Show("Are you sure you want to quit?", "Quit program?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // DO NOT CLEAR SUMMARY DETAILS
            ClearForm();
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

        private void InputTextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
    }
}