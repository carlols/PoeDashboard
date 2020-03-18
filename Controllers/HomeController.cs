using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PoeDashboard.Web.Models;

namespace PoeDashboard.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoadCurrencyPopover(string id, int valueInExalt, string currencyName)
        {
            var model = new CurrencyPopoverModel(id, valueInExalt, currencyName);

            return View("_CurrencyPopover", model);
        }

        public IActionResult GetPoeNinjaSampleJson()
        {
            string json;
            using (var r = new StreamReader(_env.WebRootFileProvider.GetFileInfo("files/poe_ninja_sample_response.json")?.PhysicalPath))
            {
                json = r.ReadToEnd();
            }

            return Content(json, "application/json");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
