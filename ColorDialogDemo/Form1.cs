using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorDialogDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AnyColor = true;
            //colorDialog.AllowFullOpen = true;

            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                Button channelButton = sender as Button;
                channelButton.BackColor = colorDialog.Color;

            }
        }
    }
}
