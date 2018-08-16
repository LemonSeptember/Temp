using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    /// <summary>
    /// 注意不要修改枚举顺序，在脉冲值一致的情况下需要排序使用
    /// </summary>
    public enum xfDataType
    {
        /// <summary>
        /// 工作参数（对应开机点S、关机点E、工作参数W）
        /// </summary>
        WorkPack,

        /// <summary>
        /// B显数据组（对应B包）
        /// </summary>
        BGroup,

        /// <summary>
        /// 速度组（对应米段M包），包括速度、时间、里程
        /// </summary>
        SpeedGroup,

        /// <summary>
        /// 控制参数（对应C包）
        /// </summary>
        CtrlPack,

        /// <summary>
        /// GPS数据组
        /// </summary>
        GPSGroup,

        /// <summary>
        /// 耦合度数据组
        /// </summary>
        CouplingGroup,

        /// <summary>
        /// 失波数组
        /// </summary>
        Miss1,
    }

    /// <summary>
    /// 图像播放方向
    /// </summary>
    public enum xfPlayDirection
    {
        /// <summary>
        /// 从左至右
        /// </summary>
        LeftToRight,

        /// <summary>
        /// 从右至左
        /// </summary>
        RightToLeft
    }

    /// <summary>
    /// 位置显示样式
    /// </summary>
    public enum xfCoordFormat
    {
        /// <summary>
        /// X°XX′XX″
        /// </summary>
        Seconds = 0,

        /// <summary>
        /// X.XX°
        /// </summary>
        Degrees = 1,

        /// <summary>
        /// X°XX′
        /// </summary>
        Minutes = 2
    }

    public class Coordinate
    {
        /// <summary>
        /// 私有构造函数
        /// </summary>
        private Coordinate() { }

        /// <summary>
        /// 定位失败的定位
        /// </summary>
        public static Coordinate InvalidCoordinate { get { return new Coordinate(); } }


        public Coordinate(short[] list)
        {  
            // TODO::经度使用前两位么？？
            if (list.Length <= 4) { return; }

            Degree = list[0];
            Minute = list[1];
            Second = list[2];
            Zone = (char)list[3];

            Valid = true;
        }

        /// <summary>
        /// A 有效，V 无效
        /// </summary>
        public bool Valid { get; private set; }

        /// <summary>
        /// 区域 E，W，N，S
        /// </summary>
        public char Zone { get; private set; }

        public short Degree { get; private set; }

        public short Minute { get; private set; }

        public double Second { get; private set; }

        /// <summary>
        /// App.BFile_Systemsetting_short_list[2] == 0  Seconds
        /// App.BFile_Systemsetting_short_list[2] == 1  Degrees
        /// App.BFile_Systemsetting_short_list[2] == Other  Minutes
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public string DisplayValue(xfCoordFormat format)
        {
            switch (format)
            {
                case xfCoordFormat.Degrees:
                    return string.Format("{0}{1}°", Zone, (Degree + Minute / 60.0f + Second / 600000.0f).ToString("####.00"));
                case xfCoordFormat.Minutes:
                    return string.Format("{0}{1}°{2}.{3}′", Zone, Degree, Minute.ToString("00"), Second);
                case xfCoordFormat.Seconds:
                    return string.Format("{0}{1}°{2}′{3}″", Zone, Degree, Minute, Second * 60 / 10000.0f);
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public class Mile
    {
        /// <summary>
        /// 初始化使用
        /// </summary>
        public Mile() { }

        public Mile(short[] list)
        {
            // KM 和 M 的分离
            if (list.Length < 2) { return; }
            KM = list[0];
            M = list[1];
        }

        public int KM { get; private set; }

        public int M { get; private set; }

        public string GetDisplayValue(xfMileUnit mileUnit)
        {
            switch (mileUnit)
            {
                case xfMileUnit.Yard:
                    return string.Format("{0}ML{1}YD", KM.ToString("0000"), M.ToString("0000"));
                case xfMileUnit.KM_MACType2:
                    return string.Format("{0}km{1}dm", KM.ToString("0000"), M.ToString("0000"));
                case xfMileUnit.KMOther:
                    return string.Format("{0}km{1}m", KM.ToString("0000"), (M / 10).ToString("000"));
                default:
                    throw new NotImplementedException();
            }

        }

        public static Mile Zero { get { return new Mile() { KM = 0, M = 0 }; } }
    }

    public enum xfMileUnit
    {
        Yard = 0,

        KM_MACType2 = 1,

        KMOther = 2
    }

    public enum xfLineType
    {
        Invalid = -1,
        MainLine = 0,
        Station = 1,
        LinkLine = 2,
        Single = 3,
        Other = 4
    }
}
