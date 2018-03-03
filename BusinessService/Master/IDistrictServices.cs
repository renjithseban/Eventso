using BusinessEntities.Master;
using System;
using System.Collections.Generic;

namespace BusinessService.Master
{
    public interface IDistrictServices:IDisposable
    {
        IEnumerable<DistrictEntity> GetAllDistricts();
        DistrictEntity GetDistrictById(int districtEntityId);
        int AddDistrict(DistrictEntity districtEntity);
        bool UpdateDistrict(DistrictEntity districtEntity);
        bool DropDistrict(int districtEntityId);
        DistrictEntity GetDistrictByName(string districtEntityName);
        IEnumerable<DistrictEntity> GetDistrictByStateName(string stateEntityName);
        IEnumerable<DistrictEntity> GetDistrictByStateId(int stateEntityId);
    }
}
