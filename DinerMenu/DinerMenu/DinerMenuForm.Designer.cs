namespace DinerMenu
{
    partial class DinerMenuForm
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
            SoupButton = new Button();
            SaladButton = new Button();
            FishButton = new Button();
            ExitButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(134, 559);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(112, 34);
            SoupButton.TabIndex = 1;
            SoupButton.Text = "Soup";
            toolTip1.SetToolTip(SoupButton, "Soup of the Day");
            SoupButton.UseVisualStyleBackColor = true;
            // 
            // SaladButton
            // 
            SaladButton.Location = new Point(325, 559);
            SaladButton.Name = "SaladButton";
            SaladButton.Size = new Size(112, 34);
            SaladButton.TabIndex = 2;
            SaladButton.Text = "Salad";
            toolTip1.SetToolTip(SaladButton, "Chef's Salad");
            SaladButton.UseVisualStyleBackColor = true;
            // 
            // FishButton
            // 
            FishButton.Location = new Point(512, 559);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(112, 34);
            FishButton.TabIndex = 3;
            FishButton.Text = "Fish";
            toolTip1.SetToolTip(FishButton, "Fresh Fish");
            FishButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(690, 559);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            toolTip1.SetToolTip(ExitButton, "Exit the program");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DinerMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 605);
            Controls.Add(ExitButton);
            Controls.Add(FishButton);
            Controls.Add(SaladButton);
            Controls.Add(SoupButton);
            Name = "DinerMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button SoupButton;
        private Button SaladButton;
        private Button FishButton;
        private Button ExitButton;
        private ToolTip toolTip1;
    }
}
