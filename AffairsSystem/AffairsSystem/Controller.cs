using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AffairsSystem
{
    
    class Controller
    {
        DAL dal;
        SqlDataAdapter da;
        SqlDataReader dr;

        public Controller()
        {
            dal = new DAL();
        }

        // SEARCH SALES PERSON ON spNr
        public SqlDataReader SearchSalesPerson(string spNr)
        {
            dr = dal.SearchSalesPerson(spNr);
            return dr;
        }



    }
}
