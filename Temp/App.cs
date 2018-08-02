using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public class Rapp
    {
        #region 成员

        private static Rapp _Instance = null;

        private Dictionary<string, string> _User_list = new Dictionary<string, string>();
        private Dictionary<string, string> _Line_list = new Dictionary<string, string>();
        private Dictionary<short, string> _Mark_list = new Dictionary<short, string>();

        #endregion

        #region 构造函数

        private Rapp()
        {
            DrawSetting = new BViewDrawSettingParameter();
            SystemSetting = new SystemSetting();
        }

        #endregion

        #region 属性

        public static Rapp Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Rapp();
                }
                return _Instance;
            }
        }

        public Dictionary<string, string> User_list { get { return _User_list; } }

        public Dictionary<string, string> Line_list { get { return _Line_list; } }

        public Dictionary<short, string> Mark_list { get { return _Mark_list; } }

        public BViewDrawSettingParameter DrawSetting
        {
            get;
            private set;
        }

        public SystemSetting SystemSetting
        {
            get;
            private set;
        }

        //public ConnectAccess ConnectAccess
        //{
        //    get;
        //    private set;
        //}

        public ReplayInfo ReplayInfo { get; set; }

        #endregion
    }
}
