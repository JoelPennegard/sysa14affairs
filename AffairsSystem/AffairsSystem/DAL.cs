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


        //EN HUVUDMETOD VI KAN ANVÄNDA TILL QUERIES DÄR VI REGISTRERAR DATA!
        public void ExecuteSetSqlQuery(string sqlQuery)
        {
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        // EN HUVUDMETOD VI KAN ANVÄNDA TILL QUERIES DÄR VI HÄMTAR GREJER MED SQLDATAADAPTER!
        public SqlDataAdapter ExecuteGetSqlAdapter(string sqlQuery)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlQuery;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }

        //GET ALL PRODUCTS
        public SqlDataAdapter GetAllProducts()
        {
            return ExecuteGetSqlAdapter("select productNr, productName, productOutPrice from product");
        }













    }
}
