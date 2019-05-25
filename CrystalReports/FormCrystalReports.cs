using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrystalReports
{
    public partial class FormCrystalReports : Form
    {
        public FormCrystalReports()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //GetData();
            //GetData1();

            ReportDataSource rds = new ReportDataSource
            {
                Name = "DataSet1",
                Value = GetData1(),
            };
            reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.LocalReport.ReportPath = @"..\..\Report1.rdlc";

            this.reportViewer1.RefreshReport();
        }

        private DataTable GetData1()
        {


            var dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Image", typeof(string));


            Bitmap bmp = GetImage();

            byte[] imgBytes = BitmapToBytes(bmp);

            DataRow dtRow = dt.NewRow();
            dtRow["Name"] = "张三";
            dtRow["Age"] = "22";
            dtRow["Image"] = Convert.ToBase64String(imgBytes);  //存放前先转码。关键之处。

            dt.Rows.Add(dtRow);

            return dt;

            //throw new NotImplementedException();
        }

        private byte[] BitmapToBytes(Bitmap bmp)
        {
            MemoryStream ms = null;
            try
            {
                ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Png);
                byte[] byteImage = new Byte[ms.Length];
                byteImage = ms.ToArray();
                return byteImage;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            finally
            {
                ms.Close();
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

        private void GetData()
        {
            DataSet ds_results = new DataSet();

            //以下为主方法内代码：
            #region 绑定报表参数
            string p1 = "参数1";
            string p2 = "参数2";

            ReportParameter[] rp = new ReportParameter[2];//
            string[] rptName = new string[2] { "START_END_TIME", "参数名2" };//这里要注意，报表参数和文本框的名字必须一致
            object[] rptValue = new object[] { p1, p2 };
            for (int i = 0; i < rp.Length; i++)
            {
                rp[i] = new ReportParameter(rptName[i], rptValue[i].ToString());
            }

            #endregion

            //绑定报表参数后，准备数据集数据源DataSet，然后调用上面通用方法
            generateChart(ds_results, rp);
        }


        /// <summary>
        /// 生成图表
        /// </summary>
        /// <param name="ds_results">数据源</param>
        /// <param name="rp">报表参数</param>
        private void generateChart(DataSet ds_results, ReportParameter[] rp)
        {
            try
            {
                if (ds_results.Tables.Count > 0)
                {
                    //重置报表
                    this.reportViewer1.Reset();
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc";

                    //指定报表参数
                    for (int i = 0; i < rp.Length; i++)
                    {
                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp[i] });//与报表有关问题
                    }

                    //报表数据源
                    ReportDataSource rds1 = new ReportDataSource("DataSet1", ds_results.Tables["DataSet1"]);//注意此处数据集名字“DataSet1”必须要和添加的数据集名字相同，否则无法绑定数据源至报表数据集
                    ReportDataSource rds2 = new ReportDataSource("DataSet2", ds_results.Tables["DataSet2"]);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds1);
                    reportViewer1.LocalReport.DataSources.Add(rds2);

                    reportViewer1.RefreshReport();

                }
                else
                {
                    MessageBox.Show("没有数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //报表数据源
                    ReportDataSource rds1 = new ReportDataSource("DataSet1", ds_results.Tables["DataSet1"]);
                    ReportDataSource rds2 = new ReportDataSource("DataSet2", ds_results.Tables["DataSet2"]);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds1);
                    reportViewer1.LocalReport.DataSources.Add(rds2);

                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {

            }
        }

        //    //以下为主方法内代码：
        //    #region 绑定报表参数
        //    string p1 = "参数1";
        //    string p2 = "参数2";

        //    ReportParameter[] rp = new ReportParameter[2];//
        //    string[] rptName = new string[2] { "START_END_TIME", "参数名2" };//这里要注意，报表参数和文本框的名字必须一致
        //    object[] rptValue = new object[] { p1, p2 };
        //            for (int i = 0; i<rp.Length; i++)
        //            {
        //                rp[i] = new ReportParameter(rptName[i], rptValue[i].ToString());
        //}

        //#endregion

        ////绑定报表参数后，准备数据集数据源DataSet，然后调用上面通用方法
        //generateChart(ds_source, rp);

    }
}
