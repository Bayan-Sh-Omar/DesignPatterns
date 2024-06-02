using Microsoft.AspNetCore.Mvc;

namespace SmartCityProjectWeb.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Hakkinda")]
        public ActionResult About()
        {
            return View();
        }
    }
}