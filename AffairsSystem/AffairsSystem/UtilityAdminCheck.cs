using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AffairsSystem
{
    public static class UtilityAdminCheck
    {
        public static Boolean Check(SqlDataReader dr)
        {
            
            String adminString = "";
            while (dr.Read())
            {
               
                adminString = dr.GetString(4);
                
                                
                
            }
            if (adminString.Equals("1"))
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
