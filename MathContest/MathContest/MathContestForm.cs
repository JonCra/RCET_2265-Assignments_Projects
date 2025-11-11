using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathContest
{
    public partial class MathContestForm : Form
    {
        private bool allFieldsAreValid;

        // Error list:
            public string ErrorMessage = "";

            private string GradeError0 = "Grade_Error0: Student grade level must not be blank";
            private string GradeError1 = "Grade_Error1: Student grade level must be a number";
            private string GradeError2 = "Grade_Error2: Student grade level must be a number between 3 and 5";

            private string AgeError0 = "Age_Error0: Student age must not be blank";
            private string AgeError1 = "Age_Error1: Student age must be a number.";
            private string AgeError2 = "Age_Error2: Student age must be a between 7 and 11.";

            private string NameError = "Name_Error: Name must not be blank.";

            private string AnswerError0 = "Answer_Error0: Answer cannot be blank";
            private string AnswerError1 = "Answer_Error1: Answer must be a number";

        private int FirstNumber;
        private int SecondNumber;
        public int CorrectAnswer;
        
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

            StudentAnswerTextBox.Enabled = MathProblemTypeGroupBox.Enabled = false;            

            AddRadioButton.Checked = true;
            SubtractRadioButton.Checked = false;
            MultiplyRadioButton.Checked = false;
            DivideRadioButton.Checked = false;

            SubmitButton.Enabled = false;
            ClearButton.Enabled = true;
            SummaryButton.Enabled = false;
            ExitButton.Enabled = true;

            ErrorMessage = "";
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

            // Resets error message each itteration
            ErrorMessage = "";

            // Student's Grade Level should be a number between 3-5 AND NOT empty
            if (string.IsNullOrEmpty(StudentGradeTextBox.Text))
            {
                GradeIsValid = false;
                StudentGradeTextBox.BackColor = Color.LightYellow;
                ErrorMessage += GradeError0;
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
                        ErrorMessage += GradeError2;
                    }
                }
                catch (Exception)
                {
                    allFieldsAreValid = false;
                    StudentGradeTextBox.BackColor = Color.LightYellow;
                    ErrorMessage += GradeError1;
                }
            }

            // Student's age should be an integer number between 7-11 AND NOT empty
            if (string.IsNullOrEmpty(StudentAgeTextBox.Text))
            {
                AgeIsValid = false;
                StudentAgeTextBox.BackColor = Color.LightYellow;
                ErrorMessage += AgeError0;
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
                        ErrorMessage += AgeError2;
                    }
                }
                catch (Exception)
                {
                    AgeIsValid = false;
                    StudentAgeTextBox.BackColor = Color.LightYellow;
                    ErrorMessage += AgeError1;
                }
            }

            // Student's name should not be empty
            if (string.IsNullOrEmpty(StudentNameTextBox.Text))
            {
                NameIsValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
                ErrorMessage += NameError;
            }
            else
            {
                NameIsValid = true;
                StudentNameTextBox.BackColor = Color.White;
            }

            // Verifies all fields are valid before returning final bool value and enabling Submit button
            if (GradeIsValid == true && AgeIsValid == true && NameIsValid == true)
            {
                allFieldsAreValid = SubmitButton.Enabled = MathProblemTypeGroupBox.Enabled = StudentAnswerTextBox.Enabled = true;
                ErrorMessage = "No errors detected";
                MathContestor();
            }
            else
            {
                allFieldsAreValid = SubmitButton.Enabled = MathProblemTypeGroupBox.Enabled = false;
            }

                return allFieldsAreValid;
        }

        private void MathContestor()
        {
            // Generate two integers
            FirstNumberGenerator();
            SecondNumberGenerator();

            // Calculate correct answer
            if (AddRadioButton.Checked)
            {
                CorrectAnswer = (FirstNumber + SecondNumber);
            }
            else if (SubtractRadioButton.Checked)
            {
                CorrectAnswer = (FirstNumber - SecondNumber);
            }
            else if (MultiplyRadioButton.Checked)
            {
                CorrectAnswer = (FirstNumber * SecondNumber);
            }
            else if (DivideRadioButton.Checked)
            {
                CorrectAnswer = (FirstNumber / SecondNumber);
            }

            // Record/judge user answer
            AnswerValidator();
        }

        private void FirstNumberGenerator()
        {
            FirstNumber = 0;
        }

        private void SecondNumberGenerator()
        {
            SecondNumber = 0;
        }

        private void AnswerValidator()
        {
            if (string.IsNullOrEmpty(StudentAnswerTextBox.Text))
            {
                // Student answer is blank
                StudentAnswerTextBox.BackColor = Color.LightYellow;
                ErrorMessage += AnswerError0;
                SubmitButton.Enabled = false;
            }
            else
            {
                // Student answer is NOT blank
                try
                {
                    int.Parse(StudentAnswerTextBox.Text);
                    {
                        // Student answer meets all requirements and can submit answer
                        StudentAnswerTextBox.BackColor = Color.White;
                        SubmitButton.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    // Student answer is NOT a number
                    StudentAnswerTextBox.BackColor = Color.LightYellow;
                    SubmitButton.Enabled = false;
                    ErrorMessage += AnswerError1;
                }
            }
        }

        private void ContestJudge()
        {
            // Record correct answers vs number of provided questions
        }

        // Event Handlers --------------------------------------------------------------
        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputFields();
        }

        private void Answer_Changed(object sender, EventArgs e)
        {
            AnswerValidator();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Enters/saves user inputs
            ContestJudge();
            SummaryButton.Enabled = true;
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

        private void showErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allow user to view error list
            //ErrorMessage.ToString() = MessageBox;
        }
    }
}