using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp.UC
{

    public partial class UCBViewControl : UserControl, IUCBViewControlEvents//, IUCBViewControl
    {

        #region 成员

        private const int PLAYSIZE = 2500;

        /// <summary>
        /// 播放定时器
        /// </summary>
        private readonly System.Windows.Forms.Timer mPlayTimer = new System.Windows.Forms.Timer();

        /// <summary>
        /// 绘制对象
        /// </summary>
        //private IDrawOperator mDrawOperator = DrawOperatorFactory.GetDrawOperator(xfBViewMode.Mode0);

        private int mPlayPointer = 0;

        private bool mNeedMovePlayPointer = false;

        private int mMouseDownX = 0;

        private bool mInitialized = false;

        /// <summary>
        /// 数据处理对象
        /// </summary>
        //private DataProcessor mDataProcessor;

        /// <summary>
        /// 回放信息
        /// </summary>
        private ReplayInfo mReplayInfo;

        private Graphics mDrawGraphics;


        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public UCBViewControl()
        {
            InitializeComponent();
        }

        public event OnPeplayInfoUpdateedDelegate OnReplayInfoUpdated;

        #endregion

        #region 控件事件



        #endregion

        #region 公共方法

        //public xfBViewMode ViewMode
        //{
        //    get { return mD}
        //}


        #endregion

        #region 私有方法



        #endregion

        #region IUCBViewControlEvents



        #endregion
    }
}
