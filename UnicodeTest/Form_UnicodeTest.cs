using System;
using System.Windows.Forms;

namespace UnicodeTest
{
    public partial class Form_UnicodeTest : Form
    {
        public Form_UnicodeTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            string str = textBox1.Text;
            char[] test = str.ToCharArray();
            foreach (char item in test)
            {
                richTextBox1.Text += ((short)item).ToString();
                richTextBox1.Text += "\n";
            }

            //byte[] strList = Encoding.Unicode.GetBytes(str);
            //foreach (byte item in strList)
            //{
            //    richTextBox1.Text += item.ToString();
            //    richTextBox1.Text += "\n";
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            short value = Convert.ToInt16(textBox2.Text);

            richTextBox1.Text += (char)value;

        }
    }
}
