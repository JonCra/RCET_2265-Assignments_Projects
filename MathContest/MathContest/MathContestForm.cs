using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathContest
{
    public partial class MathContestForm : Form
    {
        private bool NameIsValidated;
        private bool AgeIsValidated;
        private bool GradeIsValidated;
        public MathContestForm()
        {
            InitializeComponent();            
            setDefaults();
            //if (StudentNameTextBox.Text != "" && StudentAgeTextBox.Text != "" && StudentGradeTextBox.Text != "")
            //{
            //    VerifyFieldsAreValid();
            //}
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
        private void NameText_Changed(object sender, EventArgs e)
        {
            // BUG: Name validates regardless of character, fix so that leading blank "spaces" are trimmed?
            NameValidator();
        }
        private void AgeText_Changed(object sender, EventArgs e)
        {
            AgeValidator();
        }
        private void GradeText_Changed(object sender, EventArgs e)
        {
            GradeValidator();
        }

        // Independantly validate Input Fields
        bool NameValidator()
        {
            bool NameIsValid = false;
            // Name should not be empty
            if (StudentNameTextBox.Text == "")
            {
                NameIsValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
                StudentNameTextBox.Focus();
            }
            else
            {
                NameIsValid = true;
                StudentNameTextBox.BackColor = Color.White;
            }
            NameIsValidated = NameIsValid;
                return NameIsValidated;
        }
        bool AgeValidator()
        {
            bool AgeIsValid = false;
            int _age;

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
                    StudentAgeTextBox.Clear();
                    StudentAgeTextBox.Focus();
                }
            }
            catch (Exception)
            {
                StudentAgeTextBox.BackColor = Color.LightYellow;
                //StudentAgeTextBox.Clear();
                StudentAgeTextBox.Focus();
            }

            // Age shoudl not be empty
            if (StudentAgeTextBox.Text == "")
            {
                AgeIsValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
                StudentAgeTextBox.Focus();
            }
            AgeIsValidated = AgeIsValid;
                return AgeIsValidated;
        }
        bool GradeValidator()
        {
            int _grade;
            bool GradeIsValid = false;

            try
            {
                _grade = int.Parse(StudentGradeTextBox.Text);
                if (_grade >= 1 || _grade <= 4)
                {
                    GradeIsValid = true;
                    StudentGradeTextBox.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                GradeIsValid = false;
                StudentGradeTextBox.BackColor = Color.LightYellow;
                StudentGradeTextBox.Clear();
                StudentGradeTextBox.Focus();
            }
            GradeIsValidated = GradeIsValid;
                return GradeIsValidated;
        }
        bool VerifyFieldsAreValid()
        {
            bool allFieldsAreValid = false;
            if (NameIsValidated && GradeIsValidated && AgeIsValidated == true)
            {
                allFieldsAreValid = true;
            }
            if (allFieldsAreValid == true)
            {
                StudentNameTextBox.BackColor = Color.White;
                StudentAgeTextBox.BackColor = Color.White;
                StudentAnswerTextBox.BackColor = Color.White;
            }

            // Enables submit button when Bool is TRUE
            SubmitButton.Enabled = allFieldsAreValid;

            return allFieldsAreValid;
        }
        
        // Event Handlers --------------------------------------------------------------
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
    }
}