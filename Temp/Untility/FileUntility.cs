using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    /// <summary>
    /// 文件处理辅助类
    /// </summary>
    public class FileUntility
    {
        #region 成员

        /// <summary>
        /// 旧版本的文件扩展名
        /// </summary>
        private static string[] _OldFormats = new string[] { ".xxb", ".txt" };

        /// <summary>
        /// 新版本的文件扩展名
        /// </summary>
        private readonly static string _NewFormats = ".xxc";

        #endregion


        #region 公共方法

        /// <summary>
        /// 返回新扩展名的文件路径
        /// </summary>
        /// <param name="fileName">需要修改扩展名的文件路径</param>
        /// <returns>修改为 .xxc 扩展名的文件路径</returns>
        public static string GetNewFileName(string fileName)
        {
            return Path.ChangeExtension(fileName, _NewFormats);
        }

        /// <summary>
        /// 返回新扩展名的文件路径
        /// </summary>
        /// <param name="fileName">需要修改扩展名的文件路径</param>
        /// <param name="newExtension">新扩展名 .xxc</param>
        /// <returns>修改为新扩展名的文件路径</returns>
        public static string GetNewExtensionFileName(string fileName, string newExtension)
        {
            return Path.ChangeExtension(fileName, newExtension);
        }

        #endregion
    }
}
