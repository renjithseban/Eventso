namespace BusinessEntities.Vendor
{
    public class VendorCategoryEntity : Helper.GenericProperties
    {
        public VendorEntity Vendor { get; set; }

        public Master.CategoryEntity Category { get; set; }
    }
}
