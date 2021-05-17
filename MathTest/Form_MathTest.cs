using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTest
{
    public partial class Form_MathTest : Form
    {
        public Form_MathTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int S1_ON = (1 << 3) + (1 << 2) + (0 << 1) + (0 << 0);
            const int S2_ON = (1 << 3) + (1 << 2) + (0 << 1) + (1 << 0);
            const int S3_ON = (1 << 3) + (1 << 2) + (1 << 1) + (0 << 0);

            const int MASTER_SELECT_C1 = (S1_ON << 8) + (S1_ON << 4) + (S1_ON << 0);
            const int MASTER_SELECT_C2 = (S2_ON << 8) + (S2_ON << 4) + (S2_ON << 0);
            const int MASTER_SELECT_C3 = (S3_ON << 8) + (S3_ON << 4) + (S3_ON << 0);

            const int SLAVE_SELECT_C1 = (S1_ON << 8) + (S1_ON << 4) + (S1_ON << 0);
            const int SLAVE_SELECT_C2 = (S2_ON << 8) + (S2_ON << 4) + (S2_ON << 0);
            const int SLAVE_SELECT_C3 = (S3_ON << 8) + (S3_ON << 4) + (S3_ON << 0);

            const int MASTER_PULSE_C1 = (1 << 0) + (1 << 3) + (1 << 6);
            const int MASTER_PULSE_C2 = (1 << 1) + (1 << 4) + (1 << 7);
            const int MASTER_PULSE_C3 = (1 << 2) + (1 << 5) + (1 << 8);

            const int SLAVE_PULSE_C1 = (1 << 2) + (1 << 5) + (1 << 8);
            const int SLAVE_PULSE_C2 = (1 << 1) + (1 << 4) + (1 << 7);
            const int SLAVE_PULSE_C3 = (1 << 0) + (1 << 3) + (1 << 6);
        }
    }
}
