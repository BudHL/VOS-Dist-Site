using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VOS_Dist_Site.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace VOS_Dist_Site.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesAdminController : Controller
    {
        public RolesAdminController()
        {

        }

        public RolesAdminController(ApplicationUserManager usermanager, ApplicationRoleManager rolemanager)
        {
            UserManager = usermanager;
            RoleManager = rolemanager;
        }

        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            set
            {
                _userManager = value;
            }
        }

        private ApplicationRoleManager _roleManager;
        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        //GET: /Roles/
        public ActionResult Index()
        {
            return View(RoleManager.Roles);
        }
    }
}