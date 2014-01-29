using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AffairsSystem
{
    class DAL
    {
        SqlConnection con = new SqlConnection("Data Source=LUDVIGSBÄRBARA;Initial Catalog=affAIRs;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        //EN HUVUDMETOD VI KAN ANVÄNDA TILL QUERIES DÄR VI REGISTRERAR DATA!
        public void ExecuteSetSqlQuery(string sqlQuery)
        {
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // EN HUVUDMETOD VI KAN ANVÄNDA TILL QUERIES DÄR VI HÄMTAR DATA MED ADAPTER!
        public SqlDataAdapter ExecuteGetSqlAdapter(string sqlQuery)
        {
            cmd = new SqlCommand();
            cmd.CommandText = sqlQuery;
            da = new SqlDataAdapter(cmd);
            return da;
        }

        // EN HUVUDMETOD VI KAN ANVÄNDA TILL QUERIES DÄR VI HÄMTAR DATA MED READER!
        public SqlDataReader ExecuteGetSqlReader(string sqlQuery)
        {
            con.Close();
            con.Open();
            cmd = new SqlCommand(sqlQuery, con);
            dr = cmd.ExecuteReader();
            return dr;
            // måste på nåt sätt använda con.Close() här.....
            
        }





        // SUB-SQL-METODER:
        

        // GET ALL PRODUCTS (NR, NAME, OUTPRICE)
        public SqlDataAdapter GetAllProducts()
        {
            return ExecuteGetSqlAdapter("select productNr, productName, productOutPrice from product");
        }

        // SEARCH SALES PERSON ON spNr
        public SqlDataReader SearchSalesPerson(string spNr)
        {
            return ExecuteGetSqlReader("select * from salesperson where spNr = '" + spNr + "'");
        }













    }
}
