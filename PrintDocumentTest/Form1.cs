﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PrintDocumentTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private StringReader lineReader = null;

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics; //获得绘图对象
            float linesPerPage = 0; //页面的行号
            float yPosition = 0;   //绘制字符串的纵向位置
            int count = 0; //行计数器
            float leftMargin = 1; //左边距
            float topMargin = 1; //上边距
            string line = ""; //行字符串
            Font printFont = this.Font; //当前的打印字体
            SolidBrush myBrush = new SolidBrush(Color.Black);//刷子
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(g);//每页可打印的行数
            //逐行的循环打印一页
            while (count < linesPerPage && ((line = lineReader.ReadLine()) != null))
            {
                yPosition = topMargin + (count * printFont.GetHeight(g));
                g.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }
            // 注意：使用本段代码前，要在该窗体的类中定义lineReader对象：
            //       StringReader lineReader = null;
            //如果本页打印完成而line不为空,说明还有没完成的页面,这将触发下一次的打印事件。在下一次的打印中lineReader会
            //自动读取上次没有打印完的内容，因为lineReader是这个打印方法外的类的成员，它可以记录当前读取的位置
            if (line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                // 重新初始化lineReader对象，不然使用打印预览中的打印按钮打印出来是空白页
                lineReader = new StringReader(textBox1.Text); // textBox是你要打印的文本框的内容
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
