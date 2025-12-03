/*
 * Jonas Cram
 * RCET 2265
 * Fall 2025
 * Robotics and Comm. Systems Engineering Technology
 * https://github.com/JonCra/RCET_2265-Assignments_Projects.git
 */
using System.Windows.Forms;

namespace Etch_O_Sketch
{
    public partial class EtchOSketchForm : Form
    {
        // "Global" Variables
        int oldX;
        int oldY;
        Color foreGround = Color.Black;
        int penWidth = 3;

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
        void MouseDraw(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            Pen MousePen = new Pen(this.foreGround, this.penWidth);

            g.DrawLine(MousePen, this.oldX, this.oldY, x, y);

            // "Releases" the pen
            g.Dispose();
            MousePen.Dispose();
        }

        void UpdateStatusLabel()
        {
            // Updates status label
            StatusLabel.Text = $"Coordinates:  | Color: {this.foreGround.Name} | Width: {this.penWidth}";
        }

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
            // Display "About" page/form
        }

        private void WaveformDraw(object sender, EventArgs e)
        {

        }

        private void ColorSelect(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.foreGround = colorDialog1.Color;
            UpdateStatusLabel();
        }
    }
}
