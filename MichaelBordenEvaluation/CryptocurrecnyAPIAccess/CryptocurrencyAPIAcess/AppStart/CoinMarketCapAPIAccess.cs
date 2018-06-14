using System;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptocurrencyAPIAccess.AppStart
{
    public class CoinMarketCapAPIAccess
    {
        public const string URL = "https://api.coinmarketcap.com/v2/listings/";

        public static T downloadJsonData<T>() where T : new()
        {
            using (var wc = new WebClient())
            {
                var jsonData = string.Empty;
                try
                {
                    jsonData = wc.DownloadString(URL);
                }
                catch (Exception) { }
                return !string.IsNullOrEmpty(jsonData) ? JsonConvert.DeserializeObject<T>(jsonData) : new T();
            }
        }      

    }
}
