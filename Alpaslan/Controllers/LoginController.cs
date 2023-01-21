using Alpaslan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpaslan.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        AlpaslanDBEntities db = new AlpaslanDBEntities();
        public ActionResult Index()
        {
            var model = db.Authors.ToList();
            return View();
        }
    }
}