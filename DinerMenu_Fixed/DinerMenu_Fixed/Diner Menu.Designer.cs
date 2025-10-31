namespace DinerMenu_Fixed
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            ExitButton = new Button();
            SoupButton = new Button();
            SaladButton = new Button();
            FishButton = new Button();
            DinerNameTextbox = new TextBox();
            MenuTopTextBox = new TextBox();
            MenuBottomTextBox = new TextBox();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 387);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "Exit interface");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(12, 387);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(112, 34);
            SoupButton.TabIndex = 1;
            SoupButton.Text = "Soup";
            toolTip1.SetToolTip(SoupButton, "Display Soup menu");
            SoupButton.UseVisualStyleBackColor = true;
            SoupButton.Click += SoupButton_Click;
            // 
            // SaladButton
            // 
            SaladButton.Location = new Point(177, 387);
            SaladButton.Name = "SaladButton";
            SaladButton.Size = new Size(112, 34);
            SaladButton.TabIndex = 2;
            SaladButton.Text = "Salad";
            toolTip1.SetToolTip(SaladButton, "Display Salad menu");
            SaladButton.UseVisualStyleBackColor = true;
            SaladButton.Click += SaladButton_Click;
            // 
            // FishButton
            // 
            FishButton.Location = new Point(340, 387);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(112, 34);
            FishButton.TabIndex = 3;
            FishButton.Text = "Fish";
            toolTip1.SetToolTip(FishButton, "Display Fish menu");
            FishButton.UseVisualStyleBackColor = true;
            FishButton.Click += FishButton_Click;
            // 
            // DinerNameTextbox
            // 
            DinerNameTextbox.BackColor = SystemColors.Menu;
            DinerNameTextbox.BorderStyle = BorderStyle.None;
            DinerNameTextbox.Font = new Font("Book Antiqua", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            DinerNameTextbox.Location = new Point(224, 12);
            DinerNameTextbox.Name = "DinerNameTextbox";
            DinerNameTextbox.Size = new Size(355, 37);
            DinerNameTextbox.TabIndex = 4;
            DinerNameTextbox.Text = "Ma & Pa's Corner Diner";
            DinerNameTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // MenuTopTextBox
            // 
            MenuTopTextBox.BackColor = SystemColors.Menu;
            MenuTopTextBox.BorderStyle = BorderStyle.None;
            MenuTopTextBox.Font = new Font("Book Antiqua", 12F, FontStyle.Bold | FontStyle.Italic);
            MenuTopTextBox.Location = new Point(224, 144);
            MenuTopTextBox.Name = "MenuTopTextBox";
            MenuTopTextBox.Size = new Size(355, 35);
            MenuTopTextBox.TabIndex = 5;
            MenuTopTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MenuBottomTextBox
            // 
            MenuBottomTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MenuBottomTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            MenuBottomTextBox.BackColor = SystemColors.Menu;
            MenuBottomTextBox.BorderStyle = BorderStyle.None;
            MenuBottomTextBox.Font = new Font("Book Antiqua", 12F, FontStyle.Italic);
            MenuBottomTextBox.Location = new Point(154, 252);
            MenuBottomTextBox.Name = "MenuBottomTextBox";
            MenuBottomTextBox.Size = new Size(500, 35);
            MenuBottomTextBox.TabIndex = 6;
            MenuBottomTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuBottomTextBox);
            Controls.Add(MenuTopTextBox);
            Controls.Add(DinerNameTextbox);
            Controls.Add(FishButton);
            Controls.Add(SaladButton);
            Controls.Add(SoupButton);
            Controls.Add(ExitButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ma & Pa's Corner Diner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Button ExitButton;
        private Button SoupButton;
        private Button SaladButton;
        private Button FishButton;
        private TextBox DinerNameTextbox;
        private TextBox MenuTopTextBox;
        private TextBox MenuBottomTextBox;
    }
}
