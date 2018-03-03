using System;
using System.Collections.Generic;
using AutoMapper;
using BusinessEntities.Master;
using DataAccess;
using DataAccess.Helper;

namespace BusinessService.Master
{
    public class CategoryFilterServices : ICategoryFilterServices
    {
        private readonly UnitOfWork unitOfWork;

        public CategoryFilterServices()
        {
        }

        public CategoryFilterServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddCategoryFilter(CategoryFilterEntity categoryFilterEntity)
        {
            try
            {
                var categoryFilter = Mapper.Map<CategoryFilterEntity, CategoryFilter>(categoryFilterEntity);
                var newCategoryFilter = unitOfWork.FilterRepository.Add(categoryFilter);
                if (newCategoryFilter != null)
                    return newCategoryFilter.CategoryFilterId;
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DropCategoryFilter(int categoryFilterEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.FilterRepository.Remove(categoryFilterEntityId);
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<CategoryFilterEntity> GetAllCategoryFilters()
        {
            try
            {
                var categoryFilters = unitOfWork.FilterRepository.Get();
                if (categoryFilters != null)
                {
                    var categoryFilterEntities = Mapper.Map<IEnumerable<CategoryFilter>, IEnumerable<CategoryFilterEntity>>(categoryFilters);
                    return categoryFilterEntities;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<CategoryFilterEntity> GetCategoryFilterByCategoryId(int categoryEntityId)
        {
            try
            {
                var categoryFilters = unitOfWork.FilterRepository.GetMany(cf => cf.CategoryId == categoryEntityId);
                if (categoryFilters != null)
                {
                    var categoryFilterEntity = Mapper.Map<IEnumerable<CategoryFilter>, IEnumerable<CategoryFilterEntity>>(categoryFilters);
                    return categoryFilterEntity;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<CategoryFilterEntity> GetCategoryFilterByName(string categoryFilterName)
        {
            try
            {
                var categoryFilters = unitOfWork.FilterRepository.GetMany(cf => cf.FilterName == categoryFilterName);
                if (categoryFilters != null)
                {
                    var categoryFilterEntity = Mapper.Map<IEnumerable<CategoryFilter>, IEnumerable<CategoryFilterEntity>>(categoryFilters);
                    return categoryFilterEntity;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateCategoryFilter(CategoryFilterEntity categoryFilterEntity)
        {
            try
            {
                var categoryFilter = Mapper.Map<CategoryFilterEntity, CategoryFilter>(categoryFilterEntity);
                bool isEditted = unitOfWork.FilterRepository.Update(categoryFilter);
                return isEditted;
            }
            catch (Exception)
            {
                return false;
            }
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
