﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VOS_Dist_Site.Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }
        public string CartId { get; set; }
        public int ItemId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Item Item { get; set; }
    }
}