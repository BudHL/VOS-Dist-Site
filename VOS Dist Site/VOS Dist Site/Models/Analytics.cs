using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VOS_Dist_Site.Models
{
    public class Analytics
    {
        public class AnalyticsViewModel
        {
            public List<OrderDateGroup> OrderData { get; set; }

            public List<OrderDateGroup> OrderDataForToday { get; set}
        }
    }
}