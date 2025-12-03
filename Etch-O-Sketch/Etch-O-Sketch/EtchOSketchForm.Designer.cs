namespace Etch_O_Sketch
{
    partial class EtchOSketchForm
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
            DisplayPictureBox = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            hToolStripMenuItem = new ToolStripMenuItem();
            selectColorToolStripMenuItem = new ToolStripMenuItem();
            drawWaveformsToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ColorButton = new Button();
            WaveformButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            toolTip1 = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Location = new Point(12, 36);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(784, 356);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            toolTip1.SetToolTip(DisplayPictureBox, "Draw here!");
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, hToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitProgram;
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectColorToolStripMenuItem, drawWaveformsToolStripMenuItem, clearToolStripMenuItem });
            hToolStripMenuItem.Name = "hToolStripMenuItem";
            hToolStripMenuItem.Size = new Size(58, 29);
            hToolStripMenuItem.Text = "&Edit";
            // 
            // selectColorToolStripMenuItem
            // 
            selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            selectColorToolStripMenuItem.Size = new Size(250, 34);
            selectColorToolStripMenuItem.Text = "&Select Color";
            selectColorToolStripMenuItem.Click += ColorSelect;
            // 
            // drawWaveformsToolStripMenuItem
            // 
            drawWaveformsToolStripMenuItem.Name = "drawWaveformsToolStripMenuItem";
            drawWaveformsToolStripMenuItem.Size = new Size(250, 34);
            drawWaveformsToolStripMenuItem.Text = "&Draw Waveforms";
            drawWaveformsToolStripMenuItem.Click += WaveformDraw;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(250, 34);
            clearToolStripMenuItem.Text = "&Clear";
            clearToolStripMenuItem.Click += FormClear;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += AboutDisplay;
            // 
            // ColorButton
            // 
            ColorButton.Location = new Point(49, 398);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(126, 34);
            ColorButton.TabIndex = 3;
            ColorButton.Text = "&Select Color";
            toolTip1.SetToolTip(ColorButton, "Open color palette for selection");
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorSelect;
            // 
            // WaveformButton
            // 
            WaveformButton.Location = new Point(209, 398);
            WaveformButton.Name = "WaveformButton";
            WaveformButton.Size = new Size(152, 34);
            WaveformButton.TabIndex = 4;
            WaveformButton.Text = "&Draw Waveform";
            toolTip1.SetToolTip(WaveformButton, "Draws a waveform");
            WaveformButton.UseVisualStyleBackColor = true;
            WaveformButton.Click += WaveformDraw;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(411, 398);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "&Clear";
            toolTip1.SetToolTip(ClearButton, "Clear drawing");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += FormClear;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(590, 398);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "Exit program");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitProgram;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new Point(0, 443);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(808, 32);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(179, 25);
            StatusLabel.Text = "toolStripStatusLabel1";
            // 
            // EtchOSketchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 475);
            Controls.Add(statusStrip1);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(WaveformButton);
            Controls.Add(ColorButton);
            Controls.Add(menuStrip1);
            Controls.Add(DisplayPictureBox);
            MainMenuStrip = menuStrip1;
            Name = "EtchOSketchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etch-O-Sketch";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem selectColorToolStripMenuItem;
        private ToolStripMenuItem drawWaveformsToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button ColorButton;
        private Button WaveformButton;
        private Button ClearButton;
        private Button ExitButton;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private ColorDialog colorDialog1;
    }
}
