using BusinessEntities.Vendor;
using System;
using System.Collections.Generic;

namespace BusinessService.Vendor
{
    public interface IVendorCategoryServices : IDisposable
    {
        IEnumerable<VendorCategoryEntity> GetAllVendorCategoriesByVendorId(int vendorEntityId);

        IEnumerable<VendorCategoryEntity> GetAllVendorCategoriesByCategoryId(int categoryEntityId);

        int AddVendorCategory(VendorCategoryEntity vendorCategoryEntity);

        bool UpdateVendorCategory(VendorCategoryEntity vendorCategoryEntity);

        bool DropVendorCategory(int vendorCategoryEntityId);
    }
}
