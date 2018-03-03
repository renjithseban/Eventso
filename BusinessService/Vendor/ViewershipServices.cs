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
    public class ViewershipServices : IViewershipServices
    {
        private readonly UnitOfWork unitOfWork;

        public ViewershipServices()
        {
        }

        public ViewershipServices(UnitOfWork unitOfWork)
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

        public int AddViewership(ViewershipEntity viewershipEntity)
        {
            try
            {
                var viewership = Mapper.Map<ViewershipEntity, DataAccess.Viewership>(viewershipEntity);
                var newViewership = unitOfWork.VendorViewershipRepository.Add(viewership);
                unitOfWork.Save();
                if (newViewership != null)
                    return newViewership.ViewershipId;
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DropViewership(int viewershipEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.VendorViewershipRepository.Remove(viewershipEntityId);
                unitOfWork.Save();
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<ViewershipEntity> GetAllViewershipByVendorId(int vendorEntityId)
        {
            try
            {
                var viewerships = unitOfWork.VendorViewershipRepository.GetMany(cv => cv.VendorId == vendorEntityId);
                if (viewerships != null)
                {
                    if (viewerships.Any())
                    {
                        var viewershipEntities = Mapper.Map<IEnumerable<DataAccess.Viewership>, IEnumerable<ViewershipEntity>>(viewerships);
                        return viewershipEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<ViewershipEntity> GetAllViewershipByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                var viewerships = unitOfWork.VendorViewershipRepository.GetMany(cv => cv.ViewDate>= startDate && cv.ViewDate < endDate);
                if (viewerships != null)
                {
                    if (viewerships.Any())
                    {
                        var viewershipEntities = Mapper.Map<IEnumerable<DataAccess.Viewership>, IEnumerable<ViewershipEntity>>(viewerships);
                        return viewershipEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<ViewershipEntity> GetAllViewershipByUserId(int userEntityId)
        {
            try
            {
                var viewerships = unitOfWork.VendorViewershipRepository.GetMany(cv => cv.ViewedBy == userEntityId);
                if (viewerships != null)
                {
                    if (viewerships.Any())
                    {
                        var viewershipEntities = Mapper.Map<IEnumerable<DataAccess.Viewership>, IEnumerable<ViewershipEntity>>(viewerships);
                        return viewershipEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateViewership(ViewershipEntity viewershipEntity)
        {
            try
            {
                var viewership = Mapper.Map<ViewershipEntity, DataAccess.Viewership>(viewershipEntity);
                bool isEditted = unitOfWork.VendorViewershipRepository.Update(viewership);
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
