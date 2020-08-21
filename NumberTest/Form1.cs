using System;
using System.Windows.Forms;

namespace NumberTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte b1;
            //b1 = (byte)((double)numericUpDown1.Value / 3.23);
            //numericUpDown2.Value = (decimal)(b1 * 3.23);

            double a1;
            a1 = (double)numericUpDown1.Value / 3.23;
            decimal d1 = (decimal)(a1 * 3.23);
            numericUpDown2.Value = d1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte b1;
            b1 = (byte)((double)numericUpDown2.Value / 3.23);
            numericUpDown1.Value = (decimal)(b1 * 3.23);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] fileName = new char[20];
            for (int i = 0; i < 20; i++)
            {
                fileName[i] = (char)97;
            }
            label2.Text = string.Join("", fileName);
        }
    }
}
