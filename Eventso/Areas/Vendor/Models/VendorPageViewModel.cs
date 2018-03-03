using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evento.Areas.Vendor.Models
{
    public class VendorPageViewModel
    {
        public string VendorName { get; set; }

        public string Description { get; set; }

        public string VendorEmail { get; set; }

        public string VendorContactNo { get; set; }

        public Uri VendorWebsiteURI { get; set; }

        public Uri VendorFacebook { get; set; }

        public Uri VendorTwitter { get; set; }

        public string AlternateContactNo { get; set; }
    }
}