using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace HT10D
{
    class HT10D_FileReader
    {

        /// <summary>
        /// 图片文件长度
        /// </summary>
        private const int PicLength = 218240;
        /// <summary>
        /// 图片高度
        /// </summary>
        private const int PicHeight = 480;
        /// <summary>
        /// 图片宽度
        /// </summary>
        private const int PicWidth = 640;

        /// <summary>
        /// A显波形长度
        /// </summary>
        private const int AViewLength = 256;

        public HT10D_Info ReadFileSummary(string filePath)
        {
            // 判断
            if (!File.Exists(filePath)) { throw new FileNotFoundException(filePath); }

            HT10D_Info mHT10D_Info = new HT10D_Info();
            mHT10D_Info.FilePath = filePath;
            short[] data_list;
            int fileLength = 0;

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                fileLength = (int)fileStream.Length;
                data_list = new short[fileLength];
                int i = 0;
                using (BinaryReader firstdi = new BinaryReader(fileStream))
                {
                    try
                    {
                        while (true)
                        {
                            short firstData = ReadShort(firstdi);
                            data_list[i] = firstData;
                            i++;
                        }
                    }
                    catch (Exception e)
                    {
                        //throw;
                    }
                }
            }

            for (int index = 0; index < data_list.Length; index++)
            {
                xfActCode actCode = (xfActCode)data_list[index];
                short[] temp = new short[AViewLength];

                switch (actCode)
                {

                    case xfActCode.HT_WeldNum:
                        mHT10D_Info.DamageInfo.WeldNum = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.WeldNum.Length;
                        break;
                    case xfActCode.HT_SwitchNum:
                        mHT10D_Info.DamageInfo.SwitchNum = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.SwitchNum.Length;
                        break;
                    case xfActCode.HT_RailNum:
                        mHT10D_Info.DamageInfo.RailNum = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.RailNum.Length;
                        break;
                    case xfActCode.HT_WeldType:
                        mHT10D_Info.DamageInfo.WeldType = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_WeldDesc:
                        mHT10D_Info.DamageInfo.WeldDesc = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.WeldDesc.Length;
                        break;
                    case xfActCode.HT_RailDesc:
                        mHT10D_Info.DamageInfo.RailDesc = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.RailDesc.Length;
                        break;
                    case xfActCode.HT_RailFactory:
                        mHT10D_Info.DamageInfo.RailFactory = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.RailFactory.Length;
                        break;
                    case xfActCode.HT_RailSteel:
                        mHT10D_Info.DamageInfo.RailSteel = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.RailSteel.Length;
                        break;
                    case xfActCode.HT_FurnaceNum:
                        mHT10D_Info.DamageInfo.FurnaceNum = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.FurnaceNum.Length;
                        break;
                    case xfActCode.HT_DamageType:
                        mHT10D_Info.DamageInfo.DamageType = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_DamageSize:
                        mHT10D_Info.DamageInfo.DamageSize = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_DamagePos:
                        mHT10D_Info.DamageInfo.DamagePos = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_DamageDesc:
                        mHT10D_Info.DamageInfo.DamageDesc = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.DamageDesc.Length;
                        break;
                    case xfActCode.HT_PosDesc:
                        mHT10D_Info.DamageInfo.PosDesc = GetUTF8String(data_list, index);
                        index += mHT10D_Info.DamageInfo.PosDesc.Length;
                        break;
                    case xfActCode.HT_X:
                        mHT10D_Info.DamageInfo.HT_X = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Y:
                        mHT10D_Info.DamageInfo.HT_Y = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_GainDelta:
                        mHT10D_Info.DamageInfo.GainDelta = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_TestRange:
                        mHT10D_Info.DamageInfo.TestRange = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_PulseShift:
                        mHT10D_Info.DamageInfo.PulseShift = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Launch:
                        mHT10D_Info.DamageInfo.Launch = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Receiving:
                        mHT10D_Info.DamageInfo.Receiving = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Damping:
                        mHT10D_Info.DamageInfo.Damping = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Intensity:
                        mHT10D_Info.DamageInfo.Intensity = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_PulseWidth:
                        mHT10D_Info.DamageInfo.PulseWidth = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Suppress:
                        mHT10D_Info.DamageInfo.Suppress = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Bandwidth:
                        mHT10D_Info.DamageInfo.Bandwidth = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Detection:
                        mHT10D_Info.DamageInfo.Detection = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_WorkMode:
                        mHT10D_Info.DamageInfo.WorkMode = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_ProbeType:
                        mHT10D_Info.DamageInfo.ProbeType = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_RepeatFreq:
                        mHT10D_Info.DamageInfo.RepeatFreq = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_FrontDist:
                        mHT10D_Info.DamageInfo.FrontDist = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_ZeroDelay:
                        mHT10D_Info.DamageInfo.ZeroDelay = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Crystal:
                        mHT10D_Info.DamageInfo.Crystal = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_ProbeFreq:
                        mHT10D_Info.DamageInfo.ProbeFreq = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_SoundVelocity:
                        mHT10D_Info.DamageInfo.SoundVelocity = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Thickness:
                        mHT10D_Info.DamageInfo.Thickness = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_AmpMode:
                        mHT10D_Info.DamageInfo.AmpMode = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_WaveType:
                        mHT10D_Info.DamageInfo.WaveType = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_MeasureUnit:
                        mHT10D_Info.DamageInfo.MeasureUnit = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_SurfaceCompEn:
                        mHT10D_Info.DamageInfo.SurfaceCompEn = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_MeasureTrigger:
                        mHT10D_Info.DamageInfo.MeasureTrigger = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_Language:
                        mHT10D_Info.DamageInfo.Language = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_APicture:
                        mHT10D_Info.AViewImage = GetViewImage(data_list, index);
                        break;
                    case xfActCode.HT_BPicture:
                        mHT10D_Info.BViewImage = GetViewImage(data_list, index);
                        break;
                    case xfActCode.HT_ChanNum:
                        mHT10D_Info.DamageInfo.ChanNum = data_list[index + 1];
                        index += 1;
                        break;
                    case xfActCode.HT_GateHand:
                        mHT10D_Info.DamageInfo.GateHand = data_list[index + 1];
                        break;
                    case xfActCode.HT_GateWidth:
                        mHT10D_Info.DamageInfo.GateWidth = data_list[index + 1];
                        break;
                    case xfActCode.HT_GateHight:
                        mHT10D_Info.DamageInfo.GateHeight = data_list[index + 1];
                        break;
                    case xfActCode.AWAVE:
                        if (mHT10D_Info.AViewList == null)
                        {
                            mHT10D_Info.AViewList = new List<short[]>();
                        }
                        GetAViewList(mHT10D_Info, data_list, index);
                        index += AViewLength / 2;
                        break;
                    default:
                        if ((int)actCode < -10000 && (int)actCode > -12000)
                        {
                            Console.WriteLine(actCode);
                        }
                        break;
                }

            }

            return mHT10D_Info;

        }

        private void GetAViewList(HT10D_Info mHT10D_Info, short[] data_list, int index)
        {
            short[] AView = new short[AViewLength];
            for (int i = 0; i < AViewLength / 2; i++)
            {
                short temp = data_list[index + i + 1];
                byte byte2 = (byte)temp;
                byte byte1 = (byte)(temp >> 8);
                AView[i * 2] = byte1;
                AView[i * 2 + 1] = byte2;
            }
            mHT10D_Info.AViewList.Add(AView);
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

        private Bitmap GetViewImage(short[] dataList, int index)
        {
            List<short> imageArray = new List<short>();
            Bitmap bitmap = new Bitmap(PicWidth, PicHeight);
            int colorIndex = index;
            for (int x = 0; x < PicWidth; x++)
            {
                for (int y = 0; y < PicHeight; y++)
                {
                    Color color = Color.FromArgb(dataList[++index], dataList[++index], dataList[++index]);
                    bitmap.SetPixel(x, y, color);
                    //index += 3;
                }
            }
            return bitmap;
        }

        private Bitmap GetImage(short[] dataList, int index)
        {
            List<int[]> imageArray = new List<int[]>();

            for (int i = 0; i < PicHeight; i++)
            {
                int[] temp = new int[PicWidth];
                for (int j = 0; j < (PicWidth / 2); j++)
                {
                    short value = dataList[index + (i * (PicWidth / 2)) + j + 1];
                    temp[j * 2 + 1] = value & 0xff;
                    temp[j * 2] = (value >> 8) & 0xff;
                }
                imageArray.Add(temp);
            }
            //return imageArray;

            Bitmap bitmap = new Bitmap(PicWidth, PicHeight);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color = GetColor(imageArray[y][x]);
                    bitmap.SetPixel(x, y, color);
                }
            }
            return bitmap;
        }

        private Bitmap GetBitmap(short[] dataList, int index)
        {
            Bitmap bitmap = new Bitmap(1, 1);
            List<byte> bytelist = new List<byte>();
            for (int i = 0; i + index < dataList.Length; i++)
            {
                bytelist.Add((byte)dataList[i + index]);
            }
            try
            {
                using (MemoryStream ms = new MemoryStream(bytelist.ToArray()))
                {
                    bitmap = (Bitmap)Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return bitmap;
        }

        /// <summary>
        /// 将区间内的数组转换为字符串
        /// (UTF-8)
        /// </summary>
        /// <param name="dataList">数据源</param>
        /// <param name="dataIndex">起始索引</param>
        /// <param name="dataSize">长度</param>
        /// <param name="dataSize">默认开始位置</param>
        /// <returns></returns>
        public static string GetUTF8String(short[] dataList, int dataIndex)
        {
            //byte[] bytes = new byte[dataSize];
            int num = 1;
            List<byte> bytes = new List<byte>();
            while (dataList[dataIndex + num] != 0 && dataList[dataIndex + num] != (short)xfActCode.Encoder_Step)
            {
                bytes.Add((byte)dataList[dataIndex + num]);
                num++;
            }
            string str = Encoding.UTF8.GetString(bytes.ToArray());
            return str;

        }

        /// <summary>
        /// 获取颜色
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private Color GetColor(int key)
        {
            Color value = new Color();
            switch (key)
            {
                case 0xE0:// 纯红
                    value = Color.FromArgb(255, 0, 0);
                    break;

                case 0xF0:// 橙
                    value = Color.FromArgb(255, 128, 0);
                    break;

                case 0x03:// 纯蓝
                    value = Color.FromArgb(0, 0, 255);
                    break;

                case 0x1C:// 纯绿
                    value = Color.FromArgb(0, 255, 0);
                    break;

                case 0x1F:// 亮蓝
                    value = Color.FromArgb(0, 255, 255);
                    break;

                case 0x8C:// 棕
                    value = Color.FromArgb(144, 96, 0);
                    break;

                case 0xE3:// 紫红
                    value = Color.FromArgb(255, 0, 255);
                    break;

                case 0xFC:// 黄
                    value = Color.FromArgb(255, 255, 0);
                    break;

                case 0xFF:// 白
                    value = Color.FromArgb(255, 255, 255);
                    break;

                case 0x00:// 黑
                    value = Color.FromArgb(0, 0, 0);
                    break;

                case 0x10:// 深绿
                    value = Color.FromArgb(0, 128, 0);
                    break;

                case 0xF2:// 粉红
                    value = Color.FromArgb(255, 128, 128);
                    break;

                case 0x93:// 浅紫
                    value = Color.FromArgb(128, 128, 255);
                    break;

                case 0x0D:// 蓝绿
                    value = Color.FromArgb(0, 119, 119);
                    break;

                case 0x13:// 浅蓝
                    value = Color.FromArgb(0, 128, 255);
                    break;

                case 0x6D:// 灰
                    value = Color.FromArgb(110, 110, 110);
                    break;


                case 0xFE:// 背景色（浅黄）
                    value = Color.FromArgb(255, 255, 200);
                    break;

                case 0x55:// 绿色填充
                    value = Color.FromArgb(0, 176, 80);
                    break;

                case 0x80:// 红色填充
                    value = Color.FromArgb(255, 0, 0);
                    break;

                case 0x02:// 黄色背景下字体（深绿）
                    value = Color.FromArgb(0, 0, 255);
                    break;


                default:
                    value = Color.Green;
                    //Console.WriteLine(key);
                    break;
            }

            return value;
        }



    }
}
