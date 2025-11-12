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
            DiscountGroupBox = new GroupBox();
            AAA_DiscountCheckBox = new CheckBox();
            SeniorDiscountCheckBox = new CheckBox();
            OdometerUnitGroupBox = new GroupBox();
            DiscountGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(380, 459);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
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
            button2.UseVisualStyleBackColor = true;
            button2.Click += ExitButton_Click;
            // 
            // DiscountGroupBox
            // 
            DiscountGroupBox.Controls.Add(SeniorDiscountCheckBox);
            DiscountGroupBox.Controls.Add(AAA_DiscountCheckBox);
            DiscountGroupBox.Location = new Point(488, 158);
            DiscountGroupBox.Name = "DiscountGroupBox";
            DiscountGroupBox.Size = new Size(300, 150);
            DiscountGroupBox.TabIndex = 4;
            DiscountGroupBox.TabStop = false;
            DiscountGroupBox.Text = "Discounts";
            // 
            // AAA_DiscountCheckBox
            // 
            AAA_DiscountCheckBox.AutoSize = true;
            AAA_DiscountCheckBox.Location = new Point(35, 38);
            AAA_DiscountCheckBox.Name = "AAA_DiscountCheckBox";
            AAA_DiscountCheckBox.Size = new Size(149, 29);
            AAA_DiscountCheckBox.TabIndex = 0;
            AAA_DiscountCheckBox.Text = "AAA Discount";
            AAA_DiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // SeniorDiscountCheckBox
            // 
            SeniorDiscountCheckBox.AutoSize = true;
            SeniorDiscountCheckBox.Location = new Point(34, 87);
            SeniorDiscountCheckBox.Name = "SeniorDiscountCheckBox";
            SeniorDiscountCheckBox.Size = new Size(227, 29);
            SeniorDiscountCheckBox.TabIndex = 1;
            SeniorDiscountCheckBox.Text = "Senior Citizen Checkbox";
            SeniorDiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // OdometerUnitGroupBox
            // 
            OdometerUnitGroupBox.Location = new Point(34, 218);
            OdometerUnitGroupBox.Name = "OdometerUnitGroupBox";
            OdometerUnitGroupBox.Size = new Size(339, 150);
            OdometerUnitGroupBox.TabIndex = 5;
            OdometerUnitGroupBox.TabStop = false;
            OdometerUnitGroupBox.Text = "Is Odometer in Miles or Kilometers?";
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
    }
}
