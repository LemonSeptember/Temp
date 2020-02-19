using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IconTest
{
    public partial class FormIcon : Form
    {
        int index = 0;
        public FormIcon()
        {
            InitializeComponent();
        }

        private void bottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonToolStripMenuItem.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //index++;
            //if (index>100)
            //{
            //    index = 0;
            //}
            //progressBar1.Value = index;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
            }
            progressBar1.PerformStep();
            Console.WriteLine(progressBar1.Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
