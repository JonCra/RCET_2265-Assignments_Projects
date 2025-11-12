namespace MathContest
{
    partial class MathContestForm
    {
        private const bool V = false;

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
            StudentNameTextBox = new TextBox();
            StudentGradeTextBox = new TextBox();
            StudentAgeTextBox = new TextBox();
            ExitButton = new Button();
            SummaryButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            StudentAnswerTextBox = new TextBox();
            StudentInformationGroupBox = new GroupBox();
            StudentGradeTextLabel = new Label();
            StudentAgeLabel = new Label();
            StudentNameTextLabel = new Label();
            UserButtonGroupBox = new GroupBox();
            CurrentMathProblemGroupBox = new GroupBox();
            StudentAnswerLabel = new Label();
            SecondNumberLabel = new Label();
            FirstNumberLabel = new Label();
            SecondNumberTextBox = new TextBox();
            FirstNumberTextBox = new TextBox();
            MathProblemTypeGroupBox = new GroupBox();
            DivideRadioButton = new RadioButton();
            MultiplyRadioButton = new RadioButton();
            SubtractRadioButton = new RadioButton();
            AddRadioButton = new RadioButton();
            menuStrip1 = new MenuStrip();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            manualValidateToolStripMenuItem = new ToolStripMenuItem();
            showErrorsToolStripMenuItem = new ToolStripMenuItem();
            StudentInformationGroupBox.SuspendLayout();
            UserButtonGroupBox.SuspendLayout();
            CurrentMathProblemGroupBox.SuspendLayout();
            MathProblemTypeGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(6, 83);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(164, 31);
            StudentNameTextBox.TabIndex = 0;
            toolTip1.SetToolTip(StudentNameTextBox, "Enter student's name");
            StudentNameTextBox.TextChanged += Text_Changed;
            // 
            // StudentGradeTextBox
            // 
            StudentGradeTextBox.Location = new Point(341, 83);
            StudentGradeTextBox.Name = "StudentGradeTextBox";
            StudentGradeTextBox.Size = new Size(102, 31);
            StudentGradeTextBox.TabIndex = 2;
            toolTip1.SetToolTip(StudentGradeTextBox, "Enter student's grade level (1-4)");
            StudentGradeTextBox.TextChanged += Text_Changed;
            // 
            // StudentAgeTextBox
            // 
            StudentAgeTextBox.Location = new Point(203, 83);
            StudentAgeTextBox.Name = "StudentAgeTextBox";
            StudentAgeTextBox.Size = new Size(102, 31);
            StudentAgeTextBox.TabIndex = 1;
            toolTip1.SetToolTip(StudentAgeTextBox, "Enter Student's age (7-11)");
            StudentAgeTextBox.TextChanged += Text_Changed;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 12F);
            ExitButton.Location = new Point(6, 325);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(309, 95);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "Exit program");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Font = new Font("Segoe UI", 12F);
            SummaryButton.Location = new Point(6, 224);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(309, 95);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            toolTip1.SetToolTip(SummaryButton, "Display summary of last attempts");
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 12F);
            ClearButton.Location = new Point(6, 123);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(309, 95);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            toolTip1.SetToolTip(ClearButton, "Clear all user-inputted fields");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 12F);
            SubmitButton.Location = new Point(6, 22);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(309, 95);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            toolTip1.SetToolTip(SubmitButton, "Record/submit answer and student information");
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // StudentAnswerTextBox
            // 
            StudentAnswerTextBox.Location = new Point(6, 259);
            StudentAnswerTextBox.Name = "StudentAnswerTextBox";
            StudentAnswerTextBox.Size = new Size(208, 31);
            StudentAnswerTextBox.TabIndex = 1;
            toolTip1.SetToolTip(StudentAnswerTextBox, "Answer must be a whole number (integer)");
            StudentAnswerTextBox.TextChanged += Answer_Changed;
            // 
            // StudentInformationGroupBox
            // 
            StudentInformationGroupBox.Controls.Add(StudentGradeTextLabel);
            StudentInformationGroupBox.Controls.Add(StudentGradeTextBox);
            StudentInformationGroupBox.Controls.Add(StudentAgeLabel);
            StudentInformationGroupBox.Controls.Add(StudentAgeTextBox);
            StudentInformationGroupBox.Controls.Add(StudentNameTextLabel);
            StudentInformationGroupBox.Controls.Add(StudentNameTextBox);
            StudentInformationGroupBox.Location = new Point(12, 36);
            StudentInformationGroupBox.Name = "StudentInformationGroupBox";
            StudentInformationGroupBox.Size = new Size(449, 124);
            StudentInformationGroupBox.TabIndex = 0;
            StudentInformationGroupBox.TabStop = false;
            StudentInformationGroupBox.Text = "Student Information";
            // 
            // StudentGradeTextLabel
            // 
            StudentGradeTextLabel.AutoSize = true;
            StudentGradeTextLabel.Location = new Point(341, 55);
            StudentGradeTextLabel.Name = "StudentGradeTextLabel";
            StudentGradeTextLabel.Size = new Size(59, 25);
            StudentGradeTextLabel.TabIndex = 5;
            StudentGradeTextLabel.Text = "Grade";
            // 
            // StudentAgeLabel
            // 
            StudentAgeLabel.AutoSize = true;
            StudentAgeLabel.Location = new Point(203, 55);
            StudentAgeLabel.Name = "StudentAgeLabel";
            StudentAgeLabel.Size = new Size(44, 25);
            StudentAgeLabel.TabIndex = 4;
            StudentAgeLabel.Text = "Age";
            // 
            // StudentNameTextLabel
            // 
            StudentNameTextLabel.AutoSize = true;
            StudentNameTextLabel.Location = new Point(6, 55);
            StudentNameTextLabel.Name = "StudentNameTextLabel";
            StudentNameTextLabel.Size = new Size(125, 25);
            StudentNameTextLabel.TabIndex = 1;
            StudentNameTextLabel.Text = "Student Name";
            // 
            // UserButtonGroupBox
            // 
            UserButtonGroupBox.Controls.Add(ExitButton);
            UserButtonGroupBox.Controls.Add(SummaryButton);
            UserButtonGroupBox.Controls.Add(ClearButton);
            UserButtonGroupBox.Controls.Add(SubmitButton);
            UserButtonGroupBox.Location = new Point(467, 36);
            UserButtonGroupBox.Name = "UserButtonGroupBox";
            UserButtonGroupBox.Size = new Size(321, 426);
            UserButtonGroupBox.TabIndex = 1;
            UserButtonGroupBox.TabStop = false;
            // 
            // CurrentMathProblemGroupBox
            // 
            CurrentMathProblemGroupBox.Controls.Add(StudentAnswerLabel);
            CurrentMathProblemGroupBox.Controls.Add(SecondNumberLabel);
            CurrentMathProblemGroupBox.Controls.Add(FirstNumberLabel);
            CurrentMathProblemGroupBox.Controls.Add(StudentAnswerTextBox);
            CurrentMathProblemGroupBox.Controls.Add(SecondNumberTextBox);
            CurrentMathProblemGroupBox.Controls.Add(FirstNumberTextBox);
            CurrentMathProblemGroupBox.Location = new Point(12, 166);
            CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox";
            CurrentMathProblemGroupBox.Size = new Size(220, 296);
            CurrentMathProblemGroupBox.TabIndex = 2;
            CurrentMathProblemGroupBox.TabStop = false;
            CurrentMathProblemGroupBox.Text = "Current Math Problem";
            // 
            // StudentAnswerLabel
            // 
            StudentAnswerLabel.AutoSize = true;
            StudentAnswerLabel.Location = new Point(6, 232);
            StudentAnswerLabel.Name = "StudentAnswerLabel";
            StudentAnswerLabel.Size = new Size(131, 25);
            StudentAnswerLabel.TabIndex = 5;
            StudentAnswerLabel.Text = "StudentAnswer";
            // 
            // SecondNumberLabel
            // 
            SecondNumberLabel.AutoSize = true;
            SecondNumberLabel.Location = new Point(6, 130);
            SecondNumberLabel.Name = "SecondNumberLabel";
            SecondNumberLabel.Size = new Size(141, 25);
            SecondNumberLabel.TabIndex = 4;
            SecondNumberLabel.Text = "Second Number";
            // 
            // FirstNumberLabel
            // 
            FirstNumberLabel.AutoSize = true;
            FirstNumberLabel.Location = new Point(6, 39);
            FirstNumberLabel.Name = "FirstNumberLabel";
            FirstNumberLabel.Size = new Size(115, 25);
            FirstNumberLabel.TabIndex = 3;
            FirstNumberLabel.Text = "First Number";
            // 
            // SecondNumberTextBox
            // 
            SecondNumberTextBox.Location = new Point(6, 158);
            SecondNumberTextBox.Name = "SecondNumberTextBox";
            SecondNumberTextBox.ReadOnly = true;
            SecondNumberTextBox.Size = new Size(208, 31);
            SecondNumberTextBox.TabIndex = 0;
            SecondNumberTextBox.TabStop = false;
            toolTip1.SetToolTip(SecondNumberTextBox, "Second number");
            // 
            // FirstNumberTextBox
            // 
            FirstNumberTextBox.AccessibleRole = AccessibleRole.None;
            FirstNumberTextBox.Location = new Point(6, 68);
            FirstNumberTextBox.Name = "FirstNumberTextBox";
            FirstNumberTextBox.ReadOnly = true;
            FirstNumberTextBox.Size = new Size(208, 31);
            FirstNumberTextBox.TabIndex = 0;
            FirstNumberTextBox.TabStop = false;
            toolTip1.SetToolTip(FirstNumberTextBox, "First number");
            // 
            // MathProblemTypeGroupBox
            // 
            MathProblemTypeGroupBox.Controls.Add(DivideRadioButton);
            MathProblemTypeGroupBox.Controls.Add(MultiplyRadioButton);
            MathProblemTypeGroupBox.Controls.Add(SubtractRadioButton);
            MathProblemTypeGroupBox.Controls.Add(AddRadioButton);
            MathProblemTypeGroupBox.Location = new Point(238, 166);
            MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox";
            MathProblemTypeGroupBox.Size = new Size(223, 296);
            MathProblemTypeGroupBox.TabIndex = 3;
            MathProblemTypeGroupBox.TabStop = false;
            MathProblemTypeGroupBox.Text = "Math Problem Type";
            // 
            // DivideRadioButton
            // 
            DivideRadioButton.AutoSize = true;
            DivideRadioButton.Location = new Point(6, 173);
            DivideRadioButton.Name = "DivideRadioButton";
            DivideRadioButton.Size = new Size(87, 29);
            DivideRadioButton.TabIndex = 3;
            DivideRadioButton.TabStop = true;
            DivideRadioButton.Text = "Divide";
            toolTip1.SetToolTip(DivideRadioButton, "First number (\\div\\) Second number");
            DivideRadioButton.UseVisualStyleBackColor = true;
            DivideRadioButton.CheckedChanged += MathFunctionChanged;
            // 
            // MultiplyRadioButton
            // 
            MultiplyRadioButton.AutoSize = true;
            MultiplyRadioButton.Location = new Point(6, 138);
            MultiplyRadioButton.Name = "MultiplyRadioButton";
            MultiplyRadioButton.Size = new Size(101, 29);
            MultiplyRadioButton.TabIndex = 2;
            MultiplyRadioButton.TabStop = true;
            MultiplyRadioButton.Text = "Multiply";
            toolTip1.SetToolTip(MultiplyRadioButton, "First number * Second Number");
            MultiplyRadioButton.UseVisualStyleBackColor = true;
            MultiplyRadioButton.CheckedChanged += MathFunctionChanged;
            // 
            // SubtractRadioButton
            // 
            SubtractRadioButton.AutoSize = true;
            SubtractRadioButton.Location = new Point(6, 103);
            SubtractRadioButton.Name = "SubtractRadioButton";
            SubtractRadioButton.Size = new Size(103, 29);
            SubtractRadioButton.TabIndex = 1;
            SubtractRadioButton.TabStop = true;
            SubtractRadioButton.Text = "Subtract";
            toolTip1.SetToolTip(SubtractRadioButton, "First number - Second Number");
            SubtractRadioButton.UseVisualStyleBackColor = true;
            SubtractRadioButton.CheckedChanged += MathFunctionChanged;
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Location = new Point(6, 68);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(71, 29);
            AddRadioButton.TabIndex = 0;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "Add";
            toolTip1.SetToolTip(AddRadioButton, "First number + Second number");
            AddRadioButton.UseVisualStyleBackColor = true;
            AddRadioButton.CheckedChanged += MathFunctionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualValidateToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(69, 29);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // manualValidateToolStripMenuItem
            // 
            manualValidateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showErrorsToolStripMenuItem });
            manualValidateToolStripMenuItem.Name = "manualValidateToolStripMenuItem";
            manualValidateToolStripMenuItem.Size = new Size(239, 34);
            manualValidateToolStripMenuItem.Text = "Manual Validate";
            manualValidateToolStripMenuItem.Click += manualValidateToolStripMenuItem_Click;
            // 
            // showErrorsToolStripMenuItem
            // 
            showErrorsToolStripMenuItem.Name = "showErrorsToolStripMenuItem";
            showErrorsToolStripMenuItem.Size = new Size(209, 34);
            showErrorsToolStripMenuItem.Text = "Show Errors";
            // 
            // MathContestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(MathProblemTypeGroupBox);
            Controls.Add(CurrentMathProblemGroupBox);
            Controls.Add(UserButtonGroupBox);
            Controls.Add(StudentInformationGroupBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MathContestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Math Contest";
            StudentInformationGroupBox.ResumeLayout(false);
            StudentInformationGroupBox.PerformLayout();
            UserButtonGroupBox.ResumeLayout(false);
            CurrentMathProblemGroupBox.ResumeLayout(false);
            CurrentMathProblemGroupBox.PerformLayout();
            MathProblemTypeGroupBox.ResumeLayout(false);
            MathProblemTypeGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private TextBox StudentNameTextBox;
        private GroupBox StudentInformationGroupBox;
        private Label StudentNameTextLabel;
        private Label StudentGradeTextLabel;
        private TextBox StudentGradeTextBox;
        private Label StudentAgeLabel;
        private TextBox StudentAgeTextBox;
        private GroupBox UserButtonGroupBox;
        private GroupBox CurrentMathProblemGroupBox;
        private GroupBox MathProblemTypeGroupBox;
        private RadioButton DivideRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton SubtractRadioButton;
        private RadioButton AddRadioButton;
        private Button ExitButton;
        private Button SummaryButton;
        private Button ClearButton;
        private Button SubmitButton;
        private TextBox StudentAnswerTextBox;
        private TextBox SecondNumberTextBox;
        private TextBox FirstNumberTextBox;
        private Label StudentAnswerLabel;
        private Label SecondNumberLabel;
        private Label FirstNumberLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem manualValidateToolStripMenuItem;
        private ToolStripMenuItem showErrorsToolStripMenuItem;
    }
}