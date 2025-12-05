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
        string Header = "";

        // Initializers -------------------------------------
        public EtchOSketchForm()
        {
            InitializeComponent();
            UpdateStatusLabel();
        }

        // Program Logic ------------------------------------
        void MouseDraw(int x, int y)
        {
            Graphics g = Canvas.CreateGraphics();
            Pen MousePen = new Pen(this.foreGround, this.penWidth);

            g.DrawLine(MousePen, this.oldX, this.oldY, x, y);

            // "Releases" the pen
            g.Dispose();
            MousePen.Dispose();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Changes form title to display the coords of the mouse position in relation to the form
            Header = $"X: {e.X.ToString()}, Y: {e.Y.ToString()}";

            if (e.Button == MouseButtons.Left)
            {
                // Only draws when LMB is clicked
                MouseDraw(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                // Displays Color Palette when MMB is pressed
                colorDialog1.ShowDialog();
                this.foreGround = colorDialog1.Color;
            }
            UpdateStatusLabel();

            // Updates mouse coords all the time
            this.oldX = e.X;
            this.oldY = e.Y;
        }

        private void GraphicsForm_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Text = e.Delta.ToString();

            if (penWidth > 1 && e.Delta < 0)
            {
                this.penWidth--;
            }
            else if (e.Delta > 0)
            {
                this.penWidth++;
            }
            UpdateStatusLabel();
        }

        void UpdateStatusLabel()
        {
            // Updates status label
            StatusLabel.Text = $"Color: {this.foreGround.Name} | Width: {this.penWidth} | Position: {Header}";
        }

        // Event Handlers -----------------------------------
        private void ExitProgram(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClear(object sender, EventArgs e)
        {
            Canvas.Refresh(); // "Hard reset" for digital canvas
            UpdateStatusLabel();
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