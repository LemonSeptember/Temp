using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
//using XianFeng.Railway.Resources;

namespace XianFeng.Railway.Replay
{

    public class XXCFileReader
    {

        #region 公共方法

        /// <summary>
        /// 读取 xxc 文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public AnalysisedData ReadFileSummary(string filePath)
        {
            // 判断
            if (!File.Exists(filePath)) { throw new FileNotFoundException(filePath); }

            // 下位机空多个空编码值压缩展开后数量
            int PULSE_length = 0;

            // B显Gps数量
            int GPSsize_one = 0;

            // 忽略空白截取位置 记录变量
            int j_ignore = -1;

            // 连续编码值个数
            int STEP_length = 0;

            // 一次截取连续编码值个数
            int All_STEP_length = 0;

            // 最新一个忽略空白 编码位置
            int ignore_new_index = -1;



            // 用于不同分辨率状态下调整图像
            //File_Start_Blank_Size = App.frm_W / 2;
            //File_End_Blank_Size = play_size - App.frm_W / 4;

            // 文件头添加空编码值分辨率不同而不同
            int i = Common.File_Start_Blank_Size;
            int j = Common.File_Start_Blank_Size;

            // 倒车中追加的空编码值个数
            int back_add_step_size = 0;

            // 倒车位置及长度记录
            List<int> back_length_one = new List<int>();
            List<int> back_index_one = new List<int>();
            List<int> ignore_length_one = new List<int>();
            List<int> ignore_index_one = new List<int>();


            // 编码值的总数 用于进度条
            int kk = 0;
            short macType = -1;

            int fileLength = 0;
            // 下位机空多个空编码值压缩展开后数量
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // TODO:: 保证在 int 范围？
                fileLength = (int)fileStream.Length;

                using (BinaryReader firstdi = new BinaryReader(fileStream))
                {
                    try
                    {
                        while (true)
                        {
                            short firstData = ReadShort(firstdi);
                            switch (firstData)
                            {
                                case (short)xfActCode.StepNum:
                                    // 读取 Pluse 累加
                                    int readshort = ReadShort(firstdi);
                                    kk += readshort;
                                    // 此处+1为 忽略空白总数 预留位置 忽略空白开始、结束标记位占用 文件长度中
                                    // STEP_PULSE_length标记位与长度数值 位置
                                    // 当连续出现 STEP_PULSE_length时，xxc长度则大于实际数据长度 xxc数组末尾为空值
                                    PULSE_length += readshort;
                                    break;
                                case (short)xfActCode.Encoder_Step:
                                    kk++;
                                    break;
                                case (short)xfActCode.MacType:
                                    macType = ReadShort(firstdi);
                                    back_add_step_size = GetBackAddStepSize(macType);

                                    // 读入机型后切换显示面板
                                    // TODO::刷新 UI
                                    // 读入机型后切换显示面板
                                    // newBFile_DrawPanel_one.readMactype();
                                    break;
                                case (short)xfActCode.GPS:
                                    GPSsize_one++;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    catch (EndOfStreamException ex)
                    {
                        // 读取结束
                        // Logging 
                    }
                }
            }

            // 得到参数数组长度 //1500--文件末尾增加空编码值 //PULSE_length-需要膨胀的编码脉冲累计个数
            // xxc_list = new short[500+(int) f.length()+1500 +
            // PULSE_length+Power_ON_Size*Power_ON_blank_Size];

            // B显数据列表//readB所得出的数据链表
            short[] xxc_list_one = new short[Common.File_Start_Blank_Size + fileLength + Common.File_End_Blank_Size + PULSE_length];

            // readB所得出的编码值链表
            int[] StepPulse_list = new int[Common.File_Start_Blank_Size + kk + Common.File_End_Blank_Size]; ;

            for (int size = 0; size < Common.File_Start_Blank_Size; size++)
            {
                xxc_list_one[size] = (short)xfActCode.Encoder_Step;
                StepPulse_list[size] = size;
            }

            // 忽略空白截取范围
            int ignore_Size = 1000;

            // 忽略空白中前后插入空白距离 20170901 50改100 邓
            int ignore_spacing_Size = 100;

            // 忽略空白中最大拼孔值差
            int ignore_probe_distance_max = 250;


            //* 0.文件查询 1.报告查询 2.轨迹查询 3.xxa选项卡 4.一体机选项卡,5,文件播放 6.自动打开文件 7.自动导入文件8.显示耦合
            //* 9.显示零点 10.0°调节 11.半自动播放 12.忽略空白模式 13.倒车抹除模式. 14上海版本界面 15.周期管理 16、二次波显示
            bool[] BFile_Systemsetting_boolean_list = new bool[17] { true, true, true, true, true, true, false, false, false, true, false, false, false, false, true, true, true };


            // 实际工作编码长度
            int StepPulse_listsize = j;

            //TODO::xxb 处理略过
            // xxc 不用处理倒车
            // 下位机空多个空编码值压缩展开后数量
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader di = new BinaryReader(fileStream))
                {
                    try
                    {
                        if (macType == 0 || macType == 1)
                        {
                            while (true)
                            {
                                short data = ReadShort(di);
                                if (data == (short)xfActCode.Encoder_Step)// 编码脉冲
                                {
                                    if (BFile_Systemsetting_boolean_list[12]) { All_STEP_length++; }

                                    xxc_list_one[i] = data;
                                    StepPulse_list[j] = i;
                                    i++;
                                    j++;
                                }
                                // 倒车结束
                                else if (data == (short)xfActCode.BackEnd)
                                {
                                    if (BFile_Systemsetting_boolean_list[13])
                                    {
                                        // 改为倒车抹除
                                        // 倒车长度 -- 编码脉冲
                                        short back_Length = ReadShort(di);
                                        if (back_Length >= 32766 || ignore_new_index > (j - back_Length - back_add_step_size))
                                        {
                                            back_length_one.Add(0);
                                            back_index_one.Add(0);
                                            xxc_list_one[i] = data;
                                            i++;
                                            xxc_list_one[i] = back_Length;
                                        }
                                        else
                                        {
                                            int index_Max = j;
                                            int index_Max_i = i;
                                            // 此处减去400为 倒车结束后 下位机自动追加400空编码脉冲
                                            // 向前找参数
                                            j = index_Max - back_Length - back_add_step_size;

                                            // 开机倒车问题 防止将重要参数抹除
                                            if (j < Common.File_Start_Blank_Size + 10)
                                                j = Common.File_Start_Blank_Size + 10;

                                            // 此if用于忽略空白时记录倒车标记位置 防止忽略将倒车剪去
                                            if (BFile_Systemsetting_boolean_list[12])
                                            {
                                                // 与倒车储存的参数拉开一个编码值
                                                j_ignore = j;
                                                All_STEP_length = 0;
                                            }

                                            i = StepPulse_list[j];

                                            xxc_list_one[i] = data;
                                            i++;
                                            xxc_list_one[i] = back_Length;
                                            i++;

                                            for (int index = StepPulse_list[j]; index < index_Max_i; index++)
                                            {
                                                xfActCode actCode = (xfActCode)xxc_list_one[index];
                                                switch (actCode)
                                                {
                                                    // 关机状态及复位模式（工作模式）
                                                    // 开机状态及复位模式（工作模式）
                                                    // 里程归零（工作模式）
                                                    case xfActCode.PowerOff:
                                                    case xfActCode.PowerOn:
                                                    case xfActCode.KMRound:
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        break;
                                                    // 机号，正常时0为结束标记，加脉冲标记是为防止字符串漏写0
                                                    // 人员，轨型，轨型，线号，场号,股号,铁号处理方式相同
                                                    case xfActCode.MacNum:
                                                    case xfActCode.User:
                                                    case xfActCode.RailType:
                                                    case xfActCode.LineNum:
                                                    case xfActCode.SiteNum:
                                                    case xfActCode.TrackNum:
                                                    case xfActCode.RailNum:
                                                        int num = 1;
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        while (xxc_list_one[index + num] != 0)
                                                        {
                                                            xxc_list_one[i] = xxc_list_one[index + num];
                                                            i++;
                                                            num++;
                                                        }
                                                        xxc_list_one[i] = 0;
                                                        i++;
                                                        break;
                                                    // 轨高,轨头高，螺孔高，行别，里程方向，线别，工作模式
                                                    // 反射报警,穿透报警
                                                    case xfActCode.RailHgt:
                                                    case xfActCode.RailHeadHgt:
                                                    case xfActCode.RailBoltHgt:
                                                    case xfActCode.LinkType:
                                                    case xfActCode.Count:
                                                    case xfActCode.LineType:
                                                    case xfActCode.WorkMode:
                                                    case xfActCode.BackAlarm:
                                                    case xfActCode.PassAlarm:
                                                    case xfActCode.Brightness:
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 1];
                                                        i++;
                                                        break;
                                                    // 旧标记，增益,探头角度,声程,零点
                                                    // 探头位置（水平偏移也称为拼孔值）
                                                    case xfActCode.OldMark:
                                                    case xfActCode.Gain:
                                                    case xfActCode.ProbeAng:
                                                    case xfActCode.TestRange:
                                                    case xfActCode.ZeroDelay:
                                                    case xfActCode.ProbePosition:
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 1];
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 2];
                                                        i++;
                                                        break;
                                                    // 探头射向
                                                    case xfActCode.ProbeDir:
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 1];
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 2];
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 3];
                                                        i++;
                                                        break;
                                                    // 新标记
                                                    case xfActCode.NewMark:
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 1];
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 2];
                                                        i++;
                                                        xxc_list_one[i] = xxc_list_one[index + 3];
                                                        i++;
                                                        int new_mark_num = 4;
                                                        while (xxc_list_one[index + new_mark_num] != 0)
                                                        {
                                                            xxc_list_one[i] = xxc_list_one[index + new_mark_num];
                                                            i++;
                                                            new_mark_num++;
                                                        }
                                                        xxc_list_one[i] = 0;
                                                        i++;
                                                        break;

                                                    case xfActCode.SpROT_CUST:
                                                    case xfActCode.SpSECT1:
                                                    case xfActCode.SpELR1:
                                                    case xfActCode.SpELR2:
                                                    case xfActCode.SpTID:
                                                    case xfActCode.SpRID:
                                                    case xfActCode.SpRWT:
                                                    case xfActCode.SpTRF:
                                                    case xfActCode.SpUIC:
                                                    case xfActCode.SpSECT2:
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        for (int add = 1; add < 16; add++)
                                                        {
                                                            xxc_list_one[i] = xxc_list_one[index + add];
                                                            i++;
                                                        }
                                                        xxc_list_one[i] = 0;
                                                        i++;
                                                        break;
                                                    case xfActCode.SpOPER:
                                                        int SpOPER_int = 1;
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        while (xxc_list_one[index + SpOPER_int] != 0 && SpOPER_int <= Common.SpOPER_String_size)
                                                        {
                                                            xxc_list_one[i] = xxc_list_one[index + SpOPER_int];
                                                            i++;
                                                            SpOPER_int++;
                                                        }
                                                        xxc_list_one[i] = 0;
                                                        i++;
                                                        break;
                                                    case xfActCode.SpLR:
                                                        int SpLR_int = 1;
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        while (xxc_list_one[index + SpLR_int] != 0 && SpLR_int <= Common.SpLR_String_size)
                                                        {
                                                            xxc_list_one[i] = xxc_list_one[index + SpLR_int];
                                                            i++;
                                                            SpLR_int++;
                                                        }
                                                        xxc_list_one[i] = 0;
                                                        i++;
                                                        break;
                                                    case xfActCode.SpPROC:
                                                        int SpPROC_int = 1;
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        while (xxc_list_one[index + SpPROC_int] != 0 && SpPROC_int <= Common.SpPROC_String_size)
                                                        {
                                                            xxc_list_one[i] = xxc_list_one[index + SpPROC_int];
                                                            i++;
                                                            SpPROC_int++;
                                                        }
                                                        xxc_list_one[i] = 0;
                                                        i++;
                                                        break;
                                                    case xfActCode.SpCUST:
                                                        int SpCUST_int = 1;
                                                        xxc_list_one[i] = (short)actCode;
                                                        i++;
                                                        while (xxc_list_one[index + SpCUST_int] != 0 && SpCUST_int <= Common.SpCUST_String_size)
                                                        {
                                                            xxc_list_one[i] = xxc_list_one[index + SpCUST_int];
                                                            i++;
                                                            SpCUST_int++;
                                                        }
                                                        xxc_list_one[i] = 0;
                                                        i++;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                            }
                                        }

                                    }
                                    else
                                    {
                                        // 此if用于忽略空白时记录倒车标记位置 防止忽略将倒车剪去
                                        if (BFile_Systemsetting_boolean_list[12])
                                        {
                                            j_ignore = j;
                                            All_STEP_length = 0;
                                        }

                                        // 不抹除时按顺序写入数据
                                        short back_Length = ReadShort(di);
                                        xxc_list_one[i] = data;
                                        i++;
                                        xxc_list_one[i] = back_Length;
                                        i++;

                                        // 如果倒车大于三米 则计算里程时不应减去
                                        if (back_Length >= 32766)
                                            back_Length = 0;
                                        // 记录倒车位置和添加位置
                                        back_length_one.Add((int)back_Length);
                                        back_index_one.Add(j);
                                    }
                                }
                                else if (data <= (short)xfActCode.Time && data >= (short)xfActCode.BattPercent)
                                {
                                    // 20170918只忽略米包信息
                                    // 遇到非米包信息
                                    // 记录编码脉冲位置
                                    // 用于忽略空白
                                    xxc_list_one[i] = data;
                                    i++;
                                }
                                // TODO 忽略问题 2017-09-16 由遇到什么停止 改为 遇到什么不停止比如 米包不停下
                                else if (data < (short)xfActCode.Encoder_Step)
                                {
                                    // 表示 出去上方所有的标记位 以外都需要记录位置
                                    if (BFile_Systemsetting_boolean_list[12])
                                    {
                                        /*********************** 此部分为将一个完整B显点数据写入 老数据结构写4位 新结构写3位 ***********************/
                                        // 如果空白长度不足以忽略时
                                        if (All_STEP_length < ignore_Size)
                                        {
                                            xxc_list_one[i] = data;
                                            i++;
                                        }

                                        /****************** 空白长度足以忽略时 ****************************/
                                        else if (All_STEP_length > ignore_Size)
                                        {
                                            j = j_ignore;
                                            // 得到当前B显点后一个编码值xxc数组位置
                                            // j值永远为当前编码脉冲的下一位
                                            // 用于可能得到里程时间等显示信息
                                            i = StepPulse_list[j];

                                            // 此循环为忽略空白填充空编码值
                                            for (int length = 0; length < ignore_spacing_Size; length++)
                                            {
                                                xxc_list_one[i] = (short)xfActCode.Encoder_Step;
                                                StepPulse_list[j] = i;
                                                i++;
                                                j++;
                                            }
                                            xxc_list_one[i] = (short)xfActCode.STEP_BLANK_end;
                                            i++;

                                            // 记录忽略空白位置及长度 用于作业参数中工作里程计算
                                            // WorkInfoMileage_values
                                            ignore_length_one.Add(All_STEP_length);
                                            ignore_index_one.Add(j);
                                            ignore_new_index = j;

                                            // 此循环为忽略空白填充空编码值
                                            // ignore_probe_distance_max为防止拼孔混乱添加
                                            for (int length = 0; length < ignore_spacing_Size
                                                    + ignore_probe_distance_max; length++)
                                            {
                                                xxc_list_one[i] = (short)xfActCode.Encoder_Step;
                                                StepPulse_list[j] = i;
                                                i++;
                                                j++;
                                            }
                                            xxc_list_one[i] = data;
                                            i++;
                                        }
                                        // 进入到这里 即为需要忽略空白停下的位置
                                        j_ignore = j;
                                        All_STEP_length = 0;
                                    }
                                    else
                                    {
                                        // 不忽略时 改怎么记录怎么记录
                                        xxc_list_one[i] = data;
                                        i++;
                                    }
                                }
                                else
                                {
                                    xxc_list_one[i] = data;
                                    i++;
                                }
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                // TODO:: 如果为xxC 不用处理倒车
                                short data = ReadShort(di);
                                if (data == (short)xfActCode.StepNum)
                                {

                                    STEP_length = ReadShort(di);
                                    if (BFile_Systemsetting_boolean_list[12])
                                        All_STEP_length = All_STEP_length + STEP_length;

                                    for (int length = 0; length < STEP_length; length++)
                                    {
                                        xxc_list_one[i] = (short)xfActCode.Encoder_Step;
                                        StepPulse_list[j] = i;
                                        i++;
                                        j++;

                                    }
                                }
                                else if (data == (short)xfActCode.Encoder_Step)
                                {// TODO 编码脉冲
                                    if (BFile_Systemsetting_boolean_list[12])
                                        All_STEP_length++;

                                    xxc_list_one[i] = data;
                                    StepPulse_list[j] = i;
                                    // 此处i++必须放在 StepPulse_list[j] = i; 之后 否则指向向后偏移一位
                                    i++;
                                    j++;

                                }
                                else if (data <= (short)xfActCode.Time && data >= (short)xfActCode.BattPercent)
                                {
                                    // 20170918只忽略米包信息
                                    // 遇到非米包信息
                                    // 记录编码脉冲位置
                                    // 用于忽略空白
                                    xxc_list_one[i] = data;
                                    i++;
                                }
                                else if (data < (short)xfActCode.Encoder_Step)
                                {
                                    // 表示 出去上方所有的标记位 以外都需要记录位置
                                    if (BFile_Systemsetting_boolean_list[12])
                                    {
                                        /*********************** 此部分为将一个完整B显点数据写入 老数据结构写4位 新结构写3位 ***********************/
                                        // 如果空白长度不足以忽略时
                                        if (All_STEP_length < ignore_Size)
                                        {
                                            xxc_list_one[i] = data;
                                            i++;
                                        }

                                        /****************** 空白长度足以忽略时 ****************************/
                                        else if (All_STEP_length > ignore_Size)
                                        {
                                            j = j_ignore;
                                            // 得到当前B显点后一个编码值xxc数组位置
                                            // j值永远为当前编码脉冲的下一位
                                            // 用于可能得到里程时间等显示信息
                                            i = StepPulse_list[j];

                                            xxc_list_one[i] = (short)xfActCode.STEP_BLANK_end;
                                            i++;
                                            // 此循环为忽略空白填充空编码值
                                            // ignore_probe_distance_max为防止拼孔混乱添加
                                            for (int length = 0; length < ignore_spacing_Size
                                                    + ignore_probe_distance_max; length++)
                                            {
                                                xxc_list_one[i] = (short)xfActCode.Encoder_Step;
                                                StepPulse_list[j] = i;
                                                i++;
                                                j++;
                                            }
                                            xxc_list_one[i] = data;
                                            i++;
                                        }
                                        j_ignore = j;
                                        All_STEP_length = 0;
                                    }
                                    else
                                    {
                                        xxc_list_one[i] = data;
                                        i++;
                                    }
                                }
                                else
                                {
                                    xxc_list_one[i] = data;
                                    i++;
                                }
                            }
                        }
                    }
                    catch (EndOfStreamException ex)
                    {
                        // 读取结束
                        // Logging 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    // 文件尾添加Ecoder
                    for (int size = 0; size < Common.File_End_Blank_Size; size++)
                    {

                        xxc_list_one[i + size] = (short)xfActCode.Encoder_Step;
                        StepPulse_list[j + size] = i + size;
                    }

                    // 防止文件以倒车结束编码值指针为储存
                    // TODO::lwh StepPulse_listsize 可以用 StepPulse_list.size 来替换么？
                    // 不太可以把 tepPulse_list.size在忽略空白时 会大于 StepPulse_listsize
                    StepPulse_listsize = j + Common.File_End_Blank_Size;
                }
            }

            return new AnalysisedData(xxc_list_one);
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 不同机型倒车空白追加不同
        /// </summary>
        /// <param name="macType">0 - GCT-8C 1-GCT-11 2-SP 3-GL</param>
        /// <returns>倒车空白长度</returns>
        private int GetBackAddStepSize(int macType)
        {
            switch (macType)
            {
                case 0:
                case 1:
                    return 400;
                case 2:
                    return 0;
                default:
                    //Console.WriteLine(macType);
                    return 0;
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// 通过大端的方式读取 short值
        /// </summary>
        /// <param name="bw"></param>
        /// <returns></returns>
        private short ReadShort(BinaryReader bw)
        {
            if (bw == null) { throw new ArgumentNullException(); }

            Byte[] bytes = bw.ReadBytes(2);
            if (bytes == null || bytes.Length <= 0) { throw new EndOfStreamException(); }
            return (short)((bytes[0] << 8) + bytes[1]);
        }

        /// <summary>
        /// 将区间内的数组转换为字符串
        /// </summary>
        /// <param name="data">数据源</param>
        /// <param name="dataIndex">起始索引</param>
        /// <param name="dataSize">长度</param>
        /// <param name="dataSize">默认开始位置</param>
        /// <returns></returns>
        public static string GetPeroidString(short[] data, int dataIndex, int dataSize, int num = 1)
        {
            StringBuilder sb = new StringBuilder();
            while (data[dataIndex + num] != 0 && data[dataIndex + num] != (short)xfActCode.Encoder_Step && num <= dataSize)
            {
                sb.Append((char)data[dataIndex + num]);
                ++num;
            }

            return sb.ToString();
        }

        /// <summary>
        /// 将区间内的数组转换为字符串
        /// </summary>
        /// <param name="data">数据源</param>
        /// <param name="dataIndex">起始索引</param>
        /// <param name="dataSize">长度</param>
        /// <returns></returns>
        public static void Get2PeroidString(short[] data, int dataIndex, int dataSize1, int dataSize2, ref string peroidString1, ref string peroidString2)
        {
            int num = 1;
            StringBuilder sb = new StringBuilder();
            while (data[dataIndex + num] != 0 && data[dataIndex + num] != (short)xfActCode.Encoder_Step && num <= dataSize1)
            {
                sb.Append((char)data[dataIndex + num]);
                ++num;
            }

            peroidString1 = sb.ToString();

            num++;
            sb = new StringBuilder();
            while (data[dataIndex + num] != 0 && data[dataIndex + num] != (short)xfActCode.Encoder_Step && num <= dataSize2)
            {
                sb.Append((char)data[dataIndex + num]);
                ++num;
            }
            peroidString2 = sb.ToString();

            //string SpROT_CUST_String = "";
            //int SpROT_CUST_int = 1;
            //while (xxc_list[k + SpROT_CUST_int] != 0 && xxc_list[k + SpROT_CUST_int] != xfActCode.Encoder_Step && SpROT_CUST_int <= Common.Sp_New_Name_String_size)
            //{
            //    SpROT_CUST_String += (char)xxc_list[k + SpROT_CUST_int];
            //    SpROT_CUST_int++;
            //}
            //ROT_label_name_SP.Text = SpROT_CUST_String;
            //SpROT_CUST_int++;
            //SpROT_CUST_String = "";
            //while (xxc_list[k + SpROT_CUST_int] != 0 && xxc_list[k + SpROT_CUST_int] != xfActCode.Encoder_Step && SpROT_CUST_int <= Common.Sp_New_All_String_size)
            //{
            //    SpROT_CUST_String += (char)xxc_list[k + SpROT_CUST_int];
            //    SpROT_CUST_int++;
            //}
            //ROT_label_SP.Text = SpROT_CUST_String;
        }


        /// <summary>
        /// 将区间内的数组转换为字符串
        /// </summary>
        /// <param name="data">数据源</param>
        /// <param name="dataIndex">起始索引</param>
        /// <param name="dataSize">长度</param>
        /// <returns></returns>
        public static string GetPeroidByteString(short[] data, int dataIndex, int dataSize)
        {
            int num = 1;
            byte[] bytes = new byte[dataSize];
            while (data[dataIndex + num] != 0 && data[dataIndex + num] != (short)xfActCode.Encoder_Step && num <= dataSize)
            {
                bytes[num - 1] = (byte)data[dataIndex + num];
                ++num;
            }
            //team_label.setText(" " + new String(machine_team));
            return Encoding.UTF8.GetString(bytes, 0, num);
        }

        #endregion
    }
}




