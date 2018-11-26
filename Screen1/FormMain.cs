using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Screen1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击弹出截屏窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            // 新建一个和屏幕大小相同的图片
            Bitmap catchBmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            // 创建一个画板，让我们可以在画板上画图
            // 这个画板也就是和屏幕大小一样大的图片
            // 我们可以通过Graphics这个类在这个空白图片上画图
            Graphics g = Graphics.FromImage(catchBmp);
            // 把屏幕图片拷贝到我们创建的空白图片 CatchBmp中
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));
            // 创建截图窗体
            FmScreenCopy fsc = new FmScreenCopy();
            // 指示窗体的背景图片为屏幕图片
            fsc.BackgroundImage = catchBmp;
            //注册事件
            fsc.TransfEvent += frm_TransfEvent;
            // 如果Cutter窗体结束，则从剪切板获得截取的图片，并显示在聊天窗体的发送框中
            fsc.ShowDialog();
        }

        /// <summary>
        /// 两个窗体传值事件
        /// </summary>
        /// <param name="x">始终保持左上角的X坐标</param>
        /// <param name="y">始终保持左上角的Y坐标</param>
        /// <param name="width">截取区域宽度</param>
        /// <param name="height">截取区域高度</param>
        /// <param name="bmp">截取的图形</param>
        public void frm_TransfEvent(int x, int y, int width, int height, Bitmap bmp)
        {
            picScreen.BackgroundImage = bmp;
            lblScreenStartPoint.Text = "X: " + x.ToString() + "\r\nY: " + y.ToString();
            lblScreenArea.Text = "Width: " + width.ToString() + "\r\nHeight: " + height.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bitmap catchBmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(catchBmp);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            FormScreenSave formScreenSave = new FormScreenSave();
            formScreenSave.BackgroundImage = catchBmp;
            formScreenSave.SaveScreenEvent += frm_SaveEvent;
            formScreenSave.ShowDialog();
        }

        public void frm_SaveEvent(int x, int y, int width, int height, Bitmap bmp)
        {
            //picScreen.BackgroundImage = bmp;
            //lblScreenStartPoint.Text = "X: " + x.ToString() + "\r\nY: " + y.ToString();
            //lblScreenArea.Text = "Width: " + width.ToString() + "\r\nHeight: " + height.ToString();

            //Graphics g = Graphics.FromImage(bmp);
            //g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "图片文件|*.jpg|图片文件|*.bmp|图片文件|*.png",
                FileName = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog.FileName);
                MessageBox.Show("储存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //g.Dispose();
        }
    }
}







