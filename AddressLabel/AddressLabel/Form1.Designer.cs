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
            CityLabel = new Label();
            StreetAddressLabel = new Label();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            AddressLabelGroupBox = new GroupBox();
            AddressLabelTextBox = new RichTextBox();
            StateLabel = new Label();
            ZipCodeLabel = new Label();
            MailingAddressGroupBox.SuspendLayout();
            AddressLabelGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTextBox.Location = new Point(24, 69);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(229, 31);
            FirstNameTextBox.TabIndex = 0;
            FirstNameTextBox.TextChanged += FirstNameTextBox_TextChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            LastNameTextBox.Location = new Point(24, 131);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(229, 31);
            LastNameTextBox.TabIndex = 1;
            LastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.BorderStyle = BorderStyle.FixedSingle;
            CityTextBox.Location = new Point(24, 255);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(229, 31);
            CityTextBox.TabIndex = 3;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // StreetAddressTextBox
            // 
            StreetAddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            StreetAddressTextBox.Location = new Point(24, 193);
            StreetAddressTextBox.Name = "StreetAddressTextBox";
            StreetAddressTextBox.Size = new Size(229, 31);
            StreetAddressTextBox.TabIndex = 2;
            StreetAddressTextBox.TextChanged += StreetAddressTextBox_TextChanged;
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.BorderStyle = BorderStyle.FixedSingle;
            ZipCodeTextBox.Location = new Point(24, 379);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(150, 31);
            ZipCodeTextBox.TabIndex = 5;
            ZipCodeTextBox.TextChanged += ZipCodeTextBox_TextChanged;
            // 
            // StateTextBox
            // 
            StateTextBox.BorderStyle = BorderStyle.FixedSingle;
            StateTextBox.Location = new Point(24, 317);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(150, 31);
            StateTextBox.TabIndex = 4;
            StateTextBox.TextChanged += StateTextBox_TextChanged;
            // 
            // DisplayLabelButton
            // 
            DisplayLabelButton.Location = new Point(310, 385);
            DisplayLabelButton.Name = "DisplayLabelButton";
            DisplayLabelButton.Size = new Size(148, 53);
            DisplayLabelButton.TabIndex = 6;
            DisplayLabelButton.Text = "Display Label";
            DisplayLabelButton.UseVisualStyleBackColor = true;
            DisplayLabelButton.Click += DisplayLabelButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(474, 385);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(148, 53);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(640, 385);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(148, 53);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MailingAddressGroupBox
            // 
            MailingAddressGroupBox.Controls.Add(ZipCodeLabel);
            MailingAddressGroupBox.Controls.Add(StateLabel);
            MailingAddressGroupBox.Controls.Add(CityLabel);
            MailingAddressGroupBox.Controls.Add(StreetAddressLabel);
            MailingAddressGroupBox.Controls.Add(LastNameLabel);
            MailingAddressGroupBox.Controls.Add(FirstNameLabel);
            MailingAddressGroupBox.Controls.Add(StateTextBox);
            MailingAddressGroupBox.Controls.Add(FirstNameTextBox);
            MailingAddressGroupBox.Controls.Add(ZipCodeTextBox);
            MailingAddressGroupBox.Controls.Add(LastNameTextBox);
            MailingAddressGroupBox.Controls.Add(StreetAddressTextBox);
            MailingAddressGroupBox.Controls.Add(CityTextBox);
            MailingAddressGroupBox.Location = new Point(12, 12);
            MailingAddressGroupBox.Name = "MailingAddressGroupBox";
            MailingAddressGroupBox.Size = new Size(279, 426);
            MailingAddressGroupBox.TabIndex = 9;
            MailingAddressGroupBox.TabStop = false;
            MailingAddressGroupBox.Text = "Mailing Address";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(24, 227);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 9;
            CityLabel.Text = "City";
            // 
            // StreetAddressLabel
            // 
            StreetAddressLabel.AutoSize = true;
            StreetAddressLabel.Location = new Point(24, 165);
            StreetAddressLabel.Name = "StreetAddressLabel";
            StreetAddressLabel.Size = new Size(127, 25);
            StreetAddressLabel.TabIndex = 8;
            StreetAddressLabel.Text = "Street Address";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(24, 103);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(95, 25);
            LastNameLabel.TabIndex = 7;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(24, 41);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(97, 25);
            FirstNameLabel.TabIndex = 6;
            FirstNameLabel.Text = "First Name";
            // 
            // AddressLabelGroupBox
            // 
            AddressLabelGroupBox.Controls.Add(AddressLabelTextBox);
            AddressLabelGroupBox.Location = new Point(310, 12);
            AddressLabelGroupBox.Name = "AddressLabelGroupBox";
            AddressLabelGroupBox.Size = new Size(478, 367);
            AddressLabelGroupBox.TabIndex = 10;
            AddressLabelGroupBox.TabStop = false;
            AddressLabelGroupBox.Text = "Address Label";
            // 
            // AddressLabelTextBox
            // 
            AddressLabelTextBox.Location = new Point(6, 30);
            AddressLabelTextBox.Name = "AddressLabelTextBox";
            AddressLabelTextBox.Size = new Size(466, 331);
            AddressLabelTextBox.TabIndex = 0;
            AddressLabelTextBox.Text = "";
            AddressLabelTextBox.TextChanged += AddressLabelTextBox_TextChanged;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(24, 289);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(51, 25);
            StateLabel.TabIndex = 10;
            StateLabel.Text = "State";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(24, 351);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(84, 25);
            ZipCodeLabel.TabIndex = 11;
            ZipCodeLabel.Text = "Zip Code";
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
            Controls.Add(MailingAddressGroupBox);
            Name = "Form1";
            Text = "Address Label Viewer";
            MailingAddressGroupBox.ResumeLayout(false);
            MailingAddressGroupBox.PerformLayout();
            AddressLabelGroupBox.ResumeLayout(false);
            ResumeLayout(false);
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
        private RichTextBox AddressLabelTextBox;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private Label StreetAddressLabel;
        private Label CityLabel;
        private Label StateLabel;
        private Label ZipCodeLabel;
    }
}
