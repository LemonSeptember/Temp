using System;
using System.Windows.Forms;

namespace TopLevel
{
    public partial class Form_TopLevel : Form
    {
        public Form_TopLevel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.TopLevel = false;
            //form1.TopMost = true;
            form1.MdiParent = this;
            form1.Parent = this.panel1;
            form1.BringToFront();
            form1.Show();
        }

    }
}
