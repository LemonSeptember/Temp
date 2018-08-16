using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteByte
{
    public partial class Form1 : Form
    {
        List<byte> data = new List<byte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportCFG();
        }

        private void ExportCFG()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "配置文件(*.cfg)|*.cfg"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;





            }
        }
    }
}
