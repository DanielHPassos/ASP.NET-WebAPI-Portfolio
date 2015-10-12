using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebAPIPortfolioDB.Data.Context;
using WebAPIPortfolioDB.Models.Entities;

namespace WebAPIPortfolioDB.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
    }
}
