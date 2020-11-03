using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureBoxDemo
{
    public partial class FormPicture : Form
    {
        public FormPicture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = GetBitmap();
            pictureBox1.Image = bitmap;
        }

        private Bitmap GetBitmap()
        {
            Bitmap bitmap = new Bitmap(640, 340);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = Color.FromArgb(1206662020);
                    //Color color = new Color();
                    bitmap.SetPixel(x, y, color);
                }
                for (int y = 200; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, Color.Black);
                }
            }

            return bitmap;
        }

        /// <summary>
        /// 文件名
        /// </summary>
        private string curFileName;

        /// <summary>
        /// 图像对象
        /// </summary>
        private Bitmap curBitmap;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opndlg = new OpenFileDialog();
            opndlg.Filter = "所有图像文件|*.bmp;*.pcx;*.png;*.jpg;*.gif";
            opndlg.Title = "打开图像文件";
            if (opndlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = opndlg.FileName;
                try
                {
                    curBitmap = (Bitmap)Image.FromFile(curFileName);
                    Console.WriteLine(curFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            pictureBox1.Image = curBitmap;
            //Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = GetPicture();
        }

        private const int BorderBlank = 20;
        private int cellWidth1 = 300;
        private int cellWidth2 = 300;
        private const int cellHeight1 = 100;
        private const int cellHeight2 = 80;

        private Point point_1_1;
        private Point point_1_2;
        private Point point_1_3;
        private Point point_1_3_1;
        private Point point_1_3_2;
        private Point point_1_3_3;

        private Point point_2_1;
        private Point point_2_2;
        private Point point_2_3;

        private Point point_3_1;
        private Point point_3_2;
        private Point point_3_2_1;
        private Point point_3_2_2;
        private Point point_3_2_3;
        private Point point_3_2_4;
        private Point point_TextLine_1;
        private Point point_TextLine_2;

        private Point point_4_1;
        private Point point_4_2;

        private Bitmap GetPicture()
        {
            //int picWidth = 860;
            //int picHeight = 900;
            int picWidth = pictureBox1.Width;
            int picHeight = pictureBox1.Height;
            int picAViewWidth = 640;
            int picAViewHeight = 480;

            Bitmap bitmap = new Bitmap(picWidth, picHeight);
            cellWidth1 = pictureBox1.Width / 3;
            cellWidth2 = pictureBox1.Width - (cellHeight1 * 2);

            point_1_1 = new Point(BorderBlank, BorderBlank);
            point_1_2 = new Point(BorderBlank + cellWidth1, BorderBlank);
            point_1_3 = new Point(BorderBlank + cellWidth1 * 2, BorderBlank);
            point_1_3_1 = new Point(BorderBlank + cellWidth1 * 2, BorderBlank);
            point_1_3_2 = new Point(BorderBlank + cellWidth1 * 2 + cellWidth1 / 2, BorderBlank);
            point_1_3_3 = new Point(BorderBlank + cellWidth1 * 2, BorderBlank + cellHeight1 / 2);

            point_2_1 = new Point(BorderBlank, BorderBlank + cellHeight1);
            point_2_2 = new Point(BorderBlank + cellWidth1, BorderBlank + cellHeight1);
            point_2_3 = new Point(BorderBlank + cellWidth1 * 2, BorderBlank + cellHeight1);

            point_3_1 = new Point(BorderBlank, BorderBlank + cellHeight1 * 2);
            point_3_2 = new Point(BorderBlank + picAViewWidth + 30 * 2, BorderBlank + cellHeight1 * 2 + 10);
            point_3_2_1 = new Point(BorderBlank + picAViewWidth + 30 * 2, BorderBlank + cellHeight1 * 2 + 10);
            point_3_2_2 = new Point(BorderBlank + picAViewWidth + 30 * 2, BorderBlank + cellHeight1 * 2 + 10 + 40);
            point_3_2_3 = new Point(((BorderBlank + picAViewWidth + 30 * 2) + (picWidth - BorderBlank - 20)) / 2, BorderBlank + cellHeight1 * 2 + 10 + 40);
            point_3_2_4 = new Point(picWidth - BorderBlank - 20, picHeight - BorderBlank - cellHeight2 - 10);
            point_TextLine_1 = new Point((point_3_2_2.X + point_3_2_3.X) / 2, point_3_2_2.Y);
            point_TextLine_2 = new Point((point_3_2_3.X + point_3_2_4.X) / 2, point_3_2_3.Y);

            point_4_1 = new Point(BorderBlank, picHeight - BorderBlank - cellHeight2);
            point_4_2 = new Point(BorderBlank + (picWidth / 2 - BorderBlank), picHeight - BorderBlank - cellHeight2);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                DrawBorderLine(g, bitmap.Size);
                DrawLogoImage(g, bitmap.Size);
                DrawTitleText(g, bitmap.Size);
                DrawBasicInfo(g, bitmap.Size);
                DrawAScanImage(g, bitmap.Size);
            }

            return bitmap;

            //throw new NotImplementedException();
        }

        private void DrawBorderLine(Graphics g, Size size)
        {
            SolidBrush brush = new SolidBrush(Color.SteelBlue);
            Pen pen1 = new Pen(brush, 1f);
            Pen pen2 = new Pen(brush, 2f);
            // 外边框
            Rectangle borderLineRectangle = new Rectangle(BorderBlank, BorderBlank, size.Width - BorderBlank * 2, size.Height - BorderBlank * 2);
            g.DrawRectangle(pen2, borderLineRectangle);

            // 内框
            // 横线1
            int x1, x2, y1, y2;
            x2 = size.Width - BorderBlank;
            y2 = point_2_1.Y;
            g.DrawLine(pen1, point_2_1, new Point(x2, y2));
            // 横线2
            x2 = size.Width - BorderBlank;
            y2 = point_3_1.Y;
            g.DrawLine(pen1, point_3_1, new Point(x2, y2));
            // 横线3
            x2 = size.Width - BorderBlank;
            y2 = point_4_1.Y;
            g.DrawLine(pen1, point_4_1, new Point(x2, y2));

            // 竖线1
            x2 = point_1_2.X;
            y2 = BorderBlank + cellHeight1 * 2;
            g.DrawLine(pen1, point_1_2, new Point(x2, y2));
            // 竖线2
            x2 = point_1_3.X;
            y2 = BorderBlank + cellHeight1 * 2;
            g.DrawLine(pen1, point_1_3, new Point(x2, y2));

            // 小横线
            x2 = size.Width - BorderBlank;
            y2 = point_1_3_3.Y;
            g.DrawLine(pen1, point_1_3_3, new Point(x2, y2));
            // 小竖线
            x2 = point_1_3_2.X;
            y2 = point_1_3_1.Y + cellHeight1 / 2;
            g.DrawLine(pen1, point_1_3_2, new Point(x2, y2));

            // 内单元格
            // 框架
            x2 = size.Width - BorderBlank - 20;
            y2 = point_4_1.Y - 10;
            g.DrawLines(pen1, new Point[] { point_3_2, new Point(point_3_2_4.X, point_3_2.Y), point_3_2_4, new Point(point_3_2.X, point_3_2_4.Y), point_3_2 });
            // 横线
            x2 = size.Width - BorderBlank - 20;
            y2 = point_3_2_2.Y;
            g.DrawLine(pen1, point_3_2_2, new Point(x2, y2));
            // 竖线
            x2 = point_3_2_3.X;
            y2 = point_3_2_4.Y;
            g.DrawLine(pen1, point_3_2_3, new Point(x2, y2));
        }

        private void DrawLogoImage(Graphics g, Size size)
        {
            //string logoFilePath = @"conf\ImageLogo.jpg";
            string logoFilePath = @"D:\Users\KETIZU2\Desktop\ImageLogo.jpg";
            Bitmap bitmapLogo = (Bitmap)Image.FromFile(logoFilePath);
            // Size(33,23)
            //Rectangle rectangle = new Rectangle(new Point(10, 10), new Size(33, 23));
            int logoImageWidth = 33 * 3;
            int logoImageHeigth = 23 * 3;

            int x1 = point_1_1.X + (cellWidth1 - logoImageWidth) / 2;
            int y1 = point_1_1.Y + (cellHeight1 - logoImageHeigth) / 2;
            g.DrawImage(bitmapLogo, x1, y1, logoImageWidth, logoImageHeigth);
        }

        private void DrawTitleText(Graphics g, Size size)
        {
            string title1 = @"ULTRASONIC TEST REPORT";
            string title2 = @"DigiTranz-WT";

            Font font1 = new Font(@"Arial", 15, FontStyle.Regular);
            Font font2 = new Font(@"Arial", 18, FontStyle.Regular);

            //SolidBrush brush1 = new SolidBrush(Color.FromArgb(120, 184, 222));
            //SolidBrush brush1 = new SolidBrush(Color.FromArgb(83, 132, 184));
            SolidBrush brush1 = new SolidBrush(Color.SteelBlue);
            SolidBrush brush2 = new SolidBrush(Color.Black);

            SizeF text1Size = g.MeasureString(title1, font1);
            SizeF text2Size = g.MeasureString(title2, font2);

            int x1 = point_1_2.X + ((cellWidth1 - (int)text1Size.Width) / 2);
            int y1 = point_1_2.Y + ((cellHeight1 - ((int)text1Size.Height + (int)text2Size.Height + 5)) / 2);
            int x2 = point_1_2.X + ((cellWidth1 - (int)text2Size.Width) / 2);
            int y2 = y1 + (int)text1Size.Height + 5;

            g.DrawString(title1, font1, brush1, new Point(x1, y1));
            g.DrawString(title2, font2, brush2, new Point(x2, y2));
        }

        private void DrawBasicInfo(Graphics g, Size size)
        {
            string text1 = "";
            const int textHeight = 30;
            //text1 = string.Format(":{0,9} : {1}", "Gate 1", "ON");
            Font font1 = new Font(@"Arial", 12f, FontStyle.Regular);
            SolidBrush brush1 = new SolidBrush(Color.SteelBlue);
            SizeF text1Size = g.MeasureString(text1, font1);

            int x1, y1, x2, y2;
            // 日期
            text1 = "Date: " + DateTime.Now.ToString("dd/MM/yyy");
            text1Size = g.MeasureString(text1, font1);
            x1 = point_1_3.X + 15;
            y1 = point_1_3.Y + (((cellHeight1 / 2) - (int)text1Size.Height) / 2);
            g.DrawString(text1, font1, brush1, x1, y1);
            // 时间
            text1 = "Time: " + DateTime.Now.ToString("hh:mm tt");
            text1Size = g.MeasureString(text1, font1);
            x1 = point_1_3_2.X + 15;
            y1 = point_1_3_2.Y + (((cellHeight1 / 2) - (int)text1Size.Height) / 2);
            g.DrawString(text1, font1, brush1, x1, y1);

            // 软件版本
            text1 = "Software Version: ";
            text1Size = g.MeasureString(text1, font1);
            x1 = BorderBlank + cellWidth1 * 2 + 15;
            y1 = BorderBlank + (cellHeight1 / 2) + ((cellHeight1 / 2) - (int)text1Size.Height) / 2;
            g.DrawString(text1, font1, brush1, x1, y1);

            #region 第二行

            font1 = new Font(@"Arial", 12f, FontStyle.Regular);
            brush1 = new SolidBrush(Color.Black);

            #region 第一列

            x1 = point_2_1.X + 30;
            y1 = point_2_1.Y;

            text1 = string.Format("{0}: {1}", "Set No.", "");
            y1 += 10;
            g.DrawString(text1, font1, brush1, x1, y1);

            text1 = string.Format("{0}: {1}", "M/c Sr No.", "");
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);

            text1 = string.Format("{0}: {1}", "Op.Code", "");
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);

            #endregion

            #region 第二列

            x1 = point_2_2.X + 30;
            y1 = point_2_2.Y;

            text1 = string.Format("{0}: {1}", "RAIL", "");
            y1 += 10;
            g.DrawString(text1, font1, brush1, x1, y1);

            text1 = string.Format("{0}: {1}", "Road", "");
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);

            text1 = string.Format("{0}: {1}", "Defect Loc.", "");
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);

            #endregion

            #region 第三列

            x1 = point_2_3.X + 30;
            y1 = point_2_3.Y;

            text1 = string.Format("{0}: {1}", "Div/Km/Post", "");
            y1 += 10;
            g.DrawString(text1, font1, brush1, x1, y1);

            text1 = string.Format("{0}: {1}", "Classification", "");
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);

            text1 = string.Format("{0}: {1}  {2}: {3}", "Date", "", "Time", "");
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);

            #endregion

            #endregion

            #region 图片右侧参数

            brush1 = new SolidBrush(Color.Black);
            string text2;

            #region 第一列

            x1 = point_TextLine_1.X;
            y1 = point_TextLine_1.Y;

            text1 = string.Format("{0,15} : ", "Gate Start");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_1.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_1.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            text1 = string.Format("{0,15} : ", "Gate End");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_1.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_1.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            text1 = string.Format("{0,15} : ", "Gate Height");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_1.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_1.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            text1 = string.Format("{0,15} : ", "Display Mode");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_1.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_1.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            text1 = string.Format("{0,15} : ", "Mode");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_1.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_1.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            text1 = string.Format("{0,15} : ", "Filling");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_1.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_1.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            #endregion

            #region 第二列

            x1 = point_TextLine_2.X;
            y1 = point_TextLine_2.Y;
            // Gain
            text1 = string.Format("{0,15} : ", "Gain");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Range
            text1 = string.Format("{0,15} : ", "Range");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Probe Zero
            text1 = string.Format("{0,15} : ", "Probe Zero");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Reject
            text1 = string.Format("{0,15} : ", "Reject");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Gain Step
            text1 = string.Format("{0,15} : ", "Gain Step");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // PRF
            text1 = string.Format("{0,15} : ", "PRF");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Velocity
            text1 = string.Format("{0,15} : ", "Velocity");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Delay
            text1 = string.Format("{0,15} : ", "Delay");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Angle
            text1 = string.Format("{0,15} : ", "Angle");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Thickness
            text1 = string.Format("{0,15} : ", "Thickness");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Damping
            text1 = string.Format("{0,15} : ", "Damping");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            // Energy
            text1 = string.Format("{0,15} : ", "Energy");
            text1Size = g.MeasureString(text1, font1);
            x1 = (int)(point_TextLine_2.X - text1Size.Width);
            y1 += textHeight;
            g.DrawString(text1, font1, brush1, x1, y1);
            text2 = string.Format("{0}", "   ");
            x2 = point_TextLine_2.X;
            g.DrawString(text2, font1, brush1, x2, y1);

            #endregion

            #endregion

            #region 下方参数

            x1 = point_4_1.X + 30;
            y1 = point_4_1.Y;
            brush1 = new SolidBrush(Color.Black);
            font1 = new Font(@"Arial", 12f, FontStyle.Bold);
            Font font2 = new Font(@"Arial", 12f, FontStyle.Underline);
            SolidBrush brush2 = new SolidBrush(Color.SteelBlue);

            text1 = "Observations: ";
            text1 = "Prepared By: ";
            text1Size = g.MeasureString(text1, font1);
            text1Size = g.MeasureString(text1, font1);
            y1 += ((cellHeight2 - (int)text1Size.Height) / 2);
            g.DrawString(text1, font1, brush1, x1, y1);
            x2 = ((size.Width - (BorderBlank * 2)) / 2) + 30;
            g.DrawString(text1, font1, brush1, x2, y1);

            // 下划线
            Pen pen1 = new Pen(brush2, 2f);
            y2 = (size.Height - BorderBlank) - ((cellHeight2 - (int)text1Size.Height) / 2);

            x1 = BorderBlank + 30 + (int)text1Size.Width + 5;
            x2 = (((size.Width - (BorderBlank * 2)) / 2) + 30) - 10;
            g.DrawLine(pen1, x1, y2, x2, y2);

            x1 = (((size.Width - (BorderBlank * 2)) / 2) + 30) + (int)text1Size.Width + 5;
            x2 = size.Width - BorderBlank - 10;
            g.DrawLine(pen1, x1, y2, x2, y2);

            #endregion
        }

        private void DrawAScanImage(Graphics g, Size size)
        {
            int picAViewWidth = 640;
            int picAViewHeight = 480;

            string text1 = @"FileName :";
            Font font1 = new Font(@"Arial", 10.5f, FontStyle.Bold);
            SolidBrush brush1 = new SolidBrush(Color.SteelBlue);
            SizeF text1Size = g.MeasureString(text1, font1);
            int x1 = BorderBlank + 30;
            int y1 = BorderBlank + cellHeight1 * 2 + 15;
            g.DrawString(text1, font1, brush1, new Point(x1, y1));

            Bitmap bitmap = new Bitmap(picAViewWidth, picAViewHeight);
            Graphics g2 = Graphics.FromImage(bitmap);
            g2.Clear(Color.SkyBlue);
            int x2 = x1;
            int y2 = y1 + (int)text1Size.Height + 10;
            g.DrawImage(bitmap, x2, y2);
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            Console.WriteLine("pictureBox.Size:" + pictureBox1.Size);
            Console.WriteLine("Form.Size:" + Size);
        }
    }
}
