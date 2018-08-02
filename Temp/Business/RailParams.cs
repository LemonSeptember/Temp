namespace Temp
{
    /// <summary>
    /// 钢轨参数
    /// </summary>
    public class RailParams
    {
        /// <summary>
        /// 轨高，单位 mm
        /// </summary>
        public short RailHeight { get; set; }

        /// <summary>
        /// 轨头高，单位 mm
        /// </summary>
        public short RailHeadHeight { get; set; }

        /// <summary>
        /// 螺孔高，单位 mm
        /// </summary>
        public short RailBoltHeight { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public RailParams()
        {
            RailHeight = 176;
            RailHeadHeight = 46;
            RailBoltHeight = 79;
        }

    }
}