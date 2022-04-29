using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_Test
{
    internal class MainBase
    {

        public MainBase()
        {
            UserType = 0;
            Initialized = true;
        }

        #region 

        public static bool Initialized { get; private set; } = false;

        private static MainBase _Instance;
        public static MainBase Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new MainBase();
                }
                return _Instance;
            }
        }

        public static void GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new MainBase();
            }
        }

        #endregion

        public int UserType { get; set; } = 0;

    }

}
