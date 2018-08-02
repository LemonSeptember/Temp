using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Resources;
using Temp.UC;

namespace Temp
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 判断文件名称重复
        /// </summary>
        private string mCurrentFileName = string.Empty;

        private IUCBViewControl mBViewControl;

        #region Main
        public FormMain()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);// 禁止擦除背景.  
            SetStyle(ControlStyles.DoubleBuffer, true);// 双缓冲  
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            mBViewControl = ucbViewControl as IUCBViewControl;
            //mBViewControl.PlaySpeed = trackBar_playSpeedingSlider.Value;
            //mBViewControl.RefreshRate = trackBar_periodSlider.Value;
            //(ucbViewControl as IUCBViewControlEvents).OnReplayInfoUpdated+=FormMain_on
        }


        #endregion
        

        #region 托盘图标

        /// <summary>
        /// 关闭窗口时缩小到托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //// 注意判断关闭事件reason来源于窗体按钮，否则用菜单退出时无法退出!
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    //取消“关闭窗口”事件
            //    e.Cancel = true;//取消关闭窗体

            //    //使关闭时窗口向右下角缩小的效果
            //    this.WindowState = FormWindowState.Minimized;
            //    this.notifyIcon_main.Visible = true;

            //    this.Hide();
            //    return;
            //}
        }

        /// <summary>
        /// 双击托盘图标打开关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                this.WindowState = FormWindowState.Minimized;
                this.notifyIcon_main.Visible = true;
                this.Hide();
            }
            else
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        /// <summary>
        /// 托盘菜单右键实现最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.notifyIcon_main.Visible = true;
            this.Show();
        }

        /// <summary>
        /// 托盘菜单右键实现最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.notifyIcon_main.Visible = true;
            this.Hide();
        }

        /// <summary>
        /// 托盘菜单右键实现还原
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_recover_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon_main.Visible = true;
            this.Show();
        }

        /// <summary>
        /// 托盘菜单右键实现退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.notifyIcon_main.Visible = false;
                this.Close();
                this.Dispose();
                System.Environment.Exit(System.Environment.ExitCode);
            }
        }

        #endregion



        private void button_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string inspectionDocument = ResourceService.GetString("DrawPanel.Inspection_document");
            //TODO: 所有文件国际化
            openFileDialog.Filter = string.Format("所有文件（*.*）|*.*|{0}(*.xxb,*.xxc,*.cap,*.txt)|*.xxb;*.xxc;*.cap;*.txt", inspectionDocument);
            openFileDialog.Title = ResourceService.GetString("DrawPanel.opennspection_document");
            // TODO::添加默认路径
            //openFileDialog.InitialDirectory = App.BFile_Systemsetting_String_list[0]; 

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                //TODO::名称重复判断的是文件名
                if (mCurrentFileName == openFileDialog.FileName)
                {
                    MessageBox.Show(ResourceService.GetString("DrawPanel.error_Repeat_open"));
                    return;
                }

                mCurrentFileName = openFileDialog.FileName;

                string extension = Path.GetExtension(mCurrentFileName);
                switch (extension)
                {
                    case ".xxc":
                    case ".cap":
                        break;
                    case ".xxb": //转换 xxb 到 xxc 
                       //mCurrentFileName = FileUntility.GetNewExtensionFileName(extension, ".xxc");
                       //XXBFileConvert.Convert(openFileDialog.FileName, mCurrentFileName);
                        break;
                    case ".txt": //转换 txt 到 xxc 
                        //mCurrentFileName = FileUntility.GetNewExtensionFileName(extension, ".txt");
                        //TXTFileConvert.Convert(openFileDialog.FileName, mCurrentFileName);
                        break;
                    default:
                        MessageBox.Show(ResourceService.GetString("DrawPanel.errorFile"));
                        return;
                }

                mBViewControl.OpenFile(mCurrentFileName);
                trackBar_slider.Maximum = mBViewControl.MaxPointer;

                // 打开成功后右键菜单等可用
                // 按钮的可用性调整
                // setOpenFile
            }

        }
    }
}
