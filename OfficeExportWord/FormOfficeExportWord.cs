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
    }
}
