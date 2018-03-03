namespace BusinessEntities.Vendor
{
    public class OfficeAddressEntity : Helper.GenericProperties
    {
        public int CrewOfficeId { get; set; }

        public VendorEntity Crew { get; set; }

        public string Landmark { get; set; }

        public string Street { get; set; }

        public string Area { get; set; }

        public string Locality { get; set; }

        public Master.DistrictEntity CrewDistrict { get; set; }

        public string Pincode { get; set; }

        public bool IsHeadOffice { get; set; }
    }
}
