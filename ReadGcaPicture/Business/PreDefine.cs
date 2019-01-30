using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XianFeng.Railway.Replay
{
    public class Common
    {
        // 打开文件时添加的空白编码脉冲个数
        //public static readonly int File_Start_Blank_Size = 640;
        public static readonly int File_Start_Blank_Size = 0;

        //public static readonly int File_End_Blank_Size = 2180;
        public static readonly int File_End_Blank_Size = 0;


        // 静态中 作业信息中 使用
        public static readonly short MacNum_String_size = 8;
        public static short User_String_size = 4;
        public static readonly short Team_String_size = 4;
        public static readonly short Area_String_size = 4;
        public static readonly short Unit_String_size = 4;
        public static short LineNum_String_size = 4;
        public static short SiteNum_String_size = 4;
        public static short TrackNum_String_size = 4;
        public static short RailNum_String_size = 4;
        public static short RailType_String_size = 4;

        public static readonly short Sp_New_Name_String_size = 4;
        public static readonly short Sp_New_All_String_size = 13;

        public static readonly short SpOPER_String_size = 3;
        public static readonly short SpROT_String_size = 4;
        public static readonly short SpSECT1_String_size = 4;
        public static readonly short SpELR1_String_size = 3;
        public static readonly short SpELR2_String_size = 4;
        public static readonly short SpTID_String_size = 4;
        public static readonly short SpLR_String_size = 1;
        public static readonly short SpRID_String_size = 4;
        public static readonly short SpRWT_String_size = 2;
        public static readonly short SpTRF_String_size = 4;
        public static readonly short SpUIC_String_size = 4;
        public static readonly short SpPROC_String_size = 3;
        public static readonly short SpSECT2_String_size = 4;
        public static readonly short SpMARK_String_size = 4;
        public static readonly short SpCUST_String_size = 4;
        public static readonly short SpWave_String_size = 256;
        public static readonly short SpPROBE_String_size = 1;
        public static readonly short SpDIVI_String_size = 4;
        public static readonly short SpUD_String_size = 1;
        public static readonly short SpROLL_String_size = 9;
        public static readonly short SpFLAW_String_size = 4;
        public static readonly short SpCLASSNEW_String_size = 4;
        public static readonly short SpCLASSOLD_String_size = 4;
        // 忽略空白中前后插入空白距离 20170901 50改100 邓
        internal static readonly int Ignore_Spacing_Size = 100;
        // 忽略空白中最大拼孔值差
        internal static readonly int Ignore_Probe_Distance_Max = 250;
    }
}
