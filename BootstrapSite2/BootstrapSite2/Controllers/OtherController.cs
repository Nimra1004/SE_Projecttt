using System.Web.Mvc;


namespace BootstrapSite2.Controllers
{
    
    
    public class OtherController : Controller
    {
        
        public ActionResult SignIN()
        {
            return View("SignIN");
        }
        
        public ActionResult SignUP()
        {
            return View("SignUP");
        }
    }
}
