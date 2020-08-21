using System;
using System.Drawing;
using System.Windows.Forms;

namespace PenSize
{
    public partial class FormPenSize : Form
    {
        public FormPenSize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(300, 300);

            Graphics g = Graphics.FromImage(bitmap);

            g.Clear(Color.White);

            Pen pen_1 = new Pen(Color.Black, 1f);
            Pen pen_2 = new Pen(Color.Black, 1.5f);
            Pen pen_3 = new Pen(Color.Black, 2f);

            g.DrawLine(pen_1, 0, 10, bitmap.Width / 2, 90);
            g.DrawLine(pen_1, bitmap.Width, 10, bitmap.Width / 2, 90);
            g.DrawLine(pen_2, 0, 110, bitmap.Width / 2, 190);
            g.DrawLine(pen_2, bitmap.Width, 110, bitmap.Width / 2, 190);
            g.DrawLine(pen_3, 0, 210, bitmap.Width / 2, 290);
            g.DrawLine(pen_3, bitmap.Width, 210, bitmap.Width / 2, 290);

            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(300, 300);

            Graphics g = Graphics.FromImage(bitmap);

            g.Clear(Color.Black);

            Pen pen_1 = new Pen(Color.White, 1f);
            Pen pen_2 = new Pen(Color.White, 1.5f);
            Pen pen_3 = new Pen(Color.White, 2f);

            g.DrawLine(pen_1, 10, 10, 90, 90);
            g.DrawLine(pen_2, 110, 110, 190, 190);
            g.DrawLine(pen_3, 210, 210, 290, 290);


            g.DrawLine(pen_1, 10, 210, 12, 212);
            g.DrawLine(pen_2, 10, 250, 12, 252);
            g.DrawLine(pen_3, 10, 290, 12, 292);

            pictureBox1.Image = bitmap;
        }
    }
}
