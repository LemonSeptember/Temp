using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XianFeng.Railway.Replay;

namespace ReadGcaPicture
{
    public partial class FormPicture : Form
    {
        //private readonly int 
        int picHeight = 340;
        int picWidth = 640;

        private AnalysisedData mAnalysisData;
        private string fileName;

        private int[] imageArray = new int[217600];
        private int[] imageArray2 = new int[435200];

        //private byte[] bytes;

        public FormPicture()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "GCA|*.gca;*.png",
            };
            // TODO::添加默认路径

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                OpenFile(openFileDialog.FileName);
                //imageArray = GetPictureData(openFileDialog.FileName);
                ShowPicture();
            }
        }
        public byte[] GetPictureData(string imagepath)
        {
            /**/////根据图片文件的路径使用文件流打开，并保存为byte[] 
            FileStream fs = new FileStream(imagepath, FileMode.Open);//可以是其他重载方法 
            byte[] byData = new byte[fs.Length];
            fs.Read(byData, 0, byData.Length);
            fs.Close();
            return byData;
        }


        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="fileName">文件地址</param>
        private void OpenFile(string fileName)
        {
            //System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            //stopWatch.Start();
            //stopWatch.Stop();
            //Console.WriteLine(stopWatch.ElapsedMilliseconds);

            XXCFileReader xxcFileReader = new XXCFileReader();
            mAnalysisData = xxcFileReader.ReadFileSummary(fileName);
            
            // TODO::修改标题
            this.Text = Path.GetFileName(fileName);
        }

        private void ShowPicture()
        {
            Bitmap bitmap = GetBitmap();
            pictureBox1.Image = bitmap;

            //pictureBox1.Image = ReturnPhoto(imageArray);
        }

        public Image ReturnPhoto(byte[] streamByte)
        {
            MemoryStream ms = new MemoryStream(streamByte);
            Image img = Image.FromStream(ms);
            return img;
        }


        private Bitmap GetBitmap()
        {
            //Stream stream=
            for (int i = 0; i < mAnalysisData.xxc_list.Length; i++)
            {
                xfActCode actCode = (xfActCode)mAnalysisData.xxc_list[i];
                switch (actCode)
                {
                    case xfActCode.Photo:
                        for (int j = 0; j < 300000/*217600 */; j++)
                        {
                            if (j % 2 == 0)
                            {
                                imageArray2[j + 1] = mAnalysisData.xxc_list[i + j + 1];
                            }
                            else
                            {
                                imageArray2[j - 1] = mAnalysisData.xxc_list[i + j + 1];
                            }
                            //short colorH = mAnalysisData.xxc_list[i + (j * 2) + 1];
                            //short colorL = mAnalysisData.xxc_list[i + (j * 2) + 2];

                            //imageArray[j] = (colorH << 8) + colorL;
                            //imageArray2[j] = mAnalysisData.xxc_list[i + j + 1];
                        }
                        i += 217600 + 10;
                        break;
                    default:
                        break;
                }
            }
            Bitmap bitmap = new Bitmap(picWidth, 600);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    //Color color1=Color.FromArgb();
                    //Color color = Color.FromArgb(x*y*10000000) ;
                    if (imageArray2[(y * bitmap.Width) + x] == 0)
                    {
                        bitmap.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.White);
                    }

                }
            }

            //MemoryStream m = new MemoryStream();
            //b.Save(m, ImageFormat.Bmp);

            return bitmap;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Image bb = Image.FromStream(m);
            //g.DrawImage(bb, new Point(0, 0));
            //g.draw
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picWidth += 1;
            Console.WriteLine(picWidth);
            ShowPicture();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picWidth -= 1;
            Console.WriteLine(picWidth);
            ShowPicture();
        }
    }
}
