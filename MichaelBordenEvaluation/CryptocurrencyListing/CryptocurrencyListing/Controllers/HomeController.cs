using System.Web.Mvc;

namespace CryptocurrencyListing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(App_Start.CryptocurrencyAPIAccess.CryptocurrencyNames(string.Empty));
        }

        public ActionResult About()
        {
            ViewBag.Message = "A listing of all cryptocurrencies on CoinMarketCap";

            return View();
        }
    }
}