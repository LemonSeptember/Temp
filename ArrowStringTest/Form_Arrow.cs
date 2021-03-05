using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowStringTest
{
    public partial class Form_Arrow : Form
    {
        public Form_Arrow()
        {
            InitializeComponent();
        }


        private void Form_Arrow_Load(object sender, EventArgs e)
        {
            label1.Text = "↖";
            label2.Text = "↑";
            label3.Text = "↗";
            label4.Text = "←";
            label5.Text = "→";
            label6.Text = "↙";
            label7.Text = "↓";
            label8.Text = "↘";
            label9.Text = "⊕⊙";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog=new FontDialog())
            {
                fontDialog.Font = label1.Font;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    label1.Font = fontDialog.Font;
                    label2.Font = fontDialog.Font;
                    label3.Font = fontDialog.Font;
                    label4.Font = fontDialog.Font;
                    label5.Font = fontDialog.Font;
                    label6.Font = fontDialog.Font;
                    label7.Font = fontDialog.Font;
                    label8.Font = fontDialog.Font;
                    label9.Font = fontDialog.Font;
                    label10.Font = fontDialog.Font;
                    label11.Font = fontDialog.Font;
                    label12.Font = fontDialog.Font;
                }
            }
        }

    }
}
