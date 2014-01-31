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
                MessageBox.Show("Please fill out all fields.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            else
            {
                return char.ToUpper(input[0]) + input.Substring(1);
            }
        }
        //CHECK INT
        public static int CheckInt(int input)
        {
            if (input == null)
            {
                MessageBox.Show("Please fill out all fields.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return input;
            }
            else
            {
                return input;
            }
        }
        //CHECK DOUBLE
        public static double CheckDouble(double input)
        {
            if (input == null)
            {
                MessageBox.Show("Please fill out all fields.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return input;
            }
            else if (input < 1)
            {
                MessageBox.Show("Price cannot be so low!.", "Check price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return input;
            }
            else
            {
                return input;
            }
        }

        // CHECK IF SALES PERSON EXIST IN DATBASE
        public static string CheckSalesPerson(SqlDataReader dr)
        {
            Boolean noExist = true;
            String clear = null;
            while (dr.Read())
            {
                clear = dr.GetString(0);
                noExist = false;
            }
            if (noExist)
            {
                MessageBox.Show("Not in the register.", "Unregistered Sales Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                return clear;
            }
        }

  

        

    }
}
