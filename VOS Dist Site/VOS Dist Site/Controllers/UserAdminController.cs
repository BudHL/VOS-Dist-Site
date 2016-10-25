using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;

namespace VOS_Dist_Site.Controllers
{
    public class UserAdminController : Controller
    {
        [Authorize(Roles = "Admin")]
        public class UsersAdminController : Controller
        {
            public UsersAdminController()
            {

            }

            public UsersAdminController(ApplicationUserManager userManager, ApplicationRoleManager roleManager)
            {
                UserManager = userManager;
                RoleManager = roleManager;
            }

            private ApplicationUserManager _userManager;
            public ApplicationUserManager UserManager
            {
                get
                {
                    return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                }
                private set
                {
                    _userManager = value;
                }
            }

            private ApplicationRoleManager _roleManager;
            public ApplicationRoleManager RoleManager
            {

            }
        }
    }
}