/*
 * Jonas Cram
 * RCET 2265
 * Fall 2025
 * Robotics and Comm. Systems Engineering Technology
 * https://github.com/JonCra/RCET_2265-Assignments_Projects.git
 */
namespace Etch_O_Sketch
{
    public partial class EtchOSketchForm : Form
    {
        // Initializers -------------------------------------
        public EtchOSketchForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {

        }

        // Program Logic ------------------------------------
        private void ClearForm()
        {

        }

        // Event Handlers -----------------------------------
        private void ExitProgram(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClear(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void AboutDisplay(object sender, EventArgs e)
        {
            // Display "About" page
        }

        private void WaveformDraw(object sender, EventArgs e)
        {

        }

        private void ColorSelect(object sender, EventArgs e)
        {

        }
    }
}
