using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace 防止多次启动程序
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex m = new Mutex(true, Application.ProductName, out bool createNew))
            {
                if (createNew)
                {
                    //LogHelper.WriteLog("程序启动");
                    Process currentProcess = Process.GetCurrentProcess();
                    LogHelper.WriteLog(currentProcess.ProcessName);
                    //LogHelper.WriteLog(currentProcess.Id.ToString());

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMultipleStarts());
                }
                else
                {
                    Process instance = GetExistProcess();
                    if (instance != null)
                    {
                        SetForegroud(instance);
                        Application.Exit();
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 查看程序是否已经运行
        /// </summary>
        /// <returns></returns>
        private static Process GetExistProcess()
        {
            Process currentProcess = Process.GetCurrentProcess();
            LogHelper.WriteLog(currentProcess.ProcessName, new Exception("错误"));
            //LogHelper.WriteLog(currentProcess.Id.ToString(), new Exception("错误"));

            foreach (Process process in Process.GetProcessesByName(currentProcess.ProcessName))
            {
                if ((process.Id != currentProcess.Id) && (Assembly.GetExecutingAssembly().Location == currentProcess.MainModule.FileName))
                {
                    //LogHelper.WriteLog(process.Id.ToString());

                    return process;
                }
            }
            return null;
        }
        /// <summary>
        /// 使程序前端显示
        /// </summary>
        /// <param name="instance"></param>
        private static void SetForegroud(Process instance)
        {
            IntPtr mainFormHandle = instance.MainWindowHandle;
            if (mainFormHandle != IntPtr.Zero)
            {
                ShowWindowAsync(mainFormHandle, 4);
                SetForegroundWindow(mainFormHandle);
            }
        }

        /// <summary>
        /// 激活窗体
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="cmdShow">
        /// SW_HIDE = 0;            //从任务栏隐藏
        /// SW_NORMAL = 1;          //正常弹出窗体 
        /// SW_MAXIMIZE = 3;        //最大化弹出窗体 
        /// SW_SHOWNOACTIVATE = 4;  //激活窗体/恢复窗体/还原窗体
        /// SW_SHOW = 5;            //显示窗体，最小化时不会最大化
        /// SW_MINIMIZE = 6;        //最小化
        /// SW_RESTORE = 9;
        /// SW_SHOWDEFAULT = 10;
        /// </param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);

        /// <summary>
        /// 使其显示在最前
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

    }
}
