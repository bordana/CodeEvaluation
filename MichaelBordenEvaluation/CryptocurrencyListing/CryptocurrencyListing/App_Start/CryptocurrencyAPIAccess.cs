using CryptocurrencyListing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;

namespace CryptocurrencyListing.App_Start
{
    public class CryptocurrencyAPIAccess
    {
        public const string URL = "http://localhost:57471/api/Cryptocurrencies/";

        public static T[] downloadJsonData<T>() where T : new()
        {
            using (var wc = new WebClient())
            {
                var jsonData = string.Empty;
                try
                {
                    jsonData = wc.DownloadString(URL);
                }
                catch (Exception) { }
                var js = new JavaScriptSerializer();

                return  js.Deserialize<T[]>(jsonData);
            }
        }

        public static List<string> CryptocurrencyNames(string filter)
        {
            List<string> names = new List<string>();
            Crypto[] cryptocurrencys = downloadJsonData<Crypto>();

            if (filter != null && filter != string.Empty) { cryptocurrencys = cryptocurrencys.Where(c => c.name.StartsWith(filter, StringComparison.OrdinalIgnoreCase)).ToArray(); };

            names.AddRange(cryptocurrencys.Select(c => c.name));

            return names.OrderBy(n => n).ToList();
        }
    }
}