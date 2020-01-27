using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PoeDashboard.Web.Models;

namespace PoeDashboard.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoadCurrencyPopover(string id, int valueInExalt, string currencyName)
        {
            var model = new CurrencyPopoverModel(id, valueInExalt, currencyName);

            return View("_CurrencyPopover", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
