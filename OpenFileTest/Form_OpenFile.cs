using System;
using System.IO;
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.OpenWrite(openFileDialog.FileName);
                }

            }
        }
    }

    public class Rapp
    {
        public static bool FirstOpen = true;
    }
}
