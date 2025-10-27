namespace MathContest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Sets default options after initialization
            setDefaults();
        }
        void setDefaults()
        {
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
        }
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // Display summary
        }

        // Program Logic ---------------------------------------------------------------
    }
}