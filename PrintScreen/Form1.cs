using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
        }


        /// <summary>
        /// 获取屏幕截图
        /// </summary>
        /// <returns></returns>
        private Bitmap GetScreenCapture()
        {
            Rectangle tScreenRect = new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Bitmap tSrcBmp = new Bitmap(tScreenRect.Width, tScreenRect.Height); // 用于屏幕原始图片保存
            Graphics gp = Graphics.FromImage(tSrcBmp);
            gp.CopyFromScreen(0, 0, 0, 0, tScreenRect.Size);
            gp.DrawImage(tSrcBmp, 0, 0, tScreenRect, GraphicsUnit.Pixel);
            return tSrcBmp;
        }



        /// <summary>
        /// 图片灰度化
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap ImgRgbToGray(Bitmap bitmap)
        {
            Bitmap b = new Bitmap(bitmap);
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                                            ImageLockMode.ReadWrite,
                                            PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;   // 扫描的宽度 
            unsafe
            {
                byte* p = (byte*)bmData.Scan0.ToPointer(); // 获取图像首地址 
                int nOffset = stride - b.Width * 3;  // 实际宽度与系统宽度的距离 
                byte red, green, blue;
                for (int y = 0; y < b.Height; ++y)
                {
                    for (int x = 0; x < b.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        p[0] = p[1] = p[2] = (byte)(.299 * red + .587 * green + .114 * blue); // 转换公式 

                        p += 3;  // 跳过3个字节处理下个像素点 
                    }
                    p += nOffset; // 加上间隔 
                }
            }
            b.UnlockBits(bmData); // 解锁 
            return b;
        }


        /// <summary>
        /// 使用像素替换的方法
        /// </summary>
        /// <returns></returns>
        private Bitmap PixelReplace()
        {
            Bitmap tSrcBtm = GetScreenCapture();
            Bitmap tGrayBtm = ImgRgbToGray(tSrcBtm);
            for (int i = 55; i < 55 + 520; i++)
            {
                for (int k = 88; k < 88 + 233; k++)
                {
                    tGrayBtm.SetPixel(i, k, tSrcBtm.GetPixel(i, k));
                }
            }
            return tGrayBtm;
        }

        /// <summary>
        /// 在原图上画图的方法
        /// </summary>
        /// <returns></returns>
        private Bitmap DrawOnPicture()
        {
            int tAbsWidth = 1;
            Bitmap tSrcBtm = GetScreenCapture();
            Bitmap tGrayBtm = ImgRgbToGray(tSrcBtm);
            Rectangle tRectArea = new Rectangle(55, 88, 520, 233);
            Rectangle tDrawArea = new Rectangle(55 + tAbsWidth, 88 + tAbsWidth, 520 - tAbsWidth, 233 - tAbsWidth);
            Graphics gp = Graphics.FromImage(tGrayBtm);
            gp.DrawRectangle(Pens.Red, tRectArea);
            gp.DrawImage(tSrcBtm, tDrawArea, tRectArea, GraphicsUnit.Pixel);

            return tGrayBtm;
        }

        /// <summary>
        /// 使用蒙板的方法
        /// </summary>
        public void CaptureScreen()
        {
            // 获取屏幕
            Bitmap btp = GetScreenCapture();
            Image BackScreen = new Bitmap(btp);

            // 在 BackScreen 上绘制蒙板
            Graphics g = Graphics.FromImage(BackScreen);
            g.FillRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 0)), 0, 0, BackScreen.Width, BackScreen.Height);
            this.BackgroundImage = BackScreen;

            // 最大化
            this.WindowState = FormWindowState.Maximized;

            // 不在任务栏显示
            this.ShowInTaskbar = false;
            this.TopMost = true;

            // 无边框
            this.FormBorderStyle = FormBorderStyle.None;

            // 在坐标为(55,88)的地方截取长宽为(520,233)的矩形
            Rectangle rect = new Rectangle(55, 88, 520, 233);
            g.DrawImage(btp, rect, rect, GraphicsUnit.Pixel);

            this.Show();
        }

    }
}
