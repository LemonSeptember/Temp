using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.Util;
using NPOI.XWPF.UserModel;
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


namespace ExportWord
{
    public partial class FormExportWord : Form
    {
        public FormExportWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            XWPFDocument mDocx = new XWPFDocument();

            mDocx = CreatDocxTable();
            mDocx.Write(ms);
            ms.Flush();

            string fileName = DateTime.Now.ToString("HHmmss") + ".docx";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), fileName);

            SaveToFile(ms, filePath);

            //Close();
        }

        protected XWPFDocument CreatDocxTable()
        {
            XWPFDocument mDocx = new XWPFDocument();

            XWPFParagraph p1 = mDocx.CreateParagraph();
            p1.Alignment = ParagraphAlignment.CENTER;//字体居中
            XWPFRun runTitle = p1.CreateRun();
            runTitle.SetText("Title");
            runTitle.SetFontFamily("宋体", FontCharRange.None);
            runTitle.IsBold = true;
            runTitle.FontSize = 16;

            XWPFParagraph p2 = mDocx.CreateParagraph();
            p2.IndentationFirstLine = 100;
            XWPFRun runImageTitle = p2.CreateRun();
            runImageTitle.SetText("Image");
            //runImageTitle.AppendText("Image\t");
            //runImageTitle.AppendText("Image1\t");
            //runImageTitle.AppendText("Image2\t");
            runImageTitle.SetFontFamily("宋体", FontCharRange.None);
            runImageTitle.FontSize = 10;

            //gp.IndentationFirstLine = Indentation("宋体", 21, 2, FontStyle.Regular);//段首行缩进2字符

            XWPFParagraph p3 = mDocx.CreateParagraph();
            p3.Alignment = ParagraphAlignment.CENTER;   //居中
            XWPFRun runImage = p3.CreateRun();
            runImage.SetFontFamily("宋体", FontCharRange.None);
            runImage.FontSize = 10;
            MemoryStream ms = GetImageStream();
            Bitmap barcodeImage = (Bitmap)Image.FromStream(ms);
            pictureBox1.Image = barcodeImage;


            string imagefile = @".\123.jpg";
            FileStream fileStream = new FileStream(imagefile, FileMode.Open);

            runImage.AddPicture(fileStream, (int)PictureType.JPEG, "fileName", Units.ToEMU(500), Units.ToEMU(250));

            //Clipboard.SetDataObject(barcodeImage);

            //Microsoft.Office.Interop.Word.Range range = wordDoc.Bookmarks.get_Item(ref oBarcodeBookmark).Range;

            //runImage.();

            //XWPFParagraph p3 = mDocx.CreateParagraph();
            //XWPFRun run3 = p3.CreateRun();
            //run3.SetText(runImage.PictureText);
            //run3.SetFontFamily("宋体", FontCharRange.None);
            //run3.FontSize = 10;


            //XWPFTable tableTop = mDocx.CreateTable(2, 5);
            //tableTop.Width = 1000 * 5;
            //tableTop.SetColumnWidth(0, 1300);   /* 设置列宽 */
            //tableTop.SetColumnWidth(1, 500);    /* 设置列宽 */
            //tableTop.SetColumnWidth(2, 1000);   /* 设置列宽 */
            //tableTop.SetColumnWidth(3, 500);    /* 设置列宽 */
            //tableTop.SetColumnWidth(4, 1700);   /* 设置列宽 */

            ////CT_TcPr m_Pr0 = tableTop.GetRow(0).GetCell(0).GetCTTc().AddNewTcPr();
            ////m_Pr0.tcW = new CT_TblWidth();
            ////m_Pr0.tcW.w = "1300";
            ////m_Pr0.tcW.type = ST_TblWidth.dxa;


            //tableTop.GetRow(1).MergeCells(1, 4);/* 合并行 */
            //tableTop.GetRow(1).GetCell(0).SetParagraph(SetCellText(mDocx, tableTop, "产品名称"));
            //tableTop.GetRow(1).GetCell(1).SetParagraph(SetCellText(mDocx, tableTop, "              "));


            return mDocx;
        }

        private MemoryStream GetImageStream()
        {
            try
            {
                Bitmap bmp = GetBitmap();
                //pictureBox1.Image = bmp;
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                return ms;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            
        }

        private Bitmap GetBitmap()
        {
            Bitmap bmp = new Bitmap(300, 300);

            Rectangle rectangle = new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g1 = Graphics.FromImage(bmp))
            {
                g1.CopyFromScreen(0, 0, 0, 0, rectangle.Size);
                g1.Dispose();
            }
            bmp.Save(@".\123.jpg");
            return bmp;
        }

        /// <summary>    
        /// /// 设置字体格式    
        /// /// </summary>    
        /// /// <param name="doc">doc对象</param>    
        /// /// <param name="table">表格对象</param>    
        /// /// <param name="setText">要填充的文字</param>    
        /// /// <returns></returns>    
        public XWPFParagraph SetCellText(XWPFDocument doc, XWPFTable table, string setText)
        {
            //table中的文字格式设置        
            CT_P para = new CT_P();
            XWPFParagraph pCell = new XWPFParagraph(para, table.Body);
            pCell.Alignment = ParagraphAlignment.CENTER;//字体居中
            pCell.VerticalAlignment = TextAlignment.CENTER;//字体居中
            XWPFRun r1c1 = pCell.CreateRun();
            r1c1.SetText(setText);
            r1c1.FontSize = 12;
            r1c1.SetFontFamily("华文楷体", FontCharRange.None);//设置字体
            //r1c1.SetTextPosition(20);//设置高度
            return pCell;
        }

        /// <summary>
        /// 设置单元格格式
        /// </summary>
        /// <param name="doc">doc对象</param>
        /// <param name="table">表格对象</param>
        /// <param name="setText">要填充的文字</param>
        /// <param name="align">文字对齐方式</param>
        /// <param name="textPos">rows行的高度</param>
        /// <returns></returns>
        public XWPFParagraph SetCellText(XWPFDocument doc, XWPFTable table, string setText, ParagraphAlignment align, int textPos)
        {
            CT_P para = new CT_P();
            XWPFParagraph pCell = new XWPFParagraph(para, table.Body);
            //pCell.Alignment = ParagraphAlignment.LEFT;//字体        
            pCell.Alignment = align;
            XWPFRun r1c1 = pCell.CreateRun();
            r1c1.SetText(setText);
            r1c1.FontSize = 12;
            r1c1.SetFontFamily("华文楷体", FontCharRange.None);//设置雅黑字体        
            r1c1.SetTextPosition(textPos);//设置高度         
            return pCell;
        }
           

        static void SaveToFile(MemoryStream ms, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                byte[] data = ms.ToArray();
                fs.Write(data, 0, data.Length);
                fs.Flush();
                data = null;
            }
        }

        private Bitmap GetImage()
        {
            Bitmap bmp = new Bitmap(600, 600);

            Rectangle rectangle = new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g1 = Graphics.FromImage(bmp))
            {
                g1.CopyFromScreen(0, 0, 0, 0, rectangle.Size);
                g1.Dispose();
            }
            return bmp;
        }


    }
}
