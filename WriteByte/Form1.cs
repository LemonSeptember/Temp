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
        private const int MAX_VALUE = 512;
        private byte[] data = new byte[MAX_VALUE];

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            for (int i = 0; i <= byte.MaxValue; i++)
            {
                data[i] = (byte)i;
            }
            string name = "cnfg";
            char[] array = name.ToCharArray();
            for (int i = 0; i < name.Length; i++)
            {
                data[i+256] = (byte)array[i];
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
                Filter = "配置文件|*.cfg"
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
            foreach (var temp in data)
            {
                textBox1.AppendText(temp.ToString() + "\t");
            }
            textBox1.AppendText(Environment.NewLine + Environment.NewLine + data.Length);
            
        }
        private void buttonByteToBit_Click(object sender, EventArgs e)
        {
            textBoxBit.Clear();
            
            byte temp = byte.Parse(textBoxByte.Text);
            byte[] text = ByteToBit(temp);
            for (int i = text.Length-1; i >=0 ; i--)
                textBoxBit.AppendText(text[i].ToString());

        }
        private void buttonBitToByte_Click(object sender, EventArgs e)
        {
            textBoxByte.Clear();

            byte[] array = Encoding.Default.GetBytes(textBoxBit.Text);
            for (int i=0;i< 8; i++)
            {
                array[i] -= 48;
            }
            byte text = BitToByte(array);

            textBoxByte.Text = text.ToString();

        }

        private byte[] ByteToBit(byte @byte)
        {
            byte[] array = new byte[8];
            for (int i = 0; i <= 7; i++)
            {
                array[i] = (byte)(@byte & 0x01);
                @byte = (byte)(@byte >> 1);
            }
            return array;
        }

        private byte BitToByte(byte[] array)
         {
            //byte @byte=0;
            //int num = 256;
            //for(int i = 0; i < 8; i++)
            //{
            //    num /= 2;
            //    @byte += (byte)(array[i] * num);
            //}
            //return @byte;
            byte @byte = 0;
            for(int i = 0; i < 8; i++)
            {
                @byte = (byte)(@byte << 1);
                @byte += array[i];

            }
            return @byte;
        }

        private void textBoxByte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonByteToBit_Click(sender,e);
            }
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxBit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonBitToByte_Click(sender, e);
            }
            if (e.KeyChar == 48 || e.KeyChar == 49 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
