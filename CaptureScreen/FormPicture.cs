using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaptureScreen
{
    public partial class FormPicture : Form
    {

        public Bitmap b { get; set; }

        public FormPicture()
        {
            InitializeComponent();

            //CaptureScreen();
            //CaptureJpeg();
        }



        private void ShowImage()
        {
            var g = Graphics.FromImage(b);

            var screenPoint = PointToScreen(pictureBox1.Location);
            //拷贝屏幕区域到Bitmap
            g.CopyFromScreen(new Point(0,0), new Point(0, 0), new Size(pictureBox1.Width, pictureBox1.Height));
            //存文件
            //catchBmp.Save(string.Format(@"D:\image\{0}.jpg", MAC));

            g.DrawImage(b, 0, 0, pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = b;
        }

        private void CaptureScreen()
        {
            var bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //var g = Graphics.FromImage(bitmap);
            //var screenPoint = PointToScreen(pictureBox1.Location);
            //g.CopyFromScreen(screenPoint, new Point(0, 0), new Size(pictureBox1.Width, pictureBox1.Height));
            var screenPoint = PointToScreen(pictureBox1.Location);

            Rectangle rectangle = new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g1 = Graphics.FromImage(bitmap))
            {
                
                g1.CopyFromScreen(0, 0, 0, 0, rectangle.Size);
                g1.DrawImage(bitmap, -(ActiveForm.Location.X), -(ActiveForm.Location.Y), Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                pictureBox1.Image = bitmap;
                g1.Dispose();
            }
        }
        private void CaptureJpeg()
        {
            var catchBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var g = Graphics.FromImage(catchBmp);
            //转换成控件在屏幕上的坐标
            var screenPoint = PointToScreen(pictureBox1.Location);
            //拷贝屏幕区域到Bitmap
            g.CopyFromScreen(screenPoint, new Point(0, 0), new Size(pictureBox1.Width, pictureBox1.Height));
            //存文件
            //catchBmp.Save(string.Format(@"D:\image\{0}.jpg", MAC));

            g.DrawImage(catchBmp, 0, 0, pictureBox1.Width,pictureBox1.Height);

            pictureBox1.Image = catchBmp;
        }

        private void FormPicture_Load(object sender, EventArgs e)
        {
            ShowImage();

        }
    }
}
