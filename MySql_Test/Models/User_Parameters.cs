using MySql.Data.MySqlClient;
using MySql_Test.Utility;
using System.Collections.Generic;
using System.Data;

namespace MySql_Test.Models
{
    public class User_Parameters
    {
        public int User_Id { get; set; }
        public string User_Account { get; set; }
        public string User_Name { get; set; }
        public int Cmp_Id { get; set; }
        public string Cmp_Name { get; set; }
        public int T_Id { get; set; }
        public string T_Name { get; set; }
        public bool IsDel { get; set; }

        public static List<User_Parameters> ListAll()
        {
            //DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM sys_user");
            DataTable dt = SqlHelper.ExecuteTable("SELECT	user_base.User_Id,	user_base.User_Account,	user_base.User_Name,	user_base.IsDel,	user_type_dictionary.T_Id,	user_type_dictionary.T_Name,	user_company_dictionary.Cmp_Id,	user_company_dictionary.Cmp_Name FROM	user_base	LEFT JOIN user_company_dictionary ON user_base.User_Company = user_company_dictionary.Cmp_Id	LEFT JOIN user_type_dictionary ON user_base.User_Type = user_type_dictionary.T_Id GROUP BY	user_base.User_Id");
            List<User_Parameters> parameters = new List<User_Parameters>();
            foreach (DataRow dr in dt.Rows)
            {
                parameters.Add(dr.DataRowToModel<User_Parameters>());
            }
            return parameters;
        }
    }
}
