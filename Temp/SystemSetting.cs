using System;

namespace Temp
{
    public class SystemSetting
    {
        /**
        * 0.文件查询 1.报告查询 2.轨迹查询 3.xxa选项卡 4.一体机选项卡,5,文件播放 6.自动打开文件 7.自动导入文件8.显示耦合
        * 9.显示零点 10.0°调节 11.半自动播放 12.忽略空白模式 13.倒车抹除模式. 14上海版本界面 15.周期管理 16、二次波显示
        **/
        public bool[] BFile_Systemsetting_boolean_list = new bool[17];

        /**
	    * 0.版本 0-中文版 1-英文版（SP） 2-印度版 1.B显模式 2.GPS显示模式 3.背景色模式 0-黄 1-黑 4.分辨率模式 5.权限
	    * 0-智能分析 1-无 6、B显颜色显示模式 0-黄 1-黑 7、底波模式 0-底波 1-失波
	    * */
        public short[] BFile_Systemsetting_short_list = new short[8];

        /**
	    * 0.记录地址位置 1.存储上一个文件地址 2.存储上一个文件里程值3.速度参数
	    * */
        public static String[] BFile_Systemsetting_String_list = new String[4];
    }
}