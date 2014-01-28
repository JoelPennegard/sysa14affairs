using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffairsSystem
{
    public static class Utility
    {

        //FIRST LETTER TO UPPER CASE
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

    }
}
