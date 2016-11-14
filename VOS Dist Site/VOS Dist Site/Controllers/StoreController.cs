using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VOS_Dist_Site.Models;

namespace VOS_Dist_Site.Controllers
{
    public class StoreController : Controller
    {
        ApplicationDbContext storeDB = new ApplicationDbContext();

        //GET /Store/

        public ActionResult Index()
        {
            var catagories = storeDB.Categories.ToList();

            return View(categories);
        }

        //GET: /Store/Browse?

        public ActionResult Browse(string catagorie)
        {
            //Retrieves a product and associated items from DB
            var catagorieModel = storeDB.Catagoreies.Include("Items").Single(global => global.Name == catagorie);

            return View(catagorieModel);
        }

        //GET: /Sote/Details/5
        public ActionResult Details(int id)
        {
            var item = storeDB.Items.Find(id);

            return View(item);
        }

        //GET: /Store/Catagorie
        [ChildActionOnly]
        public ActionResult CatagorieMenu()
        {
            var catagories = storeDB.Catagories.ToList();

            return PartialView(catagories);
        }
    }
}