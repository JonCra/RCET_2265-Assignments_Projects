namespace RollOfTheDice_ListBox
{
    partial class RollOfTheDiceForm
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ClearButton = new Button();
            ExitButton = new Button();
            RollButton = new Button();
            DisplayRichTextBox = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(464, 381);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(137, 57);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(651, 381);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(137, 57);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // RollButton
            // 
            RollButton.Location = new Point(278, 381);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(137, 57);
            RollButton.TabIndex = 3;
            RollButton.Text = "&Roll";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // DisplayRichTextBox
            // 
            DisplayRichTextBox.BorderStyle = BorderStyle.None;
            DisplayRichTextBox.Location = new Point(12, 36);
            DisplayRichTextBox.Name = "DisplayRichTextBox";
            DisplayRichTextBox.Size = new Size(776, 339);
            DisplayRichTextBox.TabIndex = 0;
            DisplayRichTextBox.Text = "";
            // 
            // RollOfTheDiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayRichTextBox);
            Controls.Add(RollButton);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "RollOfTheDiceForm";
            Text = "Roll of the Dice";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button ClearButton;
        private Button ExitButton;
        private Button RollButton;
        private RichTextBox DisplayRichTextBox;
    }
}
