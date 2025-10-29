namespace MathContest
{
    public partial class MathContestForm : Form
    {
        public MathContestForm()
        {
            InitializeComponent();            
            setDefaults();
            if (StudentNameTextBox.Text != "" && StudentAgeTextBox.Text != "" && StudentGradeTextBox.Text != "")
            {
                ValidateInputFields();
            }
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
        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputFields();
        }
        bool ValidateInputFields()
        {
            bool allFieldsAreValid = false;
            int _age;
            int _grade;

            // Name should not be empty
            if (StudentNameTextBox.Text == "")
            {
                allFieldsAreValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
                StudentNameTextBox.Focus();
            }

            // Age Validator
            try
            {
                _age = int.Parse(StudentAgeTextBox.Text);
                if (_age <= 7 || _age >= 11)
                {
                    allFieldsAreValid = true;
                    StudentAgeTextBox.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                StudentAgeTextBox.BackColor = Color.LightYellow;
                StudentAgeTextBox.Clear();
                StudentAgeTextBox.Focus();
            }

            // Age shoudl not be empty
            if (StudentAgeTextBox.Text == "")
            {
                allFieldsAreValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
                StudentAgeTextBox.Focus();
            }

            // Grade Validator
            try
            {
                _grade = int.Parse(StudentGradeTextBox.Text);
                if (_grade <= 1 || _grade >= 4)
                {
                    allFieldsAreValid = true;
                    StudentGradeTextBox.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                StudentGradeTextBox.BackColor = Color.LightYellow;
                StudentGradeTextBox.Clear();
                StudentGradeTextBox.Focus();
            }

            if (allFieldsAreValid)
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
        }
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // Display summary
        }
    }
}