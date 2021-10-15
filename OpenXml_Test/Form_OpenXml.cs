using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Windows.Forms;

namespace OpenXml_Test
{
    public partial class Form_OpenXml : Form
    {
        public Form_OpenXml()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenWord();
        }

        private void OpenWord()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OpenWordFile(openFileDialog.FileName);
                }
            }
        }

        private void OpenWordFile(string filePath)
        {
            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate))
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(fs, true))
                {
                    MainDocumentPart mainDocumentPart = wordDocument.MainDocumentPart;
                    Document a1 = mainDocumentPart.Document;
                    Body a2 = a1.Body;
                    string a3 = a2.OuterXml;

                    Console.WriteLine(a3);
                    // 无法使用，"{"、"}"和"time"在xml中有可能分开；
                    string newStr = a3.Replace(@"{time}", "时间");
                    Console.WriteLine(a3);

                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                    string fileName = $"NewWord_{DateTime.Now.Minute:00}.docx";
                    string savePath = Path.Combine(desktopPath, fileName);
                    using (WordprocessingDocument saveDocument = WordprocessingDocument.Create(savePath, WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart saveDocumentPart = saveDocument.AddMainDocumentPart();
                        saveDocumentPart.Document = new Document();
                        Body body = saveDocumentPart.Document.AppendChild(new Body());
                        body.InnerXml = newStr;
                    }

                    //wordDocument.SaveAs(savePath);
                    Console.WriteLine(a3);
                }
            }
        }
    }
}
