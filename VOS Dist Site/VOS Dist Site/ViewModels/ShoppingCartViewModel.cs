using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VOS_Dist_Site.Models;
using System.ComponentModel.DataAnnotations;

namespace VOS_Dist_Site.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}