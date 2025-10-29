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
        void setDefaults()
        {
            // Clears and disables specified items
            StudentNameTextBox.Text = "";
            StudentAgeTextBox.Text = "";
            StudentGradeTextBox.Text = "";
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
            // Actual validation here
            int _age;

            try
            {
                _age = int.Parse(StudentAgeTextBox.Text);
                if (_age <= 0 || _age >= 80)
                {
                    allFieldsAreValid = false;
                    StudentAgeTextBox.BackColor = Color.LightYellow;
                }
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                StudentAgeTextBox.BackColor = Color.LightYellow;
                StudentAgeTextBox.Focus();
            }

            // Age shoudl not be empty
            if (StudentAgeTextBox.Text == "")
            {
                allFieldsAreValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
                StudentAgeTextBox.Focus();
            }
            // Name should not be empty
            if (StudentNameTextBox.Text == "")
            {
                allFieldsAreValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
                StudentNameTextBox.Focus();
            }
            if (allFieldsAreValid)
            {
                StudentNameTextBox.BackColor = Color.White;
                StudentAgeTextBox.BackColor = Color.White;
                StudentAnswerTextBox.BackColor = Color.White;
            }
            else
            {

            }
            SubmitButton.Enabled = allFieldsAreValid;
            return allFieldsAreValid;
        }
        //private void Text_Changed(object sender, EventArgs e)
        //{
        //    if (StudentNameTextBox.Text != "" && StudentAgeTextBox.Text != "" && StudentGradeTextBox.Text != "")
        //    {
        //        ValidateInputFields();
        //    }
        //}

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

        // Program Logic ---------------------------------------------------------------
    }
}