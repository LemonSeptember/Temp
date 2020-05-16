using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HT10D
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            GC.Collect();
            string fileName;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "探伤文件|*.xav;*.xai;*.xbi|所有文件|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    string extension = Path.GetExtension(fileName);
                    switch (extension)
                    {
                        case ".xav":
                            OpenFile(fileName);
                            break;
                        case ".xai":
                            OpenFile(fileName);
                            break;
                        case ".xbi":
                            OpenFile(fileName);
                            break;
                        default:
                            break;
                    }

                }

            }

        }

        private void OpenFile(string fileName)
        {
            HT10D_Info mHT10D_Info = new HT10D_Info();
            HT10D_FileReader mHT10D_FileReader = new HT10D_FileReader();

            mHT10D_Info = mHT10D_FileReader.ReadFileSummary(fileName);


            ShowImage(mHT10D_Info);
            ShowAView(mHT10D_Info);

        }

        /// <summary>
        /// 显示波形
        /// </summary>
        /// <param name="mHT10D_Info"></param>
        private void ShowAView(HT10D_Info mHT10D_Info)
        {
            if (mHT10D_Info.AViewList != null)
            {
                ucAView.InitAView(mHT10D_Info);
                trackBar_AViewPoint.Value = 0;
                trackBar_AViewPoint.Maximum = mHT10D_Info.AViewList.Count - 1;
                trackBar_AViewPoint.Enabled = true;
            }
            else
            {
                trackBar_AViewPoint.Enabled = false;
            }

        }

        private void ShowImage(HT10D_Info mHT10D_Info)
        {
            if (mHT10D_Info.AViewImage != null)
            {
                pictureBox1.Image = mHT10D_Info.AViewImage;
            }
            if (mHT10D_Info.BViewImage != null)
            {
                pictureBox1.Image = mHT10D_Info.BViewImage;
            }

        }

        private void OpenXAVFile(string fileName)
        {
            throw new NotImplementedException();
        }

        private void trackBar_AViewPoint_Scroll(object sender, EventArgs e)
        {
            ucAView.PlayPoint = trackBar_AViewPoint.Value;
        }
    }
}
