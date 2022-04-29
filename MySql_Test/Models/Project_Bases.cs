using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_Test.Models
{
    internal class Project_Bases
    {
        public int Prj_Id { get; set; }
        public string Prj_Name { get; set; }    
        public string Prj_Director { get; set; }    
        public string Prj_OtherPerson { get; set; }    
        public int Prj_Level { get; set; }    
        public string Prj_Project { get; set; }    
        public string Prj_SonProject { get; set; }    
        public string Prj_Remarks { get; set; }    
        public string Prj_Details { get; set; }    
        public bool IsDel { get; set; }    


    }
}
