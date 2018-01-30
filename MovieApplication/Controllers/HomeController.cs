
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MovieApplication.Controllers
{
    public class HomeController : Controller
    {
        protected string dashboardUrlBase = "https://api.themoviedb.org/3/search/movie?api_key=aa646e218fda2ff0dfcd4d3a3cb55e37&language=en-US";

        public ActionResult Index()
        {
            return View();
        }


    }
}