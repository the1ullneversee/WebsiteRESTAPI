using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestWebsite.Controllers
{
    [Route("api/[controller]")]
    public class OldContactController : Controller
    {
        // GET: Contact
        public string[] Get()
        {
            return new string[]
            {
                "Hello",
                "World"
            };
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}