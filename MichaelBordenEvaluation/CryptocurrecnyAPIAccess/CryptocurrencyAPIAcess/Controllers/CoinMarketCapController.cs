using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptocurrencyAPIAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CryptocurrencyAPIAccess.Controllers
{
    [Produces("application/json")]
    [Route("api/Cryptocurrencies")]
    public class CoinMarketCapController : Controller
    {
       
        public JsonResult CryptoNames()
        {
            var names = GetCryptoNames();
            return Json(names);
        }       

        private List<string> GetAllCryptoNames()
        {
            List<string> names = new List<string>();
            var cryptocurrencys = AppStart.CoinMarketCapAPIAccess.downloadJsonData<APIData>();

            names.AddRange(cryptocurrencys.data.Select(c => c.name));

            return names;
        }

        private List<CryptoName> GetCryptoNames()
        {
            List<CryptoName> names = new List<CryptoName>();

            foreach(string crypto in GetAllCryptoNames())
            {
                names.Add(new CryptoName { name = crypto });
            }

            return names;
        }
    }
}