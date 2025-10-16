namespace AddressLabel
{
    partial class Form1
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
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            CityTextBox = new TextBox();
            StreetAddressTextBox = new TextBox();
            ZipCodeTextBox = new TextBox();
            StateTextBox = new TextBox();
            DisplayLabelButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            MailingAddressGroupBox = new GroupBox();
            AddressLabelGroupBox = new GroupBox();
            SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTextBox.Location = new Point(70, 74);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(150, 31);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            LastNameTextBox.Location = new Point(70, 111);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(150, 31);
            LastNameTextBox.TabIndex = 1;
            // 
            // CityTextBox
            // 
            CityTextBox.BorderStyle = BorderStyle.FixedSingle;
            CityTextBox.Location = new Point(70, 212);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(150, 31);
            CityTextBox.TabIndex = 3;
            // 
            // StreetAddressTextBox
            // 
            StreetAddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            StreetAddressTextBox.Location = new Point(70, 164);
            StreetAddressTextBox.Name = "StreetAddressTextBox";
            StreetAddressTextBox.Size = new Size(150, 31);
            StreetAddressTextBox.TabIndex = 2;
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.BorderStyle = BorderStyle.FixedSingle;
            ZipCodeTextBox.Location = new Point(70, 320);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(150, 31);
            ZipCodeTextBox.TabIndex = 5;
            // 
            // StateTextBox
            // 
            StateTextBox.BorderStyle = BorderStyle.FixedSingle;
            StateTextBox.Location = new Point(70, 283);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(150, 31);
            StateTextBox.TabIndex = 4;
            // 
            // DisplayLabelButton
            // 
            DisplayLabelButton.Location = new Point(310, 385);
            DisplayLabelButton.Name = "DisplayLabelButton";
            DisplayLabelButton.Size = new Size(148, 53);
            DisplayLabelButton.TabIndex = 6;
            DisplayLabelButton.Text = "Display Label";
            DisplayLabelButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(474, 385);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(148, 53);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(640, 385);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(148, 53);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // MailingAddressGroupBox
            // 
            MailingAddressGroupBox.Location = new Point(27, 47);
            MailingAddressGroupBox.Name = "MailingAddressGroupBox";
            MailingAddressGroupBox.Size = new Size(264, 366);
            MailingAddressGroupBox.TabIndex = 9;
            MailingAddressGroupBox.TabStop = false;
            MailingAddressGroupBox.Text = "Mailing Address";
            // 
            // AddressLabelGroupBox
            // 
            AddressLabelGroupBox.Location = new Point(310, 47);
            AddressLabelGroupBox.Name = "AddressLabelGroupBox";
            AddressLabelGroupBox.Size = new Size(478, 332);
            AddressLabelGroupBox.TabIndex = 10;
            AddressLabelGroupBox.TabStop = false;
            AddressLabelGroupBox.Text = "Address Label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddressLabelGroupBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayLabelButton);
            Controls.Add(ZipCodeTextBox);
            Controls.Add(StateTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(StreetAddressTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(MailingAddressGroupBox);
            Name = "Form1";
            Text = "Address Label Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox CityTextBox;
        private TextBox StreetAddressTextBox;
        private TextBox ZipCodeTextBox;
        private TextBox StateTextBox;
        private Button DisplayLabelButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox MailingAddressGroupBox;
        private GroupBox AddressLabelGroupBox;
    }
}
