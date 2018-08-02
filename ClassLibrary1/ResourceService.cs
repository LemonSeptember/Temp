using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class ResourceService
    {
        #region 成员

        /// <summary>
        /// 本地字符串   
        /// </summary>
        private static Hashtable localStrings;

        #endregion

        #region 属性



        #endregion

        #region 公共方法

        /// <summary>
        /// 根据名称获取国际化的字符串
        /// </summary>
        /// <param name="name">字符名称</param>
        /// <returns>current language string</returns>
        public static string GetString(string name)
        {
            if (localStrings != null && localStrings[name] != null)
            {
                return localStrings[name].ToString();
            }
            return name;
            
        }

        #endregion


    }
}
