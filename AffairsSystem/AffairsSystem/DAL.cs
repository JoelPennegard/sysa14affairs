   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


// Sökfunktionerna saknar fortfarande dokumentation

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
            if (computerName.Equals("JOEL-POEL"))
            {
                connectionString = "Data Source=JOEL-POEL;Initial Catalog=affAIRsystem;Integrated Security=True";
            }
            else if(computerName.Equals("MAX-DATOR"))
            {
                connectionString =  "Data Source=MAX-DATOR;Initial Catalog=affAIRsystem;Integrated Security=True";
            }
            else if (computerName.Equals("LUDVIGSBÄRBARA"))
            {
                connectionString = "Data Source=LUDVIGSBÄRBARA;Initial Catalog=affAIRs;Integrated Security=True";
            }
            else if (computerName.Equals("LUDVIGSDATOR"))
            {
                connectionString = "Data Source=LUDVIGSDATOR;Initial Catalog=affAIRs;Integrated Security=True";
            }
            else if (computerName.Equals("MALEXANDER"))
            {
                connectionString = "Data Source=MALEXANDER;Initial Catalog=affAIRs;Integrated Security=True";
            }
            else if (computerName.Equals("ROBINS"))
            {
                connectionString = "Data Source=ROBINS;Initial Catalog=affAIRs3.0;Integrated Security=True";
            }
            else { }

            
            con = new SqlConnection(connectionString);

        }
        
        /// <summary>
        /// A generic method to use when updating the dataBase information
        /// </summary>
        /// <param name="sqlQuery">the sqlQuery to be sent to the dataBase</param>

        public void ExecuteSetSqlQuery(string sqlQuery)
        {
            con.Close();
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// A generic method that fetches database information with the sqlDataAdapter class.
        /// </summary>
        /// <param name="sqlQuery">the sqlQuery to be sent to the dataBase</param>
        /// <returns>a sqlDataAdapter with the results from the query</returns>
 
        public SqlDataAdapter ExecuteGetSqlAdapter(string sqlQuery)
        { 
            con.Close(); 
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            
            return da;
                       
        }

        /// <summary>
        /// A generic method that fetches database information with the sqlDataReader class.
        /// </summary>
        /// <param name="sqlQuery">the sqlQuery to be sent to the dataBase</param>
        /// <returns>a sqlDataReader with the results from the query</returns>
        
        public SqlDataReader ExecuteGetSqlReader(string sqlQuery)
        {
            con.Close();       
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            dr = cmd.ExecuteReader();
            return dr;
                        
        }

        /// <summary>
        /// Gets a list containing the number, name and listed price of all products in the Product table
        /// </summary>
        /// <returns>a sqlDataAdapter containing a table of products</returns>
        public SqlDataAdapter GetAllProductsToSaleList()
        {
            return ExecuteGetSqlAdapter("select productNr as [Product Nr], productName as [Product Name], productOutPrice [Price] from product where isForSale = 1 and amount > 0");
        }

        /// <summary>
        /// Gets a list containing all products and their complete information
        /// </summary>
        /// <returns>a sqlDataAdapter containing a table of products</returns>
 
        public SqlDataAdapter GetAllProductsForSale()
        {
            return ExecuteGetSqlAdapter("select productNr as [Product Nr], productName as [Product Name], ProductInPrice as [In Price], " +
                "productOutPrice as [Out Price], amount as Amount, isForSale as [Is For Sale] from product where isForSale = 1");
        }

        public SqlDataAdapter GetAllProductsNotForSale()
        {
            return ExecuteGetSqlAdapter("select productNr as [Product Nr], productName as [Product Name], ProductInPrice as [In Price], " +
                "productOutPrice as [Out Price], amount as Amount, isForSale as [Is For Sale] from product where isForSale = 0");
        }
        //GET IsACTIVE
        public SqlDataReader GetIsActive(string spNr)
        {
            return ExecuteGetSqlReader("select isActive from salesperson where spNr = '" + spNr + "'");
        }

        //GET ALL WORKING SALES PERSONS
        public SqlDataAdapter GetAllWorkingSalesPersons()
        {
            return ExecuteGetSqlAdapter("select spNr as [Security Nr], firstName as [First Name], lastName as [Last Name], sPhone as [Phone Nr] " +
                "from salesperson where isActive = 1");
        }
        //GET ALL NOT WORKING SALES PERSONS
        public SqlDataAdapter GetAllNotWorkingSalesPersons()
        {
            return ExecuteGetSqlAdapter("select spNr as [Security Nr], firstName as [First Name], lastName as [Last Name], sPhone as [Phone Nr] " + 
                "from salesperson where isActive = 0");
        }

        //SEARCH ON WORKING SALES PERSONS (ADMIN)
        public SqlDataAdapter SearchWorkingSalesPerson(string search) {

            return ExecuteGetSqlAdapter("select spNr as [Security Nr], firstName as [First Name], lastName as [Last Name], sPhone as [Phone Nr] " +
                "from salesperson where isActive = 1 and (spNr like '%" + search + "%' or firstName like '%" + search +
                    "%' or lastName like '%" + search + "%' or sPhone like '%" + search + "%')");
        }
        
        //SEARCH ON NOT WORKING SALES PERSONS (ADMIN)
        public SqlDataAdapter SearchNotWorkingSalesPerson(string search)
        {
            return ExecuteGetSqlAdapter("select spNr as [Security Nr], firstName as [First Name], lastName as [Last Name], sPhone as [Phone Nr] " +
                "from salesperson where isActive = 0 and (spNr like '%" + search + "%' or firstName like '%" + search +
                    "%' or lastName like '%" + search + "%' or sPhone like '%" + search + "%')");
        }
        //GET SALESLINES FROM A SPECIFIC SALE
        public SqlDataAdapter GetSalesLinesFromSale(int salesNr)
        {
            return ExecuteGetSqlAdapter("select p.productNr as [Product Nr], productName as [Product Name], productOutPrice as [Price], " +
                "i.amount as [Amount] from product p join salesline i " +
                "on p.productNr = i.productNr where salesNr =" + salesNr);
        }

        //SELECT ALL SALES A SALESPERSON MADE BETWEEN DATES
        public SqlDataAdapter GetSalesPersonSalesBetweenDates(string spNr, string startDate, string endDate)
        {
            return ExecuteGetSqlAdapter("select salesNr as [Sales Nr], salesDate as [Date], totalPrice as [Total Price] from sales where spNr = '" + spNr +
                "' and (salesDate between '" + startDate + "' and '" + endDate + "') order by salesDate desc");
        }

        //GET ALL SALES WITH ALL SALESPERSONS
        public SqlDataAdapter GetAllSalesFromAllSalesPersons()
        {
            return ExecuteGetSqlAdapter("select spNr as [Employee Nr], salesNr as [Sales Nr],salesDate as [Date], totalPrice as [Total Price] from sales order by salesDate desc");
        }

        //GET ALL SALES WITH ALL SALESPERSONS BETWEEN DATES
        public SqlDataAdapter GetAllSalesFromAllSalesPersonsBetweenDates(string startDate, string endDate)
        {
            return ExecuteGetSqlAdapter("select spNr as [Employee Nr], salesNr as [Sales Nr],salesDate as [Date], totalPrice as [Total Price] from sales " +
                "where salesDate between '" + startDate + "' and '" + endDate + "' order by salesDate desc");
        }

        //GET ALL SALESPERSONS SPNR'S 
        public SqlDataReader GetAllSalesPersonSpnr()
        {
            return ExecuteGetSqlReader("select spNr from salesPerson");
        }

        /// <summary>
        /// Gets a list containing all Sales made by a specified salesPerson
        /// </summary>
        /// <param name="spNr">the identifying number of the specified salesPerson</param>
        /// <returns>a sqlDataAdapter containing a table of all Sales made by the specified salesPerson c</returns>
        
        public SqlDataAdapter GetSalesPersonSales(string spNr)
        {
            return ExecuteGetSqlAdapter("select salesNr as [Sales Nr], salesDate as [Date], totalPrice as [Total Price] from sales where spNr = '" + spNr + "' order by salesDate desc");
        }

        /// <summary>
        /// Gets the information of a specified salesPerson
        /// </summary>
        /// <param name="spNr">the identifying number of the specified salesPerson</param>
        /// <returns>a sqlDataReader containing the salespersons information</returns>
        
        public SqlDataReader SearchSalesPerson(string spNr)
        {
            return ExecuteGetSqlReader("select * from salesperson where spNr = '" + spNr + "'");
        }

        // SEARCH PRODUCT IN TILL (NOT PRODUCTINPRICE)
        public SqlDataAdapter SearchProductTill(string search)
        {
            return ExecuteGetSqlAdapter("select productNr as [Product Nr], productName as [Product Name], productOutPrice as [Price] " +
                "from product where isForSale = 1 and (productNr like '%" + 
                search + "%' or productName like '%" + search + "%' or productOutPrice like '%" + search + "%')");
        }
      
        // SEARCH PRODUCT ALL ATTRIBUTES (ON SALE)
        public SqlDataAdapter SearchProductAllAttributesForSale(string search)
        {
            return ExecuteGetSqlAdapter("select productNr as [Product Nr], productName as [Product Name], productInPrice as [In Price], " +
                "productOutPrice as [Out Price], amount as [Amount], isForSale as [Is For Sale] from product where isForSale = 1 and (productNr like '%" + search + "%' or productName like '%" + search +
                "%' or productInPrice like '%" + search + "%' or productOutPrice like '%" + search + "%' or amount like '%" + search + "%')");
        }

        //SEARCH PRODUCT ALL ATTRIBUTES (NOT FOR SALE)
        public SqlDataAdapter SearchProductAllAttributesNotForSale(string search)
        {
            return ExecuteGetSqlAdapter("select productNr as [Product Nr], productName as [Product Name], productInPrice as [In Price], " +
                "productOutPrice as [Out Price], amount as [Amount], isForSale as [Is For Sale] from product where isForSale = 0 and (productNr like '%" + search + "%' or productName like '%" + search +
                "%' or productInPrice like '%" + search + "%' or productOutPrice like '%" + search + "%' or amount like '%" + search + "%')");
        }
      
        /// <summary>
        /// Gets a list with all Products that have information that matches the searchTerm
        /// </summary>
        
 
        public SqlDataAdapter SearchProductAllAttributes(int productNr, string productName, double productInPrice, double productOutPrice, int amount)
        {
            return ExecuteGetSqlAdapter("select * from product where productNr like '%" + productNr + "%' or productName like '%" + productName +
                "%' or productInPrice like '%" + productInPrice + "%' or productOutPrice like '%" + productOutPrice + "%' or amount like '%" + amount + "%'");
        }
       
        /// <summary>
        /// Updates the information of a product in the Product table
        /// </summary>
        /// <param name="productName">the name of the product</param>
        /// <param name="productInPrice">the price that the store pays per product </param>
        /// <param name="productOutPrice">the price that is listed in the store</param>
        /// <param name="amount">the amount of said product thats available</param>
        
        public void UpdateProduct (int productNr, string productName, double productInPrice, double productOutPrice, int amount, int isForSale)
        {
            ExecuteSetSqlQuery("update product set productName = '" + productName + "', productInPrice = " + productInPrice + 
                ", ProductOutPrice = " + productOutPrice + ", amount = " + amount + ", isForSale = " + isForSale + " where productNr = " + productNr);
        }            

        /// <summary>
        /// Updates the information of a salesPerson in the SalesPerson table
        /// </summary>
        /// <param name="spNr">the salespersons identyfying number</param>
        /// <param name="firstName">the salespersons first name</param>
        /// <param name="lastName">the salespersons family name</param>
        /// <param name="sPhone">the salespersons phonenumber</param>

        public void UpdateSalesPerson(string spNr, string firstName, string lastName, string sPhone, int isAdmin, int isActive)
        {
            ExecuteSetSqlQuery("update salesperson set firstName = '" + firstName + "', lastName = '" + lastName + 
                "', sPhone = '" + sPhone + "', isAdmin = " + isAdmin + ", isActive = " + isActive + " where spNr = '" + spNr + "'");
        }

        /// <summary>
        /// Adds a new salesperson to the SalesPerson table
        /// </summary>
        /// <param name="spNr">the salespersons identyfying number</param>
        /// <param name="firstName">the salespersons first name</param>
        /// <param name="lastName">the salespersons family name</param>
        /// <param name="sPhone">the salespersons phonenumber</param>

        public void SetSalesPerson(string spNr, string firstName, string lastName, string sPhone, int isAdmin, int isActive){
            ExecuteSetSqlQuery("insert into salesperson values('" + spNr + "','" + firstName + "','" + lastName + "','" + sPhone +"', " + isAdmin + ", " + isActive + ")");
        }

        /// <summary>
        /// Adds a new Product to the Product table
        /// </summary>
        /// <param name="productName">the name of the product</param>
        /// <param name="productInPrice">the price that the store pays per product </param>
        /// <param name="productOutPrice">the price that is listed in the store</param>
        /// <param name="amount">the amount of said product thats available</param>
 
        public void SetProduct(string productName, double productInPrice, double productOutPrice, int amount, int isForSale)
        {
            ExecuteSetSqlQuery("insert into product values('" + productName + "'," + productInPrice + "," + productOutPrice + "," + amount + ", " + isForSale + ")");
        }

        
        /// <summary>
        /// Adds a new Sale to the Sales table
        /// </summary>
        /// <param name="spNr">the salesPersons identyfying number </param>
        /// <param name="totalPrice">the total price of the sale in swedish kronor</param>
 
        public void SetSale(string spNr, double totalPrice)
        {
            ExecuteSetSqlQuery("insert into sales values (getdate(), '" + spNr + "'," + totalPrice + ")");
        }


        /// <summary>
        /// Adds a new salesLine to the salesLine table.
        /// </summary>
        /// <param name="productNr"> the specified products identifying number</param>
        /// <param name="salesNumber">the identifying number of the sale</param>
        /// <param name="amount">the amount/number of said product</param>

        public void SetSalesLine(int productNr, int salesNumber, int amount)
        {
            ExecuteSetSqlQuery("insert into salesline values (" + productNr + "," + salesNumber + "," + amount + ")");
        }
        

        /// <summary>
        /// Selects the salesperson with the lowest amount of sales
        /// </summary>
        /// <returns>sqlAdapter containing the information of the salesperson with the least amount of sales</returns>


        public SqlDataAdapter GetHighestSales()
        {
            return ExecuteGetSqlAdapter("select a.spNr as [Security Nr], firstname as [First Name], lastname as [Last Name], count(*) as [Amount Of Sales], " +
                "sum(totalPrice) as [Sold For Total] from salesperson a join sales b  on a.spNr = b.spNr  group by a.spNr, firstname, lastname order by sum(totalPrice) desc");
        }

        public SqlDataReader getLatestSale()
        {
            return ExecuteGetSqlReader("select top 1 salesNr from Sales order by salesDate desc");
        }

        /// <summary>
        /// Selects the salesperson with the highest amount of sales
        /// </summary>
        /// <returns>sqlDataAdapter containing the information of the top 1 salesperson</returns>
 
        public SqlDataAdapter GetTopOneSalesPerson()
        {
            return ExecuteGetSqlAdapter("select top 1 firstname as [First Name], lastname as [Last Name], salesNr as [Sales Nr], " + 
                "max(totalprice) as [Total Price] from salesperson a join sales b " +
                "on a.spNr = b.spNr group by firstname, lastname, totalprice, salesNr order by totalprice desc");
        }

        /// <summary>
        /// Selects the most sold products and the profit for said products
        /// </summary>
        /// <returns> sqlDataAdapter containing the top selling products</returns>

        public SqlDataAdapter GetTopProductSale()
        {
            return ExecuteGetSqlAdapter("select a.productNr as [Product Nr], productName as [Product Name], sum(a.amount) as [Total Sales], " +
                "(sum(a.amount * productOutPrice) - sum(a.amount * productInPrice)) as [Difference]" +
                "from salesline a join product p on a.productNr = p.productNr group by a.productNr, productName order by sum(a.amount) desc");
        }
        //GET PRODuCT AMOUNT
        public SqlDataReader getProductAmount(int productNr)
        {
            return ExecuteGetSqlReader("select amount from product where productNr = " + productNr);
        }
        //UPDATE PRODUCT AMOUNT
        public void UpdateProductAmount(int amount, int productNr, string minusOrPlus)
        {
            ExecuteSetSqlQuery("update product set amount = (amount  " + minusOrPlus + amount +") where productNr = " + productNr);
        }

    }
}
