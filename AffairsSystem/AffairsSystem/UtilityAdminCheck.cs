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
            Boolean Admin = false;
            while (dr.Read())
            {                
                Admin = dr.GetBoolean(4);                               
            }
            if (Admin)
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
