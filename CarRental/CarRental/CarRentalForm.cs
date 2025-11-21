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
        // Variables -------------------------------------------
        double distance = 0;
        double miles = 0;
        double InitOdometer = 0;
        double FinalOdometer = 0;
        double Days = 0;
        double DailyCharge = 0;
        double MileageCharge = 0;
        double Discount1 = 0;
        double Discount2 = 0;
        double Discount = 0;
        double NetTotal = 0;
        double Total = 0;
        bool allFieldsValid;

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

        private void ValidateInputs()
        {
            bool NameValid;
            bool AddressValid;
            bool CityValid;
            bool StateValid;
            bool ZipValid;
            bool Odo1Valid;
            bool Odo2Valid = false;
            bool DaysValid;
            int _Zip;

            // Name should not be empty
            if (string.IsNullOrEmpty(CustomerNameTextBox.Text) || string.IsNullOrWhiteSpace(CustomerNameTextBox.Text))
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
            if (string.IsNullOrEmpty(AddressTextBox.Text) || string.IsNullOrWhiteSpace(AddressTextBox.Text))
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
            if (string.IsNullOrEmpty(CityTextBox.Text) || string.IsNullOrWhiteSpace(CityTextBox.Text))
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
            if (StateComboBox.SelectedIndex <= 0)
            {
                StateValid = false;
                StateComboBox.BackColor = Color.LightYellow;
            }
            else
            {
                StateValid = true;
                StateComboBox.BackColor = Color.White;
            }

            // Zip Code is 5 numbers long AND not empty
            if (string.IsNullOrEmpty(ZipCodeTextBox.Text) || string.IsNullOrWhiteSpace(ZipCodeTextBox.Text))
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
            // BUG: Initial odometer input does not validate correctly
            if (string.IsNullOrEmpty(InitialOdometerTextBox.Text) || string.IsNullOrWhiteSpace(InitialOdometerTextBox.Text))
            {
                Odo1Valid = false;
                InitialOdometerTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                //InitOdometer = double.Parse(InitialOdometerTextBox.Text);
                try
                {
                        // POTENTIAL BUG: May not convert correctly
                    InitialOdometerTextBox.BackColor = Color.White;
                    InitOdometer = double.Parse(InitialOdometerTextBox.Text);
                    Odo1Valid = true;
                }
                catch (Exception)
                {
                    Odo1Valid = false;
                    InitialOdometerTextBox.BackColor = Color.LightYellow;
                }
            }

            // Final Odometer is a number AND not empty AND greater than the initial odometer
            if (string.IsNullOrEmpty(FinalOdometerTextBox.Text) || string.IsNullOrWhiteSpace(FinalOdometerTextBox.Text))
            {
                Odo2Valid = false;
                FinalOdometerTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    FinalOdometer = double.Parse(FinalOdometerTextBox.Text);
                    if (FinalOdometer >= InitOdometer)
                    {
                        Odo2Valid = true;
                        FinalOdometerTextBox.BackColor = Color.White;
                        //FinalOdometer = double.Parse(FinalOdometerTextBox.Text);
                    }
                    else if (FinalOdometer >= InitOdometer)
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

            // Days are not empty and must be a number greater than 0
            if (string.IsNullOrEmpty(DaysTextBox.Text) || string.IsNullOrWhiteSpace(DaysTextBox.Text))
            {
                DaysValid = false;
                DaysTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    double.Parse(DaysTextBox.Text);
                    Days = double.Parse(DaysTextBox.Text);
                    if (Days > 0)
                    {
                        DaysValid = true;
                        DaysTextBox.BackColor = Color.White;
                        Days = double.Parse(DaysTextBox.Text);
                    }
                    else
                    {
                        DaysValid = false;
                        DaysTextBox.BackColor = Color.LightYellow;
                    }
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
                CalculateButton.Enabled = true;
            }
            else
            {
                allFieldsValid = false;
                CalculateButton.Enabled = false;
            }
        }

        private void DailyChargeCalculator()
        {
            DailyCharge = Days * 15;
            DayChargeTextBox.Text = DailyCharge.ToString();
        }

        private void DistanceConverter()
        {
            distance = FinalOdometer - InitOdometer;
            if (KM_RadioButton.Checked == true && MilesRadioButton.Checked == false)
            {
                miles = (distance * 0.62);
            }
            else if (MilesRadioButton.Checked == true && KM_RadioButton.Checked == false)
            {
                miles = distance;
            }
            DistanceTextBox.Text = miles.ToString();

            RateCalculator(); // Calculates charge for mileage
        }

        private void RateCalculator()
        {
            if (miles <= 200)
            {
                // First 200 miles are free!
                MileageCharge = 0;
            }
            else if (miles <= 500)
            {
                MileageCharge = miles * 0.12;
            }
            else if (miles >= 500)
            {
                MileageCharge = miles * 0.10;
            }
            MileageChargeTextBox.Text = MileageCharge.ToString();
        }

        private void Discounter()
        {
            Total = DailyCharge + MileageCharge;

            DiscountedSenior();
            DiscountedMember();

            Discount = Total * (Discount1 + Discount2);
            CreditTextBox.Text = Discount.ToString();            
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

        private void TotalAmount()
        {
            NetTotal = Total - Discount;
            BalanceTotalTextBox.Text = NetTotal.ToString();
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

            DailyChargeCalculator(); // Calculates daily charge, ready to test
                        
            DistanceConverter(); // Convert km to mi, ready to test
                        
            Discounter(); // Calculate discount, ready to test

            TotalAmount();
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