using Skripsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skripsi.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            //if (Session["sessionUser"] == null)
            //{
            //    return RedirectToAction("signout");
            //}

            //Users user = (Users)Session["sessionUser"];
            return View();
        }

        public ActionResult SignOut()
        {

            Session["sessionUser"] = null;
            return View("index", "login");

        }
    }
}