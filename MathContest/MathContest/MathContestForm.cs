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

        bool ValidateInputFields()
        {
            bool allFieldsAreValid = true;
            StudentNameTextBox.BackColor = Color.White;
            StudentAgeTextBox.BackColor = Color.White;
            StudentGradeTextBox.BackColor = Color.White;
            int _grade;
            int _age;

           
            if (StudentGradeTextBox.Text == "")
            {
                allFieldsAreValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                try
                {
                    _grade = int.Parse(StudentGradeTextBox.Text);
                    if (_grade <= 3 || _grade >= 5)
                    {
                        allFieldsAreValid = false;
                        StudentAgeTextBox.BackColor = Color.LightYellow;
                    }
                }
                catch (Exception)
                {
                    allFieldsAreValid = false;
                    StudentGradeTextBox.BackColor = Color.LightYellow;
                }
            }

            // Student's age should be an integer number between 7-11 AND NOT empty
            if (StudentAgeTextBox.Text == "")
            {
                allFieldsAreValid = false;
                StudentAgeTextBox.BackColor = Color.LightYellow;
            }
            else if (StudentAgeTextBox.Text != "")
            {
                try
                {
                    _age = int.Parse(StudentAgeTextBox.Text);
                    if (_age <= 7 || _age >= 11)
                    {
                        allFieldsAreValid = false;
                        StudentAgeTextBox.BackColor = Color.LightYellow;
                    }
                }
                catch (Exception)
                {
                    allFieldsAreValid = false;
                    StudentAgeTextBox.BackColor = Color.LightYellow;
                }
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
    }
}