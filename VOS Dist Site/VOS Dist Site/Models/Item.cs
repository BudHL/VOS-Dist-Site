using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Web.Mvc.Html;

namespace VOS_Dist_Site.Models
{
    [Bind(Exclude = "ID")]
    public class Item
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();


    }
}