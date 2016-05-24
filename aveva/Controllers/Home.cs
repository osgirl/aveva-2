using aveva.itemtranslator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aveva.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Header()
        {
            var headerViewModel = new MainPageItemBuilder().CreateModel(Sitecore.Context.Item);
            return View(headerViewModel);
        }

        public ActionResult Body()
        {

            return View();
        }

        public ActionResult Footer()
        {

            return View();
        }
    }
}