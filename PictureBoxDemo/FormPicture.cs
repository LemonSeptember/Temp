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

        private Bitmap GetPicture()
        {
            //int picWidth = 860;
            //int picHeight = 900;
            int picWidth = pictureBox1.Width;
            int picHeight = pictureBox1.Height;
            Bitmap bitmap = new Bitmap(picWidth, picHeight);
            cellWidth1 = pictureBox1.Width / 3;
            cellWidth2 = pictureBox1.Width - (cellHeight1 * 2);

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
            x1 = BorderBlank;
            y1 = BorderBlank + cellHeight1;
            x2 = size.Width - BorderBlank;
            y2 = y1;
            g.DrawLine(pen1, x1, y1, x2, y2);
            // 横线2
            x1 = BorderBlank;
            y1 = BorderBlank + cellHeight1 * 2;
            x2 = size.Width - BorderBlank;
            y2 = y1;
            g.DrawLine(pen1, x1, y1, x2, y2);
            // 横线3
            x1 = BorderBlank;
            y1 = size.Height - BorderBlank - cellHeight2;
            x2 = size.Width - BorderBlank;
            y2 = y1;
            g.DrawLine(pen1, x1, y1, x2, y2);
            // 竖线1
            x1 = BorderBlank + cellWidth1;
            y1 = BorderBlank;
            x2 = x1;
            y2 = BorderBlank + cellHeight1 * 2;
            g.DrawLine(pen1, x1, y1, x2, y2);
            // 竖线2
            x1 = BorderBlank + cellWidth1 * 2;
            y1 = BorderBlank;
            x2 = x1;
            y2 = BorderBlank + cellHeight1 * 2;
            g.DrawLine(pen1, x1, y1, x2, y2);

            // 小横线
            x1 = BorderBlank + cellWidth1 * 2;
            y1 = BorderBlank + cellHeight1 / 2;
            x2 = size.Width - BorderBlank;
            y2 = y1;
            g.DrawLine(pen1, x1, y1, x2, y2);
            // 小竖线
            x1 = BorderBlank + cellWidth1 * 2 + ((size.Width - (BorderBlank * 2 + (cellWidth1 * 2))) / 2);
            y1 = BorderBlank;
            x2 = x1;
            y2 = y1 + cellHeight1 / 2;
            g.DrawLine(pen1, x1, y1, x2, y2);
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

            int x1 = BorderBlank + (cellWidth1 - logoImageWidth) / 2;
            int y1 = BorderBlank + (cellHeight1 - logoImageHeigth) / 2;
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

            int x1 = BorderBlank + cellWidth1 + ((cellWidth1 - (int)text1Size.Width) / 2);
            int y1 = BorderBlank + ((cellHeight1 - ((int)text1Size.Height + (int)text2Size.Height + 5)) / 2);
            int x2 = BorderBlank + cellWidth1 + ((cellWidth1 - (int)text2Size.Width) / 2);
            int y2 = y1 + (int)text1Size.Height + 5;

            g.DrawString(title1, font1, brush1, new Point(x1, y1));
            g.DrawString(title2, font2, brush2, new Point(x2, y2));
        }

        private void DrawBasicInfo(Graphics g, Size size)
        {
            string text1 = "";
            //text1 = string.Format(":{0,9} : {1}", "Gate 1", "ON");
            Font font1 = new Font(@"Arial", 12f, FontStyle.Regular);
            SolidBrush brush1 = new SolidBrush(Color.SteelBlue);
            SizeF text1Size = g.MeasureString(text1, font1);

            int x1, y1;
            // 日期
            text1 = "Date: " + DateTime.Now.ToString("dd/MM/yyy");
            text1Size = g.MeasureString(text1, font1);
            x1 = BorderBlank + cellWidth1 * 2 + 15;
            y1 = BorderBlank + (((cellHeight1 / 2) - (int)text1Size.Height) / 2);
            g.DrawString(text1, font1, brush1, x1, y1);
            // 时间
            text1 = "Time: " + DateTime.Now.ToString("hh:mm tt");
            text1Size = g.MeasureString(text1, font1);
            x1 = BorderBlank + cellWidth1 * 2 + ((size.Width - (BorderBlank * 2 + (cellWidth1 * 2))) / 2) + 15;
            y1 = BorderBlank + (((cellHeight1 / 2) - (int)text1Size.Height) / 2);
            g.DrawString(text1, font1, brush1, x1, y1);

            // 软件版本
            text1 = "Software Version: ";
            text1Size = g.MeasureString(text1, font1);
            x1 = BorderBlank + cellWidth1 * 2 + 15;
            y1 = BorderBlank + (cellHeight1 / 2) + ((cellHeight1 / 2) - (int)text1Size.Height) / 2;
            g.DrawString(text1, font1, brush1, x1, y1);



            #region 参数

            int x2 = 800;
            x1 = 800;
            y1 = BorderBlank + cellHeight1 * 2;
            brush1 = new SolidBrush(Color.Black);

            string text2 = "";
            SizeF text2Size;
            text2 = string.Format("{0,15} : {1}", "Gate 1", "");
            text2Size = g.MeasureString(text2, font1);
            x1 = (int)(x2 - text2Size.Width);
            y1 += 30;
            g.DrawString(text2, font1, brush1, x1, y1);

            text2 = string.Format("{0,15} : {1}", "Gate1 Start", "");
            text2Size = g.MeasureString(text2, font1);
            x1 = (int)(x2 - text2Size.Width);
            y1 += 30;
            g.DrawString(text2, font1, brush1, x1, y1);

            text2 = string.Format("{0,15} : {1}", "Gate1 Width", "");
            text2Size = g.MeasureString(text2, font1);
            x1 = (int)(x2 - text2Size.Width);
            y1 += 30;
            g.DrawString(text2, font1, brush1, x1, y1);

            text2 = string.Format("{0,15} : {1}", "Gate1 Height", "");
            text2Size = g.MeasureString(text2, font1);
            x1 = (int)(x2 - text2Size.Width);
            y1 += 30;
            g.DrawString(text2, font1, brush1, x1, y1);

            text2 = string.Format("{0,15} : {1}", "Gate1 Logic", "");
            text2Size = g.MeasureString(text2, font1);
            x1 = (int)(x2 - text2Size.Width);
            y1 += 30;
            g.DrawString(text2, font1, brush1, x1, y1);

            text2 = string.Format("{0,15} : {1}", "Gate2", "");
            text2Size = g.MeasureString(text2, font1);
            x1 = (int)(x2 - text2Size.Width);
            y1 += 30;
            g.DrawString(text2, font1, brush1, x1, y1);




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
            Console.WriteLine("Form.Size:" + this.Size);
        }
    }
}
