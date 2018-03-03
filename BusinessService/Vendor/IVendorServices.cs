using BusinessEntities.Vendor;
using System;
using System.Collections.Generic;

namespace BusinessService.Vendor
{
    public interface IVendorServices : IDisposable
    {
        IEnumerable<VendorEntity> GetAllVendors();

        VendorEntity GetVendorById(int crewEntityId);

        VendorEntity GetVendorByName(string crewEntityName);

        int AddVendor(VendorEntity crewEntity);

        bool UpdateVendor(VendorEntity crewEntity);

        bool DropVendor(int crewEntityId);
    }
}
