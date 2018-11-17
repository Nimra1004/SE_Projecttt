using System.Web.Mvc;


namespace BootstrapSite2.Controllers
{


    public class PortfolioController : Controller
    {

        public ActionResult Donors()
        {
            return View();
        }
       
        public ActionResult Details()
        {
            return View("Details");
        }
    }
}
