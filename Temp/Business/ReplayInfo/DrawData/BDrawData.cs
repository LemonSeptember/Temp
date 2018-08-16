using System.Collections.Generic;

namespace Temp
{
    public class BDrawData
    {

        public BDrawData()
        {
            
        }

        #region 属性
        public List<LabelData> DisplayDatas { get; private set; }

        // 传入PaintPanel的B显坐标
        public List<int[]> BpointData_list { get; private set; }

        // B2第二B显点
        public List<int[]> B2pointData_list { get; private set; }

        // 传入PaintPanel的底波坐标
        // double[] 里面填充的数据为 
        // {(i * zoom_factor), xZero[8] * zoom_factor, railHgt_line, 0)}-->{(i*zoom_factor),zoom_factor,channel,0}
        // { i * zoom_factor, bx * zoom_factor, railHgt_line, 1 }  bx = (int)(d * xRate[channel] + xZero[channel]);
        // -->{i,1,channel,xxc_list[k]}
        public List<BottomWave> bottom_data_list { get; private set; }

        // 传入PaintPanel工作参数
        // 工作参数数据集合
        public List<short> workdata_coor_list { get; private set; }

        public List<string> workdata_content_list { get; private set; }

        public List<short> tag_coor_list { get; private set; }

        public List<string> tag_content_list { get; private set; }

        // 开机点工作数据
        public List<short[]> start_mac_list { get; private set; }

        // 里程归零数据集合
        // 里程归零数据集合+忽略空白
        // 第一位-x位置 第二位-1 里程归零 2-忽略空白
        public List<short[]> km_round_list { get; private set; }

        // 标记信息数据集合
        public List<short> mark_coor_list { get; private set; }

        public List<string> mark_content_list { get; private set; }

        public List<short[]> trip_x_list { get; private set; }

        public List<string> trip_String_list { get; private set; }

        #endregion
    }
}