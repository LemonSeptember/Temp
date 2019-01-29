using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magnifying
{
    public partial class FormMagnifying : Form
    {
        private bool blIsDrawRectangle = true;
        private Point ptBegin = new Point();
        Thread thDraw;
        delegate void myDrawRectangel();
        myDrawRectangel myDraw;

        public FormMagnifying()
        {
            InitializeComponent();
        }


        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (blIsDrawRectangle)
            {
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), ptBegin.X, ptBegin.Y, 50, 50);
            }
        }

        private void FormMagnifying_Load(object sender, EventArgs e)
        {
            myDraw = new myDrawRectangel(ShowDrawRectangle);
            thDraw = new Thread(Run);
            thDraw.Start();
        }
        private void Run()
        {
            //while (true)
            //{
            //    if (pictureBox1.Image != null)
            //    {
            //        //this.BeginInvoke(myDraw);
            //    }
            //    Thread.Sleep(50);
            //}
        }
        private void ShowDrawRectangle()
        {
            Rectangle rec = new Rectangle(ptBegin.X * pictureBox1.Image.Size.Width / 460,
                ptBegin.Y * pictureBox1.Image.Size.Height / 350, 50 * pictureBox1.Image.Size.Width / 460,
                50 * pictureBox1.Image.Size.Height / 350);
            Graphics g = pictureBox2.CreateGraphics();
            g.DrawImage(pictureBox1.Image, pictureBox2.ClientRectangle, rec, GraphicsUnit.Pixel);
            g.Flush();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            blIsDrawRectangle = false;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            blIsDrawRectangle = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X - 25 <= 0)
            {
                ptBegin.X = 0;
            }
            else if (pictureBox1.Size.Width - e.X <= 25)
            {
                ptBegin.X = pictureBox1.Size.Width - 50;
            }
            else
            {
                ptBegin.X = e.X - 25;
            }

            if (e.Y - 25 <= 0)
            {
                ptBegin.Y = 0;
            }
            else if (pictureBox1.Size.Height - e.Y <= 25)
            {
                ptBegin.Y = pictureBox1.Size.Height - 50;
            }
            else
            {
                ptBegin.Y = e.Y - 25;
            }
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"Magnify.exe";
            OpenShellApplication(fileName);
        }
        private void OpenShellApplication(string FileName)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = FileName;
            System.Diagnostics.Process Proc;
            try
            {
                Proc = System.Diagnostics.Process.Start(Info);
            }
            catch
            {
                MessageBox.Show("系统调用[" + FileName + "]应用程序出错！");
            };
        }
    }
}
