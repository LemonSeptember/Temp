using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressBar1
{
    public partial class Form1 : Form
    {
        int value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        ///// <summary>
        ///// 用双缓冲绘制窗口的所有子控件
        ///// </summary>
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;//用双缓冲绘制窗口的所有子控件
        //        return cp;
        //    }
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            //Application.EnableVisualStyles();
            Console.WriteLine(Application.RenderWithVisualStyles);
            Console.WriteLine(Application.VisualStyleState.ToString());

            //timer1.Enabled = false;
            value = progressBar1.Minimum;
            progressBar1.Value = value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                value += 50;
                //if (value >= progressBar1.Maximum)
                //{
                //    value = progressBar1.Maximum;
                //    timer1.Enabled = false;
                //}
                //System.Threading.Thread.Sleep(500);
                //progressBar1.PerformStep();
                progressBar1.Value = value;
            }
            catch (System.Exception ex)
            {
                LogHelper.WriteLog(ex.ToString(), ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = progressBar1.Minimum;
            progressBar1.Value = value;
        }
        public class LogHelper
        {
            public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
            public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");
            public static void WriteLog(string info)
            {
                if (loginfo.IsInfoEnabled)
                {
                    loginfo.Info(info);
                }
            }

            public static void WriteLog(string info, Exception ex)
            {
                if (logerror.IsErrorEnabled)
                {
                    logerror.Error(info, ex);
                }
            }
        }

    }
}
