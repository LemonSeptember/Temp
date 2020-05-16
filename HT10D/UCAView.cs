using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HT10D
{
    public partial class UCAView : UserControl
    {

        #region 成员

        /// <summary>
        /// 底部高度
        /// </summary>
        private const short BOTTOM_VALUE = 4;

        /// <summary>
        /// 闸门辅助线高度
        /// </summary>
        private const short GATE_VALUE = 3;

        /// <summary>
        /// 宽度
        /// </summary>
        private const int PicWidth = 250;

        /// <summary>
        /// 高度
        /// </summary>
        private const int PicHeight = 255;

        /// <summary>
        /// 文件二数组起点
        /// </summary>
        private const int SecondNum = 128;

        private int _startPoint = 0;
        private int _playPoint = 0;
        private bool _envelope = false;

        /// <summary>
        /// X坐标缩放比
        /// </summary>
        private float xRate;

        /// <summary>
        /// Y坐标缩放比
        /// </summary>
        private float yRate;

        /// <summary>
        /// 是否需要绘制背景
        /// </summary>
        private bool IfDrawBackImage = true;

        /// <summary>
        /// 通道
        /// </summary>
        public xfChannelNo mChannelNo;

        /// <summary>
        /// 闸门颜色
        /// </summary>
        public Color gate_Color = Color.Blue;

        /// <summary>
        /// 底部辅助线颜色
        /// </summary>
        public Color bottom_Color = Color.Red;

        /// <summary>
        /// 背景色
        /// </summary>
        public Color imageBack_Color = Color.Black;

        /// <summary>
        /// 通道A颜色
        /// </summary>
        public Color channelA_Color = Color.FromArgb(255, 128, 0);

        /// <summary>
        /// 通道B颜色
        /// </summary>
        public Color channelB_Color = Color.FromArgb(0, 255, 255);

        /// <summary>
        /// 初始化
        /// </summary>
        private bool mInitialized = false;


        #endregion


        #region 属性

        /// <summary>
        /// 参数信息
        /// </summary>
        public HT10D_Info mHT10D_Info { get; set; }

        /// <summary>
        /// 起始位置
        /// </summary>
        public int StartPoint
        {
            get { return _startPoint; }
            set
            {
                _startPoint = value;
                //Invalidate();
                RefreshImage();
            }
        }

        /// <summary>
        /// 播放位置
        /// </summary>
        public int PlayPoint
        {
            get { return _playPoint; }
            set
            {
                _playPoint = value;
                //Invalidate();
                RefreshImage();
            }
        }

        public bool mEnvelope
        {
            get { return _envelope; }
            set
            {
                _envelope = value;
                EnvelopePoint = PlayPoint + StartPoint;
                //Invalidate();
                RefreshImage();
            }
        }

        /// <summary>
        /// 包络点
        /// </summary>
        public int EnvelopePoint;


        #endregion

        public UCAView()
        {
            InitializeComponent();
        }


        #region 控件事件

        /// <summary>
        /// 大小改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCAView_Resize(object sender, EventArgs e)
        {
            if (pictureBox.Width == 0 || pictureBox.Height == 0)
            {
                return;
            }
            xRate = pictureBox.Width / (float)PicWidth;
            yRate = (pictureBox.Height - BOTTOM_VALUE) / (float)PicHeight;
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.BackgroundImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            IfDrawBackImage = true;
            //Invalidate();
            RefreshImage();
        }

        #endregion


        #region 公共方法

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="ht10D_Info"></param>
        public void InitAView(HT10D_Info ht10D_Info)
        {
            this.mHT10D_Info = ht10D_Info;

            xRate = pictureBox.Width / (float)PicWidth;
            yRate = (pictureBox.Height - BOTTOM_VALUE) / (float)PicHeight;

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.BackgroundImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            IfDrawBackImage = true;

            mInitialized = true;
            //Invalidate();
            RefreshImage();
        }

        /// <summary>
        /// 刷新图像
        /// </summary>
        public void RefreshAView()
        {
            IfDrawBackImage = true;
            RefreshImage();
        }


        #endregion


        #region 私有方法

        private void RefreshImage()
        {
            if (!mInitialized)
            {
                return;
            }

            if (pictureBox.Width == 0 || pictureBox.Height == 0)
            {
                return;
            }


            // 绘制背景
            if (IfDrawBackImage)
            {
                Bitmap backBitmap = new Bitmap(pictureBox.BackgroundImage);
                Graphics bg = Graphics.FromImage(backBitmap);
                DrawSubline(bg);
                pictureBox.BackgroundImage = backBitmap;
                IfDrawBackImage = false;
            }


            // 绘制图像         
            {
                Bitmap bitmap = new Bitmap(pictureBox.Image);
                if (!mEnvelope)
                {
                    bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                }
                if (StartPoint + PlayPoint < EnvelopePoint)
                {
                    bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                }
                EnvelopePoint = StartPoint + PlayPoint;
                Graphics g = Graphics.FromImage(bitmap);
                DrawGate(g);
                DrawAView(g);
                pictureBox.Image = bitmap;
            }
            //GC.Collect();
        }


        #region 绘制方法

        /// <summary>
        /// 绘制辅助线
        /// </summary>
        /// <param name="g"></param>
        private void DrawSubline(Graphics g)
        {
            g.Clear(imageBack_Color);

            //float sublineWidth = (pictureBox.Width - 3) / (float)10;
            float sublineWidth = (pictureBox.Width - 1) / (float)10;
            for (int i = 0; i <= 10; i++)
            {
                //Pen pen = new Pen(Color.WhiteSmoke, 1f) { DashStyle = DashStyle.Custom, DashPattern = new float[] { 3, 9 }, LineJoin = LineJoin.Round, DashCap = DashCap.Round };
                Pen pen = new Pen(Color.Gray, 1f) { DashStyle = DashStyle.Custom, DashPattern = new float[] { 3, 9 } };
                float cenX = sublineWidth * i;
                g.DrawLine(pen, cenX, 0, cenX, pictureBox.Height);
            }

            float sublineHeight = (pictureBox.Height - BOTTOM_VALUE) / (float)10;
            for (int i = 0; i <= 10; i++)
            {
                Pen pen = new Pen(Color.Gray, 1f) { DashStyle = DashStyle.Custom, DashPattern = new float[] { 3, 9 } };
                float cenY = sublineHeight * i;
                g.DrawLine(pen, 0, cenY, pictureBox.Width, cenY);
            }

        }

        /// <summary>
        /// 绘制闸门
        /// </summary>
        /// <param name="g"></param>
        private void DrawGate(Graphics g)
        {
            int point = StartPoint + PlayPoint;
            if (point >= mHT10D_Info.AViewList.Count)
            { point = mHT10D_Info.AViewList.Count - 1; }

            //Pen pen = new Pen(Color.Red, 3f);
            SolidBrush brush = new SolidBrush(bottom_Color);
            //SolidBrush brush = new SolidBrush(Color.Brown);

            //g.DrawLine(pen, new Point(0, Height - BOTTOM_VALUE), new Point(Width, Height - BOTTOM_VALUE));
            g.FillRectangle(brush, new Rectangle(0, pictureBox.Height - GATE_VALUE, pictureBox.Width, GATE_VALUE));

            int gateHand = mHT10D_Info.DamageInfo.GateHand;
            int gateWidth = mHT10D_Info.DamageInfo.GateWidth;
            int gateHeigth = mHT10D_Info.DamageInfo.GateHeight;
            //int gateHand = GetGateHand(point);
            //int gateTail = GetGateTail(point);

            float cenX1 = gateHand * xRate;
            float cenX2 = gateWidth * xRate;
            float cenY = (PicHeight - gateHeigth) * yRate;

            SolidBrush gateBrush = new SolidBrush(gate_Color);
            //SolidBrush gateBrush = new SolidBrush(Color.Blue);

            g.FillRectangle(gateBrush, new RectangleF(cenX1, cenY, cenX2, GATE_VALUE));

        }

        /// <summary>
        /// 绘制图像
        /// </summary>
        /// <param name="g"></param>
        private void DrawAView(Graphics g)
        {

            int index = StartPoint + PlayPoint;

            if (index >= mHT10D_Info.AViewList.Count) { return; }

            short[] drawList = mHT10D_Info.AViewList[index];

            // 上一个点
            PointF lastPoint = new PointF(0, pictureBox.Height - BOTTOM_VALUE);

            Color lineColor = GetChannelColor();
            Pen pen = new Pen(lineColor, 2f);

            for (int i = 0; i < PicWidth; i++)
            {
                short temp = drawList[i];
                if (temp > PicHeight)
                {
                    temp = PicHeight;
                }

                float cenX1 = (i + 1) * xRate;
                float cenY1 = pictureBox.Height - BOTTOM_VALUE - (temp * yRate);
                PointF thisPoint = new PointF(cenX1, cenY1);

                g.DrawLine(pen, lastPoint, thisPoint);

                lastPoint = thisPoint;

            }

        }

        #endregion


        /// <summary>
        /// 获取闸门前沿
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private int GetGateHand(int point)
        {
            int gateHand = 0;
            List<int> gateHead_List;
            List<int> gateHead_Value;
            return 0;

            //switch (mChannelNo)
            //{
            //    case xfChannelNo.A:
            //        gateHead_List = mHT10D_Info.InfoList.Gate0Head_ChannelA_List;
            //        gateHead_Value = mHT10D_Info.InfoList.Gate0Head_ChannelA_Value;
            //        break;
            //    case xfChannelNo.B:
            //        gateHead_List = mHT10D_Info.InfoList.Gate0Head_ChannelB_List;
            //        gateHead_Value = mHT10D_Info.InfoList.Gate0Head_ChannelB_Value;
            //        break;
            //    default:
            //        return 0;
            //}
            //for (int headIndex = gateHead_List.Count - 1; headIndex >= 0; headIndex--)
            //{
            //    if (gateHead_List[headIndex] <= point)
            //    {
            //        gateHand = gateHead_Value[headIndex];
            //        break;
            //    }
            //}
            //return gateHand;
        }

        /// <summary>
        /// 获取闸门后沿
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private int GetGateTail(int point)
        {
            int gateTail = 0;
            List<int> gateTail_List;
            List<int> gateTail_Value;
            switch (mChannelNo)
            {
                //case xfChannelNo.A:
                //    gateTail_List = mHT10D_Info.InfoList.Gate0Tail_ChannelA_List;
                //    gateTail_Value = mHT10D_Info.InfoList.Gate0Tail_ChannelA_Value;
                //    break;
                //case xfChannelNo.B:
                //    gateTail_List = mHT10D_Info.InfoList.Gate0Tail_ChannelB_List;
                //    gateTail_Value = mHT10D_Info.InfoList.Gate0Tail_ChannelB_Value;
                //    break;
                default:
                    return 0;
            }
            for (int tailIndex = gateTail_List.Count - 1; tailIndex >= 0; tailIndex--)
            {
                if (gateTail_List[tailIndex] <= point)
                {
                    gateTail = gateTail_Value[tailIndex];
                    break;
                }
            }
            return gateTail;
        }

        /// <summary>
        /// 获取通道颜色
        /// </summary>
        /// <returns></returns>
        private Color GetChannelColor()
        {
            Color channelColor = Color.Red;
            //switch (mChannelNo)
            //{
            //    case xfChannelNo.A:
            //        channelColor = Color.FromArgb(128, 128, 255);
            //        break;
            //    case xfChannelNo.B:
            //        channelColor = Color.FromArgb(0, 255, 0);
            //        break;
            //}
            switch (mChannelNo)
            {

                case xfChannelNo.A:
                    channelColor = channelA_Color;
                    break;
                case xfChannelNo.B:
                    channelColor = channelB_Color;
                    break;
            }
            return channelColor;
        }

        #endregion


    }
}
