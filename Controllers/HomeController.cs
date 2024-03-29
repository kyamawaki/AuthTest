﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AuthTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var userName = User.Identity.Name;
            ViewBag.UserName = userName;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            ViewBag.UserName = User.Identity.Name;
        }
    }
}