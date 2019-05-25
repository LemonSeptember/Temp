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
        private const int PicLength = 218240;


        private int picWidth = 640;
        private int picHeight = 341;

        private ToolTip mToolTip=new ToolTip();

        private AnalysisedData mAnalysisData;
        private string fileName;

        private int[] imageArray = new int[217600];
        private int[] imageArray2 = new int[PicLength];

        private List<int[]> listArray = new List<int[]>();

        private short[] ShowA_GATE = new short[8];

        //private int[][] readArray = new int[340][];

        //private byte[] bytes;

        public FormPicture()
        {
            InitializeComponent();
        }

        private void FormPicture_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            mToolTip.UseAnimation = false;
            mToolTip.UseFading = false;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "所有文件|*.*|GCA|*.gca",
                FilterIndex = 2,
            };
            // TODO::添加默认路径

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                fileName =openFileDialog.FileName;
                OpenFile(openFileDialog.FileName);
                //imageArray = GetPictureData(openFileDialog.FileName);
                ShowPicture();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bitmap saveBitmap = new Bitmap(700, 960);
            using (Graphics g = Graphics.FromImage(saveBitmap))
            {
                g.Clear(Color.White);
                Bitmap bitmap = GetBitmap();
                g.DrawImage(bitmap, 30, 50);


                DrawGcaInfo(g);

            }
            string strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            //Console.WriteLine(strDesktopPath);
            saveBitmap.Save(strDesktopPath + "\\Pic.png", ImageFormat.Png);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetListArray();
            
            SaveCSV();
        }

        private void GetListArray()
        {
            listArray.Clear();
            for (int i = 0; i < picHeight; i++)
            {
                int[] temp = new int[picWidth];
                for (int j = 0; j < picWidth; j++)
                {
                    temp[j] = imageArray2[(i * picWidth) + j];
                }
                listArray.Add(temp);
            }
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

        #region 无效

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

        #endregion


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
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //using (Graphics g=pictureBox1.CreateGraphics())
            //{
            //    using (Image image=bitmap)
            //    {
            //        g.DrawImage(image, 0, 0);
            //    }
            //}

            


            //using (Graphics g = Graphics.FromImage(bitmap))
            //{



            //}


            pictureBox1.Image = bitmap;


            //pictureBox1.BackgroundImage = bitmap;
            //pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            //pictureBox1.Image = ReturnPhoto(imageArray);
        }

        private void SaveCSV()
        {
            string filePath = Path.GetDirectoryName(fileName) + "\\list.csv";
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fileStream, System.Text.Encoding.UTF8))
                    {
                        foreach (var row in listArray)
                        {
                            foreach (var column in row)
                            {
                                sw.Write(column+",");
                            }
                            sw.Write("\r\n");

                        }
                    }
                }
                MessageBox.Show("导出文件成功", "提示", MessageBoxButtons.OK);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        /// <summary>
        /// 获取图片
        /// </summary>
        /// <returns></returns>
        private Bitmap GetBitmap()
        {
            bool IfReadPhoto = false;
            short[] xxa_list = mAnalysisData.xxc_list;
            //Stream stream=
            for (int i = 0; i < mAnalysisData.xxc_list.Length; i++)
            {
                xfActCode actCode = (xfActCode)mAnalysisData.xxc_list[i];
                switch (actCode)
                {

                    case xfActCode.Gate0Head:
                        ShowA_GATE[0] = xxa_list[i + 2];
                        //mGcaInfo.GatePos = string.Concat(ShowA_GATE[0]);
                        //i += 2;
                        break;
                    case xfActCode.Gate0Tail:
                        ShowA_GATE[1] = xxa_list[i + 2];
                        //mGcaInfo.GateWid = string.Concat((ShowA_GATE[1] - ShowA_GATE[0]));
                        //i += 2;
                        break;
                    case xfActCode.Gate1Head:
                        ShowA_GATE[2] = xxa_list[i + 2];
                        break;
                    case xfActCode.Gate1Tail:
                        ShowA_GATE[3] = xxa_list[i + 2];
                        break;
                    case xfActCode.Gate2Head:
                        ShowA_GATE[4] = xxa_list[i + 2];
                        break;
                    case xfActCode.Gate2Tail:
                        ShowA_GATE[5] = xxa_list[i + 2];
                        break;
                    case xfActCode.BackAlarm:
                        ShowA_GATE[6] = xxa_list[i + 2];
                        //mGcaInfo.GateHit = string.Concat(xxa_list[i + 2]);
                        //i += 2;
                        break;
                    case xfActCode.PassAlarm:
                        ShowA_GATE[7] = xxa_list[i + 2];
                        break;

                    case xfActCode.Photo:
                        //Console.WriteLine(i);
                        if (!IfReadPhoto)
                        {
                            IfReadPhoto = true;
                            for (int j = 0; j < PicLength/*217600 */; j++)
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
                            i += PicLength;
                        }
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
                    value = Color.FromArgb(0, 0, 255);
                    break;


                default:
                    value = Color.White;
                    Console.WriteLine(key);
                    break;
            }

            return value;
        }

        /// <summary>
        /// 绘制HV信息
        /// </summary>
        /// <param name="g"></param>
        private void DrawGcaInfo(Graphics g)
        {
            GetListArray();

            int[] point = new int[3] { 0, 0, 0 };
            int height = listArray.Count - ((ShowA_GATE[6] * 2) + 5);
            int widthStart = ShowA_GATE[0] * 3 + 3;
            int widthEnd = ShowA_GATE[1] * 3 + 3;

            int imageHeight = 330;
            int imageWidth = 600;
            point[1] = widthEnd;
            point[2] = widthStart;

            for (int i = 6; i < height; i++)
            {
                for (int j = widthStart; j < widthEnd; j++)
                {
                    if (listArray[i][j] == 224)
                    {
                        if (point[0] < (imageHeight - i + 6))
                        {
                            point[0] = imageHeight - i + 6;
                        }
                        if (point[1] > j)
                        {
                            point[1] = j;
                        }
                        if (point[2] < j)
                        {
                            point[2] = j;
                        }
                    }
                }
            }

            Console.WriteLine(point[0]);
            Console.WriteLine(point[1]);
            Console.WriteLine(point[2]);

            string str = Math.Round(point[0] * 100 / (double)imageHeight).ToString() + "%" +
                Math.Round((point[2] - point[1]) * 100 / (double)imageWidth) + "%";

            Font font = new Font(@"宋体", 12, FontStyle.Regular);

            g.DrawString(str.ToString(), font, Brushes.Black, new Point(30, 440));
            //g.DrawLine(new Pen(Color.Black), new Point(10, 400), new Point(50, 400));

        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            //string filePath = Path.GetDirectoryName(fileName) + "\\"+DateTime.Now.ToString("yyyyMMddHHmmss")+".xxc";

            SaveFile(fileName);


        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="fileAdress"></param>
        /// <returns></returns>
        public static bool SaveFile(string fileAdress)
        {
            string fileName = Path.GetFileNameWithoutExtension(fileAdress) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(fileAdress);
            string oldFileAdress = fileAdress;
            string newFileAdress = Path.Combine(Path.GetDirectoryName(fileAdress), fileName);


            string readFile = fileAdress;
            //string writeFile = Path.Combine(Path.GetDirectoryName(FileName), (Path.GetFileNameWithoutExtension(FileName) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xxc"));
            string writeFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), fileName);

            try
            {
                //File.Copy(readFile, writeFile);
                using (FileStream fsRead = new FileStream(readFile, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (FileStream fsWrite = new FileStream(writeFile, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        byte[] buffer = new byte[1024 * 1024 * 2]; //每次读取2M
                        //可能文件比较大，要循环读取，每次读取2M
                        while (true)
                        {
                            //每次读取的数据    n：是每次读取到的实际数据大小
                            int n = fsRead.Read(buffer, 0, buffer.Count());
                            //如果n=0说明读取的数据为空，已经读取到最后了，跳出循环
                            if (n == 0)
                            {
                                break;
                            }
                            //写入每次读取的实际数据大小
                            fsWrite.Write(buffer, 0, n);
                        }

                        using (BinaryWriter bw = new BinaryWriter(fsWrite, Encoding.Unicode))
                        {
                            byte b1 = 125;
                            bw.Write(b1);

                        }

                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.Write(e.StackTrace);
                return false;
            }

            return true;
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
