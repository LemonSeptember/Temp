using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = GetBitmap();
            pictureBox1.Image = bitmap;
        }

        private Bitmap GetBitmap()
        {
            
            Bitmap bitmap = new Bitmap(640, 340);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = Color.FromArgb(1206662020);
                    bitmap.SetPixel(x, y, color);
                }
                for (int y = 200; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, Color.Black);

                }
            }

            return bitmap;

        }
    }
}
