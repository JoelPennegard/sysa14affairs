using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AffairsSystem
{
    public static partial class Utility
    {
        public static bool CheckAdmin(SqlDataReader dr)
        {
            bool isAdmin = true;
            while (dr.Read())
            {
                isAdmin = dr.GetBoolean(4);                
            }
            if (isAdmin)
            {
                return true;
            }
            else
            {
                return false;
            }
       }
        public static bool CheckOnlyNumbers(string text)
        {

            foreach (char c in text)
            {
                if (c < '0' || c > '9' )
                    return false;
            }
            return true;
        }
        public static bool CheckOnlyNumbersAndDecimals(string text)
        {

            foreach (char c in text)
            {
                if (c < '0' || c > '9')

                {
                    if (!c.Equals('.')){
                    return false;
                    }
                }
            }
            return true;
        }
        public static string GetSalesPersonName(SqlDataReader dr)
        {
            string name = "";
            while (dr.Read())
            {
                name = dr.GetString(1) + " " + dr.GetString(2);
            }
            return name;
                    
        }
        public static bool CheckIfContainsForbiddenChars(string searchString)
        {
            string s = "'";
            if (searchString.Contains(s))
            {
                return true;
            }
            else 
            {
                return false; 
            }

        }
        public static bool CheckIfSearchIsEmpty(string searchString)
        {
            
            if (searchString.Length < 1)
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
