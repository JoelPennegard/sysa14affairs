using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AffairsSystem
{
    
    public class Controller
    {
        DAL dal;
        SqlDataAdapter da;
        SqlDataReader dr;
        
        public Controller()
        {
            dal = new DAL();
        }

        // SEARCH SALES PERSON ON spNr
        
        /// <summary>
        /// This method returns a dataReader containing the information of the 
        /// salesperson with the specified id-number
        /// </summary>
        /// <param name="spNr"> The specified employees id-number </param>
        /// <returns> a sqlDataReader containing the employee's information </returns>
        
        public SqlDataReader SearchSalesPerson(string spNr)
        {
            dr = dal.SearchSalesPerson(spNr);
            return dr;
        }


        // CREATE NEW PRODUCT (ADMIN)
        public void SetProduct(string productName, double productInPrice, double productOutPrice, int amount)
        {
            dal.SetProduct(productName, productInPrice, productOutPrice, amount);
        }

        //CREATE NEW SALES PERSON (ADMIN)

        public void SetSalesPerson(string spNr, string firstName, string lastName, string sPhone)
        {
            dal.SetSalesPerson(spNr, firstName, lastName, sPhone);
        }

        // CREATE NEW SALE

        public void SetSale(string spNr, double totalPrice)
        {
            dal.SetSale(spNr, totalPrice);
        }

        //CREATE NEW SALESLINE

        public void SetSalesLine(int productNr, int salesNr, int amount)
        {
            dal.SetSalesLine(productNr, salesNr, amount);
        }

        // SEARCH PRODUCT ALL ATTRIBUTES
        public SqlDataAdapter SearchProductAllAttributes(int productNr, string productName, double productInPrice, double productOutPrice, int amount)
        {
            da = dal.SearchProductAllAttributes(productNr, productName, productInPrice, productOutPrice, amount);
            return da;
        }

        // SEARCH PRODUCT IN TILL (NOT PRODUCTINPRICE)
        public SqlDataAdapter SearchProductTill(string productNr, string productName, string productOutPrice)
        {
            da = dal.SearchProductTill(productNr, productName, productOutPrice);
            return da;
        }
        //SEARCH SALES PERSON ON ALL ATTRIBUTES
        public SqlDataAdapter SearchSalesPersonAllAttributes(string spNr, string firstName, string lastName, string sPhone)
        {
            da = dal.SearchSalesPersonAllAttributes(spNr, firstName, lastName, sPhone);
            return da;
        }
        // GET ALL PRODUCTS (NR, NAME, OUTPRICE)
        public SqlDataAdapter GetAllProducts()
        {
            da = dal.GetAllProducts();
            return da;
        }
        //GET SALES (SALESPERSON)
        public SqlDataAdapter GetSalesPersonSales(string spNr)
        {
            da = dal.GetSalesPersonSales(spNr);
            return da;
        }
        //UPDATE SALES PERSON (ADMIN))
        public void UpdateSalesPerson(string firstName, string lastName, string sPhone, string spNr)
        {
            dal.UpdateSalesPerson(firstName, lastName, sPhone, spNr);
        }
        //UPDATE PRODUCT (ADMIN))
        public void UpdateProduct(int productNr, string productName, int productInPrice, int productOutPrice, int amount)
        {
            dal.UpdateProduct(productNr, productName, productInPrice, productOutPrice, amount);
        }
        // UPDATE PRODUCT AMOUNT (ADMIN)
        public void UpdateProductAmount(int amount, string productNr)
        {
            dal.UpdateProductAmount(amount, productNr);
        }

        
    }
}
