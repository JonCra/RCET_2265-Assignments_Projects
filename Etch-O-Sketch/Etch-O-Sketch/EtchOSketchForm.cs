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

namespace Etch_O_Sketch
{
    public partial class EtchOSketchForm : Form
    {
        // "Global" Variables
        int oldX = -1;
        int oldY = -1;
        Color foreGround = Color.Black;
        int penWidth = 3;
        string Header = "";
        int CanvasLength;
        int CanvasHeight;
        float freq = .00969f;
        float ampl;
        float Voffset;

        Color Cosine = Color.Blue;
        Color Sine = Color.Red;
        Color Tangent = Color.Magenta;

        float CosineWave;
        float SineWave;

        AboutForm AF = new AboutForm();

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

            // Gets half of Canvas height and takes 2 pixels more for visibility
            Voffset = ampl = (CanvasHeight / 2) - 2;

            Canvas.Refresh();   // Clear form
            UpdateStatusLabel();

            DrawGraticule();
            DrawCos();
            DrawSin();
            DrawTan();
            
            // Testing only:
            //MessageBox.Show($"Waveforms Drawn! | H: {CanvasHeight}, W: {CanvasLength}");
        }

        private void DrawGraticule()
        {
            // Defines WHERE the drawing will take place
            Graphics g = Canvas.CreateGraphics();

            int defaultPen = 2;
            int penSize = 5;

            // Defines pen color and pixel width
            Pen pen = new Pen(Color.Black, defaultPen);

            float GraphLength = CanvasLength;
            float GraphHeight = CanvasHeight;

            // Format: (pen, Xstart, Ystart, Xend, Yend)

            // Horizontal dividers (L/R)
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    pen = new Pen(Color.Black, penSize);
                }
                else
                {
                    pen = new Pen(Color.Black, defaultPen);
                }
                
                float y = (GraphHeight / 10) * i;
                g.DrawLine(pen, 0f, y, GraphLength, y);
            }

            // Vertical dividers (Up/Dwn)
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    pen = new Pen(Color.Black, penSize);
                }
                else
                {
                    pen = new Pen(Color.Black, defaultPen);
                }

                float x = (GraphLength / 10) * i;
                g.DrawLine(pen, x, 0f, x, GraphHeight);
            }
        }

        private void DrawCos()
        {
            // Defines WHERE the drawing will take place
            Graphics g = Canvas.CreateGraphics();

            // Defines pen color and pixel width
            Pen pen = new Pen(Cosine, 2);

            // Defines starting point (time zero, zero AC signal)
                // Set start point to bottom of canvas; would "draw" a connecting vertical line 
            PointF previousPoint = new PointF(0, Canvas.Bottom);

            for (int x = 1; x < CanvasLength; x++)
            {
                // Cosine wave formula
                float y = (float)((ampl * Math.Cos(x * freq)) + Voffset);

                CosineWave = y;

                // Defines where pen is
                PointF currentPoint = new PointF(x, y);

                // Draw line between where pen was and now is
                g.DrawLine(pen, previousPoint, currentPoint);

                // Shift positions
                previousPoint = currentPoint;
            }
        }

        private void DrawSin()
        {
            // Defines WHERE the drawing will take place
            Graphics g = Canvas.CreateGraphics();

            // Defines pen color and pixel width
            Pen pen = new Pen(Sine, 2);

            // Defines starting point (time zero, zero AC signal)
            PointF previousPoint = new PointF(0, Voffset);

            for (int x = 1; x < CanvasLength; x++)
            {
                // Sine wave formula
                float y = (float)(ampl * Math.Sin(x * freq) + Voffset);
                SineWave = y;

                // Defines where the pen is
                PointF currentPoint = new PointF(x, y);

                // Draw between where the pen was and now is
                g.DrawLine(pen, previousPoint, currentPoint);

                // Shifts the previous points
                previousPoint = currentPoint;
            }
        }

        private void DrawTan()
        {
            // Defines WHERE the drawing will take place
            Graphics g = Canvas.CreateGraphics();

            // Defines pen color and pixel width
            Pen pen = new Pen(Tangent, 2);

            // Defines starting point (time zero, zero AC signal)
            PointF? previousPoint = null;

            float centerY = CanvasHeight / 2;
            float xScale = (float)(Math.PI / CanvasLength);
            float yScale = CanvasHeight / 4f;
            
            for (int x = 0; x < CanvasLength; x++)
            {
                float angle = x * xScale;

                float tanValue = (float)(Math.Tan(angle));

                // Binds waveform to picturebox width/length
                if (Math.Abs(tanValue) > 10f)
                {
                    previousPoint = null;
                    continue;
                }

                // Tangent wave formula
                float y = (centerY - tanValue * yScale);

                // Binds waveform to picturebox height
                if (y < 0 || y > CanvasHeight)
                {
                    previousPoint = null;
                    continue;
                }

                // Defines where the pen is
                PointF currentPoint = new PointF(x, y);

                // Draw between where the pen was and now is
                if (previousPoint != null)
                    g.DrawLine(pen, (PointF)previousPoint, currentPoint);
                

                // Shifts the previous points
                previousPoint = currentPoint;
            }
        }
        // BUG: DOES NOT DRAW AT ALL / WELL
        void MouseDraw(int X, int Y)
        {
            Graphics g = Canvas.CreateGraphics();
            Pen MousePen = new Pen(this.foreGround, this.penWidth);
            
            g.DrawLine(MousePen, this.oldX, this.oldY, X, Y);

            g.Dispose();
            MousePen.Dispose();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Changes form title to display the coords of the mouse position in relation to the form
            Header = $"X: {e.X.ToString()}, Y: {e.Y.ToString()}";

            if (e.Button == MouseButtons.Left)
            {
                if (oldX < 0 || oldY < 0)
                {
                    oldX = e.X;
                    oldY = e.Y;
                }

                // Only draws when LMB is clicked
                MouseDraw(e.X, e.Y);

                oldX = e.X;
                oldY = e.Y;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                // Displays Color Palette when MMB is pressed
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.foreGround = colorDialog1.Color;
                }
            }
            else
            {
                // Resets previous point to avoid unwanted connections
                oldX = -1;
                oldY = -1;
            }
            UpdateStatusLabel();

            // Updates mouse coords all the time
            this.oldX = e.X;
            this.oldY = e.Y;
        }

        private void GraphicsForm_MouseWheel(object sender, MouseEventArgs e)
        {
            //this.Text = e.Delta.ToString();

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

            // Disable buttons
            ExitButton.Enabled = ClearButton.Enabled = WaveformButton.Enabled
                = ColorButton.Enabled = menuStrip1.Enabled = false;

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

            // Enable buttons
            ExitButton.Enabled = ClearButton.Enabled = WaveformButton.Enabled
                = ColorButton.Enabled = menuStrip1.Enabled = true;
        }

        // Event Handlers -----------------------------------
        private void ExitProgram(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormClear(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void AboutDisplay(object sender, EventArgs e)
        {
            // Display "About" page/form
            AF.Show();
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