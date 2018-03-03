using BusinessEntities.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Vendor
{
    public interface IOfficeAddressServices : IDisposable
    {
        IEnumerable<OfficeAddressEntity> GetAllOfficeAddressByVendorId(int vendorEntityId);

        IEnumerable<OfficeAddressEntity> GetAllOfficeAddressByLocation(string location);

        IEnumerable<OfficeAddressEntity> GetAllOfficeAddressByDistrictId(int districtEntityId);

        IEnumerable<OfficeAddressEntity> GetAllOfficeAddressByStateId(int stateEntityId);

        int AddOfficeAddress(OfficeAddressEntity officeAddressEntity);

        bool UpdateOfficeAddress(OfficeAddressEntity officeAddressEntity);

        bool DropOfficeAddress(int officeAddressEntityId);


    }
}
