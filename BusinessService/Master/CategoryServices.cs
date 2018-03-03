using System;
using System.Collections.Generic;
using BusinessEntities.Master;
using AutoMapper;
using DataAccess;
using DataAccess.Helper;

namespace BusinessService.Master
{
    public class CategoryServices : ICategoryServices
    {
        private readonly UnitOfWork unitOfWork;

        public CategoryServices()
        {
        }

        public CategoryServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public int AddCategory(CategoryEntity categoryEntity)
        {
            throw new NotImplementedException();
        }

        public bool DropCategory(int categoryEntityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryEntity> GetAllCategories()
        {
            try
            {
                var categories = unitOfWork.CategoryRepository.Get();
                if (categories != null)
                {
                    var categoryEntities = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryEntity>>(categories);
                    return categoryEntities;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public CategoryEntity GetCategoryById(int categoryEntityId)
        {
            try
            {
                var category = unitOfWork.CategoryRepository.Find(categoryEntityId);
                if (category != null)
                {
                    var categoryEntity = Mapper.Map<Category, CategoryEntity>(category);
                    return categoryEntity;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public CategoryEntity GetCategoryByName(string categoryEntityName)
        {
            try
            {
                var category = unitOfWork.CategoryRepository.FirstOrDefault(d=>d.CategoryName == categoryEntityName);
                if (category != null)
                {
                    var categoryEntity = Mapper.Map<Category, CategoryEntity>(category);
                    return categoryEntity;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateCategory(CategoryEntity categoryEntity)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    unitOfWork.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
