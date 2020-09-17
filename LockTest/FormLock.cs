using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockTest
{
    public partial class FormLock : Form
    {

        class TestValue
        {
            public List<int> value;

            public TestValue()
            {
                value = new List<int>();
            }
        }
        private TestValue mTestValue = new TestValue();

        public FormLock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(AddNum);
            thread.Start();
        }

        private void AddNum()
        {
            int i = 0;
            while (true)
            {
                i++;
                if (i < int.MaxValue - 10)
                {
                    mTestValue.value.Add(i);
                }
                else
                {
                    i = 0;
                }
                Console.WriteLine(mTestValue.value.Count);
                Thread.Sleep(100);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lock (mTestValue)
            {
                mTestValue = new TestValue();
                Thread.Sleep(5000);
                Console.WriteLine("清理完毕");
                Console.WriteLine(mTestValue.value.Count);
            }
        }
    }
}
