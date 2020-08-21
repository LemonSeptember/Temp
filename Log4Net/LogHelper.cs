using log4net;
using System;

//为项目注册Log4Net.config配置文件
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

/// <summary>
/// 日志输出
/// </summary>
namespace Log4Net
{
    /// <summary>
    /// 日志输出
    /// 在AssemblyInfo.cs中添加 [assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
    /// 设置log4net.config的复制到输出目录属性为始终复制
    /// </summary>
    public class LogHelper
    {
        public static readonly ILog loginfo = LogManager.GetLogger("loginfo");
        public static readonly ILog logerror = LogManager.GetLogger("logerror");
        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>

        public static void WriteLog(string info, Exception ex)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, ex);
            }
        }

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>

        public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }
    }
}
