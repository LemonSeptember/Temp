using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IconTest
{
    public partial class FormIcon : Form
    {
        public FormIcon()
        {
            InitializeComponent();
        }

        private void bottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonToolStripMenuItem.Checked = true;
        }
    }
}
