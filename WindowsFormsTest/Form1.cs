using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Table_data = new string[7] { "", "", "", "", "", "", "" };
            for (int i = 0; i < Table_data.Length; i++)
            {
                Console.WriteLine(Table_data[i].ToString() + "i");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char i = (char)46;
            Console.WriteLine(i);
            Console.WriteLine(string.Concat(i));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"\r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string str = Interaction.InputBox("提示信息", "标题", "文本内容", -1, -1);
            string str = Interaction.InputBox("");
            textBox1.Text = str;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "F1";
            short s1 = short.Parse(str);
            Console.WriteLine(s1);
            textBox1.AppendText(s1.ToString());
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Graphics g = e.Graphics;
            Font font = new Font(@"Times New Roman", 9, FontStyle.Bold);
            //Font font = tabControl1.Font;
            
            SolidBrush brush = new SolidBrush(Color.Black);
            RectangleF tRectangleF =tabControl1.GetTabRect(e.Index);
            StringFormat sf = new StringFormat();//封装文本布局信息 
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            //e.Graphics.DrawString("t\na\nb\n1\n", font, brush, tRectangleF, sf);
            e.Graphics.DrawString(tabControl1.Controls[e.Index].Text, font, brush, tRectangleF, sf);
        }
    }
}
