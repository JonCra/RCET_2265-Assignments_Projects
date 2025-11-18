namespace CarRental
{
    partial class CarRentalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            ClearButton = new Button();
            SummaryButton = new Button();
            CalculateButton = new Button();
            button2 = new Button();
            SeniorDiscountCheckBox = new CheckBox();
            AAA_DiscountCheckBox = new CheckBox();
            KM_RadioButton = new RadioButton();
            MilesRadioButton = new RadioButton();
            DiscountGroupBox = new GroupBox();
            OdometerUnitGroupBox = new GroupBox();
            CustomerNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            CityTextBox = new TextBox();
            StateTextBox = new TextBox();
            ZipCodeTextBox = new TextBox();
            InitialOdometerTextBox = new TextBox();
            FinalOdometerTextBox = new TextBox();
            NumberOfDaysTextBox = new TextBox();
            CustomerInfoGroupBox = new GroupBox();
            DaysLabel = new Label();
            EndingOdometerLabel = new Label();
            label1 = new Label();
            ZipCodeLabel = new Label();
            StateLabel = new Label();
            CityLabel = new Label();
            AddressLabel = new Label();
            CustomerNameLabel = new Label();
            ResultGroupBox = new GroupBox();
            DistanceLabel = new Label();
            MileageChargeLabel = new Label();
            DayChargeLabel = new Label();
            DiscountLabel = new Label();
            BalanceTotalLabel = new Label();
            DistanceTextBox = new TextBox();
            MileageChargeTextBox = new TextBox();
            DayChargeTextBox = new TextBox();
            CreditTextBox = new TextBox();
            BalanceTotalTextBox = new TextBox();
            DiscountGroupBox.SuspendLayout();
            OdometerUnitGroupBox.SuspendLayout();
            CustomerInfoGroupBox.SuspendLayout();
            ResultGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(381, 571);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            toolTip1.SetToolTip(ClearButton, "Clear input fields");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(263, 571);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(112, 34);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            toolTip1.SetToolTip(SummaryButton, "Display summary and totals");
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(145, 571);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(112, 34);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Calculate";
            toolTip1.SetToolTip(CalculateButton, "Calculate total expenses");
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(499, 571);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            toolTip1.SetToolTip(button2, "Exit program");
            button2.UseVisualStyleBackColor = true;
            button2.Click += ExitButton_Click;
            // 
            // SeniorDiscountCheckBox
            // 
            SeniorDiscountCheckBox.AutoSize = true;
            SeniorDiscountCheckBox.Location = new Point(34, 95);
            SeniorDiscountCheckBox.Name = "SeniorDiscountCheckBox";
            SeniorDiscountCheckBox.Size = new Size(227, 29);
            SeniorDiscountCheckBox.TabIndex = 1;
            SeniorDiscountCheckBox.Text = "Senior Citizen Checkbox";
            toolTip1.SetToolTip(SeniorDiscountCheckBox, "3% Discount for Senior Citizens");
            SeniorDiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // AAA_DiscountCheckBox
            // 
            AAA_DiscountCheckBox.AutoSize = true;
            AAA_DiscountCheckBox.Location = new Point(35, 46);
            AAA_DiscountCheckBox.Name = "AAA_DiscountCheckBox";
            AAA_DiscountCheckBox.Size = new Size(149, 29);
            AAA_DiscountCheckBox.TabIndex = 0;
            AAA_DiscountCheckBox.Text = "AAA Discount";
            toolTip1.SetToolTip(AAA_DiscountCheckBox, "5% Discount for AAA members");
            AAA_DiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // KM_RadioButton
            // 
            KM_RadioButton.AutoSize = true;
            KM_RadioButton.Location = new Point(38, 95);
            KM_RadioButton.Name = "KM_RadioButton";
            KM_RadioButton.Size = new Size(120, 29);
            KM_RadioButton.TabIndex = 1;
            KM_RadioButton.TabStop = true;
            KM_RadioButton.Text = "Kilometers";
            toolTip1.SetToolTip(KM_RadioButton, "Odometer display is in \"km\"");
            KM_RadioButton.UseVisualStyleBackColor = true;
            // 
            // MilesRadioButton
            // 
            MilesRadioButton.AutoSize = true;
            MilesRadioButton.Checked = true;
            MilesRadioButton.Location = new Point(38, 46);
            MilesRadioButton.Name = "MilesRadioButton";
            MilesRadioButton.Size = new Size(78, 29);
            MilesRadioButton.TabIndex = 0;
            MilesRadioButton.TabStop = true;
            MilesRadioButton.Text = "Miles";
            toolTip1.SetToolTip(MilesRadioButton, "Odometer display is in \"mi\"");
            MilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // DiscountGroupBox
            // 
            DiscountGroupBox.Controls.Add(SeniorDiscountCheckBox);
            DiscountGroupBox.Controls.Add(AAA_DiscountCheckBox);
            DiscountGroupBox.Location = new Point(426, 396);
            DiscountGroupBox.Name = "DiscountGroupBox";
            DiscountGroupBox.Size = new Size(300, 150);
            DiscountGroupBox.TabIndex = 4;
            DiscountGroupBox.TabStop = false;
            DiscountGroupBox.Text = "Discounts";
            // 
            // OdometerUnitGroupBox
            // 
            OdometerUnitGroupBox.Controls.Add(KM_RadioButton);
            OdometerUnitGroupBox.Controls.Add(MilesRadioButton);
            OdometerUnitGroupBox.Location = new Point(79, 396);
            OdometerUnitGroupBox.Name = "OdometerUnitGroupBox";
            OdometerUnitGroupBox.Size = new Size(261, 150);
            OdometerUnitGroupBox.TabIndex = 5;
            OdometerUnitGroupBox.TabStop = false;
            OdometerUnitGroupBox.Text = "Odometer Measurement Unit";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(267, 44);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(150, 31);
            CustomerNameTextBox.TabIndex = 6;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(267, 81);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(150, 31);
            AddressTextBox.TabIndex = 7;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(266, 118);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(150, 31);
            CityTextBox.TabIndex = 8;
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(267, 155);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(150, 31);
            StateTextBox.TabIndex = 9;
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Location = new Point(266, 192);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(150, 31);
            ZipCodeTextBox.TabIndex = 10;
            // 
            // InitialOdometerTextBox
            // 
            InitialOdometerTextBox.Location = new Point(266, 229);
            InitialOdometerTextBox.Name = "InitialOdometerTextBox";
            InitialOdometerTextBox.Size = new Size(150, 31);
            InitialOdometerTextBox.TabIndex = 11;
            // 
            // FinalOdometerTextBox
            // 
            FinalOdometerTextBox.Location = new Point(266, 266);
            FinalOdometerTextBox.Name = "FinalOdometerTextBox";
            FinalOdometerTextBox.Size = new Size(150, 31);
            FinalOdometerTextBox.TabIndex = 12;
            // 
            // NumberOfDaysTextBox
            // 
            NumberOfDaysTextBox.Location = new Point(266, 303);
            NumberOfDaysTextBox.Name = "NumberOfDaysTextBox";
            NumberOfDaysTextBox.Size = new Size(150, 31);
            NumberOfDaysTextBox.TabIndex = 13;
            // 
            // CustomerInfoGroupBox
            // 
            CustomerInfoGroupBox.Controls.Add(DaysLabel);
            CustomerInfoGroupBox.Controls.Add(EndingOdometerLabel);
            CustomerInfoGroupBox.Controls.Add(label1);
            CustomerInfoGroupBox.Controls.Add(ZipCodeLabel);
            CustomerInfoGroupBox.Controls.Add(StateLabel);
            CustomerInfoGroupBox.Controls.Add(CityLabel);
            CustomerInfoGroupBox.Controls.Add(AddressLabel);
            CustomerInfoGroupBox.Controls.Add(CustomerNameLabel);
            CustomerInfoGroupBox.Controls.Add(NumberOfDaysTextBox);
            CustomerInfoGroupBox.Controls.Add(CustomerNameTextBox);
            CustomerInfoGroupBox.Controls.Add(FinalOdometerTextBox);
            CustomerInfoGroupBox.Controls.Add(AddressTextBox);
            CustomerInfoGroupBox.Controls.Add(InitialOdometerTextBox);
            CustomerInfoGroupBox.Controls.Add(CityTextBox);
            CustomerInfoGroupBox.Controls.Add(ZipCodeTextBox);
            CustomerInfoGroupBox.Controls.Add(StateTextBox);
            CustomerInfoGroupBox.Location = new Point(12, 12);
            CustomerInfoGroupBox.Name = "CustomerInfoGroupBox";
            CustomerInfoGroupBox.Size = new Size(435, 361);
            CustomerInfoGroupBox.TabIndex = 14;
            CustomerInfoGroupBox.TabStop = false;
            CustomerInfoGroupBox.Text = "Customer Information";
            // 
            // DaysLabel
            // 
            DaysLabel.AutoSize = true;
            DaysLabel.Location = new Point(6, 306);
            DaysLabel.Name = "DaysLabel";
            DaysLabel.Size = new Size(143, 25);
            DaysLabel.TabIndex = 21;
            DaysLabel.Text = "Number of Days";
            // 
            // EndingOdometerLabel
            // 
            EndingOdometerLabel.AutoSize = true;
            EndingOdometerLabel.Location = new Point(6, 269);
            EndingOdometerLabel.Name = "EndingOdometerLabel";
            EndingOdometerLabel.Size = new Size(223, 25);
            EndingOdometerLabel.TabIndex = 20;
            EndingOdometerLabel.Text = "Ending Odometer Reading";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 232);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 19;
            label1.Text = "Beginning Odometer Reading";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(6, 195);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(84, 25);
            ZipCodeLabel.TabIndex = 18;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(6, 158);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(51, 25);
            StateLabel.TabIndex = 17;
            StateLabel.Text = "State";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(6, 121);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 16;
            CityLabel.Text = "City";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(6, 84);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(77, 25);
            AddressLabel.TabIndex = 15;
            AddressLabel.Text = "Address";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(6, 47);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(141, 25);
            CustomerNameLabel.TabIndex = 14;
            CustomerNameLabel.Text = "Customer Name";
            // 
            // ResultGroupBox
            // 
            ResultGroupBox.Controls.Add(BalanceTotalTextBox);
            ResultGroupBox.Controls.Add(CreditTextBox);
            ResultGroupBox.Controls.Add(DayChargeTextBox);
            ResultGroupBox.Controls.Add(MileageChargeTextBox);
            ResultGroupBox.Controls.Add(DistanceTextBox);
            ResultGroupBox.Controls.Add(BalanceTotalLabel);
            ResultGroupBox.Controls.Add(DiscountLabel);
            ResultGroupBox.Controls.Add(DayChargeLabel);
            ResultGroupBox.Controls.Add(MileageChargeLabel);
            ResultGroupBox.Controls.Add(DistanceLabel);
            ResultGroupBox.Location = new Point(453, 93);
            ResultGroupBox.Name = "ResultGroupBox";
            ResultGroupBox.Size = new Size(335, 239);
            ResultGroupBox.TabIndex = 15;
            ResultGroupBox.TabStop = false;
            ResultGroupBox.Text = "Results";
            // 
            // DistanceLabel
            // 
            DistanceLabel.AutoSize = true;
            DistanceLabel.Location = new Point(6, 47);
            DistanceLabel.Name = "DistanceLabel";
            DistanceLabel.Size = new Size(144, 25);
            DistanceLabel.TabIndex = 0;
            DistanceLabel.Text = "Distance in Miles";
            // 
            // MileageChargeLabel
            // 
            MileageChargeLabel.AutoSize = true;
            MileageChargeLabel.Location = new Point(6, 84);
            MileageChargeLabel.Name = "MileageChargeLabel";
            MileageChargeLabel.Size = new Size(135, 25);
            MileageChargeLabel.TabIndex = 1;
            MileageChargeLabel.Text = "Mileage Charge";
            // 
            // DayChargeLabel
            // 
            DayChargeLabel.AutoSize = true;
            DayChargeLabel.Location = new Point(6, 121);
            DayChargeLabel.Name = "DayChargeLabel";
            DayChargeLabel.Size = new Size(104, 25);
            DayChargeLabel.TabIndex = 2;
            DayChargeLabel.Text = "Day Charge";
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(6, 158);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(134, 25);
            DiscountLabel.TabIndex = 3;
            DiscountLabel.Text = "Discount Credit";
            // 
            // BalanceTotalLabel
            // 
            BalanceTotalLabel.AutoSize = true;
            BalanceTotalLabel.Location = new Point(6, 195);
            BalanceTotalLabel.Name = "BalanceTotalLabel";
            BalanceTotalLabel.Size = new Size(113, 25);
            BalanceTotalLabel.TabIndex = 4;
            BalanceTotalLabel.Text = "Balance Total";
            // 
            // DistanceTextBox
            // 
            DistanceTextBox.Location = new Point(179, 47);
            DistanceTextBox.Name = "DistanceTextBox";
            DistanceTextBox.Size = new Size(150, 31);
            DistanceTextBox.TabIndex = 5;
            // 
            // MileageChargeTextBox
            // 
            MileageChargeTextBox.Location = new Point(179, 84);
            MileageChargeTextBox.Name = "MileageChargeTextBox";
            MileageChargeTextBox.Size = new Size(150, 31);
            MileageChargeTextBox.TabIndex = 6;
            // 
            // DayChargeTextBox
            // 
            DayChargeTextBox.Location = new Point(179, 121);
            DayChargeTextBox.Name = "DayChargeTextBox";
            DayChargeTextBox.Size = new Size(150, 31);
            DayChargeTextBox.TabIndex = 7;
            // 
            // CreditTextBox
            // 
            CreditTextBox.Location = new Point(179, 158);
            CreditTextBox.Name = "CreditTextBox";
            CreditTextBox.Size = new Size(150, 31);
            CreditTextBox.TabIndex = 8;
            // 
            // BalanceTotalTextBox
            // 
            BalanceTotalTextBox.Location = new Point(179, 195);
            BalanceTotalTextBox.Name = "BalanceTotalTextBox";
            BalanceTotalTextBox.Size = new Size(150, 31);
            BalanceTotalTextBox.TabIndex = 9;
            // 
            // CarRentalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(ResultGroupBox);
            Controls.Add(CustomerInfoGroupBox);
            Controls.Add(OdometerUnitGroupBox);
            Controls.Add(DiscountGroupBox);
            Controls.Add(button2);
            Controls.Add(SummaryButton);
            Controls.Add(CalculateButton);
            Controls.Add(ClearButton);
            Name = "CarRentalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Hacks";
            DiscountGroupBox.ResumeLayout(false);
            DiscountGroupBox.PerformLayout();
            OdometerUnitGroupBox.ResumeLayout(false);
            OdometerUnitGroupBox.PerformLayout();
            CustomerInfoGroupBox.ResumeLayout(false);
            CustomerInfoGroupBox.PerformLayout();
            ResultGroupBox.ResumeLayout(false);
            ResultGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private Button ClearButton;
        private Button SummaryButton;
        private Button CalculateButton;
        private Button button2;
        private GroupBox DiscountGroupBox;
        private CheckBox SeniorDiscountCheckBox;
        private CheckBox AAA_DiscountCheckBox;
        private GroupBox OdometerUnitGroupBox;
        private RadioButton MilesRadioButton;
        private RadioButton KM_RadioButton;
        private TextBox CustomerNameTextBox;
        private TextBox AddressTextBox;
        private TextBox CityTextBox;
        private TextBox StateTextBox;
        private TextBox ZipCodeTextBox;
        private TextBox InitialOdometerTextBox;
        private TextBox FinalOdometerTextBox;
        private TextBox NumberOfDaysTextBox;
        private GroupBox CustomerInfoGroupBox;
        private GroupBox ResultGroupBox;
        private Label CustomerNameLabel;
        private Label CityLabel;
        private Label AddressLabel;
        private Label label1;
        private Label ZipCodeLabel;
        private Label StateLabel;
        private Label EndingOdometerLabel;
        private Label DaysLabel;
        private Label MileageChargeLabel;
        private Label DistanceLabel;
        private Label BalanceTotalLabel;
        private Label DiscountLabel;
        private Label DayChargeLabel;
        private TextBox BalanceTotalTextBox;
        private TextBox CreditTextBox;
        private TextBox DayChargeTextBox;
        private TextBox MileageChargeTextBox;
        private TextBox DistanceTextBox;
    }
}
