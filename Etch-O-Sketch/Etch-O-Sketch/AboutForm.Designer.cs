namespace Etch_O_Sketch
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CloseButton = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(278, 404);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(112, 34);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(378, 386);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Coded by Jonas Cram\nFall Semester 2025\nRobotics and Communication Systems Engineering Technology (RCET)\nCollege of Technology\nIdaho State University";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
            Controls.Add(richTextBox1);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private RichTextBox richTextBox1;
    }
}