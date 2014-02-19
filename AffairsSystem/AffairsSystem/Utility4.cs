using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
                SqlException sqle = e as SqlException;
                switch (sqle.Errors[0].Number)
                {
                    case 2627: // Primary key violation
                        return "The product or salesperson is allready r egistered in the database, there can't be any duplicate identifiers (product number or Social security number)";

                    case 53: //Connection
                        return "There was a problem relating to the connection to the database";

                    default:
                        return "The database encountered a problem";
                }
            }

            else if (e is WebException)
            {
                return "The applikation failed to establish connection with the web based currency API";
            }
            else
            {
                return "There was a undocumented error, please try again";
            }


        }

    }
}
