using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
