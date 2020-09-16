using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharText
{
    public partial class Form_CharText : Form
    {
        public Form_CharText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            var charArray = text.ToCharArray();
            foreach (var item in charArray)
            {
                Console.WriteLine(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            short b = -10000;
            for (; b > -20000; b--)
            {
                Console.WriteLine((char)b);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (short i = 0; i < 30000; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
