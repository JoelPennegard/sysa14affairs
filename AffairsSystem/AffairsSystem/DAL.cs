﻿   
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
            else if (computerName.Equals("MALEXANDER"))
            {
                connectionString = "Data Source=MALEXANDER;Initial Catalog=affAIRs;Integrated Security=True";
            }
            else if (computerName.Equals("ROBINSDATORNNAMN"))
            {
                connectionString = "";
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
        public SqlDataAdapter GetAllProducts()
        {
            return ExecuteGetSqlAdapter("select productNr, productName, productOutPrice from product");
        }

        /// <summary>
        /// Gets a list containing all products and their complete information
        /// </summary>
        /// <returns>a sqlDataAdapter containing a table of products</returns>
 
        public SqlDataAdapter GetAllProductsWithInPrice()
        {
            return ExecuteGetSqlAdapter("select * from product");
        }

        /// <summary>
        /// Gets a list containing all Sales made by a specified salesPerson
        /// </summary>
        /// <param name="spNr">the identifying number of the specified salesPerson</param>
        /// <returns>a sqlDataAdapter containing a table of all Sales made by the specified salesPerson c</returns>
        
        public SqlDataAdapter GetSalesPersonSales(string spNr)
        {
            return ExecuteGetSqlAdapter("select * from sales where spNr = '" + spNr + "' order by salesDate desc");
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
            return ExecuteGetSqlAdapter("select productNr, productName, productOutPrice from product where productNr like '%" + 
                search + "%' or productName like '%" + search + 
                "%' or productOutPrice like '%" + search + "%'");
        }
      
        // SEARCH PRODUCT ALL ATTRIBUTES
        public SqlDataAdapter SearchProductAllAttributes(string search)
        {
            return ExecuteGetSqlAdapter("select * from product where productNr like '%" + search + "%' or productName like '%" + search +
                "%' or productInPrice like '%" + search + "%' or productOutPrice like '%" + search + "%' or amount like '%" + search + "%'");
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
        /// Updates the available amount of a product in the Product table
        /// </summary>
        /// <param name="amount">the change in amount of said product thats available</param>
        /// <param name="productNr"> the identifying number of the product </param>
        
        public void UpdateProductAmount(int amount, string productNr)
        {
            ExecuteSetSqlQuery("update product set amount = amount + '" + amount + "' where productNr = " + productNr);
        }
        /// <summary>
        /// Updates the information of a product in the Product table
        /// </summary>
        /// <param name="productName">the name of the product</param>
        /// <param name="productInPrice">the price that the store pays per product </param>
        /// <param name="productOutPrice">the price that is listed in the store</param>
        /// <param name="amount">the amount of said product thats available</param>
        
        public void UpdateProduct (int productNr, string productName, double productInPrice, double productOutPrice, int amount)
        {
            ExecuteSetSqlQuery("update product set productName = '" + productName + "', productInPrice = " + productInPrice + 
                ", ProductOutPrice = " + productOutPrice + ", amount = " + amount + " where productNr = " + productNr);
        }            

        /// <summary>
        /// Updates the information of a salesPerson in the SalesPerson table
        /// </summary>
        /// <param name="spNr">the salespersons identyfying number</param>
        /// <param name="firstName">the salespersons first name</param>
        /// <param name="lastName">the salespersons family name</param>
        /// <param name="sPhone">the salespersons phonenumber</param>

        public void UpdateSalesPerson(string spNr, string firstName, string lastName, string sPhone)
        {
            ExecuteSetSqlQuery("update salesperson set firstName = '" + firstName +", lastName = '" + lastName + 
                ", sPhone = '" + sPhone + "' where spNr = '" + spNr + "'");
        }

        /// <summary>
        /// Adds a new salesperson to the SalesPerson table
        /// </summary>
        /// <param name="spNr">the salespersons identyfying number</param>
        /// <param name="firstName">the salespersons first name</param>
        /// <param name="lastName">the salespersons family name</param>
        /// <param name="sPhone">the salespersons phonenumber</param>

        public void SetSalesPerson(string spNr, string firstName, string lastName, string sPhone){
            ExecuteSetSqlQuery("insert into salesperson values('" + spNr + "','" + firstName + "','" + lastName + "','" + sPhone +"')");
        }

        /// <summary>
        /// Adds a new Product to the Product table
        /// </summary>
        /// <param name="productName">the name of the product</param>
        /// <param name="productInPrice">the price that the store pays per product </param>
        /// <param name="productOutPrice">the price that is listed in the store</param>
        /// <param name="amount">the amount of said product thats available</param>
 
        public void SetProduct(string productName, double productInPrice, double productOutPrice, int amount)
        {
            ExecuteSetSqlQuery("insert into product values('" + productName + "'," + productInPrice + "," + productOutPrice + "," + amount + ")");
        }

        
        /// <summary>
        /// Adds a new Sale to the Sales table
        /// </summary>
        /// <param name="spNr">the salesPersons identyfying number </param>
        /// <param name="totalPrice">the total price of the sale in swedish kronor</param>
 
        public void SetSale(string spNr, double totalPrice)
        {
            ExecuteSetSqlQuery("insert into product values getdate(), '" + spNr + "'," + totalPrice + ")");
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
            return ExecuteGetSqlAdapter("select a.spNr, firstname, lastname, count(*) as [Amount of sales] from salesperson a join sales b " +
                "on a.spNr = b.spNr group by a.spNr, firstname, lastname order by count(*) desc");
        }

        /// <summary>
        /// Selects the salesperson with the highest amount of sales
        /// </summary>
        /// <returns>sqlDataAdapter containing the information of the top 1 salesperson</returns>
 
        public SqlDataAdapter GetTopOneSalesPerson()
        {
            return ExecuteGetSqlAdapter("select top 1 firstname, lastname, salesNr, max(totalprice) as [Total Price]from salesperson a join sales b" +
                "on a.spNr = b.spNr group by firstname, lastname, totalprice, salesNr order by totalprice desc");
        }

        /// <summary>
        /// Selects the most sold products and the profit for said products
        /// </summary>
        /// <returns> sqlDataAdapter containing the top selling products</returns>

        public SqlDataAdapter GetTopProductSale()
        {
            return ExecuteGetSqlAdapter("select a.productNr, productName, sum(a.amount) as [Total Sales], (sum(a.amount * productOutPrice) - sum(a.amount * productInPrice)) as [Difference]" +
                "from salesline a join product p on a.productNr = p.productNr group by a.productNr, productName");
        }

    }
}
