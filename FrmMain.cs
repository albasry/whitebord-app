using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whiteboard1
{
    public partial class FrmMain : Form
    {
        // Make a pen and give it color and width
        private Pen pen = new Pen(Color.Black, 10);

        private bool ISMouseDown = false;

        // I use list instead of array because it’s more dynamic and efficient.
        // Store multiple TouchPen
        private List< Tuple <List <Point>, Pen> > TouchPen = new List< Tuple< List <Point>, Pen > >();
        // Store the current TouchPen
        private List<Point> CurrentTouchPen = new List<Point>();

        public FrmMain()
        {
            InitializeComponent();
            // To reduce flickering
            this.DoubleBuffered = true;
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            // To reduce line pixelation
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (var touch in TouchPen)
            {
                if (touch.Item1.Count > 1)
                {
                    e.Graphics.DrawLines(touch.Item2, touch.Item1.ToArray());
                }
            }
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            float NewWidth = 10;

            switch (((Button)sender).Name)
            {
                case "BtnSize4":
                    NewWidth = 10;
                    break;
                case "BtnSize3":
                    NewWidth = 7;
                    break;
                case "BtnSize2":
                    NewWidth = 4;
                    break;
                case "BtnSize1":
                    NewWidth = 1;
                    break;
            }

            pen = new Pen(pen.Color, NewWidth);
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            Color NewColor = Color.Black;

            switch (((Button)sender).Name)
            {
                case "BtnBalckColor":
                    NewColor = Color.Black;
                    break;
                case "BtnBuleColor":
                    NewColor = Color.Blue;
                    break;
                case "BtnGreenColor":
                    NewColor = Color.Green;
                    break;
                case "BtnRedColor":
                    NewColor = Color.Red;
                    break;
            }

            pen = new Pen(NewColor, pen.Width);
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            ISMouseDown = true;

            // Start a new Touch Pen
            CurrentTouchPen = new List<Point> { e.Location };
            // Add it to the list of Touches Pen
            // This ensures that each TouchPen remembers its own pen size and color.
            TouchPen.Add(new Tuple< List<Point>, Pen > (CurrentTouchPen, pen));
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (ISMouseDown)
            {
                CurrentTouchPen.Add(e.Location);
                // Refresh the form to trigger Paint event
                Invalidate();
            }
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            ISMouseDown = false;
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            // Don't let the color exist
            pen.Color = Color.Transparent;

            // Clear all Whiteboard
            TouchPen.Clear();
        }
    }
}
