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

namespace WriteByte
{
    public partial class Form1 : Form
    {
        private List<byte> data = new List<byte>();

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            for (int i = 0; i <= byte.MaxValue; i++)
            {
                data.Add((byte)i);
            }
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
                Console.WriteLine(fileName);

                using (FileStream stream = File.OpenWrite(fileName))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        foreach (var a in data)
                        {
                            writer.Write(a);
                        }
                    }
                }
                //using (StreamWriter streamWriter = File.CreateText(fileName))
                //{
                //    foreach (var a in data)
                //    {
                //        streamWriter.Write(a);
                //    }
                //}
                //streamWriter.Close();
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < data.Count; i++)
            {
                Console.Write(data[i] + "\t");

            }
            Console.WriteLine("\n");
            Console.WriteLine(data.Count);
        }
    }
}
