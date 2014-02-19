using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using System.Web.Script.Serialization;
using System.Net;
using System.Windows.Forms;

namespace AffairsSystem
{
    public static partial class Utility
    {

        public static double GetCurrencyExchangeRate(string currency, double totalPrice)
        {
            
                string jsonString;
                using (WebClient client = new WebClient())
                {
                    jsonString = client.DownloadString("http://rate-exchange.appspot.com/currency?from=SEK&to=" + currency + "&q=" + totalPrice.ToString());
                }
                var serializer = new JavaScriptSerializer();
                Dictionary<string, string> values = serializer.Deserialize<Dictionary<string, string>>(jsonString);
                totalPrice = double.Parse(values["v"]);

                if (currency.Equals("EUR") || currency.Equals("USD") || currency.Equals("GBP"))
                {
                    totalPrice = Math.Round(totalPrice, 2);
                    return totalPrice;
                }
                else
                {
                    totalPrice = Math.Round(totalPrice);
                }

                

            

            return totalPrice;

        }
  

}
}




