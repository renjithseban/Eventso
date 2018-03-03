using BusinessEntities.Home;
using System;
using System.Collections.Generic;

namespace BusinessService.Home
{
    interface IHomeServices : IDisposable
    {
        IEnumerable<CategoryInfoEntity> GetCategoryInfo();

        IEnumerable<BusinessEntities.Admin.CrewEntity> GetTopFiveCrews();
    }
}
