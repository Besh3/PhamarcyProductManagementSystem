using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using System.Web;
using System.Web.Mvc;

namespace PhamarcyProductManagement.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
      
        // Get heloworld
        public ActionResult Index() {

            return View();
        }

        // Get helloword welcom
        public string Welcome(string name, int numTimes = 1) {
            return HttpUtility.HtmlEncode("Hello + " + name + "NumTimes is " + numTimes);
        }
        
    }
}