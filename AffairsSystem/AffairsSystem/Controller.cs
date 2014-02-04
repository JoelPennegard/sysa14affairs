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
        public void SetProduct(string productName, double productInPrice, double productOutPrice, int amount, int isForSale)
        {
            dal.SetProduct(productName, productInPrice, productOutPrice, amount, isForSale);
        }

        //CREATE NEW SALES PERSON (ADMIN)

        public void SetSalesPerson(string spNr, string firstName, string lastName, string sPhone, int isAdmin, int isActive)
        {
            dal.SetSalesPerson(spNr, firstName, lastName, sPhone, isAdmin, isActive);
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
        public SqlDataAdapter SearchProductAllAttributesForSale(string search)
        {
            da = dal.SearchProductAllAttributesForSale(search);
            return da;
        }
        //SEARCH PRODUCT ALL ATTRIBUTES (NOT FOR SALE)
        public SqlDataAdapter SearchProductAllAttributesNotForSale(string search)
        {
            da = dal.SearchProductAllAttributesNotForSale(search);
            return da;
        }

        // SEARCH PRODUCT IN TILL (NOT PRODUCTINPRICE)
        public SqlDataAdapter SearchProductTill(string search)
        {
            da = dal.SearchProductTill(search);
            return da;
        }
      
        // GET ALL PRODUCTS (NR, NAME, OUTPRICE)
        public SqlDataAdapter GetAllProductsToSaleList()
        {
            da = dal.GetAllProductsToSaleList();
            return da;
        }
        //GET IsACTIVE
        public SqlDataReader GetIsActive(string spNr)
        {
            dr = dal.GetIsActive(spNr);
            return dr;
        }
        // GET ALL PRODUCTS NOT FOR SALE
        public SqlDataAdapter GetAllProductsNotForSale()
        {
            da = dal.GetAllProductsNotForSale();
            return da;
        }

        //GET ALL WORKING SALES PERSONS
        public SqlDataAdapter GetAllWorkingSalesPersons()
        {
            da = dal.GetAllWorkingSalesPersons();
            return da;
        }
        
        //GET ALL NOT WORKING SALES PERSONS
        public SqlDataAdapter GetAllNotWorkingSalesPersons()
        {
            da = dal.GetAllNotWorkingSalesPersons();
            return da;
        }

        //SEARCH WORKING SALES PERSONS
        public SqlDataAdapter SearchWorkingSalesPersons(string search)
        {
            da = dal.SearchWorkingSalesPerson(search);
            return da;
        }

        //GET SALESLINES FROM A SPECIFIC SALE
        public SqlDataAdapter getSalesLinesFromSale(int salesNr)
        {
            da = dal.getSalesLinesFromSale(salesNr);
            return da;
        }


        public SqlDataAdapter SearchNotWorkingSalesPersons(string search)
        {
            da = dal.SearchNotWorkingSalesPerson(search);
            return da;
        }

        // GET ALL PRODUCTS (NR, NAME, OUTPRICE, INPRICE)
        public SqlDataAdapter GetAllProductsForSale()
        {
            da = dal.GetAllProductsForSale();
            return da;
        }
        //GET SALES (SALESPERSON)
        public SqlDataAdapter GetSalesPersonSales(string spNr)
        {
            da = dal.GetSalesPersonSales(spNr);
            return da;
        }
        // GET LATEST SALE
        public SqlDataReader GetLatestSale()
        {
            dr = dal.getLatestSale();
            return dr;
        }
        //UPDATE SALES PERSON (ADMIN))
        public void UpdateSalesPerson(string spNr, string firstName, string lastName, string sPhone, int isAdmin, int isActive)
        {
            dal.UpdateSalesPerson(spNr, firstName, lastName, sPhone, isAdmin, isActive);
        }
        //UPDATE PRODUCT (ADMIN))
        public void UpdateProduct(int productNr, string productName, double productInPrice, double productOutPrice, int amount, int isForSale)
        {
            dal.UpdateProduct(productNr, productName, productInPrice, productOutPrice, amount, isForSale);
        }
        // UPDATE PRODUCT AMOUNT (ADMIN)
        public void UpdateProductAmount(int amount, int productNr, string minusOrPlus)
        {
            dal.UpdateProductAmount(amount, productNr, minusOrPlus);
        }
        //GET PRODuCT AMOUNT
        public SqlDataReader getProductAmount(int productNr)
        {
            dr = dal.getProductAmount(productNr);
            return dr;
        }
        //GET HIGHEST SALES
        public SqlDataAdapter GetHighestSales()
        {
            da = dal.GetHighestSales();
            return da;
        }
        //GET TOP SALESPERSON
        public SqlDataAdapter GetTopOneSalesPerson()
        {
            da = dal.GetTopOneSalesPerson();
            return da;
        }
        //GET TOP PRODUCT THAT IS SOLD THE MOST
        public SqlDataAdapter GetTopProductSale()
        {
            da = dal.GetTopProductSale();
            return da;
        }

        
    }
}
