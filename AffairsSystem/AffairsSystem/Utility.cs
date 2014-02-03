using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AffairsSystem
{
    public static partial class Utility
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
        // CHECK LATEST SALE
        public static int CheckLatestSale(SqlDataReader dr)
        {
            int result = 0;
            while (dr.Read())
            {
                result = dr.GetInt32(0);
            }
            return result;
        }
        //GET PRODUCT AMOUNT
        public static int GetProductAmount(SqlDataReader dr)
        {
            int result = 0;
            while (dr.Read())
            {
                result = dr.GetInt32(0);
            }
            return result;
        }
        //CHECK PRODUCT AMOUNT
        public static int CheckProductAmount(int productAmount, int amountInt)
        {
            int amount = 0;
            if (productAmount == 0)
            {
                MessageBox.Show("There is no left of this product.", "Order more", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return amount;
            }
            else if (productAmount < amountInt)
            {
                MessageBox.Show("There are only " + productAmount + " items left of this product\n" +
                    "so you can't make this sale", "Order more", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return amount;
            }
            else if (productAmount > amountInt)
            {
                amount = productAmount - amountInt;

                if (amount < 11)
                {
                    MessageBox.Show("It is now only " + amount + " left of this product, please order more", "Order more", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return amount;
                }
                return amount;
            }
            else
            {
                MessageBox.Show("That was the last one! ORDER MORE!", "Order more", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                amount = 1;
                return amount;
            }




        }
        public static int ConvertBoolToInt(bool input)
        {
            int output = 0;
            if (input)
            {
                output = 1;
                return output;
            }
            else
            {
                output = 0;
                return output;
            }
        }
    }
        

    
}
