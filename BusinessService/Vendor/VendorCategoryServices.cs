using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Vendor;
using DataAccess.Helper;
using AutoMapper;

namespace BusinessService.Vendor
{
    public class VendorCategoryServices : IVendorCategoryServices
    {
        private readonly UnitOfWork unitOfWork;

        public VendorCategoryServices()
        {
        }

        public VendorCategoryServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
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

        public int AddVendorCategory(VendorCategoryEntity vendorCategoryEntity)
        {
            try
            {
                var vendorCategory = Mapper.Map<VendorCategoryEntity, DataAccess.VendorCategory>(vendorCategoryEntity);
                var newvendorCategory = unitOfWork.VendorCategoryRepository.Add(vendorCategory);
                unitOfWork.Save();
                if (newvendorCategory != null)
                    return 1;
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DropVendorCategory(int vendorCategoryEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.VendorCategoryRepository.Remove(vendorCategoryEntityId);
                unitOfWork.Save();
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<VendorCategoryEntity> GetAllVendorCategoriesByCategoryId(int categoryEntityId)
        {
            try
            {
                var vendorCategories = unitOfWork.VendorCategoryRepository.GetMany(cc => cc.CategoryId == categoryEntityId);
                if (vendorCategories != null)
                {
                    if (vendorCategories.Any())
                    {
                        var vendorCategoryEntities = Mapper.Map<IEnumerable<DataAccess.VendorCategory>, IEnumerable<VendorCategoryEntity>>(vendorCategories);
                        return vendorCategoryEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<VendorCategoryEntity> GetAllVendorCategoriesByVendorId(int vendorEntityId)
        {
            try
            {
                var vendorCategories = unitOfWork.VendorCategoryRepository.GetMany(cc => cc.VendorId == vendorEntityId);
                if (vendorCategories != null)
                {
                    if (vendorCategories.Any())
                    {
                        var vendorCategoryEntities = Mapper.Map<IEnumerable<DataAccess.VendorCategory>, IEnumerable<VendorCategoryEntity>>(vendorCategories);
                        return vendorCategoryEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateVendorCategory(VendorCategoryEntity vendorCategoryEntity)
        {
            try
            {
                var vendorCategory = Mapper.Map<VendorCategoryEntity, DataAccess.VendorCategory>(vendorCategoryEntity);
                bool isEditted = unitOfWork.VendorCategoryRepository.Update(vendorCategory);
                unitOfWork.Save();
                return isEditted;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
