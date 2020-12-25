using Microsoft.AspNetCore.Mvc;

namespace abp_core_v2.x.Web.Controllers
{
    public class HomeController : xControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}