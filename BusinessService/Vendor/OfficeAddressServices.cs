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
    public class OfficeAddressServices : IOfficeAddressServices
    {
        private readonly UnitOfWork unitOfWork;

        public OfficeAddressServices()
        {
        }

        public OfficeAddressServices(UnitOfWork unitOfWork)
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

        public int AddOfficeAddress(OfficeAddressEntity officeAddressEntity)
        {
            try
            {
                var vendorOfficeAddress = Mapper.Map<OfficeAddressEntity, DataAccess.OfficeAddress>(officeAddressEntity);
                var newVendorOfficeAddress = unitOfWork.VendorOfficeAddressRepository.Add(vendorOfficeAddress);
                unitOfWork.Save();
                if (newVendorOfficeAddress != null)
                    return newVendorOfficeAddress.OfficeAddressId;
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DropOfficeAddress(int officeAddressEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.VendorOfficeAddressRepository.Remove(officeAddressEntityId);
                unitOfWork.Save();
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<OfficeAddressEntity> GetAllOfficeAddressByVendorId(int vendorEntityId)
        {
            try
            {
                var officeAddresses = unitOfWork.VendorOfficeAddressRepository.GetMany(addr => addr.VendorId == vendorEntityId);
                if (officeAddresses != null)
                {
                    if (officeAddresses.Any())
                    {
                        var officeAddressEntities = Mapper.Map<IEnumerable<DataAccess.OfficeAddress>, IEnumerable<OfficeAddressEntity>>(officeAddresses);
                        return officeAddressEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<OfficeAddressEntity> GetAllOfficeAddressByDistrictId(int districtEntityId)
        {
            try
            {
                var officeAddresses = unitOfWork.VendorOfficeAddressRepository.GetMany(addr => addr.OfficeDistrictId == districtEntityId);
                if (officeAddresses != null)
                {
                    if (officeAddresses.Any())
                    {
                        var officeAddressEntities = Mapper.Map<IEnumerable<DataAccess.OfficeAddress>, IEnumerable<OfficeAddressEntity>>(officeAddresses);
                        return officeAddressEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<OfficeAddressEntity> GetAllOfficeAddressByLocation(string location)
        {
            try
            {
                var officeAddresses = unitOfWork.VendorOfficeAddressRepository.GetMany
                    (
                        addr => addr.OfficeArea.Contains(location) || 
                        addr.OfficeCity.Contains(location) || 
                        addr.OfficeLandmark.Contains(location) || 
                        addr.OfficeLocality.Contains(location) || 
                        addr.OfficeStreet.Contains(location)
                     );
                if (officeAddresses != null)
                {
                    if (officeAddresses.Any())
                    {
                        var officeAddressEntities = Mapper.Map<IEnumerable<DataAccess.OfficeAddress>, IEnumerable<OfficeAddressEntity>>(officeAddresses);
                        return officeAddressEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<OfficeAddressEntity> GetAllOfficeAddressByStateId(int stateEntityId)
        {
            try
            {
                var officeAddresses = unitOfWork.VendorOfficeAddressRepository.GetMany(addr => addr.OfficeDistrict.StateId == stateEntityId);
                if (officeAddresses != null)
                {
                    if (officeAddresses.Any())
                    {
                        var officeAddressEntities = Mapper.Map<IEnumerable<DataAccess.OfficeAddress>, IEnumerable<OfficeAddressEntity>>(officeAddresses);
                        return officeAddressEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateOfficeAddress(OfficeAddressEntity officeAddressEntity)
        {
            try
            {
                var officeAddress = Mapper.Map<OfficeAddressEntity, DataAccess.OfficeAddress>(officeAddressEntity);
                bool isEditted = unitOfWork.VendorOfficeAddressRepository.Update(officeAddress);
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
