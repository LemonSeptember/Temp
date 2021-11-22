using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandler_Test
{
    public partial class Form1 : Form
    {

        private TestClass TestClass;
        public Form1()
        {
            InitializeComponent();
            TestClass = new TestClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestClass.ButtonChangeHandler += TestClass_ButtonChangeHandler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestClass.ButtonChangeHandler -= TestClass_ButtonChangeHandler;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestClass.Show();
        }

        private void TestClass_ButtonChangeHandler(object sender, EventArgs e)
        {
            Console.WriteLine("输出");
        }
    }
}
