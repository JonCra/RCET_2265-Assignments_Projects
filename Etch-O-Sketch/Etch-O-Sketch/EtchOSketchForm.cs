/*
 * Jonas Cram
 * RCET 2265
 * Fall 2025
 * Robotics and Comm. Systems Engineering Technology
 * https://github.com/JonCra/RCET_2265-Assignments_Projects.git
 */
using System.Drawing.Configuration;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

/* TODO:
 * [ ] Proper tab order
 * [ ] "Draw Waveform" button as Enter button
 * [X] "Clear" button as the cancel button (Esc)
 * [X] Form should "shake" when cleared
 * [ ] When "Draw Waveform" btn is pressed:
 *      [X] Picture box is erased
 *      [ ] 10x10 scope graticule is drawn, EVENLY spaced in picture box
 *      [ ] Draw one cycle of the following, vertically filling the picture box:
 *          [ ] Sine Wave
 *          [ ] Cosine Wave
 *          [ ] Tangent Wave
 */

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
        int CanvasLength;
        int CanvasHeight;
        float freq = .01f;
        float ampl;
        float Voffset;
        
        

        // Initializers -------------------------------------
        public EtchOSketchForm()
        {
            this.KeyPreview = true;
            InitializeComponent();
            UpdateStatusLabel();
        }

        // Program Logic ------------------------------------
        void ResetForm()
        {
            Canvas.Refresh(); // "Hard reset" for digital canvas
            UpdateStatusLabel();
            FormShaker();
        }

        void Draw_Waveforms()
        {
            // Gets and stores Canvas dimensions
            CanvasHeight = Canvas.Size.Height;
            CanvasLength = Canvas.Size.Width;
            Voffset = ampl = (CanvasHeight / 2) - 2;

            Canvas.Refresh();   // Clear form
            UpdateStatusLabel();

            DrawGraticule();
            DrawCos();
            DrawSin();
            DrawTan();
                     
            MessageBox.Show($"Waveforms Drawn! | H: {CanvasHeight}, W: {CanvasLength}");
        }

        private void DrawGraticule()
        {

        }

        private void DrawCos()
        {
            Graphics g = Canvas.CreateGraphics();

            // Defines pen color and pixel width
            Pen pen = new Pen(Color.Black, 2);

            // Defines starting point (time zero, zero AC signal)
            PointF previousPoint = new PointF(0, Voffset);

            for (int x = 1; x < CanvasLength; x++)
            {
                // Sine wave formula
                float y = (float)(ampl * Math.Sin(x * freq) + Voffset);

                // Defines where the pen is
                PointF currentPoint = new PointF(x, y);

                // Draw between where the pen was and now is
                g.DrawLine(pen, previousPoint, currentPoint);

                // Shifts the previous points
                previousPoint = currentPoint;
            }
        }

        private void DrawSin()
        {
            // y = A*sin(2*pi*time)
            // SinWave = (CanvasHeight / 2) * Math.Sin(2*Math.PI*CanvasLength);
        }

        private void DrawTan()
        {

        }

        void MouseDraw(int x, int y)
        {
            // Specifies drawing area
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

            // Scroll DOWN decreases pen size
            if (penWidth > 1 && e.Delta < 0)
            {
                this.penWidth--;
            }
            // Scroll UP increases pen size
            else if (e.Delta > 0)
            {
                this.penWidth++;
            }
            UpdateStatusLabel();
        }

        void UpdateStatusLabel()
        {
            StatusLabel.Text = $"Color: {this.foreGround.Name} | Width: {this.penWidth} | Position: {Header}";
        }

        private void FormShaker()
        {
            int offset = 25;    // Pixel offset
            int WaitTime = 250; // Pause time in milliseconds

            // Get/store form position
            int oldY = this.Left;
            int oldX = this.Top;

            // Move form diagnally up/down 5x
            for (int i = 0; i < 5; i++)
            {
                this.Top = oldX + offset;
                this.Left = oldY + offset;
                System.Threading.Thread.Sleep(WaitTime);

                this.Top = oldX - offset;
                this.Left = oldY - offset;
                System.Threading.Thread.Sleep(WaitTime);
            }

            // Reset to original position
            this.Top = oldX;
            this.Left = oldY;
        }

        // Event Handlers -----------------------------------
        private void ExitProgram(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClear(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void AboutDisplay(object sender, EventArgs e)
        {
            // Display "About" page/form
        }

        private void WaveformDraw(object sender, EventArgs e)
        {
            Draw_Waveforms();
        }

        private void ColorSelect(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();  // Shows color Pallete

            // Updates display for selected color
            this.foreGround = colorDialog1.Color;
            UpdateStatusLabel();
        }

        private void FormKeyBind(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // BUG: Does not trigger correctly/at all
            {
                // If Enter key is pressed:
                Draw_Waveforms();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // If Escape key is pressed:
                ResetForm();
            }
        }
    }
}