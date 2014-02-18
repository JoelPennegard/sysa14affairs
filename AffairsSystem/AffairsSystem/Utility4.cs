using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AffairsSystem
{
    public static partial class Utility
    {

        public static string ExceptionResult(Exception e)
        {          
            
            if (e is SqlException)
            {
              return "SqlException";  
            }

            else if (e is WebException)
            {
                return "WebException";
            }
            else
            {
                return null;
            }


        }

    }
}
