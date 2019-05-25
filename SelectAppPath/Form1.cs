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
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "list.csv"));
            richTextBox1.AppendText("\n");
            string filePath = Path.Combine("C:\\name", "path", "list.csv ");
            string fileName = Path.GetFileName(filePath);
            string fileName1 = Path.GetFileName(fileName);
            richTextBox1.AppendText(Path.Combine("C:\\name", "path", "list.csv "));
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(fileName);
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(fileName1);
            richTextBox1.AppendText("\n");


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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "所有文件|*.*|GCA|*.gca",
            };
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                string filePath = openFileDialog.FileName;
                string fileName = string.Empty;
                richTextBox1.ResetText();
                richTextBox1.AppendText(filePath);
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText(Path.GetFullPath(filePath));
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText(Path.GetDirectoryName(filePath));
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText(Path.GetExtension(filePath));
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText(Path.GetFileName(filePath));
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText(Path.GetFileNameWithoutExtension(filePath));
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText(Path.GetPathRoot(filePath));
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText(Path.GetRandomFileName());
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText("\n");

            }
        }
    }
}
