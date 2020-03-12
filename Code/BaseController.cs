using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PoeDashboard.Web.Models;

namespace PoeDashboard.Web.Code
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewBag.MenuModel = new MenuModel();
        }
    }
}
