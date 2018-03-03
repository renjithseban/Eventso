using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evento.Areas.Vendor.Models
{
    public class OfficeAddressViewModel
    {
        public int OfficeAddressId { get; set; }

        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string Landmark { get; set; }

        public string Street { get; set; }

        public string Area { get; set; }

        public string Locality { get; set; }

        public int DistrictId { get; set; }

        public string DistrictName { get; set; }

        public string Pincode { get; set; }

        public bool IsHeadOffice { get; set; }
    }
}