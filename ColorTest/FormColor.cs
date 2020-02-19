using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ColorTest
{
    public partial class FormColor : Form
    {
        int thisTime;
        int timeValue;
        int randomTime;
        List<int> timeList = new List<int>();
        Random random = new Random();


        [DllImport("winmm")]
        static extern uint timeGetTime();
        [DllImport("winmm")]
        static extern void timeBeginPeriod(int t);
        [DllImport("winmm")]
        static extern uint timeEndPeriod(int t);


        System.Threading.Thread timerthread;


        private readonly uint TIME_N = 1;

        public FormColor()
        {
            InitializeComponent();
        }

        private void FormColor_Load(object sender, EventArgs e)
        {
            timerthread = new System.Threading.Thread(timer);

            //timeBeginPeriod(1);
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_Start.Visible = false;
            timerthread.Start();
            thisTime = 0;
            randomTime = random.Next(1000, 3000);
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            if (timeValue < thisTime)
            {
                return;
            }
            timeValue = thisTime;
            timeList.Add(timeValue);
            label_Time.Text = timeValue.ToString() + " 毫秒（ms）";
            richTextBox_Time.AppendText(timeValue.ToString() + " 毫秒（ms）\n");
            label_averageTime.Text = timeList.Average() + " 毫秒（ms）";
        }


        private void timer()
        {
            uint timerstart = timeGetTime();
            while (true)
            {
                uint i = 0;
                while (i < TIME_N)     //N为时间间隔（ms）
                {
                    i = timeGetTime() - timerstart;
                }
                timerstart = timeGetTime();
                timerfunction();               //需要循环运行的函数；           
            }
        }

        private void timerfunction()
        {
            thisTime++;
            if (thisTime == randomTime)
            {
                button_Color.BackColor = GetColor();
                thisTime = 0;
                timeValue = 3000;
                randomTime = random.Next(1000, 3000);
            }
            //Console.WriteLine(timeCount);
        }


        private Color GetColor()
        {
            
            Color color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            return color;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            timerthread.Abort();
            //timeEndPeriod(1);
            button_Start.Visible = true;
        }

        private void FormColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerthread.Abort();
            //timeEndPeriod(1);
        }
    }
}
