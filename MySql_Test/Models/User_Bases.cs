using MySql.Data.MySqlClient;
using MySql_Test.Utility;
using System;
using System.Collections.Generic;
using System.Data;

namespace MySql_Test.Models
{
    public class User_Bases
    {
        public int User_Id { get; set; }
        public string User_Account { get; set; }
        public string User_Password { get; set; }
        public string User_Name { get; set; }
        public string User_Sex { get; set; }
        public int User_Type { get; set; }
        public int User_Company { get; set; }
        public bool IsDel { get; set; }

        public static List<User_Bases> ListAll()
        {
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM user_base");
            List<User_Bases> users = new List<User_Bases>();
            foreach (DataRow dr in dt.Rows)
            {
                users.Add(dr.DataRowToModel<User_Bases>());
            }
            return users;
        }

        public static int Insert(User_Bases user_Base)
        {
            return SqlHelper.ExecuteNonQuery(
                "INSERT INTO user_base(User_Account,User_Password,User_Name,User_Sex,User_Type,User_Company,IsDel)" +
                " VALUES(?User_Account,?User_Password,?User_Name,?User_Sex,?User_Type,?User_Company,?IsDel)",
                new MySqlParameter("?User_Account", user_Base.User_Account),
                new MySqlParameter("?User_Password", user_Base.User_Password),
                new MySqlParameter("?User_Name", user_Base.User_Name),
                new MySqlParameter("?User_Sex", user_Base.User_Sex),
                new MySqlParameter("?User_Type", user_Base.User_Type),
                new MySqlParameter("?User_Company", user_Base.User_Company),
                new MySqlParameter("?IsDel", user_Base.IsDel)
                );
        }

        public static int Update(User_Bases user_Base)
        {
            return SqlHelper.ExecuteNonQuery("UPDATE user_base SET User_Account=?User_Account,User_Password=?User_Password,User_Name=?User_Account,User_Sex=?User_Sex,User_Type=?User_Type,User_Company=?User_Company,IsDel=?IsDel WHERE User_Id=?User_Id",
                new MySqlParameter("?User_Id", user_Base.User_Id),
                new MySqlParameter("?User_Account", user_Base.User_Account),
                new MySqlParameter("?User_Password", user_Base.User_Password),
                new MySqlParameter("?User_Name", user_Base.User_Name),
                new MySqlParameter("?User_Sex", user_Base.User_Sex),
                new MySqlParameter("?User_Type", user_Base.User_Type),
                new MySqlParameter("?User_Company", user_Base.User_Company),
                new MySqlParameter("?IsDel", user_Base.IsDel)
                );
        }

    }
}
