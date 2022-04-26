using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseDown_Test
{
    public partial class Form_MouseDown : Form
    {
        public Form_MouseDown()
        {
            InitializeComponent();
        }

        private void uc_BView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Form.uc_BView");
        }

        private void Form_MouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Form");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Form.Panel");
        }

        //移动鼠标 
        const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //模拟鼠标右键抬起 
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        //模拟鼠标中键抬起 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        //标示是否采用绝对坐标 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        //模拟鼠标滚轮滚动操作，必须配合dwData参数
        const int MOUSEEVENTF_WHEEL = 0x0800;

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private void button1_Click(object sender, EventArgs e)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN, 50, 50, 0, 0);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTUP, 50, 50, 0, 0);
        }
    }
}
