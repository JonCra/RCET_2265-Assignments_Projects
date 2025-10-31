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
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 387);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
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
            FishButton.UseVisualStyleBackColor = true;
            FishButton.Click += FishButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FishButton);
            Controls.Add(SaladButton);
            Controls.Add(SoupButton);
            Controls.Add(ExitButton);
            Name = "Form1";
            Text = "Ma & Pa's Corner Diner";
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private Button ExitButton;
        private Button SoupButton;
        private Button SaladButton;
        private Button FishButton;
    }
}
