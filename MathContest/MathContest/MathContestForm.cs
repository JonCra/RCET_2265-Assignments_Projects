/* 
 * Jonas Cram
 * RCET 2265
 * Robotics and Comm. Systems Engineering Techn.
 * Fall 2025
 */

using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/*
 TODO:
    [X] Enter the child's name, grade (1-4), and age (7-11)
    [X] Choose a math problem type (add, subtract, multiply, divide) using radio buttons (add selected by default)
    [X] Validate all required information. Change the textbox color to light yellow for missing/incorrect fields
    [X] Lock the Submit button until all required fields are filled in correctly
    [X] Lock the Summary button until the Submit button has been clicked at least once
    [X] If the clear button is clicked, reset all fields to their default state
    [X] If any of the student information fields are changed reset the summary to its default state and consider it a new student
    [X] Generate new random numbers for each problem or whenever the problem type is changed
    [X] Do not allow the user to enter their own numbers
    [X] Allow the contestant to enter their answer and submit
    [X] Show a congratulations message if correct, or the correct answer if not
    [X] Keep a total of correct/incorrect responses for the current student and show a summary when requested
 */
namespace MathContest
{
    public partial class MathContestForm : Form
    {
        private bool allFieldsAreValid;
        private int FirstNumber = 0;
        private int SecondNumber = 0;
        private int CorrectAnswer;
        private int CorrectTally = 0;
        private int AttemptTally = 0;

        // Error list:
        public string ErrorMessage = "";

        private string GradeError0 = "Grade_Error0: Student grade level must not be blank.\n";
        private string GradeError1 = "Grade_Error1: Student grade level must be a number.\n";
        private string GradeError2 = "Grade_Error2: Student grade level must be a number between 1 and 4.\n";

        private string AgeError0 = "Age_Error0: Student age must not be blank.\n";
        private string AgeError1 = "Age_Error1: Student age must be a number.\n";
        private string AgeError2 = "Age_Error2: Student age must be a between 7 and 11.\n";

        private string NameError = "Name_Error: Name must not be blank.\n";

        private string AnswerError0 = "Answer_Error0: Answer cannot be blank.\n";
        private string AnswerError1 = "Answer_Error1: Answer must be a number.\n";

        public MathContestForm()
        {
            InitializeComponent();
            setDefaults();
        }

        // Program Logic ---------------------------------------------------------------
        void setDefaults()
        {
            StudentNameTextBox.Text = "";
            StudentNameTextBox.BackColor = Color.White;

            StudentAgeTextBox.Text = "";
            StudentAgeTextBox.BackColor = Color.White;

            StudentGradeTextBox.Text = "";
            StudentGradeTextBox.BackColor = Color.White;

            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";

            StudentAnswerTextBox.Text = "";
            StudentAnswerTextBox.BackColor = Color.White;

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
                    if (_grade >= 1 && _grade <= 4)
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
            // POTENTIAL BUG: Name is validated if there is blanks or spaces
            if (string.IsNullOrEmpty(StudentNameTextBox.Text))
            {
                NameIsValid = false;
                StudentNameTextBox.BackColor = Color.LightYellow;
                ErrorMessage += NameError;
            }
            // Attempt to register a FALSE if there is any "White Spaces" in name
            //else if (char.IsWhiteSpace(StudentNameTextBox))
            //{

            //}
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
                allFieldsAreValid = SubmitButton.Enabled = StudentAnswerTextBox.Enabled = MathProblemTypeGroupBox.Enabled = false;
            }

            return allFieldsAreValid;
        }

        private void MathContestor()
        {
            QuestionDisplay();

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

        private void QuestionDisplay()
        {
            // Generate random number to draw from pool
            RandomNumberGenerator();

            if (SubtractRadioButton.Checked)
            {
                SubtNumberGen();
            }
            else if (MultiplyRadioButton.Checked)
            {
                MultiNumberGen();
            }
            else if (DivideRadioButton.Checked)
            {
                DiviNumberGen();
            }
            else
            {
                AddNumberGen();
            }
        }

        private void RandomNumberGenerator()
        {
            int DrawValue = 0;

            // Produces a random number to draw from a pool of questions
            Random roll = new Random();
            for (int i = 0; i < 1; i++)
            {
                switch (roll.Next(0, 6))
                {
                    case 0:
                        {
                            FirstNumber = 9;
                            SecondNumber = 9;
                            break;
                        }
                    case 1:
                        {
                            FirstNumber = 2;
                            SecondNumber = 5;
                            break;
                        }
                    case 2:
                        {
                            FirstNumber = 8;
                            SecondNumber = 5;
                            break;
                        }
                    case 3:
                        {
                            FirstNumber = 2;
                            SecondNumber = 3;
                            break;
                        }
                    case 4:
                        {
                            FirstNumber = 2;
                            SecondNumber = 7;
                            break;
                        }
                    case 5:
                        {
                            FirstNumber = 4;
                            SecondNumber = 3;
                            break;
                        }
                }
            }
        }

        private void AddNumberGen()
        {
            FirstNumberTextBox.Text = FirstNumber.ToString();
            SecondNumberTextBox.Text = SecondNumber.ToString();
            CorrectAnswer = (FirstNumber + SecondNumber);
        }

        private void SubtNumberGen()
        {
            FirstNumberTextBox.Text = FirstNumber.ToString();
            SecondNumberTextBox.Text = SecondNumber.ToString();
            CorrectAnswer = (FirstNumber - SecondNumber);
        }

        private void MultiNumberGen()
        {
            FirstNumberTextBox.Text = FirstNumber.ToString();
            SecondNumberTextBox.Text = SecondNumber.ToString();
            CorrectAnswer = (FirstNumber * SecondNumber);
        }

        private void DiviNumberGen()
        {
            FirstNumberTextBox.Text = FirstNumber.ToString();
            SecondNumberTextBox.Text = SecondNumber.ToString();
            CorrectAnswer = (FirstNumber / SecondNumber);
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
            if (StudentAnswerTextBox.Text == CorrectAnswer.ToString())
            {
                CorrectTally++;
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show($"Sorry, that isn't correct. The correct answer is {CorrectAnswer}.");
            }
        }

        // Event Handlers --------------------------------------------------------------
        private void MathFunctionChanged(object sender, EventArgs e)
        {
            QuestionDisplay();
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputFields();
            CorrectTally = AttemptTally = 0;
        }

        private void Answer_Changed(object sender, EventArgs e)
        {
            AnswerValidator();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Enters/saves user inputs
            ContestJudge();

            // Resets student's answer
            StudentAnswerTextBox.Clear();

            // Draws a new question
            QuestionDisplay();

            AttemptTally++;
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
            // Display summary - MessageBox or "pop-up"?
            MessageBox.Show($"You got {CorrectTally} out of {AttemptTally} answers correct!");
        }

        private void manualValidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidateInputFields();
        }
                
        private void showErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ErrorMessage))
            {
                MessageBox.Show("No errors detected.", "Error List");
            }
            else
            {
                MessageBox.Show(ErrorMessage, "Error List");
            }
        }
    }
}