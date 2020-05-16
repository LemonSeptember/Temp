using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace HT10D
{
    public class HT10D_Info
    {
        public HT10D_Info()
        {
            DamageInfo = new DamageInfo();
            //AViewList = new List<short[]>();
        }

        /// <summary>
        /// 文件地址
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 伤损信息
        /// </summary>
        public DamageInfo DamageInfo { get; private set; }

        /// <summary>
        /// A显波形数组
        /// </summary>
        public List<short[]> AViewList { get; set; }

        /// <summary>
        /// A显图片
        /// </summary>
        public Bitmap AViewImage { get; set; }

        /// <summary>
        /// B显图片
        /// </summary>
        public Bitmap BViewImage { get; set; }
    }

    /// <summary>
    /// 伤损信息
    /// </summary>
    public class DamageInfo
    {

        public DamageInfo()
        {
            WeldNum = string.Empty;
            SwitchNum = string.Empty;
            RailNum = string.Empty;
            WeldDesc = string.Empty;
            RailDesc = string.Empty;
            RailFactory = string.Empty;
            RailSteel = string.Empty;
            FurnaceNum = string.Empty;
            DamageDesc = string.Empty;
            PosDesc = string.Empty;

            WeldType = short.MinValue;
            RailType = short.MinValue;
            DamageType = short.MinValue;
            DamageSize = short.MinValue;
            DamagePos = short.MinValue;
            HT_X = short.MinValue;
            HT_Y = short.MinValue;
            GainDelta = short.MinValue;
            TestRange = short.MinValue;
            PulseShift = short.MinValue;
            Launch = short.MinValue;
            Receiving = short.MinValue;
            Damping = short.MinValue;
            Intensity = short.MinValue;
            PulseWidth = short.MinValue;
            Suppress = short.MinValue;
            Bandwidth = short.MinValue;
            Detection = short.MinValue;
            WorkMode = short.MinValue;
            ProbeType = short.MinValue;
            RepeatFreq = short.MinValue;
            FrontDist = short.MinValue;
            ZeroDelay = short.MinValue;
            Crystal = short.MinValue;
            ProbeFreq = short.MinValue;
            SoundVelocity = short.MinValue;
            Thickness = short.MinValue;
            AmpMode = short.MinValue;
            WaveType = short.MinValue;
            MeasureUnit = short.MinValue;
            SurfaceCompEn = short.MinValue;
            MeasureTrigger = short.MinValue;
            Language = short.MinValue;
            ChanNum = short.MinValue;
            GateHand = short.MinValue;
            GateWidth = short.MinValue;
            GateHeight = short.MinValue;
        }

        /// <summary>
        /// 焊号
        /// </summary>
        public string WeldNum { get; set; }

        /// <summary>
        /// 岔号
        /// </summary>
        public string SwitchNum { get; set; }

        /// <summary>
        /// 轨号
        /// </summary>
        public string RailNum { get; set; }

        /// <summary>
        /// 焊缝种类(0—无/1—电弧焊/2—气压焊/3—闪光焊/4—铝热焊/5—其他)
        /// </summary>
        public short WeldType { get; set; }

        /// <summary>
        /// 焊缝描述()
        /// </summary>
        public string WeldDesc { get; set; }

        /// <summary>
        /// 钢轨种类
        /// </summary>
        public short RailType { get; set; }

        /// <summary>
        /// 钢轨描述()
        /// </summary>
        public string RailDesc { get; set; }

        /// <summary>
        /// 厂家()
        /// </summary>
        public string RailFactory { get; set; }

        /// <summary>
        /// 钢种()
        /// </summary>
        public string RailSteel { get; set; }

        /// <summary>
        /// 炉号()
        /// </summary>
        public string FurnaceNum { get; set; }

        /// <summary>
        /// 伤损类型(0—无/1—轻伤/2—轻伤发展/3—重伤/4—其他)
        /// </summary>
        public short DamageType { get; set; }

        /// <summary>
        /// 伤损大小
        /// </summary>
        public short DamageSize { get; set; }

        /// <summary>
        /// 伤损位置(0—无/1—轨头/2—轨腰/3—轨底/4—其他)
        /// </summary>
        public short DamagePos { get; set; }

        /// <summary>
        /// 伤损描述
        /// </summary>
        public string DamageDesc { get; set; }

        /// <summary>
        /// 位置描述
        /// </summary>
        public string PosDesc { get; set; }

        /// <summary>
        /// X
        /// </summary>
        public short HT_X { get; set; }

        /// <summary>
        /// Y
        /// </summary>
        public short HT_Y { get; set; }

        /// <summary>
        /// 增益增量
        /// </summary>
        public short GainDelta { get; set; }

        /// <summary>
        /// 声程
        /// </summary>
        public short TestRange { get; set; }

        /// <summary>
        /// 脉冲移位(-20~3400,单位0.1us)
        /// </summary>
        public short PulseShift { get; set; }

        /// <summary>
        /// 发射(1—TX1/2—TX2/3—TX3/4—TX4/ 5—TX5/6—TX6)
        /// </summary> 
        public short Launch { get; set; }

        /// <summary>
        /// 接收（1—TX1/2—TX2/3—TX3/4—TX4/ 5—TX5/6—TX6/7—RX1/8—RX6）
        /// </summary> 
        public short Receiving { get; set; }

        /// <summary>
        /// 阻尼 单位欧
        /// </summary>
        public short Damping { get; set; }

        /// <summary>
        /// 强度（0—低/2—中/1—高）
        /// </summary> 
        public short Intensity { get; set; }

        /// <summary>
        /// 脉宽 单位ns
        /// </summary> 
        public short PulseWidth { get; set; }

        /// <summary>
        /// 抑制（0~50）%
        /// </summary> 
        public short Suppress { get; set; }

        /// <summary>
        /// 频带（0—0.5～15MHz/1—1.5～3MHz）
        /// </summary> 
        public short Bandwidth { get; set; }

        /// <summary>
        /// 检波（0—正半波/1—负半波/2—全波）
        /// </summary> 
        public short Detection { get; set; }

        /// <summary>
        /// 工作方式（0—单/1—双）
        /// </summary> 
        public short WorkMode { get; set; }

        /// <summary>
        /// 探头类型（0—直探头/1—斜探头）
        /// </summary> 
        public short ProbeType { get; set; }

        /// <summary>
        /// 重复频率 Hz
        /// <summary> 
        public short RepeatFreq { get; set; }

        /// <summary>
        /// 探头前沿 单位0.1mm
        /// </summary>
        public short FrontDist { get; set; }

        /// <summary>
        /// 零点延时 单位0.1us
        /// </summary> 
        public short ZeroDelay { get; set; }

        /// <summary>
        /// 晶片（0—P20/1—P10/2—Z20/3—P6/4—P8/5—P10/6—P12/7—P14/8—P28/9—8*12/10—13*13/11—6*8/12—9*9/13—10*16/14—P14/15—P20/16—18*18）
        /// </summary> 
        public short Crystal { get; set; }

        /// <summary>
        /// 探头频率（0—0.5MHz/1—1.25MHz/2—2MHz/3—2.5MHz/4—4MHz/5—5MHz/6—10MHz）
        /// </summary> 
        public short ProbeFreq { get; set; }

        /// <summary>
        /// 声速 m/s
        /// </summary> 
        public short SoundVelocity { get; set; }

        /// <summary>
        /// 工件厚度  mm
        /// </summary>
        public short Thickness { get; set; }

        /// <summary>
        /// 增益类型（0—增益型/1—衰减型）
        /// </summary>
        public short AmpMode { get; set; }

        /// <summary>
        /// 波形样式（0—空心/1—实心）
        /// </summary>
        public short WaveType { get; set; }

        /// <summary>
        /// 标尺单位（0—mm/1—us）
        /// </summary>
        public short MeasureUnit { get; set; }

        /// <summary>
        /// 表面补偿 dB
        /// </summary>
        public short SurfaceCompEn { get; set; }

        /// <summary>
        /// 记录模式（0—全部记录/1—压缩记录/2—报警记录）
        /// </summary>
        public short MeasureTrigger { get; set; }

        /// <summary>
        /// 语言(0—中文/1—英文)
        /// </summary>
        public short Language { get; set; }

        /// <summary>
        /// 通道号
        /// </summary>  
        public short ChanNum { get; set; }

        /// <summary>
        /// 门位
        /// </summary>
        public short GateHand { get; set; }

        /// <summary>
        /// 门宽
        /// </summary>
        public short GateWidth { get; set; }

        /// <summary>
        /// 门高
        /// </summary>
        public short GateHeight { get; set; }
    }

    /// <summary>
    /// 机型
    /// </summary>
    public enum xfMacType
    {
        Unknown = -1,
        _8C = 0,
        _11 = 1,
        _SP = 2,
        _8CPlus_China = 3,
        _8CPlus_India = 4,
        _8CPlus_Sperry = 5,
        _8CPlus_Sperry_ID = 6,
        _8D = 7,
        _X20 = 10,
    }

    /// <summary>
    /// 通道号
    /// </summary>
    public enum xfChannelNo
    {
        All = -1,
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,
        G = 6,
        H = 7,
        I = 8
    }

}
