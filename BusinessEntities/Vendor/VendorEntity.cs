using System;

namespace BusinessEntities.Vendor
{
    public class VendorEntity : Helper.GenericProperties
    {
        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string VendorEmail { get; set; }

        public string VendorContactNo { get; set; }

        public Uri VendorWebsiteURI { get; set; }

        public Uri VendorFacebook { get; set; }

        public Uri VendorTwitter { get; set; }

        public string VendorDescription { get; set; }

        public Common.UserEntity OwnerUser { get; set; }

        public string AlternateContactNo { get; set; }

    }
}
