using MySql_Test.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql_Test
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //MainService.GetInstance();
            SqlHelper.conStr = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            using (Form_Login form_Login = new Form_Login())
            {
                form_Login.ShowDialog();

            }
            switch (MainBase.Instance.UserType)
            {
                case 1:
                    Application.Run(new Form_MySql());
                    break;
                case 2:
                    Application.Run(new Form_MySql());
                    break;
                case 3:
                    Application.Run(new Form_MySql());
                    break;
                case 4:
                    break;
                default:
                    // 退出
                    return;
            }

            //Application.Run(new Form_MySql());
        }
    }
}
