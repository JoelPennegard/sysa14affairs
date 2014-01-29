using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AffairsSystem
{
    public static class Utility
    {

        // FIRST LETTER TO UPPER CASE
        public static string FirstCharToUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Du har inte skrivit in något.");
                return string.Empty;
            }
            else
            {
                return char.ToUpper(input[0]) + input.Substring(1);
            }
        }

        // CHECK IF SALES PERSON EXIST IN DATBASE
        public static string CheckSalesPerson(SqlDataReader dr)
        {
            Boolean noExist = true;
            while (dr.Read())
            {
                dr.ToString();
                noExist = false;
            }
            if (noExist)
            {
                MessageBox.Show("Not in the register.");
                return null;
            }
            else
            {
                MessageBox.Show("du är reggad mannen, välkommen in i systemet!");
                return null;
            }
        }

    }
}
