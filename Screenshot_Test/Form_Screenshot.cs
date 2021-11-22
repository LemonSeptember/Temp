using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screenshot_Test
{
    public partial class Form_Screenshot : Form
    {
        public Form_Screenshot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormScreenSave formScreenSave = new FormScreenSave())
            {
                formScreenSave.SaveScreenEvent += FormScreenSave_SaveScreenEvent;
                formScreenSave.ShowDialog();
            }
        }

        private void FormScreenSave_SaveScreenEvent(Bitmap bmp)
        {
            ImageFormat[] formats = new ImageFormat[] { ImageFormat.Jpeg, ImageFormat.Bmp, ImageFormat.Png };
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                //Title = ResourceService.GetString("FormMain.Dialog.SaveScreenshot.Title"),
                Filter = string.Format("{0}|*.jpg|{0}|*.bmp|{0}|*.png", "Image"),
                // TODO::保存截图文件名修改
                FileName = DateTime.Now.ToString("yyyyMMddHHmmss"),
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 第一个选择的 FilterIndex 索引是 1，所以要减 1，与数组索引对应
                ImageFormat format = formats[saveFileDialog.FilterIndex - 1];
                bmp.Save(saveFileDialog.FileName, format);
                MessageBox.Show("保存成功");
                //MessageBox.Show(ResourceService.GetString("FormMain.Dialog.SaveScreenshot.Success"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
