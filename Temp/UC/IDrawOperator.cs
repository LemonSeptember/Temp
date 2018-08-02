using System.Drawing;

namespace Temp
{
    public interface IDrawOperator
    {
        BViewDrawSettingParameter DrawSetting { get; set; }

        xfBViewMode ViewMode { get; }

        void InitDrawParams(ReplayInfo projectInfo, int drawHeight);

        Image GetSublineImage(RailParams railParams, Size drawSize, BDrawData drawDatas);
    }
}