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
            DiscountGroupBox.SuspendLayout();
            OdometerUnitGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(380, 459);
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
            SummaryButton.Location = new Point(262, 459);
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
            CalculateButton.Location = new Point(144, 459);
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
            button2.Location = new Point(498, 459);
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
            DiscountGroupBox.Location = new Point(417, 283);
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
            OdometerUnitGroupBox.Location = new Point(49, 283);
            OdometerUnitGroupBox.Name = "OdometerUnitGroupBox";
            OdometerUnitGroupBox.Size = new Size(261, 150);
            OdometerUnitGroupBox.TabIndex = 5;
            OdometerUnitGroupBox.TabStop = false;
            OdometerUnitGroupBox.Text = "Odometer Measurement Unit";
            // 
            // CarRentalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(OdometerUnitGroupBox);
            Controls.Add(DiscountGroupBox);
            Controls.Add(button2);
            Controls.Add(SummaryButton);
            Controls.Add(CalculateButton);
            Controls.Add(ClearButton);
            Name = "CarRentalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            DiscountGroupBox.ResumeLayout(false);
            DiscountGroupBox.PerformLayout();
            OdometerUnitGroupBox.ResumeLayout(false);
            OdometerUnitGroupBox.PerformLayout();
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
    }
}
