

using NPOI.SS.UserModel;
using NPOI.XWPF.Usermodel;
using NPOI.XWPF.UserModel;
using System.IO;

namespace NPOI_Test.Word
{
    class WordTest
    {
        public static void ReadFromExcelFile(string filePath)
        {
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }

                fs.Close();
                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(0);

                IRow row = sheet.GetRow(0);  //读取当前行数据

                //LastRowNum 是当前表的总行数-1（注意）
                int offset = 0;
                for (int i = 0; i <= sheet.LastRowNum; i++)
                {
                    row = sheet.GetRow(i);  //读取当前行数据
                    if (row != null)
                    {
                        //LastCellNum 是当前行的总列数
                        for (int j = 0; j < row.LastCellNum; j++)
                        {
                            //读取该行的第j列数据
                            string value = row.GetCell(j).ToString();
                            Console.Write(value.ToString() + " ");
                        }
                        Console.WriteLine("\n");
                    }
                }
            }

            catch (Exception e)
            {
                //只在Debug模式下才输出
                Console.WriteLine(e.Message);
            }
        }


        public static void ReadWordFile(string filePath)
        {
            FileStream fs = File.OpenRead(filePath);

            XWPFDocument docx = new XWPFDocument(fs);

            XWPFTable table = docx.CreateTable(3, 3);



            //HWPFDocument doc = new XWPFDocument(fs);

        }

    }
}
