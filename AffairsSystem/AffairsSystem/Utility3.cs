using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Net;

namespace AffairsSystem
{
    public static partial class Utility
    {

        public static double GetCurrencyExchangeRate(string currency)
        {
            string jsonString;
            using (WebClient client = new WebClient())
            {
                jsonString = client.DownloadString("http://rate-exchange.appspot.com/currency?from=" +currency+ "&to=SEK&q=1");
            }
            var serializer = new JavaScriptSerializer();
            Dictionary<string, string> values = serializer.Deserialize<Dictionary<string, string>>(jsonString);
            double rate = Double.Parse(values["rate"]);

            return rate;
            
        }

    }
}
