using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawBezierTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawBeziersPointF(e);
        }
        private void DrawBezierFloat(PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 1);

            // Create coordinates of points for curve.
            float startX = 100.0F;
            float startY = 100.0F;
            float controlX1 = 200.0F;
            float controlY1 = 10.0F;
            float controlX2 = 350.0F;
            float controlY2 = 50.0F;
            float endX = 500.0F;
            float endY = 100.0F;

            // Draw arc to screen.
            e.Graphics.DrawBezier(blackPen, startX, startY,
                controlX1, controlY1,
                controlX2, controlY2,
                endX, endY);
            e.Graphics.DrawLines(redPen, new PointF[] { new PointF(startX, startY), new PointF(controlX1, controlY1), new PointF(controlX2, controlY2), new PointF(endX, endY) });
        }
        private void DrawBeziersPointF(PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 1);

            // Create points for curve.
            PointF start = new PointF(100.0F, 100.0F);
            PointF control1 = new PointF(200.0F, 10.0F);
            PointF control2 = new PointF(350.0F, 50.0F);
            PointF end1 = new PointF(500.0F, 100.0F);
            PointF control3 = new PointF(600.0F, 150.0F);
            PointF control4 = new PointF(650.0F, 250.0F);
            PointF end2 = new PointF(500.0F, 300.0F);
            PointF[] bezierPoints = { start, control1, control2, end1,
         control3, control4, end2 };

            // Draw arc to screen.
            e.Graphics.DrawBeziers(blackPen, bezierPoints);
            e.Graphics.DrawLines(redPen, bezierPoints);
        }
    }
}
