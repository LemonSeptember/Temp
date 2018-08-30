using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamageReport
{
    public partial class FormDamageReport : Form
    {
        public FormDamageReport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打印(pdf)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 导出(图片)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            //Bitmap image = new Bitmap(ActiveForm.Width-16, ActiveForm.Height-39);   //减去多余的边
            Bitmap image = new Bitmap(panelTitle.Width, panelTitle.Height + panelBView.Height + panelMiddle.Height + groupBoxTaskInfo.Height);
            Graphics imgGraphics = Graphics.FromImage(image);
            imgGraphics.CopyFromScreen(panelTitle.PointToScreen(Point.Empty), Point.Empty, image.Size); //从屏幕截取图像，范围可自己调整

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "图片文件|*.jpg;*.bmp;*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)     //显示保存文件对话框
            {
                image.Save(saveFileDialog.FileName);                //保存图片
                MessageBox.Show("图片保存成功！");
            }
            imgGraphics.Dispose();
            image.Dispose();
        }

        /// <summary>
        /// 储存(数据库&文件)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
