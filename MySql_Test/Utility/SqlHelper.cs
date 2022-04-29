using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace MySql_Test.Utility
{
    internal class SqlHelper
    {

        //public MySqlConnection conn;

        public static string conStr;

        //public MySqlHelper()
        //{
        //    try
        //    {
        //        //conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=conf\color.mdb");
        //        //conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=conf\Config.mdb");
        //        //conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Users\KETIZU2\Desktop\Config.mdb;User ID=Admin;Jet OLEDB:Database Password=xtxfcsdz");
        //        //string dataPath = Path.Combine(Application.StartupPath, @"conf\Config.mdb");
        //        //conn = new OleDbConnection($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dataPath}");
        //        conStr = ConfigurationManager.ConnectionStrings["connString"].ToString();
        //        conn = new MySqlConnection(conStr);
        //        conn.Open();
        //        Console.WriteLine("已经建立连接");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        Console.Write(e.Message);
        //        //MessageBox.Show(e.ToString());
        //    }
        //}


        internal static DataTable ExecuteTable(string cmdText)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
        }

        internal static int ExecuteNonQuery(string cmdText, params MySqlParameter[] sqlParameters)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.AddRange(sqlParameters);
                int rows = cmd.ExecuteNonQuery();
                if (rows <= 0)
                {
                    throw new Exception("数据库操作失败");
                }
                return rows;
            }
        }

        internal static DataTable Login(string userName, string password)
        {
            string selectSql = $"SELECT * FROM sys_user WHERE user_Name = '{userName}' AND user_Password = '{password}'";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(selectSql, conn))
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
