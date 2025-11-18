namespace CarRental
{
    /*
    TODO (Details in appropriate object/method):
        [X] Input Validation
        [ ] Calculations
        [X] Ouptut Display
        [ ] Summary
        [X] Clear Form
        [X] Yes/No confirm closing program
    */

    public partial class CarRentalForm : Form
    {
        // Variables
        double distance;
        double miles;
        double InitOdometer;
        double FinalOdometer;
        double Days;
        double DailyCharge = 0;
        double Discount1;
        double Discount2;
        double Discount;
        double Total;

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

            // Loads blank text / empty for the following:
            CustomerNameTextBox.Text = AddressTextBox.Text = CityTextBox.Text = ZipCodeTextBox.Text =
                InitialOdometerTextBox.Text = FinalOdometerTextBox.Text = DaysTextBox.Text = "";

            DistanceTextBox.Text = MileageChargeTextBox.Text = DayChargeTextBox.Text =
                CreditTextBox.Text = BalanceTotalTextBox.Text = "";

            StateComboBox.SelectedIndex = 0;
        }

        private void ClearForm()
        {
            // Clear all input/output text boxes, discount boxes, select miles checkbox
            // DO NOT CLEAR SUMMARY

            MilesRadioButton.Checked = true;
            KM_RadioButton.Checked = AAA_DiscountCheckBox.Checked = SeniorDiscountCheckBox.Checked = false;

            CustomerNameTextBox.Text = AddressTextBox.Text = CityTextBox.Text = ZipCodeTextBox.Text =
                InitialOdometerTextBox.Text = FinalOdometerTextBox.Text = DaysTextBox.Text = "";

            StateComboBox.SelectedIndex = 0;
        }

        bool ValidateInputs() // Maybe make each field individual...?
        {
            bool allFieldsValid = false;
            bool NameValid = false;
            bool AddressValid = false;
            bool CityValid = false;
            bool StateValid = false;
            bool ZipValid = false;
            bool Odo1Valid = false;
            bool Odo2Valid = false;
            bool DaysValid = false;
            int _Zip;

            // Name should not be empty
            if (string.IsNullOrEmpty(CustomerNameTextBox.Text))
            {
                NameValid = false;
                CustomerNameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                NameValid = true;
                CustomerNameTextBox.BackColor = Color.White;
            }

            // Address should not be empty
            if (string.IsNullOrEmpty(AddressTextBox.Text))
            {
                AddressValid = false;
                AddressTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                AddressValid = true;
                AddressTextBox.BackColor = Color.White;
            }

            // City should not be empty
            if (string.IsNullOrEmpty(CityTextBox.Text))
            {
                CityValid = false;
                CityTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                CityValid = true;
                CityTextBox.BackColor = Color.White;
            }

            // State is selected
            if (StateComboBox.SelectedIndex == 0)
            {
                StateValid = false;
                StateComboBox.BackColor = Color.LightYellow;
            }
            else if (StateComboBox.SelectedIndex != 0)
            {
                StateValid = true;
                StateComboBox.BackColor = Color.White;
            }

            // Zip Code is 5 numbers long AND not empty
            if (string.IsNullOrEmpty(ZipCodeTextBox.Text))
            {
                ZipValid = false;
                ZipCodeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    // Convert string to integer
                    _Zip = int.Parse(ZipCodeTextBox.Text);
                    if (ZipCodeTextBox.TextLength < 5)
                    {
                        ZipValid = false;
                        ZipCodeTextBox.BackColor = Color.LightYellow;
                    }
                    else
                    {
                        ZipValid = true;
                        ZipCodeTextBox.BackColor = Color.White;
                    }
                }
                catch (Exception)
                {
                    ZipValid = false;
                    ZipCodeTextBox.BackColor = Color.LightYellow;
                }
            }

            // Initial Odometer is a number AND not empty
            if (string.IsNullOrEmpty(InitialOdometerTextBox.Text))
            {
                Odo1Valid = false;
                InitialOdometerTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    // POTENTIAL BUG: May not convert correctly
                    double.Parse(InitialOdometerTextBox.Text);
                    Odo1Valid = true;
                    InitialOdometerTextBox.Text += InitOdometer;
                }
                catch (Exception)
                {
                    Odo1Valid = false;
                    InitialOdometerTextBox.BackColor = Color.LightYellow;
                }
            }

            // Final Odometer is a number AND not empty AND greater than the initial odometer
            if (string.IsNullOrEmpty(FinalOdometerTextBox.Text))
            {
                Odo2Valid = false;
                FinalOdometerTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    double.Parse(FinalOdometerTextBox.Text);
                    FinalOdometerTextBox.Text += FinalOdometer;
                    if (FinalOdometer < InitOdometer)
                    {
                        Odo2Valid = true;
                        FinalOdometerTextBox.BackColor = Color.White;
                    }
                    else
                    {
                        Odo2Valid = false;
                        FinalOdometerTextBox.BackColor = Color.LightYellow;
                    }
                }
                catch (Exception)
                {
                    Odo2Valid = false;
                    FinalOdometerTextBox.BackColor = Color.LightYellow;
                }
            }

            // Days are not empty and must be a number
            if (string.IsNullOrEmpty(DaysTextBox.Text))
            {
                DaysValid = false;
                DaysTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    double.Parse(DaysTextBox.Text);
                    DaysValid = true;
                    DaysTextBox.BackColor = Color.White;
                    Days = double.Parse(DaysTextBox.Text);
                }
                catch (Exception)
                {
                    DaysValid = false;
                    DaysTextBox.BackColor = Color.LightYellow;
                }
            }

            // All fields are valid
            if (NameValid && AddressValid && CityValid && StateValid && ZipValid && Odo1Valid && Odo2Valid && DaysValid)
            {
                allFieldsValid = true;
            }
            else
            {
                allFieldsValid = false;
            }
            return allFieldsValid;
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

            DailyChargeCalculator(); // Calculates daily charge
                        
            DistanceConverter(); // Convert km to mi

            RateCalculator(); // Calculate milage charge
                        
            Discounter(); // Calculate discount
        }

        private void DailyChargeCalculator()
        {
            DailyCharge = Days * 15;
        }

        private void DistanceConverter()
        {
            distance = FinalOdometer - InitOdometer;
            if (KM_RadioButton.Checked == true)
            {
                miles = distance * 0.62;
            }
            else if (MilesRadioButton.Checked == true)
            {
                miles = distance;
            }
            DistanceTextBox.Text = distance.ToString();
        }

        private void RateCalculator()
        {
            if (miles <= 200)
            {
                // First 200 miles are free!
            }
            else if (miles <= 500)
            {
                MileageChargeTextBox.Text = (miles * 0.1).ToString();
                Total = miles * 0.12;
            }
            else if (miles >= 500)
            {
                MileageChargeTextBox.Text = (miles * 0.1).ToString();
                Total = miles * 0.10;
            }
        }

        private void Discounter()
        {            
            DiscountedSenior();
            DiscountedMember();
            Discount = Discount1 + Discount2;   
        }

        private void DiscountedSenior()
        {
            if (SeniorDiscountCheckBox.Checked == true)
            {
                Discount1 = .03;
            }
            else
            {
                Discount1 = 0;
            }
        }

        private void DiscountedMember()
        {
            if (AAA_DiscountCheckBox.Checked == true)
            {
                Discount2 = .05;
            }
            else
            {
                Discount2 = 0;
            }
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