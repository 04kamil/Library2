using Library2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library2.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult DodajKsiazke()
        {
            using (LibraryContext db = new LibraryContext())
            {

                return View();
            }
                
        }
        public ActionResult DodajAutora()
        {
            return View();
        }
    }
}