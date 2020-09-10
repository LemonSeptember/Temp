using System;
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

        private void button4_Click(object sender, EventArgs e)
        {
            // 2020/1/1 12:00:00
            DateTime dateTime0 = new DateTime(2020, 1, 1, 12, 0, 0);
            // 2020/1/1 12:01:00
            DateTime dateTime1 = new DateTime(2020, 1, 1, 12, 1, 0);
            // 2020/1/1 12:00:01
            DateTime dateTime2 = new DateTime(2020, 1, 1, 12, 0, 1);

            TimeSpan timeSpan1 = dateTime1 - dateTime0;
            TimeSpan timeSpan2 = dateTime2 - dateTime0;

            Console.Write(dateTime1.ToLongTimeString() + " - " + dateTime0.ToLongTimeString());
            Console.WriteLine(" = " + timeSpan1.Milliseconds);
            Console.Write(dateTime2.ToLongTimeString() + " - " + dateTime0.ToLongTimeString());
            Console.WriteLine(" = " + timeSpan2.Milliseconds);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2020, 8, 29);
            Console.WriteLine("DateTime.Now.Date = DateTime.Today ? " + (DateTime.Now.Date == DateTime.Today));
            Console.WriteLine("date = DateTime.Today ? " + (date == DateTime.Today));
            Console.WriteLine("date = DateTime.Now.Date ? " + (DateTime.Now.Date == date));
        }
    }
}
