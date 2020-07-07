using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            try
            {
                dateTime = new DateTime(2019, 2, 29);
            }
            catch (Exception)
            {
                dateTime = DateTime.MinValue;
            }
            Console.WriteLine(dateTime);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            try
            {
                dateTime = new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day, 200, 59, 60);
            }
            catch (Exception)
            {
                dateTime = DateTime.MinValue;
            }
            Console.WriteLine(dateTime.ToString(@"HH\:mm\:ss"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan dateTime;
            try
            {
                dateTime = new TimeSpan(200, 59, 60);
            }
            catch (Exception)
            {
                dateTime = TimeSpan.MinValue;
            }
            Console.WriteLine(dateTime.ToString(@"HH\:mm\:ss"));
        }
    }
}
