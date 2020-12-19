using System;
using System.Windows.Forms;

namespace SwitchTimeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("执行");
                        break;
                    case 1:
                        Console.WriteLine("执行");
                        break;
                    case 2:
                        Console.WriteLine("执行");
                        break;
                    case 3:
                        Console.WriteLine("执行");
                        break;
                    default:
                        Console.WriteLine("执行");
                        break;
                }
            }
            stopWatch.Stop();
            Console.WriteLine("switch: " + stopWatch.ElapsedMilliseconds);
        }

        /// <summary>
        /// if
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("执行");
                }
                else if (i == 1)
                {
                    Console.WriteLine("执行");
                }
                else if (i == 2)
                {
                    Console.WriteLine("执行");
                }
                else if (i == 3)
                {
                    Console.WriteLine("执行");
                }
                else
                {
                    Console.WriteLine("执行");
                }
            }
            stopWatch.Stop();
            Console.WriteLine("if: " + stopWatch.ElapsedMilliseconds);
        }
    }
}
