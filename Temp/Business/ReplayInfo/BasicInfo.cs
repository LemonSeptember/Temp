using System;

namespace Temp
{
    public class BasicInfo
    {
        public BasicInfo()
        {
            User = string.Empty;
            Team = string.Empty;
            WorkArea = string.Empty;
            Company = string.Empty;
            RailClass = string.Empty;
            LineNum = string.Empty;
            SiteNum = string.Empty;
            TrackNum = string.Empty;
            RailType = string.Empty;
            WorkMode = string.Empty;
            RailNum = string.Empty;
            MissAlarm = short.MinValue;
            BackAlarm = short.MinValue;
            //Longitude = Coordinate.InvalidCoordinate;
            //Latitude = Coordinate.InvalidCoordinate;

        }


        #region 属性

        /// <summary>
        /// 主机编号
        /// </summary>
        public int MacID { get; set; }

        /// <summary>
        /// 日期和时间（分别从Conv.Date 和 ConvTime 中取出）
        /// </summary>
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        /// <summary>
        /// 机型 0 - GCT-8C 1-GCT-11 2-SP 3-GL
        /// TODO::修改为枚举
        /// </summary>
        public short MacType { get; set; }

        /// <summary>
        /// 人员(word报告使用信息)
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// 班组
        /// </summary>
        public string Team { get; set; }

        /// <summary>
        /// 工区
        /// </summary>
        public string WorkArea { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 股别（1 左股，其他右股）
        /// </summary>
        public short Side { get; set; }

        /// <summary>
        /// 行别
        /// </summary>
        public short LinkType { get; set; }

        /// <summary>
        /// 方向( if ==1 count_direction = -1 else count_direction = 1;)
        /// 增为+1 减为-1
        /// </summary>
        public short Count { get; set; }

        /// <summary>
        /// 路况
        /// </summary>
        public string RailClass { get; set; }

        /// <summary>
        /// 线别
        /// </summary>
        public xfLineType LineType { get; set; }

        /// <summary>
        /// 线号（LineType 为非 Station）
        /// </summary>
        public string LineNum { get; set; }

        /// <summary>
        /// 场号（LineType 为 Station）
        /// </summary>
        public string SiteNum { get; set; }

        /// <summary>
        /// 股号
        /// </summary>
        public string TrackNum { get; set; }

        /// <summary>
        /// 轨型
        /// </summary>
        public string RailType { get; set; }

        /// <summary>
        /// 车别
        /// </summary>
        public short Trolley { get; set; }

        /// <summary>
        /// 工作模式
        /// </summary>
        public string WorkMode { get; set; }

        /// <summary>
        /// 失波报警（穿透报警）
        /// </summary>
        public short MissAlarm { get; set; }

        /// <summary>
        /// 反射报警
        /// </summary>
        public short BackAlarm { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public Coordinate Longitude { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        public Coordinate Latitude { get; set; }

        // TODO::未使用？？？
        /// <summary>
        /// 铁号
        /// </summary>
        public string RailNum { get; set; }

        #endregion

        public override string ToString()
        {
            string result = string.Format(@"机号： {0}    日期：{1}    机型：{2}    人员：{3}    班组：{4}    工区：{5}
                                            单位：{6}    股别：{7}    行别：{8}    方向：{9}    路况：{10}  
                                              线别：{11}    线号：{12}    股号：{13}    轨型：{14}    车别：{15} 
                                            模式：{16}    穿透报警：{17}    反射报警：{18}    维度：{19}    经度：{20}"
                , MacID, Date, MacType, User, Team, WorkArea, Company, Side, LineType, Count, RailClass, LineType, LineNum,
                TrackNum, RailType, Trolley, WorkMode, MissAlarm, BackAlarm, Longitude, Latitude);

            return result;
        }
    }
}