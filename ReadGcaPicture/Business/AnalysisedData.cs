using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XianFeng.Railway.Replay
{
    public class AnalysisedData
    {
        /// <summary>
        /// 文件内容
        /// </summary>
        public short[] xxc_list { get; private set; }

        
        public AnalysisedData(short[] xxc_list_one)
        {
            xxc_list = xxc_list_one;
            
        }
    }
}
