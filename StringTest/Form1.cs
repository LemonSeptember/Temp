using System;
using System.Collections.Generic;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //string str = "焊缝，0,开始，003";
            string str = "焊缝，,开始，003";
            //string str = "L";
            string[] markList = str.Split(',', '，');
            for (int i = 0; i < markList.Length; i++)
            {
                string item = markList[i];
                Console.WriteLine(i + " " + item);
            }
        }
    }
}
