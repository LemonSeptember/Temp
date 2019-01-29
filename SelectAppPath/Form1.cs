using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectAppPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            richTextBox1.AppendText(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(System.Environment.CurrentDirectory);
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(System.IO.Directory.GetCurrentDirectory());
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(System.AppDomain.CurrentDomain.BaseDirectory);
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(System.Windows.Forms.Application.StartupPath);
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(System.Windows.Forms.Application.ExecutablePath);
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);

            // 1.System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName
            //    获取模块的完整路径。
            // 2.System.Environment.CurrentDirectory
            //    获取和设置当前目录(该进程从中启动的目录)的完全限定目录。
            // 3.System.IO.Directory.GetCurrentDirectory()
            //    获取应用程序的当前工作目录。这个不一定是程序从中启动的目录啊，有可能程序放在C:\www里,这个函数有可能返回C:\Documents and Settings\ZYB\,或者C:\Program Files\Adobe\,有时不一定返回什么东东，这是任何应用程序最后一次操作过的目录，比如你用Word打开了E:\doc\my.doc这个文件，此时执行这个方法就返回了E:\doc了。
            // 4.System.AppDomain.CurrentDomain.BaseDirectory
            //    获取程序的基目录。
            // 5.System.Windows.Forms.Application.StartupPath
            //    获取启动了应用程序的可执行文件的路径。效果和2、5一样。只是5返回的字符串后面多了一个"\"而已。
            // 6.System.Windows.Forms.Application.ExecutablePath
            //    获取启动了应用程序的可执行文件的路径及文件名，效果和1一样。
            // 7.System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase
            //    获取和设置包括该应用程序的目录的名称。
        }
    }
}
