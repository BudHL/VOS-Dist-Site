using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VOS_Dist_Site.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
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
    }
}