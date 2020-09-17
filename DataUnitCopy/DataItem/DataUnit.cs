using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataUnitCopy
{
    /// <summary>
    /// 具体数据包
    /// </summary>
    public class DataUnit
    {
        /// <summary>
        /// 具体数据项-显示在图像中的参数，一个单元代表一个正向的编码值
        /// 显示参数 - 脉冲、时间、里程、速度、标记、GPS、耦合
        /// </summary>
        public List<IDataItem> DataItemsList { get; }

        /// <summary>
        /// 控制参数
        /// </summary>
        public List<IDataItem> DataParamItemsList { get; }

        public int DataIndex { get; private set; }

        public string DataStr { get; private set; }

        /// <summary>
        ///  描述： 构造函数
        /// </summary>
        public DataUnit()
        {
            DataItemsList = new List<IDataItem>();
            DataParamItemsList = new List<IDataItem>();
            DataIndex = 0;
            DataStr = "12";
            //首先添加脉冲
            DataItemsList.Add(DataItemFactory.GetStepPulseItem());
        }

        public object Copy()
        {
            return this.MemberwiseClone();

            BinaryFormatter formatter = new BinaryFormatter(null, new System.Runtime.Serialization.StreamingContext(System.Runtime.Serialization.StreamingContextStates.Clone));
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            object clonedObj = formatter.Deserialize(stream);
            stream.Close();
            return clonedObj;
        }

        /// <summary>
        /// 添加显示参数
        /// </summary>
        public void AddDataItem(IDataItem DataItem)
        {
            DataItemsList.Add(DataItem);
        }

        /// <summary>
        /// 添加控制参数
        /// </summary>
        /// <param name="DataItem"></param>
        public void AddDataParamItem(IDataItem DataItem)
        {
            DataParamItemsList.Add(DataItem);
        }

        public void ChangeValue(int value,string str)
        {
            DataIndex = value;
            DataStr = str;
        }
    }
}
