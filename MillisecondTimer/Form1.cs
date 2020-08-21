using System;
using System.Windows.Forms;

namespace MillisecondTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MillisecondTimer _sysTimer;

        private void Form1_Load(object sender, EventArgs e)
        {
            _sysTimer = new MillisecondTimer();
            _sysTimer.Tick += sysTimer_Tick; ;
            _sysTimer.Interval = 1; //每秒执行
            _sysTimer.Start();
        }

        private void sysTimer_Tick(object sender, EventArgs e)
        {
            //需要定时执行的内容
            Console.WriteLine(DateTime.Now.Second + " " + DateTime.Now.Millisecond);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _sysTimer.Interval = 25;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _sysTimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _sysTimer.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mTimer.Stop();
        }

        private void mTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.Second + "." + DateTime.Now.Millisecond);
        }
    }
}
