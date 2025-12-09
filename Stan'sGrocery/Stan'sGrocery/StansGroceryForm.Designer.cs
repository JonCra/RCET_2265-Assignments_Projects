namespace Stan_sGrocery
{
    partial class StansGroceryForm
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
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            FilterComboBox = new ComboBox();
            DisplayListBox = new ListBox();
            DisplayLabel = new Label();
            FilterGroupBox = new GroupBox();
            FilterByCategoryRadioButton = new RadioButton();
            FilterByAisleRadioButton = new RadioButton();
            TopMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            MainToolTip = new ToolTip(components);
            ContextMenuStrip = new ContextMenuStrip(components);
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            SearchGroupBox = new GroupBox();
            FilterGroupBox.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            SearchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(6, 116);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(263, 31);
            SearchTextBox.TabIndex = 0;
            MainToolTip.SetToolTip(SearchTextBox, "Text search query");
            SearchTextBox.TextChanged += SearchTextChanged;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(275, 116);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 34);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Seach";
            MainToolTip.SetToolTip(SearchButton, "Confirm search query");
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Items.AddRange(new object[] { "Show All" });
            FilterComboBox.Location = new Point(6, 53);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(263, 33);
            FilterComboBox.TabIndex = 2;
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.ItemHeight = 25;
            DisplayListBox.Location = new Point(442, 66);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(346, 354);
            DisplayListBox.TabIndex = 3;
            MainToolTip.SetToolTip(DisplayListBox, "Items found within search");
            // 
            // DisplayLabel
            // 
            DisplayLabel.AutoSize = true;
            DisplayLabel.Location = new Point(442, 38);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(70, 25);
            DisplayLabel.TabIndex = 4;
            DisplayLabel.Text = "Display";
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(FilterByCategoryRadioButton);
            FilterGroupBox.Controls.Add(FilterByAisleRadioButton);
            FilterGroupBox.Location = new Point(18, 250);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(300, 127);
            FilterGroupBox.TabIndex = 5;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filters";
            // 
            // FilterByCategoryRadioButton
            // 
            FilterByCategoryRadioButton.AutoSize = true;
            FilterByCategoryRadioButton.Location = new Point(6, 88);
            FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton";
            FilterByCategoryRadioButton.Size = new Size(177, 29);
            FilterByCategoryRadioButton.TabIndex = 6;
            FilterByCategoryRadioButton.TabStop = true;
            FilterByCategoryRadioButton.Text = "Filter by Category";
            MainToolTip.SetToolTip(FilterByCategoryRadioButton, "Filter items categorically");
            FilterByCategoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // FilterByAisleRadioButton
            // 
            FilterByAisleRadioButton.AutoSize = true;
            FilterByAisleRadioButton.Location = new Point(6, 43);
            FilterByAisleRadioButton.Name = "FilterByAisleRadioButton";
            FilterByAisleRadioButton.Size = new Size(142, 29);
            FilterByAisleRadioButton.TabIndex = 6;
            FilterByAisleRadioButton.TabStop = true;
            FilterByAisleRadioButton.Text = "Filter by Aisle";
            MainToolTip.SetToolTip(FilterByAisleRadioButton, "Filter items by aisle number");
            FilterByAisleRadioButton.UseVisualStyleBackColor = true;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 33);
            TopMenuStrip.TabIndex = 6;
            TopMenuStrip.Text = "Top Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(166, 34);
            searchToolStripMenuItem.Text = "Search";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(166, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitProgram;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, exitToolStripMenuItem1 });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(137, 68);
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(136, 32);
            fileToolStripMenuItem1.Text = "Search";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(136, 32);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += ExitProgram;
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(FilterComboBox);
            SearchGroupBox.Controls.Add(SearchButton);
            SearchGroupBox.Controls.Add(SearchTextBox);
            SearchGroupBox.Location = new Point(12, 36);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(393, 180);
            SearchGroupBox.TabIndex = 7;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Search";
            // 
            // StansGroceryForm
            // 
            AcceptButton = SearchButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchGroupBox);
            Controls.Add(FilterGroupBox);
            Controls.Add(DisplayLabel);
            Controls.Add(DisplayListBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "StansGroceryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stan's Grocery Search";
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ContextMenuStrip.ResumeLayout(false);
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private Button SearchButton;
        private ComboBox FilterComboBox;
        private ListBox DisplayListBox;
        private Label DisplayLabel;
        private GroupBox FilterGroupBox;
        private RadioButton FilterByAisleRadioButton;
        private RadioButton FilterByCategoryRadioButton;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolTip MainToolTip;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private GroupBox SearchGroupBox;
    }
}
