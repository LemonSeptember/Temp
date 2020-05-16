using System;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Color = DocumentFormat.OpenXml.Wordprocessing.Color;

namespace ExportWordWithOpenXMLSDK
{
    public partial class ExportWordWithOpenXMLSDK : Form
    {
        public ExportWordWithOpenXMLSDK()
        {
            InitializeComponent();
        }

        private void ExportWordWithOpenXMLSDK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            string fileName = string.Format("NewWord{0}.docx", DateTime.Now.Minute.ToString());
            string filepath = Path.Combine(desktopPath, fileName);
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
            {
                //MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                //mainPart.Document = new Document(
                //    new Body(
                //        new Paragraph(
                //            new Run(
                //                new Text("Create text in body - CreateWordprocessingDocument")))));

                // Add a main document part. 
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                // Create the document structure and add some text.
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Create text in body - CreateWordprocessingDocument"));

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fileName = string.Format("NewWord{0}.docx", DateTime.Now.Minute.ToString());
            string filepath = Path.Combine(desktopPath, fileName);

            //D:\Users\KETIZU2\Desktop\images\logo.jpg
            string pictureName = @"D:\Users\KETIZU2\Desktop\images\logo.jpg";
            InsertAPicture(filepath, pictureName);

        }

        public static void InsertAPicture(string document, string fileName)
        {
            using (WordprocessingDocument wordprocessingDocument = WordprocessingDocument.Create(document, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordprocessingDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                //Paragraph para = body.AppendChild(new Paragraph());
                //Run run = para.AppendChild(new Run());
                ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Jpeg);
                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    imagePart.FeedData(stream);
                }
                AddImageToBody(wordprocessingDocument, mainPart.GetIdOfPart(imagePart));

            }

        }

        private static void AddImageToBody(WordprocessingDocument wordDoc, string relationshipId)
        {
            // Define the reference of the image.
            var element =
                 new Drawing(
                     new DW.Inline(
                         new DW.Extent() { Cx = 990000L, Cy = 792000L },
                         new DW.EffectExtent()
                         {
                             LeftEdge = 0L,
                             TopEdge = 0L,
                             RightEdge = 0L,
                             BottomEdge = 0L
                         },
                         new DW.DocProperties()
                         {
                             Id = (UInt32Value)1U,
                             Name = "Picture 1"
                         },
                         new DW.NonVisualGraphicFrameDrawingProperties(
                             new A.GraphicFrameLocks() { NoChangeAspect = true }),
                         new A.Graphic(
                             new A.GraphicData(
                                 new PIC.Picture(
                                     new PIC.NonVisualPictureProperties(
                                         new PIC.NonVisualDrawingProperties()
                                         {
                                             Id = (UInt32Value)0U,
                                             Name = "New Bitmap Image.jpg"
                                         },
                                         new PIC.NonVisualPictureDrawingProperties()),
                                     new PIC.BlipFill(
                                         new A.Blip(
                                             new A.BlipExtensionList(
                                                 new A.BlipExtension()
                                                 {
                                                     Uri =
                                                        "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                                 })
                                         )
                                         {
                                             Embed = relationshipId,
                                             CompressionState =
                                             A.BlipCompressionValues.Print
                                         },
                                         new A.Stretch(
                                             new A.FillRectangle())),
                                     new PIC.ShapeProperties(
                                         new A.Transform2D(
                                             new A.Offset() { X = 0L, Y = 0L },
                                             new A.Extents() { Cx = 990000L, Cy = 792000L }),
                                         new A.PresetGeometry(
                                             new A.AdjustValueList()
                                         )
                                         { Preset = A.ShapeTypeValues.Rectangle }))
                             )
                             { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                     )
                     {
                         DistanceFromTop = (UInt32Value)0U,
                         DistanceFromBottom = (UInt32Value)0U,
                         DistanceFromLeft = (UInt32Value)0U,
                         DistanceFromRight = (UInt32Value)0U,
                         EditId = "50D07946"
                     });

            // Append the reference to body, the element should be in a Run.
            wordDoc.MainDocumentPart.Document.Body.AppendChild(new Paragraph(new Run(element)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            string fileName = string.Format("NewWord{0}_{1}.docx", DateTime.Now.Minute.ToString(), DateTime.Now.Second.ToString());
            string filepath = Path.Combine(desktopPath, fileName);

            CreateTable(filepath);

        }
        // Insert a table into a word processing document.
        public static void CreateTable(string fileName)
        {
            // Use the file name and path passed in as an argument 
            // to open an existing Word 2007 document.

            //using (WordprocessingDocument doc = WordprocessingDocument.Open(fileName, true))
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                mainPart.Document.AppendChild(new Body());

                // Create an empty table.
                Table table = new Table();

                // Create a TableProperties object and specify its border information.
                TableProperties tblProp = new TableProperties(new TableBorders(
                        new TopBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new BottomBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new LeftBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new RightBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new InsideHorizontalBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new InsideVerticalBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        }
                    )
                );


                tblProp.TableWidth = new TableWidth() { Width = "8306", Type = TableWidthUnitValues.Dxa };
                tblProp.TableLayout = new TableLayout() { Type = TableLayoutValues.Fixed };   //固定列宽
                // Append the TableProperties object to the empty table.
                table.AppendChild<TableProperties>(tblProp);

                // 列宽
                //TableGrid tblGrid = table.AppendChild(new TableGrid());
                //tblGrid.Append(new GridColumn() { Width = new StringValue("100") });
                //tblGrid.Append(new GridColumn() { Width = new StringValue("200") });
                //tblGrid.Append(new GridColumn() { Width = new StringValue("400") });
                //tblGrid.Append(new GridColumn() { Width = new StringValue("100") });
                //tblGrid.Append(new GridColumn() { Width = new StringValue("100") });
                //tblGrid.Append(new GridColumn() { Width = new StringValue("6000") });


                #region 

                {
                    // Create a row.
                    TableRow tr1 = new TableRow();
                    // Create a cell.
                    TableCell tc1 = new TableCell();
                    // Specify the width property of the table cell.
                    //tc1.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "5000" }));
                    //new TableCellWidth() { Type = TableWidthUnitValues.Auto }));

                    // Specify the table cell content.
                    tc1.Append(new Paragraph(new Run(new Text("some text 1"))));
                    // Append the table cell to the table row.
                    tr1.Append(tc1);

                    // Create a second table cell by copying the OuterXml value of the first table cell.
                    TableCell tc2 = new TableCell(tc1.OuterXml);
                    TableCell tc3 = new TableCell(tc1.OuterXml);
                    TableCell tc4 = new TableCell(tc1.OuterXml);
                    TableCell tc5 = new TableCell(tc1.OuterXml);
                    TableCell tc6 = new TableCell(tc1.OuterXml);
                    // Append the table cell to the table row.
                    tr1.Append(tc2);
                    tr1.Append(tc3);
                    tr1.Append(tc4);
                    tr1.Append(tc5);
                    tr1.Append(tc6);
                    // Append the table row to the table.
                    table.Append(tr1);
                }

                //{
                //    TableRow tr2 = new TableRow();
                //    tr2.Append(new TableRowProperties(new TableRowHeight() { HeightType = HeightRuleValues.AtLeast, Val = 5000 }));

                //    TableCell tc1 = new TableCell();
                //    tc1.Append(new TableCellProperties(new HorizontalMerge() { Val = MergedCellValues.Restart }));
                //    tc1.Append(new Paragraph(new Run(new Text("some text 3"))));
                //    tr2.Append(tc1);

                //    TableCell tc2 = new TableCell();
                //    tc2.Append(new TableCellProperties(new HorizontalMerge() { Val = MergedCellValues.Continue }));
                //    tc2.Append(new Paragraph(new Run(new Text("some text 4"))));
                //    tr2.Append(tc2);

                //    TableCell tc3 = new TableCell(tc2.OuterXml);
                //    TableCell tc4 = new TableCell(tc2.OuterXml);
                //    TableCell tc5 = new TableCell(tc2.OuterXml);
                //    TableCell tc6 = new TableCell(tc2.OuterXml);
                //    tr2.Append(tc3);
                //    tr2.Append(tc4);
                //    tr2.Append(tc5);
                //    tr2.Append(tc6);


                //    table.Append(tr2);
                //}

                {
                    TableRow tr3 = new TableRow();
                    {
                        TableCell tc1 = new TableCell();
                        //tc1.Append(new TableCellProperties(new HorizontalMerge() { Val = MergedCellValues.Restart }));
                        tc1.Append(new Paragraph(new Run(new Text("some text 5"))));
                        tc1.Append(new Paragraph(new Run(new Text("some text 5"))));
                        tc1.Append(new Paragraph(new Run(new Text("some text 5"))));
                        //tc1.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "1384" }));
                        tr3.Append(tc1);

                        TableCell tc2 = new TableCell();
                        tc2.Append(new TableCellProperties(new HorizontalMerge() { Val = MergedCellValues.Restart }));
                        //tc2.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "4153" }));
                        tc2.Append(new Paragraph(new Run(new Text("some text 6"))));
                        tr3.Append(tc2);

                        TableCell tc3 = new TableCell();
                        tc3.Append(new TableCellProperties(new HorizontalMerge() { Val = MergedCellValues.Continue }));
                        tc3.Append(new Paragraph(new Run(new Text("some text 7"))));
                        tr3.Append(tc3);

                        TableCell tc4 = new TableCell(tc3.OuterXml);
                        tc4.Append(new TableCellProperties(new HorizontalMerge() { Val = MergedCellValues.Continue }));
                        tr3.Append(tc4);

                        TableCell tc5 = new TableCell();
                        //tc5.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2768" }));
                        //tc5.Append(new TableCellProperties(new HorizontalMerge() { Val = MergedCellValues.Restart }));
                        tc5.Append(new Paragraph(new Run(new Text("some text 8"))));
                        tr3.Append(tc5);

                        TableCell tc6 = new TableCell(tc5.OuterXml);
                        //tc6.Append(new TableCellProperties(new HorizontalMerge() { Val = MergedCellValues.Continue }));
                        tr3.Append(tc6);

                    }

                    table.Append(tr3);
                }

                #endregion


                #region 


                //List<string[]> reportTable = new List<string[]>();
                //reportTable.Add(new string[] { "1-1", "1-2", "1-3", "1-4" });
                //reportTable.Add(new string[] { "2-1", "2-2", "2-3", "2-4" });
                //reportTable.Add(new string[] { "3-1", "3-2", "3-3", "3-4" });
                //reportTable.Add(new string[] { "4-1", "4-2", "4-3", "4-4" });
                //reportTable.Add(new string[] { "5-1", "5-2", "5-3", "5-4" });


                //int count = reportTable.Count;
                //int cols = reportTable[0].Length;
                //int j = 0;
                //foreach (var strs in reportTable)
                //{
                //    TableRow row = new TableRow();
                //    for (int i = 0; i < cols; i++)
                //    {
                //        TableCell cell = new TableCell();
                //        TableCellProperties tableCellProperties = new TableCellProperties();
                //        TableCellMargin margin = new TableCellMargin();
                //        margin.LeftMargin = new LeftMargin() { Width = "100", Type = TableWidthUnitValues.Dxa };
                //        margin.RightMargin = new RightMargin() { Width = "100", Type = TableWidthUnitValues.Dxa };
                //        tableCellProperties.Append(margin);

                //        Paragraph par = new Paragraph();
                //        Run run = new Run();
                //        if (strs.Length != cols && i >= strs.Length - 1)
                //        {
                //            HorizontalMerge verticalMerge = new HorizontalMerge();
                //            if (i == strs.Length - 1)
                //            {
                //                RunProperties rPr = new RunProperties();
                //                rPr.Append(new Bold());
                //                run.Append(rPr);
                //                verticalMerge.Val = MergedCellValues.Restart;
                //                run.Append(new Text(strs[i]));
                //            }
                //            else
                //            {
                //                verticalMerge.Val = MergedCellValues.Continue;
                //            }
                //            tableCellProperties.Append(verticalMerge);
                //        }
                //        else
                //        {
                //            run.Append(new Text(strs[i]));
                //        }
                //        par.Append(run);
                //        cell.Append(tableCellProperties);
                //        cell.Append(par);
                //        row.Append(cell);
                //    }
                //    j++;
                //    table.Append(row);
                //}




                #endregion






                // Append the table to the document.
                wordDocument.MainDocumentPart.Document.Body.Append(table);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            string fileName = string.Format("报告{0}_{1}.docx", DateTime.Now.Minute.ToString(), DateTime.Now.Second.ToString());
            string filepath = Path.Combine(desktopPath, fileName);

            ExportWordDocument(filepath);
        }

        public void ExportWordDocument(string filepath)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());


                #region 标题文字（加粗居中）

                Paragraph para = body.AppendChild(new Paragraph());

                ParagraphProperties pPr = para.AppendChild(new ParagraphProperties());
                pPr.Append(new Justification() { Val = JustificationValues.Center });


                Run run = para.AppendChild(new Run());
                RunProperties rPr = new RunProperties(new RunFonts() { Ascii = "宋体", ComplexScript = "宋体", EastAsia = "宋体", HighAnsi = "宋体" });
                rPr.Append(new FontSize() { Val = "40" });
                rPr.Append(new Bold() { Val = true });

                run.Append(rPr);
                run.Append(new Text("钢轨探伤仪探伤报告"));

                #endregion

                //rPr.FontSize.Val = "40";
                //rPr.Append(new RunFonts() { ComplexScript = "宋体" });
                //rPr.RunFonts.ComplexScript = "宋体";

                //Run r = wordDocument.MainDocumentPart.Document.Descendants<Run>().First();
                //r.PrependChild(rPr);

                #region 表格

                Table table = new Table();

                #region 表格样式

                // Create a TableProperties object and specify its border information.
                TableProperties tblProp = new TableProperties(
                    new TableBorders(
                        new TopBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new BottomBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new LeftBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new RightBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new InsideHorizontalBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new InsideVerticalBorder()
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        }
                    )
                );
                tblProp.TableWidth = new TableWidth() { Width = "9639", Type = TableWidthUnitValues.Dxa };
                tblProp.TableLayout = new TableLayout() { Type = TableLayoutValues.Fixed };   //固定列宽
                tblProp.TableLook = new TableLook() { Val = "0000", FirstRow = false, LastRow = false, FirstColumn = false, LastColumn = false };

                table.Append(tblProp);

                #endregion

                #region 成员模板

                //Paragraph tblPara = new Paragraph();
                //ParagraphProperties tblpPr = tblPara.AppendChild(new ParagraphProperties());
                //tblpPr.AppendChild(new Justification() { Val = JustificationValues.Left });
                //tblpPr.AppendChild(
                //    new RunProperties(
                //        new RunFonts() { Ascii = "宋体", ComplexScript = @"宋体", EastAsia = "宋体", HighAnsi = "宋体" },
                //        new FontSize() { Val = "24" })
                //    );

                TableRow tr = new TableRow();
                tr.AppendChild(new TableRowProperties(new TableRowHeight() { Val = 454 }));

                TableCell tc = new TableCell();
                tc.AppendChild(new TableCellProperties(
                    new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
                    //,new Shading() { Val = ShadingPatternValues.Clear, Fill = "auto" }// 阴影
                    ));
                tc.AppendChild(new TableCellMargin(
                        new LeftMargin() { Width = "100" }
                        ));
                Run tblRun = new Run();
                tblRun.AppendChild(new RunProperties(
                    new RunFonts() { Ascii = "宋体", ComplexScript = @"宋体", EastAsia = "宋体", HighAnsi = "宋体" },
                    new FontSize() { Val = "24" },
                    new Bold() { Val = true }
                    ));
                #endregion

                #region 例1
                {
                    // Create a row.
                    TableRow test1 = new TableRow(tr.OuterXml);
                    // Create a cell.
                    // Create a second table cell by copying the OuterXml value of the first table cell.
                    TableCell tc1 = new TableCell(tc.OuterXml);
                    TableCell tc2 = new TableCell(tc.OuterXml);
                    TableCell tc3 = new TableCell(tc.OuterXml);
                    TableCell tc4 = new TableCell(tc.OuterXml);
                    TableCell tc5 = new TableCell(tc.OuterXml);
                    TableCell tc6 = new TableCell(tc.OuterXml);
                    // Specify the table cell content.
                    Run run1 = new Run(tblRun.OuterXml);
                    Run run2 = new Run(tblRun.OuterXml);
                    Run run3 = new Run(tblRun.OuterXml);
                    Run run4 = new Run(tblRun.OuterXml);
                    Run run5 = new Run(tblRun.OuterXml);
                    Run run6 = new Run(tblRun.OuterXml);
                    run1.Append(new Text("some text 1"));
                    run2.Append(new Text("some text 2"));
                    run3.Append(new Text("some text 3"));
                    run4.Append(new Text("文字4："));
                    run5.Append(new Text("some text 5"));
                    run6.Append(new Text("text 6"));
                    tc1.Append(new Paragraph(run1));
                    tc2.Append(new Paragraph(run2));
                    tc3.Append(new Paragraph(run3));
                    tc4.Append(new Paragraph(run4));
                    tc5.Append(new Paragraph(run5));
                    tc6.Append(new Paragraph(run6));

                    //Paragraph para1 = new Paragraph(tlbPara.OuterXml);
                    //Paragraph para2 = new Paragraph(tlbPara.OuterXml);
                    //Paragraph para3 = new Paragraph(tlbPara.OuterXml);
                    //Paragraph para4 = new Paragraph(tlbPara.OuterXml);
                    //Paragraph para5 = new Paragraph(tlbPara.OuterXml);
                    //Paragraph para6 = new Paragraph(tlbPara.OuterXml);
                    //para1.Append(new Run(new Text("some text 1")));
                    //para2.Append(new Run(new Text("some text 2")));
                    //para3.Append(new Run(new Text("some text 3")));
                    //para4.Append(new Run(new Text("some text 4")));
                    //para5.Append(new Run(new Text("some text 5")));
                    //para6.Append(new Run(new Text("some text 6")));
                    //tc1.Append(para1);
                    //tc2.Append(para2);
                    //tc3.Append(para3);
                    //tc4.Append(para4);
                    //tc5.Append(para5);
                    //tc6.Append(para6);
                    // Append the table cell to the table row.
                    test1.Append(tc1);
                    test1.Append(tc2);
                    test1.Append(tc3);
                    test1.Append(tc4);
                    test1.Append(tc5);
                    test1.Append(tc6);

                    // Append the table row to the table.
                    //table.Append(test1);

                }
                #endregion

                #region 第一行
                {
                    TableRow tr1 = new TableRow(tr.OuterXml);

                    TableCell tc1 = new TableCell(tc.OuterXml);
                    TableCell tc2 = new TableCell(tc.OuterXml);
                    TableCell tc3 = new TableCell(tc.OuterXml);
                    TableCell tc4 = new TableCell(tc.OuterXml);
                    TableCell tc5 = new TableCell(tc.OuterXml);
                    TableCell tc6 = new TableCell(tc.OuterXml);
                    // Specify the table cell content.
                    Run run1 = new Run(tblRun.OuterXml);
                    Run run2 = new Run(tblRun.OuterXml);
                    Run run3 = new Run(tblRun.OuterXml);
                    Run run4 = new Run(tblRun.OuterXml);
                    Run run5 = new Run(tblRun.OuterXml);
                    Run run6 = new Run(tblRun.OuterXml);
                    run1.Append(new Text("线名："));
                    run2.Append(new Text("000"));
                    run3.Append(new Text("线别："));
                    run4.Append(new Text("正线"));
                    run5.Append(new Text("股别："));
                    run6.Append(new Text("右"));
                    tc1.Append(new Paragraph(run1));
                    tc2.Append(new Paragraph(run2));
                    tc3.Append(new Paragraph(run3));
                    tc4.Append(new Paragraph(run4));
                    tc5.Append(new Paragraph(run5));
                    tc6.Append(new Paragraph(run6));
                    // Append the table cell to the table row.
                    tr1.Append(tc1);
                    tr1.Append(tc2);
                    tr1.Append(tc3);
                    tr1.Append(tc4);
                    tr1.Append(tc5);
                    tr1.Append(tc6);
                    // Append the table row to the table.
                    table.Append(tr1);
                }
                #endregion

                #region 第二行
                {
                    TableRow tr2 = new TableRow(tr.OuterXml);

                    TableCell tc1 = new TableCell(tc.OuterXml);
                    TableCell tc2 = new TableCell(tc.OuterXml);
                    TableCell tc3 = new TableCell(tc.OuterXml);
                    TableCell tc4 = new TableCell(tc.OuterXml);
                    TableCell tc5 = new TableCell(tc.OuterXml);
                    TableCell tc6 = new TableCell(tc.OuterXml);
                    // Specify the table cell content.
                    Run run1 = new Run(tblRun.OuterXml);
                    Run run2 = new Run(tblRun.OuterXml);
                    Run run3 = new Run(tblRun.OuterXml);
                    Run run4 = new Run(tblRun.OuterXml);
                    Run run5 = new Run(tblRun.OuterXml);
                    Run run6 = new Run(tblRun.OuterXml);
                    run1.Append(new Text("轨型："));
                    run2.Append(new Text("60"));
                    run3.Append(new Text("伤损类型："));
                    run4.Append(new Text(""));
                    run5.Append(new Text("生产厂商："));
                    run6.Append(new Text(""));
                    tc1.Append(new Paragraph(run1));
                    tc2.Append(new Paragraph(run2));
                    tc3.Append(new Paragraph(run3));
                    tc4.Append(new Paragraph(run4));
                    tc5.Append(new Paragraph(run5));
                    tc6.Append(new Paragraph(run6));
                    // Append the table cell to the table row.
                    tr2.Append(tc1);
                    tr2.Append(tc2);
                    tr2.Append(tc3);
                    tr2.Append(tc4);
                    tr2.Append(tc5);
                    tr2.Append(tc6);
                    // Append the table row to the table.
                    table.Append(tr2);
                }
                #endregion

                #region 第三行
                {
                    TableRow tr3 = new TableRow(tr.OuterXml);

                    TableCell tc1 = new TableCell(tc.OuterXml);
                    TableCell tc2 = new TableCell(tc.OuterXml);
                    TableCell tc3 = new TableCell(tc.OuterXml);
                    TableCell tc4 = new TableCell(tc.OuterXml);
                    TableCell tc5 = new TableCell(tc.OuterXml);
                    TableCell tc6 = new TableCell(tc.OuterXml);
                    // Specify the table cell content.
                    Run run1 = new Run(tblRun.OuterXml);
                    Run run2 = new Run(tblRun.OuterXml);
                    Run run3 = new Run(tblRun.OuterXml);
                    Run run4 = new Run(tblRun.OuterXml);
                    Run run5 = new Run(tblRun.OuterXml);
                    Run run6 = new Run(tblRun.OuterXml);
                    run1.Append(new Text("伤损编号："));
                    run2.Append(new Text(""));
                    run3.Append(new Text("探伤时间："));
                    run4.Append(new Text(DateTime.Now.ToString()));
                    run5.Append(new Text("探伤人员："));
                    run6.Append(new Text(""));
                    tc1.Append(new Paragraph(run1));
                    tc2.Append(new Paragraph(run2));
                    tc3.Append(new Paragraph(run3));
                    tc4.Append(new Paragraph(run4));
                    tc5.Append(new Paragraph(run5));
                    tc6.Append(new Paragraph(run6));
                    // Append the table cell to the table row.
                    tr3.Append(tc1);
                    tr3.Append(tc2);
                    tr3.Append(tc3);
                    tr3.Append(tc4);
                    tr3.Append(tc5);
                    tr3.Append(tc6);
                    // Append the table row to the table.
                    table.Append(tr3);
                }
                #endregion

                #region 第四行
                {
                    TableRow tr4 = new TableRow(tr.OuterXml);

                    TableCell tc1 = new TableCell(tc.OuterXml);
                    TableCell tc2 = new TableCell(tc.OuterXml);

                    TableCellProperties tcPr = tc2.Descendants<TableCellProperties>().First();
                    tcPr.Append(new GridSpan() { Val = 5 });

                    // Specify the table cell content.
                    Run run1 = new Run(tblRun.OuterXml);
                    Run run2 = new Run(tblRun.OuterXml);
                    Run run3 = new Run(tblRun.OuterXml);
                    Run run4 = new Run(tblRun.OuterXml);
                    run1.Append(new Text("增益："));
                    run2.Append(new Text("A：45.0dB  B：45.5dB  C：45.5dB"));
                    run3.Append(new Text("D：45.5dB  E：45.0dB  F：45.0dB"));
                    run4.Append(new Text("G：46.5dB  H：46.5dB  I：52.0dB"));
                    tc1.Append(new Paragraph(run1));
                    tc2.Append(new Paragraph(run2));
                    tc2.Append(new Paragraph(run3));
                    tc2.Append(new Paragraph(run4));
                    // Append the table cell to the table row.
                    tr4.Append(tc1);
                    tr4.Append(tc2);
                    // Append the table row to the table.
                    table.Append(tr4);
                }
                #endregion

                #region 第五行
                {
                    TableRow tr5 = new TableRow(tr.OuterXml);

                    TableCell tc1 = new TableCell(tc.OuterXml);

                    TableRowProperties tblPr4 = tr5.Descendants<TableRowProperties>().First();
                    tblPr4.AppendChild(new TableRowHeight() { Val = 9000 });

                    TableCellProperties tcPr = tc1.Descendants<TableCellProperties>().First();
                    tcPr.Append(
                        new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Top },
                        new GridSpan() { Val = 6 }
                        );
                    tcPr.Append(new TableCellMargin(new TopMargin() { Width = "50" }));

                    //new Shading() { Val = ShadingPatternValues.Clear, Fill = "auto" }
                    // Specify the table cell content.
                    Run run1 = new Run(tblRun.OuterXml);
                    Run run2 = new Run(tblRun.OuterXml);
                    Run run3 = new Run(tblRun.OuterXml);
                    Run run4 = new Run(tblRun.OuterXml);
                    //地段：0
                    //当前里程：0km039m

                    run1.Append(new Text("地段："));
                    run2.Append(new Text("0"));
                    run3.Append(new Text("当前里程："));
                    run4.Append(new Text("0km039m"));
                    tc1.Append(new Paragraph(run1, run2));
                    //tc1.Append(new Paragraph(run2));
                    tc1.Append(new Paragraph(run3, run4));
                    //tc1.Append(new Paragraph(run4));

                    ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Jpeg);


                    //Bitmap bitmap = new Bitmap(500, 500);
                    //Graphics g = Graphics.FromImage(bitmap);
                    //g.Clear(System.Drawing.Color.Pink);
                    //using (MemoryStream stream = new MemoryStream())
                    //{
                    //    bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //    imagePart.FeedData(stream);
                    //}

                    //////string fileName = @"?D:\Users\KETIZU2\Desktop\images\logo.jpg";
                    string fileName = @"D:\Users\KETIZU2\Desktop\images\logo.jpg";
                    using (FileStream stream = new FileStream(fileName, FileMode.Open))
                    {
                        imagePart.FeedData(stream);
                    }

                    // Define the reference of the image.
                    Paragraph paraImage = AddImageToParagraph(mainPart.GetIdOfPart(imagePart), 6120000L, 2160000L);

                    //wordDoc.MainDocumentPart.Document.Body.AppendChild(new Paragraph(new Run(element)));
                    tc1.AppendChild(paraImage);

                    // Append the table cell to the table row.
                    tr5.Append(tc1);
                    // Append the table row to the table.
                    table.Append(tr5);
                }
                #endregion

                #region 第六行
                {
                    TableRow tr6 = new TableRow(tr.OuterXml);

                    TableCell tc1 = new TableCell(tc.OuterXml);
                    TableCell tc2 = new TableCell(tc.OuterXml);

                    TableCellProperties tcPr = tc2.Descendants<TableCellProperties>().First();
                    tcPr.Append(new GridSpan() { Val = 5 });

                    // Specify the table cell content.
                    Run run1 = new Run(tblRun.OuterXml);
                    Run run2 = new Run(tblRun.OuterXml);

                    run1.Append(new Text("单位名称："));
                    run2.Append(new Text(""));

                    tc1.Append(new Paragraph(run1));
                    tc2.Append(new Paragraph(run2));

                    // Append the table cell to the table row.
                    tr6.Append(tc1);
                    tr6.Append(tc2);
                    // Append the table row to the table.
                    table.Append(tr6);
                }
                #endregion

                #region 第七行
                {
                    TableRow tr7 = new TableRow(tr.OuterXml);

                    TableCell tc1 = new TableCell(tc.OuterXml);
                    TableCell tc2 = new TableCell(tc.OuterXml);
                    TableCell tc3 = new TableCell(tc.OuterXml);
                    TableCell tc4 = new TableCell(tc.OuterXml);

                    TableCellProperties tcPr = tc2.Descendants<TableCellProperties>().First();
                    tcPr.Append(new GridSpan() { Val = 3 });

                    // Specify the table cell content.
                    Run run1 = new Run(tblRun.OuterXml);
                    Run run2 = new Run(tblRun.OuterXml);
                    Run run3 = new Run(tblRun.OuterXml);
                    Run run4 = new Run(tblRun.OuterXml);

                    run1.Append(new Text("操作人员："));
                    run2.Append(new Text(""));
                    run3.Append(new Text("日期："));
                    run4.Append(new Text(DateTime.Now.ToString()));

                    tc1.Append(new Paragraph(run1));
                    tc2.Append(new Paragraph(run2));
                    tc3.Append(new Paragraph(run3));
                    tc4.Append(new Paragraph(run4));

                    // Append the table cell to the table row.
                    tr7.Append(tc1);
                    tr7.Append(tc2);
                    tr7.Append(tc3);
                    tr7.Append(tc4);
                    // Append the table row to the table.
                    table.Append(tr7);
                }
                #endregion

                body.Append(table);

                #endregion

                #region 文档格式

                SectionProperties sectPr = body.AppendChild(new SectionProperties());
                sectPr.AppendChild(new PageMargin() { Top = 1134, Right = 1247, Bottom = 1134, Left = 1247, Header = 851, Footer = 992, Gutter = 0 });

                #endregion


            }
        }

        private Paragraph AddImageToParagraph(string relationshipId, long width, long heigth)
        {

            var element =
                 new Drawing(
                     new DW.Inline(
                         new DW.Extent() { Cx = width, Cy = heigth },
                         new DW.EffectExtent()
                         {
                             LeftEdge = 0L,
                             TopEdge = 0L,
                             RightEdge = 0L,
                             BottomEdge = 0L
                         },
                         new DW.DocProperties()
                         {
                             Id = (UInt32Value)1U,
                             Name = "Picture 1"
                         },
                         new DW.NonVisualGraphicFrameDrawingProperties(
                             new A.GraphicFrameLocks() { NoChangeAspect = true }),
                         new A.Graphic(
                             new A.GraphicData(
                                 new PIC.Picture(
                                     new PIC.NonVisualPictureProperties(
                                         new PIC.NonVisualDrawingProperties()
                                         {
                                             Id = (UInt32Value)0U,
                                             Name = "New Bitmap Image.jpg"
                                         },
                                         new PIC.NonVisualPictureDrawingProperties()),
                                     new PIC.BlipFill(
                                         new A.Blip(
                                             new A.BlipExtensionList(
                                                 new A.BlipExtension()
                                                 {
                                                     Uri =
                                                        "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                                 })
                                         )
                                         {
                                             Embed = relationshipId,
                                             CompressionState =
                                             A.BlipCompressionValues.Print
                                         },
                                         new A.Stretch(
                                             new A.FillRectangle())),
                                     new PIC.ShapeProperties(
                                         new A.Transform2D(
                                             new A.Offset() { X = 0L, Y = 0L },
                                             new A.Extents() { Cx = width, Cy = heigth }),
                                         new A.PresetGeometry(
                                             new A.AdjustValueList()
                                         )
                                         { Preset = A.ShapeTypeValues.Rectangle }))
                             )
                             { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                     )
                     {
                         DistanceFromTop = (UInt32Value)0U,
                         DistanceFromBottom = (UInt32Value)0U,
                         DistanceFromLeft = (UInt32Value)0U,
                         DistanceFromRight = (UInt32Value)0U,
                         EditId = "50D07946"
                     });

            return new Paragraph(new Run(element));
        }


        private void button5_Click(object sender, EventArgs e)
        {

            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"999.jpg");

            Bitmap bitmap = new Bitmap(500, 500);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(System.Drawing.Color.Pink);
            //Image image = bitmap;


            using (MemoryStream memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] image = memoryStream.ToArray();

                FileStream fileStream = new FileStream("", FileMode.Create);
                fileStream.Write(image, 0, image.Length);


                //using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                //{
                //    Console.WriteLine(memoryStream.ToString());
                //    Console.WriteLine(fileStream.ToString());
                //    Bitmap bitmap1 = new Bitmap(fileStream);
                //    bitmap1.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"888.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);

                //}
            }

            //////string fileName = @"‪D:\Users\KETIZU2\Desktop\images\logo.jpg";
            //string fileName = @"D:\Users\KETIZU2\Desktop\images\logo.jpg";
            //using (FileStream stream = new FileStream(fileName, FileMode.Open))
            //{
            //    imagePart.FeedData(stream);
            //}

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 设置标签数据
        /// </summary>
        /// <param name="lableData">标签数据</param>
        public void SetLableData(Dictionary<string, string> lableData, WordprocessingDocument wordDoc, List<Paragraph> thisParagraphs)
        {
            if (wordDoc == null)
                throw new Exception("word parse failed.");
            if (lableData == null)
                throw new Exception("lableData can not be null.");
            if (thisParagraphs.Count == 0)
                return;
            var items = lableData.GetEnumerator();
            while (items.MoveNext())
            {
                var item = items.Current;
                foreach (var paragraph in thisParagraphs)
                {
                    if (!paragraph.InnerText.Contains(item.Key))
                        continue;
                    var run = paragraph.Elements<DocumentFormat.OpenXml.Wordprocessing.Run>().FirstOrDefault(g => g.InnerText.Trim() == item.Key);
                    var text = run?.Elements<DocumentFormat.OpenXml.Wordprocessing.Text>().FirstOrDefault(g => g.Text.Trim() == item.Key);
                    if (text != null)
                    {
                        text.Text = item.Value;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string wordDot = "";
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        wordDot = openFileDialog.FileName;
                    }
                }
                using (var document = WordprocessingDocument.Open(wordDot, true))
                {
                    var doc = document.MainDocumentPart.Document;
                    // Code removed here…
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}