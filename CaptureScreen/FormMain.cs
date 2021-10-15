using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CaptureScreen
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //captureControl(pictureBox1);

            FormPicture formPicture = new FormPicture();
            formPicture.bitmap = captureControl(panel_Main);
            formPicture.ShowDialog();
        }

        /// <summary>  
        /// 控件(窗口)的截图，控件被其他窗口(而非本窗口内控件)遮挡时也可以正确截图，使用BitBlt方法  
        /// </summary>  
        /// <param name="control">需要被截图的控件</param>  
        /// <returns>该控件的截图，控件被遮挡时也可以正确截图</returns>  
        public static Bitmap captureControl(Control control)
        {
            //调用API截屏  
            IntPtr hSrce = GetWindowDC(control.Handle);
            IntPtr hDest = CreateCompatibleDC(hSrce);
            IntPtr hBmp = CreateCompatibleBitmap(hSrce, control.Width, control.Height);
            IntPtr hOldBmp = SelectObject(hDest, hBmp);
            if (BitBlt(hDest, 0, 0, control.Width, control.Height, hSrce, 0, 0, CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt))
            {
                Bitmap bmp = Image.FromHbitmap(hBmp);
                SelectObject(hDest, hOldBmp);
                DeleteObject(hBmp);
                DeleteDC(hDest);
                ReleaseDC(control.Handle, hSrce);
                //bmp.Save(@"a.png");
                //bmp.Dispose();
                return bmp;
            }
            return null;

        }


        #region  DLL calls

        [DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSource, int xSrc, int ySrc, CopyPixelOperation rop);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hDc">handle to DC</param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteDC(IntPtr hDc);

        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteObject(IntPtr hDc);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc">handle to DC</param>
        /// <param name="nWidth">width of bitmap, in pixels</param>
        /// <param name="nHeight">height of bitmap, in pixels</param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc">handle to DC</param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc">handle to DC</param>
        /// <param name="bmp">handle to object</param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr ptr);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd">Window to copy,Handle to the window that will be copied.</param>
        /// <param name="hdcBlt">HDC to print into,Handle to the device context.</param>
        /// <param name="nFlags">Optional flags,Specifies the drawing options. It can be one of the following values.param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, UInt32 nFlags);

        [DllImport("user32.dll")]
        static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);
        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            FormMain form1 = new FormMain();
            form1.TopMost = true;
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string snapshotPath = "snapshot.exe";
            string exeFile = Path.Combine(appPath, snapshotPath);

            if (File.Exists(exeFile))
            {
                using (Process process = new Process())
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(exeFile, "");
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }

        }
    }
}
