using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockingCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            var queue = new ConcurrentQueue<string>();
            // 生产者线程
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    queue.Enqueue("value" + count);
                    count++;
                }
            });
            // 消费者线程1
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    string value;
                    if (queue.TryDequeue(out value))
                    {
                        Console.WriteLine("Worker 1: " + value);
                    }
                }
            });
            // 消费者线程2
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    string value;
                    if (queue.TryDequeue(out value))
                    {
                        Console.WriteLine("Worker 2: " + value);
                    }

                }
            });


            Thread.Sleep(50000);

            Console.ReadLine();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            var blockingCollection = new BlockingCollection<string>(500);
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    blockingCollection.Add("value" + count);
                    count++;
                }
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    //Console.WriteLine("Worker 1: " + blockingCollection.Take());
                    richTextBox1.AppendText("Worker 1: " + blockingCollection.Take());
                }
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    //Console.WriteLine("Worker 2: " + blockingCollection.Take());
                    richTextBox2.AppendText("Worker 2: " + blockingCollection.Take());
                }
            });

            Thread.Sleep(50000);

            Console.ReadLine();
        }
    }
}
