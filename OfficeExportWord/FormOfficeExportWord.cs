using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MSWord = Microsoft.Office.Interop.Word;


namespace OfficeExportWord
{
    public partial class FormOfficeExportWord : Form
    {
        public FormOfficeExportWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object Nothing = System.Reflection.Missing.Value;
            //object path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "MyWord_Print.doc");
            object path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), DateTime.Now.ToString("yyMMdd") + ".doc");
            object format = MSWord.WdSaveFormat.wdFormatDocument;

            MSWord.Application wordApp = new MSWord.Application();
            MSWord.Document wordDoc = new MSWord.Document();
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);



            //wordDoc.SaveAs(ref path, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            wordDoc.SaveAs(ref path);

            wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
            wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);

            //Response.Write("<script>alert('" + path + ": Word文档创建完毕!');</script>");


        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog=new SaveFileDialog())
            {
                saveFileDialog.Filter = "报告|*.docx";
                if (saveFileDialog.ShowDialog()==DialogResult.OK)
                {
                    ExportWord(saveFileDialog.FileName);
                }
            }
        }

        /// <summary>
        /// 导出Word报告
        /// </summary>
        public static void ExportWord(/*ReplayInfo _replayInfo, */string _SaveFilePath)
        {
            object savePath;                                        //文件路径变量
            string strContent = "钢轨探伤仪探伤报告";               //文本内容变量
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string picturePath = Path.Combine(desktopPath, @"bView.jpg");        //图片位置
            //string picturePath = Path.Combine(Application.StartupPath, @"data\image\bView.jpg");        //图片位置

            MSWord.Application wordApp;                     //Word应用程序变量
            MSWord.Document wordDoc;                        //Word文档变量

            savePath = _SaveFilePath;
            wordApp = new MSWord.ApplicationClass(); //初始化
            //wordApp.Visible = true;//使文档可见

            //如果已存在，则删除
            if (File.Exists((string)savePath))
            {
                File.Delete((string)savePath);
            }

            // 由于使用的是COM库，因此有许多变量需要用Missing.Value代替
            object Nothing = System.Reflection.Missing.Value;
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

            try
            {
                // 页面设置
                wordDoc.PageSetup.PaperSize = MSWord.WdPaperSize.wdPaperA4;//设置纸张样式为A4纸
                wordDoc.PageSetup.Orientation = MSWord.WdOrientation.wdOrientPortrait;//排列方式为垂直方向
                wordDoc.PageSetup.TopMargin = wordApp.CentimetersToPoints(float.Parse("2"));
                wordDoc.PageSetup.BottomMargin = wordApp.CentimetersToPoints(float.Parse("2"));
                wordDoc.PageSetup.LeftMargin = wordApp.CentimetersToPoints(float.Parse("2"));
                wordDoc.PageSetup.RightMargin = wordApp.CentimetersToPoints(float.Parse("2"));

                object unite = MSWord.WdUnits.wdStory;
                wordApp.Selection.Font.Name = @"宋体";
                wordApp.Selection.Font.Bold = 1;
                wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;

                wordDoc.Paragraphs.Last.Range.Font.Bold = 1;
                wordDoc.Paragraphs.Last.Range.Font.Size = 20;
                wordDoc.Paragraphs.Last.Range.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphCenter;
                wordDoc.Paragraphs.Last.Range.Text = strContent;

                #region 添加表格、填充数据、设置表格行列宽高、合并单元格、添加表头斜线、给单元格添加图片

                wordDoc.Content.InsertAfter("\n");//这一句与下一句的顺序不能颠倒，原因还没搞透
                wordApp.Selection.EndKey(ref unite, ref Nothing); //将光标移动到文档末尾
                wordApp.Selection.Font.Size = 12;
                wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;

                // 设置表格的行数和列数
                int tableRow = 7;
                int tableColumn = 6;

                // 定义一个Word中的表格对象
                MSWord.Table table = wordDoc.Tables.Add(wordApp.Selection.Range, tableRow, tableColumn, ref Nothing, ref Nothing);

                // 默认创建的表格没有边框，这里修改其属性，使得创建的表格带有边框
                table.Borders.Enable = 1;//这个值可以设置得很大，例如5、13等等

                // 设置table样式
                table.Rows.HeightRule = MSWord.WdRowHeightRule.wdRowHeightAtLeast;//行高至少是一个最小指定值。
                table.Rows.Height = wordApp.CentimetersToPoints(float.Parse("0.8"));//

                //table.Range.Font.Size = 12;
                //table.Range.Font.Bold = 1;

                table.Range.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;//表格文本居中
                table.Range.Cells.VerticalAlignment = MSWord.WdCellVerticalAlignment.wdCellAlignVerticalCenter;//文本垂直贴到底部

                // 表格第一行
                table.Cell(1, 1).Range.Text = "线名：";
                table.Cell(1, 2).Range.Text = "";/*InfoPraser.LineNumDisplayValue(_replayInfo.BasicInfo.LineNum);*/
                table.Cell(1, 3).Range.Text = "线别：";
                table.Cell(1, 4).Range.Text = "";/*InfoPraser.LineTypeDisplayValue(_replayInfo.BasicInfo.LineType);*/
                table.Cell(1, 5).Range.Text = "股别：";
                table.Cell(1, 6).Range.Text = ""; /*InfoPraser.SideStringDisplayValue(_replayInfo.BasicInfo.Side);*/

                // 表格第二行
                table.Cell(2, 1).Range.Text = "轨型：";
                table.Cell(2, 2).Range.Text = ""; /*_replayInfo.BasicInfo.RailType;*/
                table.Cell(2, 3).Range.Text = "伤损类型：";
                table.Cell(2, 4).Range.Text = "";
                table.Cell(2, 5).Range.Text = "生产厂商：";
                table.Cell(2, 6).Range.Text = "";

                // 表格第三行
                table.Cell(3, 1).Range.Text = "伤损编号：";
                table.Cell(3, 2).Range.Text = "";
                table.Cell(3, 3).Range.Text = "探伤时间：";
                //table.Cell(3, 4).Range.Text = _replayInfo.BasicInfo.Date.ToShortDateString()+_replayInfo.BasicInfo.Time.ToShortTimeString();
                table.Cell(3, 4).Range.Text = DateTime.Now.ToString(); ;/* new DateTime(_replayInfo.BasicInfo.Date.Year, _replayInfo.BasicInfo.Date.Month, _replayInfo.BasicInfo.Date.Day, _replayInfo.BasicInfo.Time.Hour, _replayInfo.BasicInfo.Time.Minute, _replayInfo.BasicInfo.Time.Second).ToString();*/
                table.Cell(3, 5).Range.Text = "探伤人员：";
                table.Cell(3, 6).Range.Text = ""; /*InfoPraser.UserNumDisplayValue(_replayInfo.BasicInfo.User);*/

                // 表格第四行
                table.Cell(4, 1).Range.Text = "增益：";
                string gain_A = "A：" + "";/*_replayInfo.ChannelInfo.GetGainString(0);*/
                string gain_B = "B：" + "";/*_replayInfo.ChannelInfo.GetGainString(1);*/
                string gain_C = "C：" + "";/*_replayInfo.ChannelInfo.GetGainString(2);*/
                string gain_D = "D：" + "";/*_replayInfo.ChannelInfo.GetGainString(3);*/
                string gain_E = "E：" + "";/*_replayInfo.ChannelInfo.GetGainString(4);*/
                string gain_F = "F：" + "";/*_replayInfo.ChannelInfo.GetGainString(5);*/
                string gain_G = "G：" + "";/*_replayInfo.ChannelInfo.GetGainString(6);*/
                string gain_H = "H：" + "";/*_replayInfo.ChannelInfo.GetGainString(7);*/
                string gain_I = "I：" + "";/*_replayInfo.ChannelInfo.GetGainString(8);*/
                //table.Cell(4, 2).Range.Text = "1:45dB+2.5dB  2:45dB+0dB  3:45dB+0dB\n4:32dB + -3dB  5:32dB + 0dB  6:32dB + 1dB\n1A: 45dB + 2.5dB  2A: 45dB + 0dB  3A: 45dB + 0dB";
                table.Cell(4, 2).Range.Text = string.Format("{0}  {1}  {2}\n{3}  {4}  {5}\n{6}  {7}  {8}", gain_A, gain_B, gain_C, gain_D, gain_E, gain_F, gain_G, gain_H, gain_I);
                table.Cell(4, 2).Merge(table.Cell(4, 6));//横向合并

                // 表格第五行
                //table.Cell(5, 1).Range.Text = string.Format("地段：0\n当前里程：{0}\n速度：{1}\n",_replayInfo.TaskInfo.CurrentMile.GetDisplayValue(xfMileUnit.KMOther),);
                table.Cell(5, 1).Range.Text = string.Format("地段：0\n当前里程：{0}\n", "" /*_replayInfo.TaskInfo.CurrentMile.GetDisplayValue(xfMileUnit.KMOther)*/);
                object LinkToFile = false;
                object SaveWithDocument = true;
                object Anchor = table.Cell(5, 2).Range;//选中要添加图片的单元格
                wordDoc.Application.ActiveDocument.InlineShapes.AddPicture(picturePath, ref LinkToFile, ref SaveWithDocument, ref Anchor);
                wordDoc.Application.ActiveDocument.InlineShapes[1].Width = wordApp.CentimetersToPoints(float.Parse("16"));          //图片宽度
                wordDoc.Application.ActiveDocument.InlineShapes[1].Height = wordApp.CentimetersToPoints(float.Parse("5.5"));          //图片高度
                table.Rows[5].Height = 450;
                table.Rows[5].Range.Cells.VerticalAlignment = MSWord.WdCellVerticalAlignment.wdCellAlignVerticalTop;
                table.Cell(5, 1).Merge(table.Cell(5, 6));//横向合并
                // 将图片设置为四周环绕型
                //MSWord.Shape s = wordDoc.Application.ActiveDocument.InlineShapes[2].ConvertToShape();
                //s.WrapFormat.Type = MSWord.WdWrapType.wdWrapSquare;

                // 表格第六行
                table.Cell(6, 1).Range.Text = "单位名称：";
                table.Cell(6, 2).Range.Text = "";
                table.Cell(6, 2).Merge(table.Cell(6, 6));//横向合并

                // 表格第七行
                table.Cell(7, 1).Range.Text = "操作人员：";
                table.Cell(7, 2).Range.Text = "";
                table.Cell(7, 5).Range.Text = "日期：";
                table.Cell(7, 6).Range.Text = DateTime.Now.ToShortDateString();
                table.Cell(7, 2).Merge(table.Cell(7, 4));//横向合并

                // 设置table边框样式
                //table.Borders.OutsideLineStyle = MSWord.WdLineStyle.wdLineStyleDouble;//表格外框是双线
                //table.Borders.InsideLineStyle = MSWord.WdLineStyle.wdLineStyleSingle;//表格内框是单线

                #endregion
                // Word默认文档文件格式
                //object format = MSWord.WdSaveFormat.wdFormatDocument;// Word默认文档文件格式。Microsoft.Office.Interop.Word 11.0为doc格式。
                object format = MSWord.WdSaveFormat.wdFormatDocument;// wdFormatDocument97是Word 97-2003 文档
                if (Path.GetExtension(_SaveFilePath) == ".docx")
                {
                    format = MSWord.WdSaveFormat.wdFormatDocumentDefault;// Word默认文档文件格式。对于Microsoft Office Word 2007，这是docx格式。
                }
                // 将wordDoc文档对象的内容保存为DOCX文档
                wordDoc.SaveAs(ref savePath, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);

                //看是不是要打印
                //wordDoc.PrintOut();

                //关闭wordDoc文档对象
                wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
                //关闭wordApp组件对象
                wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
                //Console.WriteLine(savePath + " 创建完毕！");
                MessageBox.Show("导出成功!");
            }
            catch (System.Exception ex)
            {
                //// 关闭wordDoc文档对象
                //wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
                //// 关闭wordApp组件对象
                //wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
                //Console.WriteLine(savePath + " 创建完毕！");
                Console.WriteLine(ex.ToString());
                MessageBox.Show("导出失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
