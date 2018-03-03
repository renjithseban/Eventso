using BusinessEntities.Vendor;
using System;
using System.Collections.Generic;

namespace BusinessService.Vendor
{
    public interface IViewershipServices : IDisposable
    {
        IEnumerable<ViewershipEntity> GetAllViewershipByVendorId(int vendorEntityId);

        IEnumerable<ViewershipEntity> GetAllViewershipByDateRange(DateTime startDate, DateTime endDate);

        IEnumerable<ViewershipEntity> GetAllViewershipByUserId(int userEntityId);

        int AddViewership(ViewershipEntity viewershipEntity);

        bool UpdateViewership(ViewershipEntity viewershipEntity);

        bool DropViewership(int viewershipEntityId);
    }
}
