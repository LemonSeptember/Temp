using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Log4Net
{
    public partial class FormLog4Net : Form
    {
        public FormLog4Net()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在AssemblyInfo.cs中添加
            //[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
            //设置log4net.config的复制到输出目录属性为始终复制
            LogHelper.WriteLog("程序已启动");

        }
    }
}
