using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HT10D
{
    public enum xfActCode : short
    {
        /// <summary>
        /// STEP_PLUSE
        /// </summary>
        Encoder_Step = -10000,

        /// <summary>
        /// 通道1~9第一B显点（废弃不用）
        /// </summary>
        B1 = -10001,

        /// <summary>
        /// 通道1~9第而B显点（废弃不用）
        /// </summary>
        B2 = -10002,

        /// <summary>
        /// MISS1 失底波1
        /// </summary>
        Miss1_Rail_Base = -10003,

        /// <summary>
        /// MISS2 失底波2
        /// </summary>
        Miss2_Rail_Base = -10004,

        /// <summary>
        /// 机型
        /// </summary>
        MacType = -10005,

        /// <summary>
        /// 机号
        /// </summary>
        MacNum = -10006,

        /// <summary>
        /// 日期
        /// </summary>
        Date = -10007,

        /// <summary>
        /// 时间
        /// </summary>
        Time = -10008,

        /// <summary>
        /// TRIP 里程
        /// </summary>
        Location = -10009,

        /// <summary>
        /// 速度
        /// </summary>
        Speed = -10010,

        /// <summary>
        /// 耦合度
        /// </summary>
        Coupling = -10011,

        /// <summary>
        /// 经纬度 GPS
        /// </summary>
        GPS = -10012,

        /// <summary>
        /// BATTERY 电量
        /// </summary>
        BattPercent = -10013,

        /// <summary>
        /// 人员
        /// </summary>
        User = -10014,

        /// <summary>
        /// 班组
        /// </summary>
        Team = -10015,

        /// <summary>
        /// 工区
        /// </summary>
        Area = -10016,

        /// <summary>
        /// 单位
        /// </summary>
        Unit = -10017,

        /// <summary>
        /// 行别
        /// </summary>
        LinkType = -10018,

        /// <summary>
        /// 股别
        /// </summary>
        SideType = -10019,

        /// <summary>
        /// 里程方向
        /// </summary>
        Count = -10020,

        /// <summary>
        /// 线别
        /// </summary>
        LineType = -10021,

        /// <summary>
        /// 线号
        /// </summary>
        LineNum = -10022,

        /// <summary>
        /// 场号
        /// </summary>
        SiteNum = -10023,

        /// <summary>
        /// 股号
        /// </summary>
        TrackNum = -10024,

        /// <summary>
        /// 铁号
        /// </summary>
        RailNum = -10025,

        /// <summary>
        /// 车别
        /// </summary>
        Trolley = -10026,

        /// <summary>
        /// 工作模式
        /// </summary>
        WorkMode = -10027,

        /// <summary>
        /// 轨型
        /// </summary>
        RailType = -10028,

        /// <summary>
        /// 路况
        /// </summary>
        RailClass = -10029,

        /// <summary>
        /// 轨高
        /// </summary>
        RailHgt = -10030,

        /// <summary>
        /// 轨头高
        /// </summary>
        RailHeadHgt = -10031,

        /// <summary>
        /// 螺孔高
        /// </summary>
        RailBoltHgt = -10032,

        /// <summary>
        /// 增益
        /// </summary>
        Gain = -10033,

        /// <summary>
        /// 探头射向
        /// </summary>
        ProbeDir = -10034,

        /// <summary>
        /// 探头角度
        /// </summary>
        ProbeAng = -10035,

        /// <summary>
        /// 声程
        /// </summary>
        TestRange = -10036,

        /// <summary>
        /// 零点
        /// </summary>
        ZeroDelay = -10037,

        /// <summary>
        /// 大门前沿
        /// </summary>
        Gate0Head = -10038,

        /// <summary>
        /// 大门后沿
        /// </summary>
        Gate0Tail = -10039,

        /// <summary>
        /// 小门1前沿
        /// </summary>
        Gate1Head = -10040,

        /// <summary>
        /// 小门1后沿
        /// </summary>
        Gate1Tail = -10041,

        /// <summary>
        /// 小门2前沿
        /// </summary>
        Gate2Head = -10042,

        /// <summary>
        /// 小门2后沿
        /// </summary>
        Gate2Tail = -10043,

        /// <summary>
        /// PROBE_POS 探头位置
        /// </summary>
        ProbePosition = -10044,

        /// <summary>
        /// 抑制
        /// </summary>
        Suppress = -10045,

        /// <summary>
        /// 反射报警
        /// </summary>
        BackAlarm = -10046,

        /// <summary>
        /// MISS_ALARM 穿透报警
        /// </summary>
        PassAlarm = -10047,

        /// <summary>
        /// 超速报警
        /// </summary>
        SpeedAlarm = -10048,

        /// <summary>
        /// 耦合报警
        /// </summary>
        CoupleAlarm = -10049,

        /// <summary>
        /// 批注
        /// </summary>
        Note = -10050,

        /// <summary>
        /// 图片
        /// </summary>
        Photo = -10051,

        /// <summary>
        /// 开机
        /// </summary>
        PowerOn = -10052,

        /// <summary>
        /// 关机
        /// </summary>
        PowerOff = -10053,

        /// <summary>
        /// 倒车开始
        /// </summary>
        BackStart = -10054,

        /// <summary>
        /// 倒车结束
        /// </summary>
        BackEnd = -10055,

        /// <summary>
        /// 里程归零
        /// </summary>
        KMRound = -10056,

        /// <summary>
        /// Obsolute 8C11标记
        /// </summary>
        OldMark = -10057,

        /// <summary>
        /// 新机型标记
        /// </summary>
        NewMark = -10058,

        /// <summary>
        /// PulseLen 编码脉冲长度
        /// </summary>
        StepLength = -10059,

        /// <summary>
        /// SpBRI 亮度
        /// </summary>
        Brightness = -10060,

        /// <summary>
        /// 度量衡
        /// </summary>
        Measurement = -10061,

        /// <summary>
        /// STEP_PULSE_length 无动作编码脉冲
        /// </summary>
        StepNum = -10062,

        /// <summary>
        /// B_1_a 通道1第一B显点
        /// </summary>
        B1_Chan1 = -10063,

        /// <summary>
        /// B_1_b 通道2第一B显点
        /// </summary>
        B1_Chan2 = -10064,

        /// <summary>
        /// B_1_c 通道3第一B显点
        /// </summary>
        B1_Chan3 = -10065,

        /// <summary>
        /// B_1_d 通道4第一B显点
        /// </summary>
        B1_Chan4 = -10066,

        /// <summary>
        /// B_1_e 通道5第一B显点
        /// </summary>
        B1_Chan5 = -10067,

        /// <summary>
        /// B_1_f 通道6第一B显点
        /// </summary>
        B1_Chan6 = -10068,

        /// <summary>
        /// B_1_g 通道7第一B显点
        /// </summary>
        B1_Chan7 = -10069,

        /// <summary>
        /// B_1_h 通道8第一B显点
        /// </summary>
        B1_Chan8 = -10070,

        /// <summary>
        /// B_1_i 通道9第一B显点
        /// </summary>
        B1_Chan9 = -10071,

        /// <summary>
        /// B_2_a 通道1第二B显点
        /// </summary>
        B2_Chan1 = -10073,

        /// <summary>
        /// B_2_b 通道2第二B显点
        /// </summary>
        B2_Chan2 = -10074,

        /// <summary>
        /// B_2_c 通道3第二B显点
        /// </summary>
        B2_Chan3 = -10075,

        /// <summary>
        /// B_2_d 通道4第二B显点
        /// </summary>
        B2_Chan4 = -10076,

        /// <summary>
        /// B_2_e 通道5第二B显点
        /// </summary>
        B2_Chan5 = -10077,

        /// <summary>
        /// B_2_f 通道6第二B显点
        /// </summary>
        B2_Chan6 = -10078,

        /// <summary>
        /// B_2_g 通道7第二B显点
        /// </summary>
        B2_Chan7 = -10079,

        /// <summary>
        /// B_2_h 通道8第二B显点
        /// </summary>
        B2_Chan8 = -10080,

        /// <summary>
        /// B_2_i 通道9第二B显点
        /// </summary>
        B2_Chan9 = -10081,

        /// <summary>
        /// 程序版本信息
        /// </summary>
        VERSION = -10082,

        /// <summary>
        /// 闸门3前沿
        /// </summary>
        GATE3_HEAD = -10083,

        /// <summary>
        /// 闸门3后沿
        /// </summary>
        GATE3_TAIL = -10084,

        /// <summary>
        /// 路局
        /// </summary>
        SECTION = -10085,

        /// <summary>
        /// 工务段
        /// </summary>
        DIVISION = -10086,

        /// <summary>
        /// A显波形
        /// </summary>
        AWAVE = -10087,

        LOG_INFO = -10088,

        TIMEZONE = -10089,

        SAVE_TH0 = -10090,

        /// <summary>
        /// 补偿修改记录
        /// </summary>
        BC_CHANGE = -10091,

        Auto_Gain = -10092,

        BACK_SAVE_CODE = -10093,

        #region Sperry

        SpOPER = -10200,
        SpROT = -10201,
        SpSECT1 = -10202,
        SpELR1 = -10203,
        SpELR2 = -10204,
        SpTID = -10205,
        SpLR = -10206,
        SpRID = -10207,
        SpRWT = -10208,
        SpTRF = -10209,
        SpUIC = -10210,
        SpPROC = -10211,
        SpSECT2 = -10212,
        SpMARK = -10213,
        SpCUST = -10214,
        SpWave = -10215,
        SpPROBE = -10216,
        SpDIVI = -10217,
        SpUD = -10218,
        SpROLL = -10219,
        SpFLAW = -10220,
        SpCLASSNEW = -10221,
        SpCLASSOLD = -10222,
        SpROT_CUST = -10223,
        SpSECT1_CUST = -10224,
        SpELR1_CUST = -10225,
        SpELR2_CUST = -10226,
        SpTID_CUST = -10227,
        SpRID_CUST = -10228,
        SpRWT_CUST = -10229,
        SpTRF_CUST = -10230,
        SpUIC_CUST = -10231,
        SpSECT2_CUST = -10232,
        SpCLASS_CUST = -10233,
        SpLCS_CUST = -10234,
        SpRsrv1_Cust = -10235,
        SpRsrv2_Cust = -10236,
        /// <summary>
        /// RAILWIGHT
        /// </summary>
        SpRW = -10237,

        /// <summary>
        /// 手动A文件零点，单位us
        /// </summary>
        SpHand_Zero = -10238,

        /// <summary>
        /// 手动A文件零点，单位mm
        /// </summary>
        SpHand_Delay = -10239,

        /// <summary>
        /// 印度A显图片门宽
        /// </summary>
        SPHAND_WAVE_WIDE = -10240,

        /// <summary>
        /// 印度A显图片门位
        /// </summary>
        SPHAND_WAVE_HIGHT = -10241,

        /// <summary>
        /// 失波报警个数
        /// </summary>
        LobDist = -10242,


        #endregion


        B1_RWUT_a = -10300,
        B1_RWUT_b = -10301,
        B1_RWUT_c = -10302,
        B1_RWUT_d = -10303,
        B1_RWUT_e = -10304,
        B1_RWUT_f = -10305,
        B1_RWUT_g = -10306,
        B1_RWUT_h = -10307,
        B1_RWUT_i = -10308,
        B1_RWUT_j = -10309,
        B1_RWUT_k = -10310,
        B2_RWUT_a = -10311,
        B2_RWUT_b = -10312,
        B2_RWUT_c = -10313,
        B2_RWUT_d = -10314,
        B2_RWUT_e = -10315,
        B2_RWUT_f = -10316,
        B2_RWUT_g = -10317,
        B2_RWUT_h = -10318,
        B2_RWUT_i = -10319,
        B2_RWUT_j = -10320,
        B2_RWUT_k = -10321,

        #region ForPC

        /// <summary>
        /// 检索
        /// </summary>
        Search = -11000,

        /// <summary>
        /// 回放
        /// </summary>
        Replay = -11001,

        /// <summary>
        /// 报告
        /// </summary>
        Report = -11002,

        #endregion

        // STEP_BLANK_start = -11003, 

        /// <summary>
        /// TODO::无对照？？
        /// </summary>
        STEP_BLANK_end = -11004,
        F9_NOTE = -11005,
        PLAY_BACK = -11006,

        #region India

        ROLLMARK = -10400,
        FLAWNUM = -10401,
        CLASSNEW = -10402,
        CLASSOLD = -10403,
        LOCATION = -10404,
        TRIPID = -10405,

        #endregion


        #region HT10C+专用标示，起始-10600~-10700，暂定100个

        /// <summary>
        /// 焊号
        /// </summary>
        HT_WeldNum = -10600,

        /// <summary>
        /// 岔号
        /// </summary>
        HT_SwitchNum = -10601,

        /// <summary>
        /// 轨号
        /// </summary>
        HT_RailNum = -10602,

        /// <summary>
        /// 焊缝种类
        /// </summary>
        HT_WeldType = -10603,

        /// <summary>
        /// 焊缝描述
        /// </summary>
        HT_WeldDesc = -10604,

        /// <summary>
        /// 钢轨描述
        /// </summary>
        HT_RailDesc = -10605,

        /// <summary>
        /// 
        /// </summary>
        HT_RailFactory = -10606,

        /// <summary>
        /// 钢种
        /// </summary> 
        HT_RailSteel = -10607,

        /// <summary>
        ///  炉号
        /// </summary>  
        HT_FurnaceNum = -10608,

        /// <summary>
        /// 伤损类型
        /// </summary>
        HT_DamageType = -10609,

        /// <summary>
        /// 伤损大小
        /// </summary>
        HT_DamageSize = -10610,

        /// <summary>
        /// 伤损位置
        /// </summary>
        HT_DamagePos = -10611,

        /// <summary>
        /// 伤损描述
        /// </summary>
        HT_DamageDesc = -10612,

        /// <summary>
        /// 位置描述
        /// </summary>
        HT_PosDesc = -10613,

        /// <summary>
        /// X
        /// </summary>
        HT_X = -10614,

        /// <summary>
        /// Y
        /// </summary>
        HT_Y = -10615,

        /// <summary>
        /// 增益增量
        /// </summary>  
        HT_GainDelta = -10616,

        /// <summary>
        /// 声程 
        /// </summary>  
        HT_TestRange = -10617,

        /// <summary>
        /// 脉冲移位
        /// </summary> 
        HT_PulseShift = -10618,

        /// <summary>
        /// 发射
        /// </summary> 
        HT_Launch = -10619,

        /// <summary>
        /// 接收
        /// </summary> 
        HT_Receiving = -10620,

        /// <summary>
        /// 阻尼
        /// </summary>
        HT_Damping = -10621,

        /// <summary>
        /// 强度
        /// </summary> 
        HT_Intensity = -10622,

        /// <summary>
        /// 脉宽
        /// </summary> 
        HT_PulseWidth = -10623,

        /// <summary>
        /// 抑制
        /// </summary> 
        HT_Suppress = -10624,

        /// <summary>
        /// 频带
        /// </summary> 
        HT_Bandwidth = -10625,

        /// <summary>
        /// 检波
        /// </summary> 
        HT_Detection = -10626,

        /// <summary>
        /// 工作方式
        /// </summary> 
        HT_WorkMode = -10627,

        /// <summary>
        /// 探头类型
        /// </summary> 
        HT_ProbeType = -10628,

        /// <summary>
        /// 重复频率
        /// <summary> 
        HT_RepeatFreq = -10629,

        /// <summary>
        /// 探头前沿
        /// </summary>
        HT_FrontDist = -10630,

        /// <summary>
        /// 零点延时
        /// </summary> 
        HT_ZeroDelay = -10631,

        /// <summary>
        /// 晶片
        /// </summary> 
        HT_Crystal = -10632,

        /// <summary>
        /// 探头频率
        /// </summary> 
        HT_ProbeFreq = -10633,

        /// <summary>
        /// 声速
        /// </summary> 
        HT_SoundVelocity = -10634,

        /// <summary>
        /// 工件厚度 
        /// </summary>
        HT_Thickness = -10635,

        /// <summary>
        /// 增益类型
        /// </summary>
        HT_AmpMode = -10636,

        /// <summary>
        /// 波形样式
        /// </summary>
        HT_WaveType = -10637,

        /// <summary>
        /// 标尺单位
        /// </summary>
        HT_MeasureUnit = -10638,

        /// <summary>
        /// 表面补偿
        /// </summary>
        HT_SurfaceCompEn = -10639,

        /// <summary>
        /// 记录模式
        /// </summary>
        HT_MeasureTrigger = -10640,

        /// <summary>
        /// 语言
        /// </summary> 
        HT_Language = -10641,

        /// <summary>
        /// A显数据
        /// </summary>
        HT_APicture = -10642,

        /// <summary>
        /// B显数据
        /// </summary>
        HT_BPicture = -10643,

        /// <summary>
        /// 通道号
        /// </summary> 
        HT_ChanNum = -10644,

        /// <summary>
        /// 门位
        /// </summary>
        HT_GateHand = -10645,

        /// <summary>
        /// 门宽
        /// </summary>
        HT_GateWidth = -10646,

        /// <summary>
        /// 门高
        /// </summary>
        HT_GateHight = -10647,

        #endregion

    }
}
