﻿namespace Temp
{
    public enum xfBViewMode
    {
        // 二次波压缩模式，8C显示模式，1区显示，斜70度纵坐标压缩至轨头
        //即A、B、C、D通道y方向上压缩50%
        Mode0 = 0,

        // 实际位置模式，1区显示，所有通道按实际坐标显示，所有通道组合
        Mode1 = 1,

        //上海模式 将主屏幕分为三个区域 分别显示 70° 37° 0°探头数据
        // 所占屏幕比例为2:4:4  70°所显示为轨头高度 37°0°为整个钢轨高度
        Mode2 = 2,


        Mode3 = 3,


        Mode4 = 4
    }
}