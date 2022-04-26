using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Rectangle temp1 = Screen.PrimaryScreen.Bounds;
            //Console.WriteLine(temp1);

            //Rectangle temp2 = Screen.GetWorkingArea(this);
            //Console.WriteLine(temp2);

            //Rectangle temp3 = Screen.GetBounds(this);
            //Console.WriteLine(temp3);

            foreach (Screen item in Screen.AllScreens)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(GetSystemMetrics(SM_CXVIRTUALSCREEN));
            Console.WriteLine(GetSystemMetrics(SM_CYVIRTUALSCREEN));
            Console.WriteLine(GetSystemMetrics(SM_XVIRTUALSCREEN));
            Console.WriteLine(GetSystemMetrics(SM_YVIRTUALSCREEN));
        }

        [DllImport("user32")]
        public static extern int GetSystemMetrics(int nIndex);

        private const int SM_CXSCREEN = 0;
        private const int SM_CYSCREEN = 1;
        private const int SM_CXVSCROLL = 2;
        private const int SM_CYHSCROLL = 3;
        private const int SM_CYCAPTION = 4;
        private const int SM_CXBORDER = 5;
        private const int SM_CYBORDER = 6;
        private const int SM_CXDLGFRAME = 7;
        private const int SM_CYDLGFRAME = 8;
        private const int SM_CYVTHUMB = 9;
        private const int SM_CXHTHUMB = 10;
        private const int SM_CXICON = 11;
        private const int SM_CYICON = 12;
        private const int SM_CXCURSOR = 13;
        private const int SM_CYCURSOR = 14;
        private const int SM_CYMENU = 15;
        private const int SM_CXFULLSCREEN = 10;
        private const int SM_CYFULLSCREEN = 17;
        private const int SM_CYKANJIWINDOW = 18;
        private const int SM_MOUSEPRESENT = 19;
        private const int SM_CYVSCROLL = 20;
        private const int SM_CXHSCROLL = 21;
        private const int SM_DEBUG = 22;
        private const int SM_SWAPBUTTON = 23;
        private const int SM_RESERVED1 = 24;
        private const int SM_RESERVED2 = 25;
        private const int SM_RESERVED3 = 26;
        private const int SM_RESERVED4 = 27;
        private const int SM_CXMIN = 28;
        private const int SM_CYMIN = 29;
        private const int SM_CXSIZE = 30;
        private const int SM_CYSIZE = 31;
        private const int SM_CXFRAME = 20;
        private const int SM_CYFRAME = 33;
        private const int SM_CXMINTRACK = 34;
        private const int SM_CYMINTRACK = 35;
        private const int SM_CXDOUBLECLK = 36;
        private const int SM_CYDOUBLECLK = 37;
        private const int SM_CXICONSPACING = 38;
        private const int SM_CYICONSPACING = 39;
        private const int SM_MENUDROPALIGNMENT = 40;
        private const int SM_PENWINDOWS = 41;
        private const int SM_DBCSENABLED = 42;
        private const int SM_CMOUSEBUTTONS = 43;
        private const int SM_SECURE = 44;
        private const int SM_CXEDGE = 45;
        private const int SM_CYEDGE = 46;
        private const int SM_CXMINSPACING = 47;
        private const int SM_CYMINSPACING = 48;
        private const int SM_CXSMICON = 49;
        private const int SM_CYSMICON = 50;
        private const int SM_CYSMCAPTION = 51;
        private const int SM_CXSMSIZE = 52;
        private const int SM_CYSMSIZE = 53;
        private const int SM_CXMENUSIZE = 54;
        private const int SM_CYMENUSIZE = 55;
        private const int SM_ARRANGE = 56;
        private const int SM_CXMINIMIZED = 57;
        private const int SM_CYMINIMIZED = 58;
        private const int SM_CXMAXTRACK = 59;
        private const int SM_CYMAXTRACK = 60;
        private const int SM_CXMAXIMIZED = 61;
        private const int SM_CYMAXIMIZED = 62;
        private const int SM_NETWORK = 63;
        private const int SM_CLEANBOOT = 67;
        private const int SM_CXDRAG = 68;
        private const int SM_CYDRAG = 69;
        private const int SM_SHOWSOUNDS = 70;
        private const int SM_CXMENUCHECK = 71;
        private const int SM_CYMENUCHECK = 72;
        private const int SM_SLOWMACHINE = 73;
        private const int SM_MIDEASTENABLED = 74;
        private const int SM_MOUSEWHEELPRESENT = 75;
        private const int SM_CMETRICS = 76;
        private const int SM_XVIRTUALSCREEN = 76;
        private const int SM_YVIRTUALSCREEN = 77;
        private const int SM_CXVIRTUALSCREEN = 78;
        private const int SM_CYVIRTUALSCREEN = 79;
        private const int SM_CMONITORS = 80;
        private const int SM_SAMEDISPLAYFORMAT = 81;
        private const int SM_IMMENABLED = 82;
        private const int SM_CXFOCUSBORDER = 83;
        private const int SM_CYFOCUSBORDER = 84;
        private const int SM_REMOTESESSION = 1000;
    }
}
