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
        
        private int picWidth = 640;
        private int picHeight = 341;

        private ToolTip mToolTip=new ToolTip();

        private AnalysisedData mAnalysisData;
        private string fileName;

        private int[] imageArray = new int[217600];
        private int[] imageArray2 = new int[435200];

        //private byte[] bytes;

        public FormPicture()
        {
            InitializeComponent();
        }

        private void FormPicture_Load(object sender, EventArgs e)
        {
            mToolTip.UseAnimation = false;
            mToolTip.UseFading = false;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "GCA|*.gca",
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

        public Image ReturnPhoto(byte[] streamByte)
        {
            MemoryStream ms = new MemoryStream(streamByte);
            Image img = Image.FromStream(ms);
            return img;
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
                        // TODO::两个标记点
                        i += 217600 * 2;
                        break;
                    default:
                        break;
                }
            }
            Bitmap bitmap = new Bitmap(picWidth, picHeight);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color=GetColor(imageArray2[(y * bitmap.Width) + x]);

                    bitmap.SetPixel(x, y, color);

                    //Color color = Color.FromArgb(x*y*10000000) ;
                    //if (imageArray2[(y * bitmap.Width) + x] == 0)
                    //{
                    //    bitmap.SetPixel(x, y, Color.Black);
                    //}
                    //else
                    //{
                    //    bitmap.SetPixel(x, y, Color.White);
                    //}

                }
            }

            //MemoryStream m = new MemoryStream();
            //b.Save(m, ImageFormat.Bmp);

            return bitmap;

        }

        private Color GetColor(int key)
        {
            Color value = new Color();
            switch (key)
            {
                case 0xE0:// 纯红
                    value = Color.FromArgb(255, 0, 0);
                    break;

                case 0xF0:// 橙
                    value = Color.FromArgb(255, 128, 0);
                    break;

                case 0x03:// 纯蓝
                    value = Color.FromArgb(0, 0, 255);
                    break;

                case 0x1C:// 纯绿
                    value = Color.FromArgb(0, 255, 0);
                    break;

                case 0x1F:// 亮蓝
                    value = Color.FromArgb(0, 255, 255);
                    break;

                case 0x8C:// 棕
                    value = Color.FromArgb(144, 96, 0);
                    break;

                case 0xE3:// 紫红
                    value = Color.FromArgb(255, 0, 255);
                    break;

                case 0xFC:// 黄
                    value = Color.FromArgb(255, 255, 0);
                    break;

                case 0xFF:// 白
                    value = Color.FromArgb(255, 255, 255);
                    break;

                case 0x00:// 黑
                    value = Color.FromArgb(0, 0, 0);
                    break;

                case 0x10:// 深绿
                    value = Color.FromArgb(0, 128, 0);
                    break;

                case 0xF2:// 粉红
                    value = Color.FromArgb(255, 128, 128);
                    break;

                case 0x93:// 浅紫
                    value = Color.FromArgb(128, 128, 255);
                    break;

                case 0x0D:// 蓝绿
                    value = Color.FromArgb(0, 119, 119);
                    break;

                case 0x13:// 浅蓝
                    value = Color.FromArgb(0, 128, 255);
                    break;

                case 0x6D:// 灰
                    value = Color.FromArgb(110, 110, 110);
                    break;


                case 0xFE:// 背景色（浅黄）
                    value = Color.FromArgb(255, 255, 200);
                    break;

                case 0x55:// 绿色填充
                    value = Color.FromArgb(0, 176, 80);
                    break;

                case 0x80:// 红色填充
                    value = Color.FromArgb(255, 0, 0);
                    break;

                case 0x02:// 黄色背景下字体（深绿）
                    value = Color.FromArgb(0, 128, 0);
                    break;


                default:
                    value = Color.White;
                    Console.WriteLine(key);
                    break;
            }

            return value;
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //mToolTip.SetToolTip(pictureBox1, e.Location.ToString());
            //mToolTip.AutoPopDelay = 5000;
            //mToolTip.ShowAlways = false;
            //Console.WriteLine(e.Location.ToString());

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mToolTip.SetToolTip(pictureBox1, e.Location.ToString());
        }

    }


    class ColorInfo
    {
        int Key;
        private Color _value;

        Color value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public ColorInfo(int key)
        {
            Key = key;
        }

    }
}
