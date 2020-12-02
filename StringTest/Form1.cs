using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<char> channelNum = new List<char>();
            for (int i = 0; i < 9; i++)
            {
                channelNum.Add(' ');
            }
            string str = new string(channelNum.ToArray());
            if (string.IsNullOrEmpty(str))
            {
                str = " ";
            }
            Console.WriteLine(str);
        }
    }
}
