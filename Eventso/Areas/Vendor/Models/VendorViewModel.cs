using System;
using Evento.Models.Helper;

namespace Evento.Areas.Vendor.Models
{
    public class VendorViewModel : GenericProperties
    {
        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string VendorEmail { get; set; }

        public string VendorContactNo { get; set; }

        public Uri VendorWebsiteURI { get; set; }

        public Uri VendorFacebook { get; set; }

        public Uri VendorTwitter { get; set; }

        public string VendorDescription { get; set; }

        public Common.Models.UserViewModel VendorOwnerUserId { get; set; }

        public string AlternateContactNo { get; set; }
    }
}