using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//1st commit.
namespace StripeFundamentals.Controllers
{
    public class BookController : Controller
    {
        // embedded form
        public ActionResult Index()
        {
            return View();
        }
        
        //custom form
        public ActionResult Custom() 
        {
            return View();
        }
    }
}