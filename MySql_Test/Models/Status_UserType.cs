using MySql_Test.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_Test.Models
{
    internal class Status_UserType
    {
        public int T_Id { get; set; }
        public string T_Name { get; set; }

        public static List<Status_UserType> ListAll()
        {
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM status_user_type");
            List<Status_UserType> cuses = new List<Status_UserType>();
            foreach (DataRow dr in dt.Rows)
            {
                cuses.Add(dr.DataRowToModel<Status_UserType>());
            }
            return cuses;
        }
    }
}
