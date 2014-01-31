using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AffairsSystem
{
    class DAL
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        
        /// <summary>
        /// A constructor that checks the name of the current computer and changes the connection-string 
        /// accordingly 
        /// </summary>
        public DAL()
        {
            string computerName = SystemInformation.ComputerName;
            string connectionString = "";

            if(computerName.Equals("JOEL-DATOR"))
            {
                connectionString =  "Data Source=JOEL-DATOR;Initial Catalog=affAIRsystem;Integrated Security=True";
            }
            else if(computerName.Equals("MAX-DATOR"))
            {
                connectionString =  "Data Source=MAX-DATOR;Initial Catalog=affAIRsystem;Integrated Security=True";
            }
            else if (computerName.Equals("LUDVIGSBÄRBARA"))
            {
                connectionString = "Data Source=LUDVIGSBÄRBARA;Initial Catalog=affAIRs;Integrated Security=True";
            }
            else if (computerName.Equals("MALEXANDER"))
            {
                connectionString = "Data Source=MALEXANDER;Initial Catalog=affAIRs;Integrated Security=True";
            }
            else if (computerName.Equals("ROBINSDATORNNAMN"))
            {
                connectionString = "";
            }
            else { }

            //MessageBox.Show("Konstruktorn i DAL hälsar att detta är din connectionstring: \n \n " + connectionString + " \n \n det är bara att klicka OK så kommer du vidare");
            con = new SqlConnection(connectionString);

        }
        
        //EN HUVUDMETOD VI KAN ANVÄNDA TILL QUERIES DÄR VI REGISTRERAR DATA!
        public void ExecuteSetSqlQuery(string sqlQuery)
        {
            con.Close();
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // EN HUVUDMETOD VI KAN ANVÄNDA TILL QUERIES DÄR VI HÄMTAR DATA MED ADAPTER!
        public SqlDataAdapter ExecuteGetSqlAdapter(string sqlQuery)
        { 
            con.Close(); 
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            da = new SqlDataAdapter(cmd); 
                      
            return da;
            
                       
        }

        // EN HUVUDMETOD VI KAN ANVÄNDA TILL QUERIES DÄR VI HÄMTAR DATA MED READER!
        public SqlDataReader ExecuteGetSqlReader(string sqlQuery)
        {
            con.Close();       
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            dr = cmd.ExecuteReader();
            return dr;
                        
        }





        // SUB-SQL-METODER:
        

        // GET ALL PRODUCTS (NR, NAME, OUTPRICE)
        public SqlDataAdapter GetAllProducts()
        {
            return ExecuteGetSqlAdapter("select productNr, productName, productOutPrice from product");
        }

        // GET ALL PRODUCTS (NR, NAME, OUTPRICE, INPRICE)
        public SqlDataAdapter GetAllProductsWithInPrice()
        {
            return ExecuteGetSqlAdapter("select * from product");
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
        public SqlDataAdapter SearchSalesPersonAllAttributes(string spNr, string firstName, string lastName, string sPhone)
        {
            return ExecuteGetSqlAdapter("select * from salesperson where spNr like '%" + spNr + "%' or firstName like '%" + firstName + 
                "%' or lastName like '%" + lastName + "%' or sPhone like '%" + sPhone + "%'");
        }
        
        // SEARCH PRODUCT IN TILL (NOT PRODUCTINPRICE)
        public SqlDataAdapter SearchProductTill(string productNr, string productName, string productOutPrice)
        {
            return ExecuteGetSqlAdapter("select productNr, productName, productOutPrice from product where productNr like '%" + 
                productNr + "%' or productName like '%" + productName + 
                "%' or productOutPrice like '%" + productOutPrice + "%'");
        }
      
        // SEARCH PRODUCT ALL ATTRIBUTES
        public SqlDataAdapter SearchProductAllAttributes(int productNr, string productName, double productInPrice, double productOutPrice, int amount)
        {
            return ExecuteGetSqlAdapter("select * from product where productNr like '%" + productNr + "%' or productName like '%" + productName +
                "%' or productInPrice like '%" + productInPrice + "%' or productOutPrice like '%" + productOutPrice + "%' or amount like '%" + amount + "%'");
        }

        // UPDATE PRODUCT AMOUNT (ADMIN)
        public void UpdateProductAmount(int amount, string productNr)
        {
            ExecuteSetSqlQuery("update product set amount = amount + '" + amount + "' where productNr = " + productNr);
        }

        //UPDATE PRODUCT (ADMIN)
        public void UpdateProduct (int productNr, string productName, double productInPrice, double productOutPrice, int amount)
        {
            ExecuteSetSqlQuery("update product set productName = '" + productName + "', productInPrice = " + productInPrice + 
                ", ProductOutPrice = " + productOutPrice + ", amount = " + amount + " where productNr = " + productNr);
        }            

        //UPDATE SALES PERSON (ADMIN)
        public void UpdateSalesPerson(string firstName, string lastName, string sPhone, string spNr)
        {
            ExecuteSetSqlQuery("update salesperson set firstName = '" + firstName +", lastName = '" + lastName + 
                ", sPhone = '" + sPhone + "' where spNr = '" + spNr + "'");
        }

        //CREATE NEW SALES PERSON (ADMIN)
        public void SetSalesPerson(string spNr, string firstName, string lastName, string sPhone){
            ExecuteSetSqlQuery("insert into salesperson values('" + spNr + "','" + firstName + "','" + lastName + "','" + sPhone +"')");
        }

        // CREATE NEW PRODUCT (ADMIN)
        public void SetProduct(string productName, double productInPrice, double productOutPrice, int amount)
        {
            ExecuteSetSqlQuery("insert into product values('" + productName + "'," + productInPrice + "," + productOutPrice + "," + amount + ")");
        }

        // CREATE NEW SALE
        public void SetSale(string spNr, double totalPrice)
        {
            ExecuteSetSqlQuery("insert into product values getdate(), '" + spNr + "'," + totalPrice + ")");
        }


        //CREATE NEW SALESLINE
        public void SetSalesLine(int productNr, int salesNumber, int amount)
        {
            ExecuteSetSqlQuery("insert into salesline values (" + productNr + "," + salesNumber + "," + amount + ")");
        }

        //SELECT SALESPERSON WITH HIGHEST/LOWEST SALES

        public SqlDataAdapter GetHighestSales()
        {
            return ExecuteGetSqlAdapter("select a.spNr, firstname, lastname, count(*) as [Amount of sales] from salesperson a join sales b " +
                "on a.spNr = b.spNr group by a.spNr, firstname, lastname order by count(*) desc");
        }

        // SELECT TOP 1 SALESPERSON WITH THE HIGHEST SALE
        public SqlDataAdapter GetTopOneSalesPerson()
        {
            return ExecuteGetSqlAdapter("select top 1 firstname, lastname, salesNr, max(totalprice) as [Total Price]from salesperson a join sales b" +
                "on a.spNr = b.spNr group by firstname, lastname, totalprice, salesNr order by totalprice desc");
        }

        //SELECT MOST SOLD PRUDUCT AND THE PROFIT OF THIS PRODUCT
        public SqlDataAdapter GetTopProductSale()
        {
            return ExecuteGetSqlAdapter("select a.productNr, productName, sum(a.amount) as [Total Sales], (sum(a.amount * productOutPrice) - sum(a.amount * productInPrice)) as [Difference]" +
                "from salesline a join product p on a.productNr = p.productNr group by a.productNr, productName");
        }

    }
}
