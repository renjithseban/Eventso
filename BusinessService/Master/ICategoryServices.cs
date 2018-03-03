using BusinessEntities.Master;
using System;
using System.Collections.Generic;

namespace BusinessService.Master
{
    public interface ICategoryServices : IDisposable
    {
        IEnumerable<CategoryEntity> GetAllCategories();

        CategoryEntity GetCategoryById(int categoryEntityId);

        CategoryEntity GetCategoryByName(string categoryEntityName);

        int AddCategory(CategoryEntity categoryEntity);

        bool UpdateCategory(CategoryEntity categoryEntity);

        bool DropCategory(int categoryEntityId);
    }
}
