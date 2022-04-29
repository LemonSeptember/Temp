using MySql_Test.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_Test.Models
{
    internal class Status_UserCompany
    {
        public int Cmp_Id { get; set; } 
        public string Cmp_Name { get; set; }

        public static List<Status_UserCompany> ListAll()
        {
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM status_user_company");
            List<Status_UserCompany> cmps = new List<Status_UserCompany>();
            foreach (DataRow dr in dt.Rows)
            {
                cmps.Add(dr.DataRowToModel<Status_UserCompany>());
            }
            return cmps;
        }
    }
}
