using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileTest
{
    public partial class Form_OpenFile : Form
    {
        public Form_OpenFile()
        {
            InitializeComponent();
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (Rapp.FirstOpen)
                {
                    openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath);
                }
                openFileDialog.ShowDialog();
                Rapp.FirstOpen = false;
            }
        }
    }

    public class Rapp
    {
        public static bool FirstOpen = true;
    }
}
