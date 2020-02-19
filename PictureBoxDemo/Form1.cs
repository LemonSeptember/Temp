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


        //文件名
        private string curFileName;
        //图像对象
        private Bitmap curBitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opndlg = new OpenFileDialog();
            opndlg.Filter = "所有图像文件|*.bmp;*.pcx;*.png;*.jpg;*.gif";
            opndlg.Title = "打开图像文件";
            if (opndlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = opndlg.FileName;
                try
                {
                    curBitmap = (Bitmap)Image.FromFile(curFileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            pictureBox1.Image = curBitmap;
            //Invalidate();
        }
    }
}
