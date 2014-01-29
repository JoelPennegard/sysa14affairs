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

        // SET PRODUCT
        public void SetProduct(string productName, double productInPrice, double productOutPrice, int amount)
        {
            dal.SetProduct(productName, productInPrice, productOutPrice, amount);
        }

        // SET SALES PERSON

        public void SetSalesPerson(string spNr, string firstName, string lastName, string sPhone)
        {
            dal.SetSalesPerson(spNr, firstName, lastName, sPhone);
        }

        // SET SALE

        public void SetSales(int spNr, double totalPrice)
        {
            dal.SetSales(spNr, totalPrice);
        }

        // SET SALE LINE

        public void SetSalesLine(int productNr, int salesNr, int amount)
        {
            dal.SetSalesLine(productNr, salesNr, amount);
        }


    }
}
