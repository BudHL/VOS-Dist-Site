using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace VOS_Dist_Site.Configuration
{
    interface IConfiguration
    {
        String OrderEmail { get; set; }

        String EmailApiKey { get; set; }

        String DomainForApiKey { get; set; }

        String FromName { get; set; }

        String FromEmail { get; set; }

        List<String> CreditCardType { get; set; }

    }
}