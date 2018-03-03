using BusinessEntities.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Master
{
    interface ICategoryFilterServices : IDisposable
    {
        IEnumerable<CategoryFilterEntity> GetAllCategoryFilters();

        IEnumerable<CategoryFilterEntity> GetCategoryFilterByCategoryId(int categoryEntityId);

        IEnumerable<CategoryFilterEntity> GetCategoryFilterByName(string categoryFilterName);

        int AddCategoryFilter(CategoryFilterEntity categoryFilterEntity);

        bool UpdateCategoryFilter(CategoryFilterEntity categoryFilterEntity);

        bool DropCategoryFilter(int categoryFilterEntityId);
    }
}
