/*
 * Jonas Cram
 * RCET 2265
 * Robotics and Comm. Systems Engineering Technology
 * Fall 2025
 */
using System.Numerics;
namespace CarRental
{
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
        int customers = 0;
        double totalMileage = 0;
        double totalCharges = 0;

        // Validator Variables:
        bool NameValid;
        bool AddressValid;
        bool CityValid;
        bool StateValid;
        bool ZipValid;
        bool Odo1Valid;
        bool Odo2Valid = false;
        bool DaysValid;

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
                CreditTextBox.Enabled = BalanceTotalTextBox.Enabled = SummaryButton.Enabled = false;

            // Loads blank text / empty for the following:
            CustomerNameTextBox.Text = AddressTextBox.Text = CityTextBox.Text = ZipCodeTextBox.Text =
                InitialOdometerTextBox.Text = FinalOdometerTextBox.Text = DaysTextBox.Text = "";

            DistanceTextBox.Text = MileageChargeTextBox.Text = DayChargeTextBox.Text =
                CreditTextBox.Text = BalanceTotalTextBox.Text = "";

            StateComboBox.SelectedIndex = 0;
            StateComboBox.BackColor = Color.White;
        }

        // User-Input Validators:
        private void NameIsValid()
        {
            // Name should not be empty
            if (string.IsNullOrEmpty(CustomerNameTextBox.Text) || string.IsNullOrWhiteSpace(CustomerNameTextBox.Text))
            {
                NameValid = false;
                CustomerNameTextBox.BackColor = Color.LightYellow;
                CustomerNameTextBox.Focus();
            }
            else
            {
                NameValid = true;
                CustomerNameTextBox.BackColor = Color.White;
            }
            ValidateInputs();
        }

        private void AddressIsValid()
        {
            // Address should not be empty
            if (string.IsNullOrEmpty(AddressTextBox.Text) || string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                AddressValid = false;
                AddressTextBox.BackColor = Color.LightYellow;
                AddressTextBox.Focus();
            }
            else
            {
                AddressValid = true;
                AddressTextBox.BackColor = Color.White;
            }
            ValidateInputs();
        }

        private void CityIsValid()
        {
            // City should not be empty
            if (string.IsNullOrEmpty(CityTextBox.Text) || string.IsNullOrWhiteSpace(CityTextBox.Text))
            {
                CityValid = false;
                CityTextBox.BackColor = Color.LightYellow;
                CityTextBox.Focus();
            }
            else
            {
                CityValid = true;
                CityTextBox.BackColor = Color.White;
            }
            ValidateInputs();
        }

        private void StateIsValid()
        {
            // State is selected
            if (StateComboBox.SelectedIndex <= 0)
            {
                StateValid = false;
                StateComboBox.BackColor = Color.LightYellow;
                StateComboBox.Focus();
            }
            else
            {
                StateValid = true;
                StateComboBox.BackColor = Color.White;
            }
            ValidateInputs();
        }

        private void ZipIsValid()
        {
            int _Zip; 
            
            // Zip Code is 5 numbers long AND not empty
            if (string.IsNullOrEmpty(ZipCodeTextBox.Text) || string.IsNullOrWhiteSpace(ZipCodeTextBox.Text))
            {
                ZipValid = false;
                ZipCodeTextBox.BackColor = Color.LightYellow;
                ZipCodeTextBox.Focus();
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
            ValidateInputs();
        }

        private void InitOdoIsValid()
        {
            // Initial Odometer is a number AND not empty
            if (string.IsNullOrEmpty(InitialOdometerTextBox.Text) || string.IsNullOrWhiteSpace(InitialOdometerTextBox.Text))
            {
                Odo1Valid = false;
                InitialOdometerTextBox.BackColor = Color.LightYellow;
                InitialOdometerTextBox.Focus();
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
                    InitialOdometerTextBox.Focus();
                }
            }
            ValidateInputs();
        }

        private void FinalOdoIsValid()
        {
            // Final Odometer is a number AND not empty AND greater than the initial odometer
            if (string.IsNullOrEmpty(FinalOdometerTextBox.Text) || string.IsNullOrWhiteSpace(FinalOdometerTextBox.Text))
            {
                Odo2Valid = false;
                FinalOdometerTextBox.BackColor = Color.LightYellow;
                FinalOdometerTextBox.Focus();
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
                        FinalOdometerTextBox.Focus();
                    }
                }
                catch (Exception)
                {
                    Odo2Valid = false;
                    FinalOdometerTextBox.BackColor = Color.LightYellow;
                    FinalOdometerTextBox.Focus();
                }
            }
            ValidateInputs();
        }

        private void DaysAreValid()
        {
            // Days are not empty and 0 < Days <= 45
            if (string.IsNullOrEmpty(DaysTextBox.Text) || string.IsNullOrWhiteSpace(DaysTextBox.Text))
            {
                DaysValid = false;
                DaysTextBox.BackColor = Color.LightYellow;
                DaysTextBox.Focus();
            }
            else
            {
                try
                {
                    double.Parse(DaysTextBox.Text);
                    Days = double.Parse(DaysTextBox.Text);
                    if (Days > 0 && Days <= 45)
                    {
                        DaysValid = true;
                        DaysTextBox.BackColor = Color.White;
                        Days = double.Parse(DaysTextBox.Text);
                    }
                    else
                    {
                        DaysValid = false;
                        DaysTextBox.BackColor = Color.LightYellow;
                        DaysTextBox.Focus();
                    }
                }
                catch (Exception)
                {
                    DaysValid = false;
                    DaysTextBox.BackColor = Color.LightYellow;
                    DaysTextBox.Focus();
                }
            }
            ValidateInputs();
        }

        private void ValidateInputs()
        {
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
                ValidateAll();
            }
        }

        private void ValidateAll()
        {
            // Triggers when the days input has changed, to ensure all fields are valid
            NameIsValid();
            AddressIsValid();
            CityIsValid();
            StateIsValid();
            ZipIsValid();
            InitOdoIsValid();
            FinalOdoIsValid();
            DaysAreValid();
            ValidateInputs();
        }

        // Calculation Logic:
        private void DailyChargeCalculator()
        {
            DailyCharge = Days * 15;
            DayChargeTextBox.Text = DailyCharge.ToString("C2");
        }

        private void DistanceConverter()
        {
            distance = FinalOdometer - InitOdometer;
            if (KM_RadioButton.Checked == true && MilesRadioButton.Checked == false)
            {
                miles = (distance * 0.62);
                Math.Round(miles, 2);
            }
            else if (MilesRadioButton.Checked == true && KM_RadioButton.Checked == false)
            {
                miles = distance;
            }
            Math.Round(miles, 2);
            DistanceTextBox.Text = miles.ToString("N2");
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
                Math.Round(MileageCharge, 2);
            }
            else if (miles >= 500)
            {
                MileageCharge = miles * 0.10;
                Math.Round(MileageCharge, 2);
            }
            Math.Round(MileageCharge, 2);
            MileageChargeTextBox.Text = MileageCharge.ToString("C2");
        }

        private void Discounter()
        {
            Total = DailyCharge + MileageCharge;

            DiscountedSenior();
            DiscountedMember();

            Discount = Total * (Discount1 + Discount2);
            Math.Round(Discount, 2);
            CreditTextBox.Text = Discount.ToString("C2");            
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
            Math.Round(NetTotal, 2);
            BalanceTotalTextBox.Text = NetTotal.ToString("C2");
        }

        private void SummaryTally()
        {
            MessageBox.Show($"Total Customers: {customers}\n" +
                $"Total Mileage: {totalMileage.ToString("N2")} mi\n" +
                $"Total Charges: ${totalCharges.ToString("C2")}", "Transaction Summary");
        }

        // Event Handlers ----------------------------------------

        // User-input Field Validation Triggers:
        private void NameChanged(object sender, EventArgs e)
        {
            NameIsValid();
        }

        private void AddressChanged(object sender, EventArgs e)
        {
            AddressIsValid();
        }

        private void CityChanged(object sender, EventArgs e)
        {
            CityIsValid();
        }

        private void StateChanged(object sender, EventArgs e)
        {
            StateIsValid();
        }

        private void ZipChanged(object sender, EventArgs e)
        {
            ZipIsValid();
        }

        private void InitOdoChanged(object sender, EventArgs e)
        {
            InitOdoIsValid();
        }

        private void FinalOdoChanged(object sender, EventArgs e)
        {
            FinalOdoIsValid();
        }

        private void DaysChanged(object sender, EventArgs e)
        {
            DaysAreValid();
        }

        // Button Events:
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateButton.Enabled = false;

            DailyChargeCalculator(); // Calculates daily charge
                        
            DistanceConverter(); // Convert km to mi
                        
            Discounter(); // Calculate discount

            TotalAmount();

            customers++;

            totalMileage += miles;

            totalCharges += NetTotal;

            SummaryButton.Enabled = true;
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
            SummaryTally();
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
    }
}