using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VOS_Dist_Site.Models;
using VOS_Dist_Site.ViewModels;

namespace VOS_Dist_Site.Controllers
{
    public class ShoppingCartController : Controller
    {
        ApplicationDbContext storeDB = new ApplicationDbContext();

        //GET: /ShoppingCart/
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            //Set up the Cart ViewModel
            var viewmodel = new ShoppingCartViewModel
            {

            }
        }
    }
}