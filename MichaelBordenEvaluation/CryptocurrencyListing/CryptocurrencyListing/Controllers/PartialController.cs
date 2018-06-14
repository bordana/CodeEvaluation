using System.Web.Mvc;

namespace CryptocurrencyListing.Controllers
{
    public class PartialController : Controller
    {
        public ActionResult Filter(string filter)
        {
            return View(App_Start.CryptocurrencyAPIAccess.CryptocurrencyNames(filter));
        }
               
    }
}