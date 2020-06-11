using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimerTest
{
    public partial class Form1 : Form
    {
        private DateTime dtFrom = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        private int timeValue = 0;
        private BlockingCollection<string> ExportStr = new BlockingCollection<string>();
        private System.Timers.Timer mTimer_2 = new System.Timers.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = mTimer.Interval;
            mTimer_2.Interval = (int)numericUpDown1.Value;
            mTimer_2.Elapsed += mTimer_2_Elapsed;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mTimer.Interval = (int)numericUpDown1.Value;
            mTimer_2.Interval= (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportStr = new BlockingCollection<string>();
            mTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mTimer.Stop();
            //timeValue = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExportStr = new BlockingCollection<string>();
            mTimer_2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mTimer_2.Stop();
        }

        private void mTimer_Tick(object sender, EventArgs e)
        {
            //timeValue++;
            //Console.WriteLine(timeValue);
            //Console.WriteLine((DateTime.Now.ToUniversalTime().Ticks - dtFrom.Ticks) / 10000);
            //Console.WriteLine(DateTime.Now.ToString("mm:ss.ffff"));
            ExportStr.Add(DateTime.Now.ToString("mm:ss.ffff"));

        }

        private void mTimer_2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            ExportStr.Add(DateTime.Now.ToString("mm:ss.ffff"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = DateTime.Now.ToString("mm_ss");
                saveFileDialog.Filter = "TXT|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fileStream))
                        {
                            foreach (var item in ExportStr)
                            {
                                sw.WriteLine(item);
                            }
                        }
                    }
                }
            }
        }

    }
}
