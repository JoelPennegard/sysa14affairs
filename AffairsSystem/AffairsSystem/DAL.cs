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

        SqlConnection con = new SqlConnection("Data Source=ROBINS;Initial Catalog=affAIRs2.0;Integrated Security=True");
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

        //GET SALES (SALESPERSON)
        public SqlDataAdapter GetSalesPersonSales(string spNr)
        {
            return ExecuteGetSqlAdapter("select * from sales where spNr = '" + spNr + "' order by salesDate desc");
        }

        // SEARCH SALES PERSON ON spNr
        public SqlDataReader SearchSalesPerson(string spNr)
        {
            return ExecuteGetSqlReader("select * from salesperson where spNr = '" + spNr + "'");
        }

        // SEARCH SALES PERSON ON ALL ATTRIBUTES
        public SqlDataAdapter SearchSalesPersonAllAttributes(string sPnr, string firstName, string lastName, string sPhone)
        {
            return ExecuteGetSqlAdapter("select * from salesperson where sPnr like '%" + sPnr + "%' or firstName like '%" + firstName + 
                "%' or lastName like '%" + lastName + "%' or sPhone like '%" + sPhone + "%'");
        }
        
        // SEARCH PRODUCT IN TILL (NOT PRODUCTINPRICE)
        public SqlDataAdapter SearchProductTill(int productNr, string productName, double productOutPrice, int amount)
        {
            return ExecuteGetSqlAdapter("select * from product where productNr like '%" + productNr + "%' or productName like '%" + productName + 
                "%' or productOutPrice like '%" + productOutPrice + "%' or amount like '%" + amount + "%'");
        }
      
        // SEARCH PRODUCT ALL ATTRIBUTES
        public SqlDataAdapter SearchProductAllAttributes(int productNr, string productName, double productInPrice, double productOutPrice, int amount)
        {
            return ExecuteGetSqlAdapter("select * from product where productNr like '%" + productNr + "%' or productName like '%" + productName +
                "%' or productInPrice like '%" + productInPrice + "%' or productOutPrice like '%" + productOutPrice + "%' or amount like '%" + amount + "%'");
        }
        



        //CREATE NEW SALES PERSON
        public void SetSalesPerson(string sPnr, string firstName, string lastName, string sPhone){
            ExecuteSetSqlQuery("insert into salesperson values('" + sPnr + "','" + firstName + "','" + lastName + "','" + sPhone +"')");
        }

        // CREATE NEW PRODUCT
        public void SetProduct(string productName, double productInPrice, double productOutPrice, int amount)
        {
            ExecuteSetSqlQuery("insert into product values('" + productName + "'," + productInPrice + "," + productOutPrice + "," + amount + ")");
        }

        // CREATE NEW SALE
        public void SetSale(string sPnr, double totalPrice)
        {
            ExecuteSetSqlQuery("insert into product values (getdate(), '" + sPnr + "'," + totalPrice + ")");
        }

        //CREATE NEW SALESLINE
        public void SetSalesLine(int productNr, int salesNumber, int amount)
        {
            ExecuteSetSqlQuery("insert into salesline values (" + productNr + "," + salesNumber + "," + amount + ")");
        }

      



        












    }
}
