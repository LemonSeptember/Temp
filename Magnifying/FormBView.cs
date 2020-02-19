using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magnifying
{
    public partial class FormBView : Form
    {
        public FormBView()
        {
            InitializeComponent();
        }

        private int mValue { get; set; }

        public void SetValue(int _value)
        {
            mValue = _value;

            label1.Text = mValue.ToString();
        }


        #region 鼠标拖动

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void MovingWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }
        #endregion

        private void button_Top_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void button_Bottom_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
        }
    }
}
