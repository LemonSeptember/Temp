using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTF8Text
{
    public partial class Form_UTF8Text : Form
    {
        public Form_UTF8Text()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (short i = 0; i < 30000; i++)
            {
                string text = Encoding.UTF8.GetString(new byte[] { (byte)i });
                Console.WriteLine(text);
            }
        }
    }
}
