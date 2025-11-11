using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathContest
{
    public partial class MathContestForm : Form
    {
        private bool allFieldsAreValid;
        public MathContestForm()
        {
            InitializeComponent();
            setDefaults();
        }

        // Program Logic ---------------------------------------------------------------
        void setDefaults()
        {
            // Clears and disables specified items
            StudentNameTextBox.Text = "";
            StudentNameTextBox.BackColor = Color.White;

            StudentAgeTextBox.Text = "";
            StudentAgeTextBox.BackColor = Color.White;

            StudentGradeTextBox.Text = "";
            StudentGradeTextBox.BackColor = Color.White;

            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            StudentAnswerTextBox.Text = "";

            AddRadioButton.Checked = true;
            AddRadioButton.Enabled = false;

            SubtractRadioButton.Checked = false;
            SubtractRadioButton.Enabled = false;

            MultiplyRadioButton.Checked = false;
            MultiplyRadioButton.Enabled = false;

            DivideRadioButton.Checked = false;
            DivideRadioButton.Enabled = false;

            SubmitButton.Enabled = false;
            ClearButton.Enabled = true;
            SummaryButton.Enabled = false;
            ExitButton.Enabled = true;
        }

        // Triggers independantly when text changes
        bool ValidateInputFields()
        {
            bool allFieldsAreValid = false;
            bool GradeIsValid = false;
            bool AgeIsValid = false;
            bool NameIsValid = false;
            int _grade;
            int _age;

            // Student's Grade Level should be a number between 3-5 AND NOT empty
            if (string.IsNullOrEmpty(StudentGradeTextBox.Text))
            {
                GradeIsValid = false;
                StudentGradeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    _grade = int.Parse(StudentGradeTextBox.Text);
                    if (_grade >= 3 && _grade <= 5)
                    {
                        GradeIsValid = true;
                        StudentGradeTextBox.BackColor = Color.White;
                    }
                    else
                    {
                        GradeIsValid = false;
                        StudentGradeTextBox.BackColor = Color.LightYellow;
                    }
                }
                catch (Exception)
                {
                    allFieldsAreValid = false;
                    StudentGradeTextBox.BackColor = Color.LightYellow;
                }
            }

            // Student's age should be an integer number between 7-11 AND NOT empty
            if (string.IsNullOrEmpty(StudentAgeTextBox.Text))
            {
                AgeIsValid = false;
                StudentAgeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    _age = int.Parse(StudentAgeTextBox.Text);
                    if (_age >= 7 && _age <= 11)
                    {
                        AgeIsValid = true;
                        StudentAgeTextBox.BackColor = Color.White;
                    }
                    else
                    {
                        AgeIsValid = false;
                        StudentAgeTextBox.BackColor = Color.LightYellow;
                    }
                }
                catch (Exception)
                {
                    AgeIsValid = false;
                    StudentAgeTextBox.BackColor = Color.LightYellow;
                }
            }

            // Student's name should not be empty
            if (string.IsNullOrEmpty(StudentNameTextBox.Text))
            {
                NameIsValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                NameIsValid = true;
                StudentNameTextBox.BackColor = Color.White;
            }

            // Verifies all fields are valid before returning final bool value and enabling Submit button
            if (GradeIsValid == true && AgeIsValid == true && NameIsValid == true)
            {
                allFieldsAreValid = true;
                SubmitButton.Enabled = true;
            }
            else
            {
                allFieldsAreValid = false;
                SubmitButton.Enabled = false;
            }

                return allFieldsAreValid;
        }


        // Event Handlers --------------------------------------------------------------
        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputFields();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Enters/saves user inputs
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close program/solution
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            setDefaults();
            setDefaults();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // Display summary
        }

        private void manualValidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidateInputFields();
        }
    }
}