using Alpaslan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpaslan.Controllers
{
    public class AuthorAdminController : Controller
    {
        // GET: AuthorAdmin
        AlpaslanDBEntities db = new AlpaslanDBEntities();
        public ActionResult Index()
        {
            return View(db.Authors.ToList()); //tüm yazarları listeleyecek
        }
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return HttpNotFound();
            }
            Author author = db.Authors.Find(Id);
            db.Authors.Remove(author);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}