using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AffairsSystem
{
    public static class UtilityAdminCheck
    {
        public static Boolean Check(SqlDataReader dr)
        {
            string adminstring = "";
            
            while (dr.Read())
            {
                adminstring = dr.GetString(4); 
            }
            if(adminstring.Equals("1"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
