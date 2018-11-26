using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pen
{
    public partial class FormPen : Form
    {
        public FormPen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen2 = new Pen(Color.Blue, 12);
            pen2.DashStyle = DashStyle.Custom;
            pen2.DashPattern = new float[] { 1f, 1f };
            Graphics g2 = this.CreateGraphics();
            g2.DrawLine(pen2, 10, 150, 500, 150);
        }
    }
}
